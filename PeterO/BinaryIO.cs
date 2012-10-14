/*
Written by Peter O.
Any copyright is dedicated to the Public Domain.
http://creativecommons.org/publicdomain/zero/1.0/
If you like this, you should donate to Peter O.
at: http://upokecenter.dreamhosters.com/articles/donate-now-2/
 */
using System;
using System.IO;

namespace PeterO {
    /// <include file='../docs.xml'
    /// path='docs/doc[@name="T:PeterO.BinaryIO"]/*'/>
  public sealed class BinaryIO {
    private readonly Stream stream;

    /// <include file='../docs.xml'
    /// path='docs/doc[@name="M:PeterO.BinaryIO.#ctor(System.IO.Stream)"]/*'/>
    public BinaryIO(Stream stream) {
      if (stream == null) {
        throw new ArgumentNullException("stream");
      }
      this.stream = stream;
    }

    /// <include file='../docs.xml'
    /// path='docs/doc[@name="P:PeterO.BinaryIO.CanRead"]/*'/>
    public bool CanRead {
      get {
        return this.stream.CanRead;
      }
    }

    /// <include file='../docs.xml'
    /// path='docs/doc[@name="P:PeterO.BinaryIO.CanSeek"]/*'/>
    public bool CanSeek {
      get {
        return this.stream.CanSeek;
      }
    }

    /// <include file='../docs.xml'
    /// path='docs/doc[@name="P:PeterO.BinaryIO.CanWrite"]/*'/>
    public bool CanWrite {
      get {
        return this.stream.CanWrite;
      }
    }

    /// <include file='../docs.xml'
    /// path='docs/doc[@name="P:PeterO.BinaryIO.Length"]/*'/>
    public long Length {
      get {
        return this.stream.Length;
      }
    }

    /// <include file='../docs.xml'
    /// path='docs/doc[@name="P:PeterO.BinaryIO.Position"]/*'/>
    public long Position {
      get {
        return this.stream.Position;
      }

      set {
        this.stream.Position = value;
      }
    }

    // *********************************************
    //
    // Reading
    //
    // *********************************************
    //
    // Big endian

    /// <include file='../docs.xml'
    /// path='docs/doc[@name="M:PeterO.BinaryIO.ReadInt32BE"]/*'/>
    public int ReadInt32BE() {
      var data = this.ReadBytes(4);
      return ((int)data[3] & 0xff) | (((int)data[2] & 0xff) << 8) |
        (((int)data[1] & 0xff) << 16) | (((int)data[0] & 0xff) << 24);
    }

    /// <include file='../docs.xml'
    /// path='docs/doc[@name="M:PeterO.BinaryIO.ReadInt64BE"]/*'/>
    public long ReadInt64BE() {
      var data = this.ReadBytes(8);
      return ((long)data[7] & 0xff) | (((long)data[6] & 0xff) << 8) |
        (((long)data[5] & 0xff) << 16) | (((long)data[4] & 0xff) << 24) |
        (((long)data[3] & 0xff) << 32) | (((long)data[2] & 0xff) << 40) |
        (((long)data[1] & 0xff) << 48) | (((long)data[0] & 0xff) << 56);
    }

    /// <include file='../docs.xml'
    /// path='docs/doc[@name="M:PeterO.BinaryIO.ReadInt16BE"]/*'/>
    public short ReadInt16BE() {
      var data = this.ReadBytes(2);
      return (short)(((int)data[1] & 0xff) | (((int)data[0] & 0xff) << 8));
    }

    /// <include file='../docs.xml'
    /// path='docs/doc[@name="M:PeterO.BinaryIO.ReadSingleBE"]/*'/>
    public float ReadSingleBE() {
      var data = this.ReadBytes(4);
      if (BitConverter.IsLittleEndian) {
        ArrayUtil.Reverse(data);
      }
      return BitConverter.ToSingle(data, 0);
    }

    /// <include file='../docs.xml'
    /// path='docs/doc[@name="M:PeterO.BinaryIO.ReadDoubleBE"]/*'/>
    public double ReadDoubleBE() {
      var data = this.ReadBytes(8);
      var doubleData = ((long)data[7] & 0xff) | (((long)data[6] & 0xff) << 8) |
        (((long)data[5] & 0xff) << 16) | (((long)data[4] & 0xff) << 24) |
        (((long)data[3] & 0xff) << 32) | (((long)data[2] & 0xff) << 40) |
        (((long)data[1] & 0xff) << 48) | (((long)data[0] & 0xff) << 56);
      return BitConverter.ToDouble(BitConverter.GetBytes((long)doubleData), 0);
    }

    // Little endian
    /// <include file='../docs.xml'
    /// path='docs/doc[@name="M:PeterO.BinaryIO.ReadInt32LE"]/*'/>
    public int ReadInt32LE() {
      var data = this.ReadBytes(4);
      return ((int)data[0] & 0xff) | (((int)data[1] & 0xff) << 8) |
        (((int)data[2] & 0xff) << 16) | (((int)data[3] & 0xff) << 24);
    }

    /// <include file='../docs.xml'
    /// path='docs/doc[@name="M:PeterO.BinaryIO.ReadInt64LE"]/*'/>
    public long ReadInt64LE() {
      var data = this.ReadBytes(8);
      return ((long)data[0] & 0xff) | (((long)data[1] & 0xff) << 8) |
        (((long)data[2] & 0xff) << 16) | (((long)data[3] & 0xff) << 24) |
        (((long)data[4] & 0xff) << 32) | (((long)data[5] & 0xff) << 40) |
        (((long)data[6] & 0xff) << 48) | (((long)data[7] & 0xff) << 56);
    }

    /// <include file='../docs.xml'
    /// path='docs/doc[@name="M:PeterO.BinaryIO.ReadInt16LE"]/*'/>
    public short ReadInt16LE() {
      var data = this.ReadBytes(2);
      return unchecked((short)(((int)data[0] & 0xff) | (((int)data[1] & 0xff) <<
                    8)));
    }

    /// <include file='../docs.xml'
    /// path='docs/doc[@name="M:PeterO.BinaryIO.ReadSingleLE"]/*'/>
    public float ReadSingleLE() {
      var data = this.ReadBytes(4);
      if (!BitConverter.IsLittleEndian) {
        ArrayUtil.Reverse(data);
      }
      return BitConverter.ToSingle(data, 0);
    }

    /// <include file='../docs.xml'
    /// path='docs/doc[@name="M:PeterO.BinaryIO.ReadDoubleLE"]/*'/>
    public double ReadDoubleLE() {
      var data = this.ReadBytes(8);
      var doubleData = ((long)data[0] & 0xff) | (((long)data[1] & 0xff) << 8) |
        (((long)data[2] & 0xff) << 16) | (((long)data[3] & 0xff) << 24) |
        (((long)data[4] & 0xff) << 32) | (((long)data[5] & 0xff) << 40) |
        (((long)data[6] & 0xff) << 48) | (((long)data[7] & 0xff) << 56);
      return BitConverter.ToDouble(BitConverter.GetBytes((long)doubleData), 0);
    }

    /// <include file='../docs.xml'
    /// path='docs/doc[@name="M:PeterO.BinaryIO.Read(System.Byte[],System.Int32,System.Int32)"]/*'/>
    public int Read(byte[] data, int offset, int length) {
      if (data == null) {
        throw new ArgumentNullException("data");
      }
      if (offset < 0) {
      throw new ArgumentException("offset (" + offset + ") is less than " + 0);
      }
      if (offset > data.Length) {
        throw new ArgumentException("offset (" + offset + ") is more than " +
                    data.Length);
      }
      if (length < 0) {
      throw new ArgumentException("length (" + length + ") is less than " + 0);
      }
      if (length > data.Length) {
        throw new ArgumentException("length (" + length + ") is more than " +
                    data.Length);
      }
      if (data.Length - offset < length) {
        throw new ArgumentException("data's length minus " + offset + " (" +
                    (data.Length - offset) + ") is less than " + length);
      }
      return this.stream.Read(data, offset, length);
    }

    /// <include file='../docs.xml'
    /// path='docs/doc[@name="M:PeterO.BinaryIO.ReadByte"]/*'/>
    public byte ReadByte() {
      var b = this.stream.ReadByte();
      if (b < 0) {
        throw new EndOfStreamException();
      }
      return (byte)b;
    }

    /// <include file='../docs.xml'
    /// path='docs/doc[@name="M:PeterO.BinaryIO.ReadBytes(System.Int32)"]/*'/>
    public byte[] ReadBytes(int size) {
      if (size < 0) {
        throw new ArgumentException("size (" + size + ") is less than " + 0);
      }
      if (size >= 0x100000) {
        // If size is ludicrous, check whether
        // all bytes can be read beforehand
 if (this.stream.CanSeek && this.stream.Length - this.stream.Position < size) {
          throw new EndOfStreamException();
        }
      }
      var data = new byte[size];
      if (size > 0) {
        if (this.stream.Read(data, 0, data.Length) < size) {
          throw new EndOfStreamException();
        }
      }
      return data;
    }

    /// <include file='../docs.xml'
    /// path='docs/doc[@name="M:PeterO.BinaryIO.Read7BitEncodedInt32LE"]/*'/>
    public int Read7BitEncodedInt32LE() {
      byte currentByte;
      var ret = 0;
      var shift = 0;
      do {
        currentByte = this.ReadByte();
        if (shift == 28 && (currentByte & 0xf0) > 0) {
          throw new
       FormatException("A bad 7-bit encoded integer was found in the stream.");
        }
        ret |= (((int)currentByte) & 0x7f) << shift;
        shift += 7;
      }
      while ((currentByte & 0x80) != 0);
      return ret;
    }

    /// <include file='../docs.xml'
    /// path='docs/doc[@name="M:PeterO.BinaryIO.Read7BitEncodedUInt32LE"]/*'/>
    public int Read7BitEncodedUInt32LE() {
      byte currentByte;
      var ret = 0;
      var shift = 0;
      do {
        currentByte = this.ReadByte();
        if (shift == 28 && (currentByte & 0xf8) > 0) {
          throw new
       FormatException("A bad 7-bit encoded integer was found in the stream.");
        }
        ret |= (((int)currentByte) & 0x7f) << shift;
        shift += 7;
      }
      while ((currentByte & 0x80) != 0);
      return ret;
    }

    /// <include file='../docs.xml'
    /// path='docs/doc[@name="M:PeterO.BinaryIO.Read7BitEncodedInt64LE"]/*'/>
    public long Read7BitEncodedInt64LE() {
      byte currentByte;
      long ret = 0;
      var shift = 0;
      do {
        currentByte = this.ReadByte();
        if (shift == 63 && (currentByte & 0xfe) > 0) {
          throw new
       FormatException("A bad 7-bit encoded integer was found in the stream.");
        }
        long tmp = (currentByte & 0x7f) << shift;
        ret |= tmp;
        shift += 7;
      }
      while ((currentByte & 0x80) != 0);
      return ret;
    }

    /// <include file='../docs.xml'
    /// path='docs/doc[@name="M:PeterO.BinaryIO.Read7BitEncodedInt32BE"]/*'/>
    public int Read7BitEncodedInt32BE() {
      byte currentByte;
      var ret = 0;
      do {
        currentByte = this.ReadByte();
        if ((ret >> 25) != 0) {
          throw new
       FormatException("A bad 7-bit encoded integer was found in the stream.");
        }
        ret <<= 7;
        ret |= ((int)currentByte) & 0x7f;
      }
      while ((currentByte & 0x80) != 0);
      return ret;
    }

    /// <include file='../docs.xml'
    /// path='docs/doc[@name="M:PeterO.BinaryIO.Read7BitEncodedUInt32BE"]/*'/>
    public int Read7BitEncodedUInt32BE() {
      byte currentByte;
      var ret = 0;
      do {
        currentByte = this.ReadByte();
        if ((ret >> 25) != 0) {
          throw new
       FormatException("A bad 7-bit encoded integer was found in the stream.");
        }
        ret <<= 7;
        ret |= ((int)currentByte) & 0x7f;
      }
      while ((currentByte & 0x80) != 0);
      if (ret < 0) {
        throw new
       FormatException("A bad 7-bit encoded integer was found in the stream.");
      }
      return ret;
    }

    /// <include file='../docs.xml'
    /// path='docs/doc[@name="M:PeterO.BinaryIO.Read7BitEncodedInt64BE"]/*'/>
    public long Read7BitEncodedInt64BE() {
      byte currentByte;
      long ret = 0;
      do {
        currentByte = this.ReadByte();
        if ((ret >> 57) != 0) {
          throw new
       FormatException("A bad 7-bit encoded integer was found in the stream.");
        }
        long tmp = currentByte & 0x7f;
        ret <<= 7;
        ret |= tmp;
      }
      while ((currentByte & 0x80) != 0);
      return ret;
    }

    // *********************************************
    //
    // Writing
    //
    // *********************************************
    //
    // Big endian
    /// <include file='../docs.xml'
    /// path='docs/doc[@name="M:PeterO.BinaryIO.WriteBE(System.Int32)"]/*'/>
    public void WriteBE(int value) {
      var data = new byte[4];
      data[3] = (byte)(value & 0xff);
      data[2] = (byte)((value >> 8) & 0xff);
      data[1] = (byte)((value >> 16) & 0xff);
      data[0] = (byte)((value >> 24) & 0xff);
      this.Write(data);
    }

    /// <include file='../docs.xml'
    /// path='docs/doc[@name="M:PeterO.BinaryIO.WriteBE(System.Int64)"]/*'/>
    public void WriteBE(long value) {
      var data = new byte[8];
      data[7] = (byte)(value & 0xff);
      data[6] = (byte)((value >> 8) & 0xff);
      data[5] = (byte)((value >> 16) & 0xff);
      data[4] = (byte)((value >> 24) & 0xff);
      data[3] = (byte)((value >> 32) & 0xff);
      data[2] = (byte)((value >> 40) & 0xff);
      data[1] = (byte)((value >> 48) & 0xff);
      data[0] = (byte)((value >> 56) & 0xff);
      this.Write(data);
    }

    /// <include file='../docs.xml'
    /// path='docs/doc[@name="M:PeterO.BinaryIO.WriteBE(System.Int16)"]/*'/>
    public void WriteBE(short value) {
      var data = new byte[2];
      data[1] = (byte)(value & 0xff);
      data[0] = (byte)((value >> 8) & 0xff);
      this.Write(data);
    }

    /// <include file='../docs.xml'
    /// path='docs/doc[@name="M:PeterO.BinaryIO.WriteBE(System.Single)"]/*'/>
    public void WriteBE(float value) {
      var data = BitConverter.GetBytes(value);
      if (BitConverter.IsLittleEndian) {
        ArrayUtil.Reverse(data);
      }
      this.Write(data);
    }

    /// <include file='../docs.xml'
    /// path='docs/doc[@name="M:PeterO.BinaryIO.WriteBE(System.Double)"]/*'/>
    public void WriteBE(double value) {
      var bits = BitConverter.ToInt64(BitConverter.GetBytes((double)value), 0);
      var data = new byte[8];
      data[7] = (byte)(bits & 0xff);
      data[6] = (byte)((bits >> 8) & 0xff);
      data[5] = (byte)((bits >> 16) & 0xff);
      data[4] = (byte)((bits >> 24) & 0xff);
      data[3] = (byte)((bits >> 32) & 0xff);
      data[2] = (byte)((bits >> 40) & 0xff);
      data[1] = (byte)((bits >> 48) & 0xff);
      data[0] = (byte)((bits >> 56) & 0xff);
      this.Write(data);
    }

    /// <include file='../docs.xml'
    /// path='docs/doc[@name="M:PeterO.BinaryIO.WriteLE(System.Int32)"]/*'/>
    public void WriteLE(int value) {
      // Little endian
      var data = new byte[4];
      data[0] = (byte)(value & 0xff);
      data[1] = (byte)((value >> 8) & 0xff);
      data[2] = (byte)((value >> 16) & 0xff);
      data[3] = (byte)((value >> 24) & 0xff);
      this.Write(data);
    }

    /// <include file='../docs.xml'
    /// path='docs/doc[@name="M:PeterO.BinaryIO.WriteLE(System.Int64)"]/*'/>
    public void WriteLE(long value) {
      var data = new byte[8];
      data[0] = (byte)(value & 0xff);
      data[1] = (byte)((value >> 8) & 0xff);
      data[2] = (byte)((value >> 16) & 0xff);
      data[3] = (byte)((value >> 24) & 0xff);
      data[4] = (byte)((value >> 32) & 0xff);
      data[5] = (byte)((value >> 40) & 0xff);
      data[6] = (byte)((value >> 48) & 0xff);
      data[7] = (byte)((value >> 56) & 0xff);
      this.Write(data);
    }

    /// <include file='../docs.xml'
    /// path='docs/doc[@name="M:PeterO.BinaryIO.WriteLE(System.Int16)"]/*'/>
    public void WriteLE(short value) {
      var data = new byte[2];
      data[0] = (byte)(value & 0xff);
      data[1] = (byte)((value >> 8) & 0xff);
      this.Write(data);
    }

    /// <include file='../docs.xml'
    /// path='docs/doc[@name="M:PeterO.BinaryIO.WriteLE(System.Single)"]/*'/>
    public void WriteLE(float value) {
      var data = BitConverter.GetBytes(value);
      if (BitConverter.IsLittleEndian) {
        ArrayUtil.Reverse(data);
      }
      this.Write(data);
    }

    /// <include file='../docs.xml'
    /// path='docs/doc[@name="M:PeterO.BinaryIO.WriteLE(System.Double)"]/*'/>
    public void WriteLE(double value) {
      var bits = BitConverter.ToInt64(BitConverter.GetBytes((double)value), 0);
      var data = new byte[8];
      data[0] = (byte)(bits & 0xff);
      data[1] = (byte)((bits >> 8) & 0xff);
      data[2] = (byte)((bits >> 16) & 0xff);
      data[3] = (byte)((bits >> 24) & 0xff);
      data[4] = (byte)((bits >> 32) & 0xff);
      data[5] = (byte)((bits >> 40) & 0xff);
      data[6] = (byte)((bits >> 48) & 0xff);
      data[7] = (byte)((bits >> 56) & 0xff);
      this.Write(data);
    }

    // Endian independent
    /// <include file='../docs.xml'
    /// path='docs/doc[@name="M:PeterO.BinaryIO.WriteBE(System.Byte)"]/*'/>
    public void WriteBE(byte value) {
      this.stream.WriteByte(value);
    }

    /// <include file='../docs.xml'
    /// path='docs/doc[@name="M:PeterO.BinaryIO.WriteLE(System.Byte)"]/*'/>
    public void WriteLE(byte value) {
      this.stream.WriteByte(value);
    }

    /// <include file='../docs.xml'
    /// path='docs/doc[@name="M:PeterO.BinaryIO.Write(System.Byte)"]/*'/>
    public void Write(byte value) {
      this.stream.WriteByte(value);
    }

    /// <include file='../docs.xml'
    /// path='docs/doc[@name="M:PeterO.BinaryIO.Write(System.Byte[])"]/*'/>
    public void Write(byte[] data) {
      if (data == null) {
        throw new ArgumentNullException("data");
      }
      this.stream.Write(data, 0, data.Length);
    }

    /// <include file='../docs.xml'
    /// path='docs/doc[@name="M:PeterO.BinaryIO.Write(System.Byte[],System.Int32,System.Int32)"]/*'/>
    public void Write(byte[] data, int offset, int length) {
      if (data == null) {
        throw new ArgumentNullException("data");
      }
      if (offset < 0) {
      throw new ArgumentException("offset (" + offset + ") is less than " + 0);
      }
      if (offset > data.Length) {
        throw new ArgumentException("offset (" + offset + ") is more than " +
                    data.Length);
      }
      if (length < 0) {
      throw new ArgumentException("length (" + length + ") is less than " + 0);
      }
      if (length > data.Length) {
        throw new ArgumentException("length (" + length + ") is more than " +
                    data.Length);
      }
      if (data.Length - offset < length) {
        throw new ArgumentException("data's length minus " + offset + " (" +
                    (data.Length - offset) + ") is less than " + length);
      }
      this.stream.Write(data, offset, length);
    }

    /// <include file='../docs.xml'
    /// path='docs/doc[@name="M:PeterO.BinaryIO.Write7BitEncodedInt32LE(System.Int32)"]/*'/>
    public int Write7BitEncodedInt32LE(int value) {
      var uintValue = unchecked((uint)value);
      var ret = 0;
      do {
        var b = (byte)(uintValue & 0x7f);
        uintValue >>= 7;
        if (uintValue != 0) {
          b |= (byte)0x80;
        }
        this.stream.WriteByte(b);
        ++ret;
      }
      while (uintValue != 0);
      return ret;
    }

    /// <include file='../docs.xml'
    /// path='docs/doc[@name="M:PeterO.BinaryIO.Write7BitEncodedUInt32LE(System.Int32)"]/*'/>
    public int Write7BitEncodedUInt32LE(int value) {
      if (value < 0) {
        throw new ArgumentException("value less than " + "0 (" +
                    Convert.ToString(
                    value,
                    System.Globalization.CultureInfo.InvariantCulture) + ")");
      }
      return this.Write7BitEncodedInt32LE(value);
    }

    /// <include file='../docs.xml'
    /// path='docs/doc[@name="M:PeterO.BinaryIO.Write7BitEncodedInt64LE(System.Int64)"]/*'/>
    public int Write7BitEncodedInt64LE(long value) {
      var uintValue = unchecked((ulong)value);
      var ret = 0;
      do {
        var b = (byte)(uintValue & (ulong)0x7f);
        uintValue >>= 7;
        if (uintValue != 0) {
          b |= (byte)0x80;
        }
        this.stream.WriteByte(b);
        ++ret;
      }
      while (uintValue != 0);
      return ret;
    }

    /// <include file='../docs.xml'
    /// path='docs/doc[@name="M:PeterO.BinaryIO.Write7BitEncodedInt32BE(System.Int32)"]/*'/>
    public int Write7BitEncodedInt32BE(int value) {
      var uintValue = unchecked((uint)value);
      var ret = 0;
      var i = -1;
      var ba = new byte[] { 0,
        0,
        0,
        0,
        0 };
      do {
        ba[++i] = (byte)(uintValue & 0x7f);
        uintValue >>= 7;
      }
      while (uintValue != 0);
      do {
        var b = ba[i];
        if (i > 0) {
          b |= (byte)0x80;
        }
        this.stream.WriteByte(b);
        ++ret;
      }
      while ((i--) > 0);
      return ret;
    }

    /// <include file='../docs.xml'
    /// path='docs/doc[@name="M:PeterO.BinaryIO.Write7BitEncodedUInt32BE(System.Int32)"]/*'/>
    public int Write7BitEncodedUInt32BE(int value) {
      if (value < 0) {
        throw new ArgumentException("value less than " + "0 (" +
                    Convert.ToString(
                    value,
                    System.Globalization.CultureInfo.InvariantCulture) + ")");
      }
      return this.Write7BitEncodedInt32BE(value);
    }

    /// <include file='../docs.xml'
    /// path='docs/doc[@name="M:PeterO.BinaryIO.Write7BitEncodedInt64BE(System.Int64)"]/*'/>
    public int Write7BitEncodedInt64BE(long value) {
      var uintValue = unchecked((ulong)value);
      var ret = 0;
      var i = -1;
      var ba = new byte[] { 0,
        0,
        0,
        0,
        0,
        0,
        0,
        0,
        0,
        0 };
      do {
        ++i;
        ba[i] = (byte)(uintValue & (ulong)0x7f);
        uintValue >>= 7;
      }
      while (uintValue != 0);
      do {
        var b = ba[i];
        if (i > 0) {
          b |= (byte)0x80;
        }
        this.stream.WriteByte(b);
        ++ret;
      }
      while ((i--) > 0);
      return ret;
    }
  }
}
