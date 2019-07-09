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
  public sealed class Png4BitIndexed {
    private readonly byte[] subdata1;

    /// <summary>Not documented yet.</summary>
    /// <param name='x'>The parameter <paramref name='x'/> is a 32-bit
    /// signed integer.</param>
    /// <param name='y'>The parameter <paramref name='y'/> is a 32-bit
    /// signed integer.</param>
    /// <param name='pixel'>The parameter <paramref name='pixel'/> is a
    /// 32-bit signed integer.</param>
    public void SetPixel (int x, int y, int pixel) {
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
      var offset = (y * this.realRowSize) + (x >> 1) + 1;
      if ((x & 1) == 1) {
        this.data[offset] &= 0xf0;
        this.data[offset] |= (byte)((byte)pixel & (byte)0x0f);
      } else {
        this.data[offset] &= 0x0f;
        this.data[offset] |= (byte)((pixel & 0x0f) << 4);
      }
    }

    /// <summary>Not documented yet.</summary>
    /// <param name='x'>The parameter <paramref name='x'/> is a 32-bit
    /// signed integer.</param>
    /// <param name='y'>The parameter <paramref name='y'/> is a 32-bit
    /// signed integer.</param>
    /// <returns>A 32-bit signed integer.</returns>
    public int GetPixel (int x, int y) {
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
      var offset = (y * this.realRowSize) + (x >> 1) + 1;
      return ((x & 1) == 0) ? (this.data[offset] & 0x0f) :
        ((this.data[offset] >> 4) & 0x0f);
    }

    /// <summary>Not documented yet.</summary>
    /// <param name='index'>The parameter <paramref name='index'/> is a
    /// 32-bit signed integer.</param>
    /// <returns>A byte array.</returns>
    public byte[] GetColor (int index) {
      if (index < 0) {
        throw new ArgumentException("index (" + index +
          ") is less than 0");
      }
      if (index > 15) {
        throw new ArgumentException("index (" + index + ") is more than 15");
      }
      return new byte[] {
        this.colors[index * 3],
        this.colors[ (index * 3) + 1],
        this.colors[ (index * 3) + 2], 255
      };
    }

    /// <summary>Not documented yet.</summary>
    /// <param name='index'>The parameter <paramref name='index'/> is a
    /// 32-bit signed integer.</param>
    /// <param name='color'>The parameter <paramref name='color'/> is
    /// a.Byte[] object.</param>
    /// <exception cref='ArgumentNullException'>The parameter <paramref
    /// name='color'/> is null.</exception>
    /// <exception cref='ArgumentException'>The parameter <paramref
    /// name='color'/> must have length 3 or more.</exception>
    public void SetColor (int index, byte[] color) {
      if (index < 0) {
        throw new ArgumentException("index (" + index +
          ") is less than 0");
      }
      if (index > 15) {
        throw new ArgumentException("index (" + index + ") is more than 15");
      }
      if (color == null) {
        throw new ArgumentNullException(nameof(color));
      }
      if (color.Length < 3) {
        throw new ArgumentException("'color' must have length 3 or more.");
      }
      this.colors[index * 3] = color[0];
      this.colors[ (index * 3) + 1] = color[1];
      this.colors[ (index * 3) + 2] = color[2];
    }

    private byte[] GetBE (int crc) {
      return new[] {
        (byte)((crc >> 24) & 255),
        (byte)((crc >> 16) & 255),
        (byte)((crc >> 8) & 255),
        (byte)((crc >> 0) & 255)
      };
    }

    /// <summary>Not documented yet.</summary>
    /// <param name='filename'>The parameter <paramref name='filename'/> is
    /// a text string.</param>
    /// <exception cref='ArgumentNullException'>The parameter <paramref
    /// name='filename'/> is null.</exception>
    public void Save (string filename) {
      if (filename == null) {
        throw new ArgumentNullException(nameof(filename));
      }
      if (filename.Length == 0) {
        throw new ArgumentException("filename" + " is empty.");
      }
      using (var fs = new FileStream(filename, FileMode.Create)) {
        fs.Write (this.subdata1, 0, this.subdata1.Length);
        var crc32 = Png.Crc32 (this.subdata1, 12, 17, 0);
        byte[] deflated = null;
        fs.Write (this.GetBE (crc32), 0, 4);
        // Write the color data
        fs.Write (this.GetBE (48), 0, 4);
        fs.Write (new byte[] { 0x50, 0x4c, 0x54, 0x45 }, 0, 4);
        crc32 = Png.Crc32 (new byte[] { 0x50, 0x4c, 0x54, 0x45 }, 0, 4, 0);
        crc32 = Png.Crc32 (this.colors, 0, 48, crc32);
        fs.Write (this.colors, 0, 48);
        fs.Write (this.GetBE (crc32), 0, 4);
        // Write the transparent color
        if (this.transparent >= 0 && this.transparent < 16) {
          fs.Write (this.GetBE (1), 0, 4);
          fs.Write (new byte[] { 0x74, 0x52, 0x4e, 0x53 }, 0, 4);
          crc32 = Png.Crc32 (new byte[] { 0x74, 0x52, 0x4e, 0x53 }, 0, 4, 0);
          crc32 = Png.Crc32 (new[] { (byte)this.transparent }, 0, 1, crc32);
          fs.Write (new[] { (byte)this.transparent }, 0, 1);
          fs.Write (this.GetBE (crc32), 0, 4);
        }
        // Write the image data
        using (var ms = new MemoryStream()) {
          // PNG compression uses a ZLIB stream not a DEFLATE stream
          ms.WriteByte (0x78);
          ms.WriteByte (0x9c);
          using (
            var ds = new DeflateStream(
              ms,
              CompressionMode.Compress,
              true)) {
            ds.Write (this.data, 0, this.data.Length);
          }
          ms.Write (Png.Adler32 (this.data, 0, this.data.Length), 0, 4);
          deflated = ms.ToArray();
        }
        var defLength = new[] {
          (byte)((deflated.Length >> 24) & 255),
          (byte)((deflated.Length >> 16) & 255),
          (byte)((deflated.Length >> 8) & 255),
          (byte)((deflated.Length >> 0) & 255)
        };
        fs.Write (defLength, 0, defLength.Length);
        fs.Write (new byte[] { 0x49, 0x44, 0x41, 0x54 }, 0, 4);
        fs.Write (deflated, 0, deflated.Length);
        var crc = Png.Crc32 (deflated, 0, deflated.Length, this.idatCrc);
        var subdcrc = this.GetBE (crc);
        fs.Write (subdcrc, 0, subdcrc.Length);
        fs.Write (this.subdata2, 0, this.subdata2.Length);
      }
    }

    private readonly int realRowSize;

    private readonly int height;
    private readonly int rowSize;
    private readonly int width;

    /// <summary>Gets the height of the image.</summary>
    /// <value>The height of the image.</value>
    public int Height {
      get {
        return this.height;
      }
    }

    /// <summary>Gets the width of the image.</summary>
    /// <value>The width of the image.</value>
    public int Width {
      get {
        return this.width;
      }
    }

    private byte[] subdata2;
    private readonly byte[] data;
    private readonly byte[] colors;
    private readonly byte[] imageData;
    private readonly int idatCrc;
    [System.Diagnostics.CodeAnalysis.SuppressMessage ("Usage",
        "CC0052:Make field readonly",
        Justification = "False positive")]
    private int transparent;

    /// <summary>Gets or sets the index of the transparent color.</summary>
    /// <value>The index of the transparent color.</value>
    public int Transparent {
      get {
        return this.transparent;
      }

      set {
        if (value < 0 || value >= 16) {
          throw new ArgumentOutOfRangeException(nameof(value));
        }
        this.transparent = value;
      }
    }

    /// <summary>Initializes a new instance of the
    /// <see cref='PeterO.Png4BitIndexed'/> class.</summary>
    /// <param name='width'>The parameter <paramref name='width'/> is a
    /// 32-bit signed integer.</param>
    /// <param name='height'>The parameter <paramref name='height'/> is a
    /// 32-bit signed integer.</param>
    public Png4BitIndexed (int width, int height) {
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
      this.colors = new byte[48];
      this.transparent = -1;
      this.subdata1 = new byte[] {
        0x89, 0x50, 0x4e, 0x47, 0x0d, 0x0a, 0x1a,
        0x0a, 0,
        0, 0, 0xd,
        0x49, 0x48, 0x44, 0x52,
        0, 0, (byte)(width >> 8), (byte)(width & 255),
        0, 0, (byte)(height >> 8), (byte)(height & 255),
        4, 3, 0, 0, 0
      };
      this.width = width;
      this.height = height;
      this.realRowSize = ((this.width + 1) >> 1) + 1;
      this.rowSize = this.realRowSize;
      this.imageData = new byte[this.rowSize * this.height];
      this.data = this.imageData;
      this.idatCrc = Png.Crc32(
          new byte[] { 0x49, 0x44, 0x41, 0x54 },
          0,
          4,
          0);
      this.subdata2 = new byte[] {
        0, 0, 0, 0, 0x49, 0x45, 0x4e, 0x44, 0xae,
        0x42,
        0x60, 0x82
      };
    }
  }
}
