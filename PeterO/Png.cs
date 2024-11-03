/*
 *
 * This file is in the public domain.
 *
 */
using System;
using System.IO;
using System.IO.Compression;

namespace PeterO {
  /// <summary>A simple class for encoding PNG image files.</summary>
  public sealed class Png {
    internal static byte[] Adler32(
      byte[] array,
      int offset,
      int length) {
      var v1 = 1;
      var v2 = 0;
      var len = length;
      var ofs = offset;
      var chunk = 0;
      while (len > 0) {
        chunk = Math.Min(3854, len);
        len -= chunk;
        while (chunk > 0) {
          v1 = unchecked((int)v1 + array[ofs]);
          v2 = unchecked((int)v1 + v2);
          --chunk;
          ++ofs;
        }
        v1 %= 65521;
        v2 %= 65521;
      }
      return new[] {
        (byte)(v2 >> 8),
        (byte)(v2 & 255),
        (byte)(v1 >> 8),
        (byte)(v1 & 255),
      };
    }

    private readonly byte[] subdata1;
    private static int[] crcTable;

    internal static int Crc32(byte[] stream, int offset, int length, int crc) {
      int c;
      int[] table = null;
      lock (crcTable) {
        if (crcTable == null) {
          crcTable = new int[256];
          for (int n = 0; n <= 255; ++n) {
            c = n;
            for (var k = 0; k <= 7; ++k) {
              c = ((c & 1) == 1) ? (unchecked((int)0xedb88320) ^ ((c >> 1) &
                    0x7fffffff)) : ((c >> 1) & 0x7fffffff);
            }
            crcTable[n] = c;
          }
        }
        table = crcTable;
      }
      c = crc ^ -1;
      var endOffset = offset + length;
      for (var i = offset; i < endOffset; ++i) {
        c = table[(c ^ stream[i]) & 255] ^ ((c >> 8) & 0xffffff);
      }
      return c ^ -1;
    }

    /// <summary>Not documented yet.</summary>
    /// <param name='y'>The parameter <paramref name='y'/> is a 32-bit
    /// signed integer.</param>
    /// <param name='filter'>The parameter <paramref name='filter'/> is a
    /// byte (from 0 to 255).</param>
    public void SetFilter(int y, byte filter) {
      if (y < 0) {
        throw new ArgumentException("y (" + y + ") is less than 0");
      }
      if (y > this.height - 1) {
        throw new ArgumentException("y (" + y + ") is more than " +
          (this.height - 1));
      }
      this.data[y * this.realRowSize] = filter;
    }

    /// <summary>Not documented yet.</summary>
    /// <param name='y'>The parameter <paramref name='y'/> is a 32-bit
    /// signed integer.</param>
    /// <returns>A byte (from 0 to 255).</returns>
    public byte GetFilter(int y) {
      if (y < 0) {
        throw new ArgumentException("y (" + y + ") is less than 0");
      }
      if (y > this.height - 1) {
        throw new ArgumentException("y (" + y + ") is more than " +
          (this.height - 1));
      }
      return this.data[y * this.realRowSize];
    }

    /// <summary>Sets the pixel.</summary>
    /// <param name='x'>The x coordinate.</param>
    /// <param name='y'>The y coordinate.</param>
    /// <param name='pixel'>The parameter <paramref name='pixel'/> is
    /// a.Byte[] object.</param>
    /// <exception cref='ArgumentNullException'>The parameter <paramref
    /// name='pixel'/> is null.</exception>
    /// <exception cref='ArgumentException'>The parameter <paramref
    /// name='pixel'/> has an improper length.</exception>
    public void SetPixel(int x, int y, byte[] pixel) {
      if (pixel == null) {
        throw new ArgumentNullException(nameof(pixel));
      }
      if (pixel.Length >= 4) {
        this.SetPixel(x, y, pixel[0], pixel[1], pixel[2], pixel[3]);
      } else if (pixel.Length == 3) {
        this.SetPixel(x, y, pixel[0], pixel[1], pixel[2], (byte)255);
      } else {
        throw new ArgumentException("'pixel' has an improper length");
      }
    }

    private const int ValueBytesPerPixel = 4;

    /// <summary>Not documented yet.</summary>
    /// <param name='x'>The parameter <paramref name='x'/> is a 32-bit
    /// signed integer.</param>
    /// <param name='y'>The parameter <paramref name='y'/> is a 32-bit
    /// signed integer.</param>
    /// <param name='r'>The parameter <paramref name='r'/> is a byte (from
    /// 0 to 255).</param>
    /// <param name='g'>The parameter <paramref name='g'/> is a byte (from
    /// 0 to 255).</param>
    /// <param name='b'>The parameter <paramref name='b'/> is a byte (from
    /// 0 to 255).</param>
    public void SetPixel(int x, int y, byte r, byte g, byte b) {
      this.SetPixel(x, y, r, g, b, (byte)255);
    }

    /// <summary>Not documented yet.</summary>
    /// <param name='x'>The parameter <paramref name='x'/> is a 32-bit
    /// signed integer.</param>
    /// <param name='y'>The parameter <paramref name='y'/> is a 32-bit
    /// signed integer.</param>
    /// <param name='r'>The parameter <paramref name='r'/> is a byte (from
    /// 0 to 255).</param>
    /// <param name='g'>The parameter <paramref name='g'/> is a byte (from
    /// 0 to 255).</param>
    /// <param name='b'>The parameter <paramref name='b'/> is a byte (from
    /// 0 to 255).</param>
    /// <param name='a'>The parameter <paramref name='a'/> is a byte (from
    /// 0 to 255).</param>
    public void SetPixel(int x, int y, byte r, byte g, byte b, byte a) {
      if (x < 0) {
        throw new ArgumentException("x (" + x + ") is less than 0");
      }
      if (x > this.width - 1) {
        throw new ArgumentException("x (" + x + ") is more than " +
          (this.width - 1));
      }
      if (y < 0) {
        throw new ArgumentException("y (" + y + ") is less than 0");
      }
      if (y > this.height - 1) {
        throw new ArgumentException("y (" + y + ") is more than " +
          (this.height - 1));
      }
      var offset = (y * this.realRowSize) + (x * ValueBytesPerPixel) + 1;
      this.data[offset] = r;
      this.data[offset + 1] = g;
      this.data[offset + 2] = b;
      if (true) {
        this.data[offset + 3] = a;
      }
    }

    /// <summary>Not documented yet.</summary>
    /// <param name='x'>The parameter <paramref name='x'/> is a 32-bit
    /// signed integer.</param>
    /// <param name='y'>The parameter <paramref name='y'/> is a 32-bit
    /// signed integer.</param>
    /// <returns>A byte array.</returns>
    public byte[] GetPixel(int x, int y) {
      if (x < 0) {
        throw new ArgumentException("x (" + x + ") is less than 0");
      }
      if (x > this.width - 1) {
        throw new ArgumentException("x (" + x + ") is more than " +
          (this.width - 1));
      }
      if (y < 0) {
        throw new ArgumentException("y (" + y + ") is less than 0");
      }
      if (y > this.height - 1) {
        throw new ArgumentException("y (" + y + ") is more than " +
          (this.height - 1));
      }
      var offset = (y * this.realRowSize) + (x * ValueBytesPerPixel) + 1;
      return new[] {
        this.data[offset],
        this.data[offset + 1],
        this.data[offset + 2],
        (byte)this.data[offset + 3],
      };
    }

    private byte[] GetBE(int crc) {
      return new[] {
        (byte)((crc >> 24) & 255),
        (byte)((crc >> 16) & 255),
        (byte)((crc >> 8) & 255),
        (byte)((crc >> 0) & 255),
      };
    }

    /// <summary>Not documented yet.</summary>
    /// <param name='filename'>The parameter <paramref name='filename'/> is
    /// a text string.</param>
    /// <exception cref='ArgumentNullException'>The parameter <paramref
    /// name='filename'/> is null.</exception>
    public void Save(string filename) {
      using (var fs = new FileStream(filename, FileMode.Create)) {
        fs.Write(this.subdata1, 0, this.subdata1.Length);
        var crc32 = Crc32(this.subdata1, 12, 17, 0);
        byte[] deflated = null;
        fs.Write(this.GetBE(crc32), 0, 4);
        using (var ms = new MemoryStream()) {
          // PNG compression uses a ZLIB stream not a DEFLATE stream
          ms.WriteByte(0x78);
          ms.WriteByte(0x9c);
          using (
            var ds = new DeflateStream(
              ms,
              CompressionMode.Compress,
              true)) {
            ds.Write(this.data, 0, this.data.Length);
          }
          ms.Write(Adler32(this.data, 0, this.data.Length), 0, 4);
          deflated = ms.ToArray();
        }
        var defLength = new[] {
          (byte)((deflated.Length >> 24) & 255),
          (byte)((deflated.Length >> 16) & 255),
          (byte)((deflated.Length >> 8) & 255),
          (byte)((deflated.Length >> 0) & 255),
        };
        fs.Write(defLength, 0, defLength.Length);
        fs.Write(new byte[] { 0x49, 0x44, 0x41, 0x54 }, 0, 4);
        fs.Write(deflated, 0, deflated.Length);
        var crc = Crc32(deflated, 0, deflated.Length, this.idatCrc);
        var subdcrc = this.GetBE(crc);
        fs.Write(subdcrc, 0, subdcrc.Length);
        fs.Write(this.subdata2, 0, this.subdata2.Length);
      }
    }

    private readonly int realRowSize;

    private readonly int height;
    private readonly int rowSize;
    private readonly int width;
    private readonly byte[] data;
    private readonly byte[] subdata2;
    private readonly byte[] imageData;
    private readonly int idatCrc;

    /// <summary>Gets a value not documented yet.</summary>
    /// <value>A value not documented yet.</value>
    public int Height {
      get {
        return this.height;
      }
    }

    /// <summary>Gets a value not documented yet.</summary>
    /// <value>A value not documented yet.</value>
    public int Width {
      get {
        return this.width;
      }
    }

    /// <param name='width'>The parameter <paramref name='width'/> is a
    /// 32-bit signed integer.</param>
    /// <param name='height'>The parameter <paramref name='height'/> is a
    /// 32-bit signed integer.</param>
    public Png(int width, int height) {
      if (width < 1) {
        throw new ArgumentException("width (" + width +
          ") is less than 1");
      }
      if (width > 65535) {
        throw new ArgumentException("width (" + width + ") is more than" +
"\u002065535");
      }
      if (height < 1) {
        throw new ArgumentException("height (" + height +
          ") is less than 1");
      }
      if (height > 65535) {
        throw new ArgumentException("height (" + height +
          ") is more than 65535");
      }
      this.subdata1 = new byte[] {
        0x89, 0x50, 0x4e, 0x47, 0x0d, 0x0a, 0x1a,
        0x0a, 0,
        0, 0, 0xd,
        0x49, 0x48, 0x44, 0x52,
        0, 0, (byte)(width >> 8), (byte)(width & 255),
        0, 0, (byte)(height >> 8), (byte)(height & 255),
        8, (byte)6, 0, 0, 0,
      };
      this.width = width;
      this.height = height;
      this.realRowSize = (this.width * ValueBytesPerPixel) + 1;
      this.rowSize = this.realRowSize;
      this.imageData = new byte[this.rowSize * this.height];
      this.data = this.imageData;
      this.idatCrc = Crc32(
          new byte[] { 0x49, 0x44, 0x41, 0x54 },
          0,
          4,
          0);
      this.subdata2 = new byte[] {
        0, 0, 0, 0, 0x49, 0x45, 0x4e, 0x44, 0xae,
        0x42,
        0x60, 0x82,
      };
    }
  }
}
