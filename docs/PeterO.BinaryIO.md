## PeterO.BinaryIO

    public sealed class BinaryIO

 Reads and writes data types in little endian or big endian.

### Member Summary
* <code>[CanRead](#CanRead)</code> - Gets a value indicating whether the underlying stream can be read.
* <code>[CanSeek](#CanSeek)</code> - Gets a value indicating whether the underlying stream supports seeking.
* <code>[CanWrite](#CanWrite)</code> - Gets a value indicating whether the underlying stream supports writing.
* <code>[Length](#Length)</code> - Gets the length of the underlying stream.
* <code>[Position](#Position)</code> - Gets or sets the position of the underlying stream.
* <code>[Read(byte[], int, int)](#Read_byte_int_int)</code> - Not documented yet.
* <code>[Read7BitEncodedInt32BE()](#Read7BitEncodedInt32BE)</code> - Not documented yet.
* <code>[Read7BitEncodedInt32LE()](#Read7BitEncodedInt32LE)</code> - Reads a signed 32-bit integer encoded in 7-bit encoding to the stream.
* <code>[Read7BitEncodedInt64BE()](#Read7BitEncodedInt64BE)</code> - Not documented yet.
* <code>[Read7BitEncodedInt64LE()](#Read7BitEncodedInt64LE)</code> - Not documented yet.
* <code>[Read7BitEncodedUInt32BE()](#Read7BitEncodedUInt32BE)</code> - Not documented yet.
* <code>[Read7BitEncodedUInt32LE()](#Read7BitEncodedUInt32LE)</code> - Reads an unsigned 32-bit integer encoded in 7-bit encoding to the stream.
* <code>[ReadByte()](#ReadByte)</code> - Not documented yet.
* <code>[ReadBytes(int)](#ReadBytes_int)</code> - Reads data from a stream into a byte array.
* <code>[ReadDoubleBE()](#ReadDoubleBE)</code> - Reads a 64-bit floating-point number in big-endian byte order.
* <code>[ReadDoubleLE()](#ReadDoubleLE)</code> - Not documented yet.
* <code>[ReadInt16BE()](#ReadInt16BE)</code> - Reads a 16-bit signed integer in big-endian byte order (2 bytes).
* <code>[ReadInt16LE()](#ReadInt16LE)</code> - Not documented yet.
* <code>[ReadInt32BE()](#ReadInt32BE)</code> - Reads a 32-bit signed integer in big-endian byte order (4 bytes).
* <code>[ReadInt32LE()](#ReadInt32LE)</code> - Not documented yet.
* <code>[ReadInt64BE()](#ReadInt64BE)</code> - Reads a 64-bit signed integer in big-endian byte order (8 bytes).
* <code>[ReadInt64LE()](#ReadInt64LE)</code> - Not documented yet.
* <code>[ReadSingleBE()](#ReadSingleBE)</code> - Not documented yet.
* <code>[ReadSingleLE()](#ReadSingleLE)</code> - Not documented yet.
* <code>[Write(byte[])](#Write_byte)</code> - Not documented yet.
* <code>[Write(byte[], int, int)](#Write_byte_int_int)</code> - Not documented yet.
* <code>[Write7BitEncodedInt32BE(int)](#Write7BitEncodedInt32BE_int)</code> - Not documented yet.
* <code>[Write7BitEncodedInt32LE(int)](#Write7BitEncodedInt32LE_int)</code> - Not documented yet.
* <code>[Write7BitEncodedInt64BE(long)](#Write7BitEncodedInt64BE_long)</code> - Not documented yet.
* <code>[Write7BitEncodedInt64LE(long)](#Write7BitEncodedInt64LE_long)</code> - Not documented yet.
* <code>[Write7BitEncodedUInt32BE(int)](#Write7BitEncodedUInt32BE_int)</code> - Not documented yet.
* <code>[Write7BitEncodedUInt32LE(int)](#Write7BitEncodedUInt32LE_int)</code> - Not documented yet.
* <code>[WriteBE(byte)](#WriteBE_byte)</code> - Not documented yet.
* <code>[WriteBE(double)](#WriteBE_double)</code> - Not documented yet.
* <code>[WriteBE(float)](#WriteBE_float)</code> - Not documented yet.
* <code>[WriteBE(int)](#WriteBE_int)</code> - Not documented yet.
* <code>[WriteBE(long)](#WriteBE_long)</code> - Not documented yet.
* <code>[WriteBE(short)](#WriteBE_short)</code> - Not documented yet.
* <code>[WriteLE(byte)](#WriteLE_byte)</code> - Not documented yet.
* <code>[WriteLE(double)](#WriteLE_double)</code> - Not documented yet.
* <code>[WriteLE(float)](#WriteLE_float)</code> - Not documented yet.
* <code>[WriteLE(int)](#WriteLE_int)</code> - Not documented yet.
* <code>[WriteLE(long)](#WriteLE_long)</code> - Not documented yet.
* <code>[WriteLE(short)](#WriteLE_short)</code> - Not documented yet.

<a id="Void_ctor_Stream"></a>
### BinaryIO Constructor

    public BinaryIO(
        System.IO.Stream stream);

 Initializes a new instance of the [PeterO.BinaryIO](PeterO.BinaryIO.md) class. Initializes a new BinaryIO instance.

<b>Parameters:</b>

 * <i>stream</i>: The parameter  <i>stream</i>
 is a Stream object.

<b>Exceptions:</b>

 * System.ArgumentNullException:
The parameter  <i>stream</i>
 is null.

<a id="CanRead"></a>
### CanRead

    public bool CanRead { get; }

 Gets a value indicating whether the underlying stream can be read.  <b>Returns:</b>

 `true`  if the underlying stream can be read; otherwise,  `false`  .

<a id="CanSeek"></a>
### CanSeek

    public bool CanSeek { get; }

 Gets a value indicating whether the underlying stream supports seeking.  <b>Returns:</b>

 `true`  if the underlying stream supports seeking; otherwise,  `false`  .

<a id="CanWrite"></a>
### CanWrite

    public bool CanWrite { get; }

 Gets a value indicating whether the underlying stream supports writing.  <b>Returns:</b>

 `true`  if the underlying stream supports writing; otherwise,  `false`  .

<a id="Length"></a>
### Length

    public long Length { get; }

 Gets the length of the underlying stream.  <b>Returns:</b>

The length of the underlying stream.

<a id="Position"></a>
### Position

    public long Position { get; set; }

 Gets or sets the position of the underlying stream.  <b>Returns:</b>

The position of the underlying stream.

<a id="Read_byte_int_int"></a>
### Read

    public int Read(
        byte[] data,
        int offset,
        int length);

 Not documented yet.

<b>Parameters:</b>

 * <i>data</i>: The parameter  <i>data</i>
 is not documented yet.

 * <i>offset</i>: A zero-based index showing where the desired portion of  <i>data</i>
 begins.

 * <i>length</i>: The number of elements in the desired portion of  <i>data</i>
 (but not more than  <i>data</i>
 's length).

<b>Return Value:</b>

A 32-bit signed integer.

<b>Exceptions:</b>

 *  T:System.ArgumentException:
Either  <i> offset</i>
 or  <i> length</i>
 is less than 0 or greater than  <i>data</i>
 's length, or  <i>             data</i>
 ' s length minus  <i>offset</i>
 is less than  <i>length</i>
 .

 * System.ArgumentNullException:
The parameter  <i>data</i>
 is null.

 * System.ArgumentException:
Either "offset" or "length" is less than 0 or greater than "data"'s length, or "data"'s length minus "offset" is less than "length".

<a id="Read7BitEncodedInt32BE"></a>
### Read7BitEncodedInt32BE

    public int Read7BitEncodedInt32BE();

 Not documented yet.

<b>Return Value:</b>

A 32-bit signed integer.

<a id="Read7BitEncodedInt32LE"></a>
### Read7BitEncodedInt32LE

    public int Read7BitEncodedInt32LE();

 Reads a signed 32-bit integer encoded in 7-bit encoding to the stream.  In 7-bit encoding, an integer is encoded in one or more bytes. Each byte contains 7 bits of the result, starting with the least-significant bits. If the eighth (highest) bit is 1, then the byte that follows it contains 7 more bits, and so on. Otherwise, the process stops and the resulting integer is returned. The return value of this method can be up to 32 bits long. If bit 32 is 1, the return value is negative; otherwise positive.

<b>Return Value:</b>

A 32-bit signed integer.

<a id="Read7BitEncodedInt64BE"></a>
### Read7BitEncodedInt64BE

    public long Read7BitEncodedInt64BE();

 Not documented yet.

<b>Return Value:</b>

A 64-bit signed integer.

<a id="Read7BitEncodedInt64LE"></a>
### Read7BitEncodedInt64LE

    public long Read7BitEncodedInt64LE();

 Not documented yet.

<b>Return Value:</b>

A 64-bit signed integer.

<a id="Read7BitEncodedUInt32BE"></a>
### Read7BitEncodedUInt32BE

    public int Read7BitEncodedUInt32BE();

 Not documented yet.

<b>Return Value:</b>

A 32-bit signed integer.

<a id="Read7BitEncodedUInt32LE"></a>
### Read7BitEncodedUInt32LE

    public int Read7BitEncodedUInt32LE();

 Reads an unsigned 32-bit integer encoded in 7-bit encoding to the stream.  In 7-bit encoding, an integer is encoded in one or more bytes. Each byte contains 7 bits of the result, starting with the least-significant bits. If the eighth (highest) bit is 1, then the byte that follows it contains 7 more bits, and so on. Otherwise, the process stops and the resulting integer is returned. The return value of this method can be up to 31 bits long and is positive.

<b>Return Value:</b>

A 32-bit signed integer.

<a id="ReadByte"></a>
### ReadByte

    public byte ReadByte();

 Not documented yet.

<b>Return Value:</b>

A byte (from 0 to 255).

<a id="ReadBytes_int"></a>
### ReadBytes

    public byte[] ReadBytes(
        int size);

 Reads data from a stream into a byte array.

<b>Parameters:</b>

 * <i>size</i>: The parameter  <i>size</i>
 is not documented yet.

<b>Return Value:</b>

A byte array containing the data read.

<a id="ReadDoubleBE"></a>
### ReadDoubleBE

    public double ReadDoubleBE();

 Reads a 64-bit floating-point number in big-endian byte order.

<b>Return Value:</b>

A 64-bit floating-point number.

<a id="ReadDoubleLE"></a>
### ReadDoubleLE

    public double ReadDoubleLE();

 Not documented yet.

<b>Return Value:</b>

A 64-bit floating-point number.

<a id="ReadInt16BE"></a>
### ReadInt16BE

    public short ReadInt16BE();

 Reads a 16-bit signed integer in big-endian byte order (2 bytes).

<b>Return Value:</b>

A 16-bit signed integer.

<a id="ReadInt16LE"></a>
### ReadInt16LE

    public short ReadInt16LE();

 Not documented yet.

<b>Return Value:</b>

A 16-bit signed integer.

<a id="ReadInt32BE"></a>
### ReadInt32BE

    public int ReadInt32BE();

 Reads a 32-bit signed integer in big-endian byte order (4 bytes).

<b>Return Value:</b>

A 32-bit signed integer.

<a id="ReadInt32LE"></a>
### ReadInt32LE

    public int ReadInt32LE();

 Not documented yet.

<b>Return Value:</b>

A 32-bit signed integer.

<a id="ReadInt64BE"></a>
### ReadInt64BE

    public long ReadInt64BE();

 Reads a 64-bit signed integer in big-endian byte order (8 bytes).

<b>Return Value:</b>

A 64-bit signed integer.

<a id="ReadInt64LE"></a>
### ReadInt64LE

    public long ReadInt64LE();

 Not documented yet.

<b>Return Value:</b>

A 64-bit signed integer.

<a id="ReadSingleBE"></a>
### ReadSingleBE

    public float ReadSingleBE();

 Not documented yet.

<b>Return Value:</b>

A 32-bit floating-point number.

<a id="ReadSingleLE"></a>
### ReadSingleLE

    public float ReadSingleLE();

 Not documented yet.

<b>Return Value:</b>

A 32-bit floating-point number.

<a id="Write_byte"></a>
### Write

    public void Write(
        byte value);

 Not documented yet.

<b>Parameters:</b>

 * <i>value</i>: The parameter  <i>value</i>
 is not documented yet.

<a id="Write_byte"></a>
### Write

    public void Write(
        byte[] data);

 Not documented yet.

<b>Parameters:</b>

 * <i>data</i>: The parameter  <i>data</i>
 is not documented yet.

<b>Exceptions:</b>

 * System.ArgumentNullException:
The parameter  <i>data</i>
 is null.

<a id="Write_byte_int_int"></a>
### Write

    public void Write(
        byte[] data,
        int offset,
        int length);

 Not documented yet.

<b>Parameters:</b>

 * <i>data</i>: The parameter  <i>data</i>
 is not documented yet.

 * <i>offset</i>: A zero-based index showing where the desired portion of  <i>data</i>
 begins.

 * <i>length</i>: The number of elements in the desired portion of  <i>data</i>
 (but not more than  <i>data</i>
 's length).

<b>Exceptions:</b>

 * System.ArgumentException:
Either  <i>offset</i>
 or  <i>length</i>
 is less than 0 or greater than  <i>data</i>
 's length, or  <i>             data</i>
 ' s length minus  <i>offset</i>
 is less than  <i>length</i>
 .

 * System.ArgumentNullException:
The parameter  <i>data</i>
 is null.

<a id="Write7BitEncodedInt32BE_int"></a>
### Write7BitEncodedInt32BE

    public int Write7BitEncodedInt32BE(
        int value);

 Not documented yet.

<b>Parameters:</b>

 * <i>value</i>: The parameter  <i>value</i>
 is not documented yet.

<b>Return Value:</b>

A 32-bit signed integer.

<a id="Write7BitEncodedInt32LE_int"></a>
### Write7BitEncodedInt32LE

    public int Write7BitEncodedInt32LE(
        int value);

 Not documented yet.

<b>Parameters:</b>

 * <i>value</i>: The parameter  <i>value</i>
 is not documented yet.

<b>Return Value:</b>

A 32-bit signed integer.

<a id="Write7BitEncodedInt64BE_long"></a>
### Write7BitEncodedInt64BE

    public int Write7BitEncodedInt64BE(
        long value);

 Not documented yet.

<b>Parameters:</b>

 * <i>value</i>: The parameter  <i>value</i>
 is not documented yet.

<b>Return Value:</b>

A 32-bit signed integer.

<a id="Write7BitEncodedInt64LE_long"></a>
### Write7BitEncodedInt64LE

    public int Write7BitEncodedInt64LE(
        long value);

 Not documented yet.

<b>Parameters:</b>

 * <i>value</i>: The parameter  <i>value</i>
 is not documented yet.

<b>Return Value:</b>

A 32-bit signed integer.

<a id="Write7BitEncodedUInt32BE_int"></a>
### Write7BitEncodedUInt32BE

    public int Write7BitEncodedUInt32BE(
        int value);

 Not documented yet.

<b>Parameters:</b>

 * <i>value</i>: The parameter  <i>value</i>
 is not documented yet.

<b>Return Value:</b>

A 32-bit signed integer.

<a id="Write7BitEncodedUInt32LE_int"></a>
### Write7BitEncodedUInt32LE

    public int Write7BitEncodedUInt32LE(
        int value);

 Not documented yet.

<b>Parameters:</b>

 * <i>value</i>: The parameter  <i>value</i>
 is not documented yet.

<b>Return Value:</b>

A 32-bit signed integer.

<a id="WriteBE_byte"></a>
### WriteBE

    public void WriteBE(
        byte value);

 Not documented yet.

<b>Parameters:</b>

 * <i>value</i>: The parameter  <i>value</i>
 is not documented yet.

<a id="WriteBE_double"></a>
### WriteBE

    public void WriteBE(
        double value);

 Not documented yet.

<b>Parameters:</b>

 * <i>value</i>: The parameter  <i>value</i>
 is not documented yet.

<a id="WriteBE_float"></a>
### WriteBE

    public void WriteBE(
        float value);

 Not documented yet.

<b>Parameters:</b>

 * <i>value</i>: The parameter  <i>value</i>
 is not documented yet.

<a id="WriteBE_int"></a>
### WriteBE

    public void WriteBE(
        int value);

 Not documented yet.

<b>Parameters:</b>

 * <i>value</i>: The parameter  <i>value</i>
 is not documented yet.

<a id="WriteBE_long"></a>
### WriteBE

    public void WriteBE(
        long value);

 Not documented yet.

<b>Parameters:</b>

 * <i>value</i>: The parameter  <i>value</i>
 is not documented yet.

<a id="WriteBE_short"></a>
### WriteBE

    public void WriteBE(
        short value);

 Not documented yet.

<b>Parameters:</b>

 * <i>value</i>: The parameter  <i>value</i>
 is not documented yet.

<a id="WriteLE_byte"></a>
### WriteLE

    public void WriteLE(
        byte value);

 Not documented yet.

<b>Parameters:</b>

 * <i>value</i>: The parameter  <i>value</i>
 is not documented yet.

<a id="WriteLE_double"></a>
### WriteLE

    public void WriteLE(
        double value);

 Not documented yet.

<b>Parameters:</b>

 * <i>value</i>: The parameter  <i>value</i>
 is not documented yet.

<a id="WriteLE_float"></a>
### WriteLE

    public void WriteLE(
        float value);

 Not documented yet.

<b>Parameters:</b>

 * <i>value</i>: The parameter  <i>value</i>
 is not documented yet.

<a id="WriteLE_int"></a>
### WriteLE

    public void WriteLE(
        int value);

 Not documented yet.

<b>Parameters:</b>

 * <i>value</i>: The parameter  <i>value</i>
 is not documented yet.

<a id="WriteLE_long"></a>
### WriteLE

    public void WriteLE(
        long value);

 Not documented yet.

<b>Parameters:</b>

 * <i>value</i>: The parameter  <i>value</i>
 is not documented yet.

<a id="WriteLE_short"></a>
### WriteLE

    public void WriteLE(
        short value);

 Not documented yet.

<b>Parameters:</b>

 * <i>value</i>: The parameter  <i>value</i>
 is not documented yet.
