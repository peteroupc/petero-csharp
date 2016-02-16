## PeterO.BinaryIO

    public sealed class BinaryIO

Reads and writes data types in little endian or big endian.

### BinaryIO Constructor

    public BinaryIO(
        System.IO.Stream stream);

Initializes a new instance of the[PeterO.BinaryIO](PeterO.BinaryIO.md) class. Initializes a new BinaryIO instance.

<b>Parameters:</b>

 * <i>stream</i>: A Stream object.

<b>Exceptions:</b>

 * System.ArgumentNullException:
The parameter <i>stream</i>
 is null.

### CanRead

    public bool CanRead { get; }

Gets a value indicating whether the underlying stream can be read.

<b>Returns:</b>

 `true`  If the underlying stream can be read; otherwise,.  `false` .

### CanSeek

    public bool CanSeek { get; }

Gets a value indicating whether the underlying stream supports seeking.

<b>Returns:</b>

 `true`  If the underlying stream supports seeking; otherwise,.  `false` .

### CanWrite

    public bool CanWrite { get; }

Gets a value indicating whether the underlying stream supports writing.

<b>Returns:</b>

 `true`  If the underlying stream supports writing; otherwise,.  `false` .

### Length

    public long Length { get; }

Gets the length of the underlying stream.

<b>Returns:</b>

The length of the underlying stream.

### Position

    public long Position { get; set;}

Gets or sets the position of the underlying stream.

<b>Returns:</b>

The position of the underlying stream.

### Read

    public int Read(
        byte[] data,
        int offset,
        int length);

Not documented yet.

<b>Parameters:</b>

 * <i>data</i>: A byte array.

 * <i>offset</i>: A zero-based index showing where the desired portion of  <i>data</i>
 begins.

 * <i>length</i>: The number of elements in the desired portion of  <i>data</i>
 (but not more than  <i>data</i>
 's length).

<b>Return Value:</b>

A 32-bit signed integer.

<b>Exceptions:</b>

 * System.ArgumentNullException:
The parameter <i>data</i>
 is null.

 * System.ArgumentException:
Either  <i>offset</i>
 or  <i>length</i>
 is less than 0 or greater than  <i>data</i>
 's length, or  <i>data</i>
 ' s length minus  <i>offset</i>
 is less than  <i>length</i>
.

### Read7BitEncodedInt32BE

    public int Read7BitEncodedInt32BE();

Not documented yet.

<b>Return Value:</b>

A 32-bit signed integer.

### Read7BitEncodedInt32LE

    public int Read7BitEncodedInt32LE();

Reads a signed 32-bit integer encoded in 7-bit encoding to the stream.

In 7-bit encoding, an integer is encoded in one or more bytes. Each byte contains 7 bits of the result, starting with the least-significant bits. If the eighth (highest) bit is 1, then the byte that follows it contains 7 more bits, and so on. Otherwise, the process stops and the resulting integer is returned. The return value of this method can be up to 32 bits long. If bit 32 is 1, the return value is negative; otherwise positive.

<b>Return Value:</b>

A 32-bit signed integer.

### Read7BitEncodedInt64BE

    public long Read7BitEncodedInt64BE();

Not documented yet.

<b>Return Value:</b>

A 64-bit signed integer.

### Read7BitEncodedInt64LE

    public long Read7BitEncodedInt64LE();

Not documented yet.

<b>Return Value:</b>

A 64-bit signed integer.

### Read7BitEncodedUInt32BE

    public int Read7BitEncodedUInt32BE();

Not documented yet.

<b>Return Value:</b>

A 32-bit signed integer.

### Read7BitEncodedUInt32LE

    public int Read7BitEncodedUInt32LE();

Reads an unsigned 32-bit integer encoded in 7-bit encoding to the stream.

In 7-bit encoding, an integer is encoded in one or more bytes. Each byte contains 7 bits of the result, starting with the least-significant bits. If the eighth (highest) bit is 1, then the byte that follows it contains 7 more bits, and so on. Otherwise, the process stops and the resulting integer is returned. The return value of this method can be up to 31 bits long and is positive.

<b>Return Value:</b>

A 32-bit signed integer.

### ReadByte

    public byte ReadByte();

Not documented yet.

<b>Return Value:</b>

A Byte object.

### ReadBytes

    public byte[] ReadBytes(
        int size);

Reads data from a stream into a byte array.

<b>Parameters:</b>

 * <i>size</i>: A 32-bit signed integer.

<b>Return Value:</b>

A byte array containing the data read.

### ReadDoubleBE

    public double ReadDoubleBE();

Reads a 64-bit floating-point number in big-endian byte order.

<b>Return Value:</b>

A 64-bit floating-point number.

### ReadDoubleLE

    public double ReadDoubleLE();

Not documented yet.

<b>Return Value:</b>

A 64-bit floating-point number.

### ReadInt16BE

    public short ReadInt16BE();

Reads a 16-bit signed integer in big-endian byte order (2 bytes).

<b>Return Value:</b>

A 16-bit signed integer.

### ReadInt16LE

    public short ReadInt16LE();

Not documented yet.

<b>Return Value:</b>

A 16-bit signed integer.

### ReadInt32BE

    public int ReadInt32BE();

Reads a 32-bit signed integer in big-endian byte order (4 bytes).

<b>Return Value:</b>

A 32-bit signed integer.

### ReadInt32LE

    public int ReadInt32LE();

Not documented yet.

<b>Return Value:</b>

A 32-bit signed integer.

### ReadInt64BE

    public long ReadInt64BE();

Reads a 64-bit signed integer in big-endian byte order (8 bytes).

<b>Return Value:</b>

A 64-bit signed integer.

### ReadInt64LE

    public long ReadInt64LE();

Not documented yet.

<b>Return Value:</b>

A 64-bit signed integer.

### ReadSingleBE

    public float ReadSingleBE();

Not documented yet.

<b>Return Value:</b>

A 32-bit floating-point number.

### ReadSingleLE

    public float ReadSingleLE();

Not documented yet.

<b>Return Value:</b>

A 32-bit floating-point number.

### Write

    public void Write(
        byte value);

Not documented yet.

<b>Parameters:</b>

 * <i>value</i>: A Byte object.

### Write

    public void Write(
        byte[] data);

Not documented yet.

<b>Parameters:</b>

 * <i>data</i>: A byte array to write to the stream.

<b>Exceptions:</b>

 * System.ArgumentNullException:
The parameter <i>data</i>
 is null.

### Write

    public void Write(
        byte[] data,
        int offset,
        int length);

Not documented yet.

<b>Parameters:</b>

 * <i>data</i>: A byte array. (2).

 * <i>offset</i>: A zero-based index showing where the desired portion of  <i>data</i>
 begins.

 * <i>length</i>: The number of elements in the desired portion of  <i>data</i>
 (but not more than  <i>data</i>
 's length).

<b>Exceptions:</b>

 * System.ArgumentNullException:
The parameter <i>data</i>
 is null.

 * System.ArgumentException:
Either  <i>offset</i>
 or  <i>length</i>
 is less than 0 or greater than  <i>data</i>
 's length, or  <i>data</i>
 ' s length minus  <i>offset</i>
 is less than  <i>length</i>
.

### Write7BitEncodedInt32BE

    public int Write7BitEncodedInt32BE(
        int value);

Not documented yet.

<b>Parameters:</b>

 * <i>value</i>: Another 32-bit signed integer.

<b>Return Value:</b>

A 32-bit signed integer.

### Write7BitEncodedInt32LE

    public int Write7BitEncodedInt32LE(
        int value);

Not documented yet.

<b>Parameters:</b>

 * <i>value</i>: Another 32-bit signed integer.

<b>Return Value:</b>

A 32-bit signed integer.

### Write7BitEncodedInt64BE

    public int Write7BitEncodedInt64BE(
        long value);

Not documented yet.

<b>Parameters:</b>

 * <i>value</i>: A 64-bit signed integer.

<b>Return Value:</b>

A 32-bit signed integer.

### Write7BitEncodedInt64LE

    public int Write7BitEncodedInt64LE(
        long value);

Not documented yet.

<b>Parameters:</b>

 * <i>value</i>: A 64-bit signed integer.

<b>Return Value:</b>

A 32-bit signed integer.

### Write7BitEncodedUInt32BE

    public int Write7BitEncodedUInt32BE(
        int value);

Not documented yet.

<b>Parameters:</b>

 * <i>value</i>: Another 32-bit signed integer.

<b>Return Value:</b>

A 32-bit signed integer.

### Write7BitEncodedUInt32LE

    public int Write7BitEncodedUInt32LE(
        int value);

Not documented yet.

<b>Parameters:</b>

 * <i>value</i>: Another 32-bit signed integer.

<b>Return Value:</b>

A 32-bit signed integer.

### WriteBE

    public void WriteBE(
        byte value);

Not documented yet.

<b>Parameters:</b>

 * <i>value</i>: A Byte object.

### WriteBE

    public void WriteBE(
        double value);

Not documented yet.

<b>Parameters:</b>

 * <i>value</i>: A 64-bit floating-point number.

### WriteBE

    public void WriteBE(
        float value);

Not documented yet.

<b>Parameters:</b>

 * <i>value</i>: A 32-bit floating-point number.

### WriteBE

    public void WriteBE(
        int value);

Not documented yet.

<b>Parameters:</b>

 * <i>value</i>: A 32-bit signed integer.

### WriteBE

    public void WriteBE(
        long value);

Not documented yet.

<b>Parameters:</b>

 * <i>value</i>: A 64-bit signed integer.

### WriteBE

    public void WriteBE(
        short value);

Not documented yet.

<b>Parameters:</b>

 * <i>value</i>: A 16-bit signed integer.

### WriteLE

    public void WriteLE(
        byte value);

Not documented yet.

<b>Parameters:</b>

 * <i>value</i>: A Byte object.

### WriteLE

    public void WriteLE(
        double value);

Not documented yet.

<b>Parameters:</b>

 * <i>value</i>: A 64-bit floating-point number.

### WriteLE

    public void WriteLE(
        float value);

Not documented yet.

<b>Parameters:</b>

 * <i>value</i>: A 32-bit floating-point number.

### WriteLE

    public void WriteLE(
        int value);

Not documented yet.

<b>Parameters:</b>

 * <i>value</i>: A 32-bit signed integer.

### WriteLE

    public void WriteLE(
        long value);

Not documented yet.

<b>Parameters:</b>

 * <i>value</i>: A 64-bit signed integer.

### WriteLE

    public void WriteLE(
        short value);

Not documented yet.

<b>Parameters:</b>

 * <i>value</i>: A 16-bit signed integer.
