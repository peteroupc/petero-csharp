## PeterO.PartialStream

    public sealed class PartialStream :
        System.IO.Stream,
        System.IAsyncDisposable,
        System.IDisposable

Represents a portion of another data stream. For this to work, the underlying stream must be seekable and have a known length.

### Member Summary
* <code>[CanRead](#CanRead)</code> - Gets a value indicating whether the underlying stream supports reading.
* <code>[CanSeek](#CanSeek)</code> - Gets a value indicating whether the underlying stream supports seeking.
* <code>[CanWrite](#CanWrite)</code> - Gets a value indicating whether the underlying stream supports writing.
* <code>[Flush()](#Flush)</code> - Not documented yet.
* <code>[Length](#Length)</code> - Gets the partial stream's length in bytes.
* <code>[Position](#Position)</code> - Gets the partial stream's current byte position.
* <code>[Read(byte[], int, int)](#Read_byte_int_int)</code> - Not documented yet.
* <code>[Seek(long, System.IO.SeekOrigin)](#Seek_long_System_IO_SeekOrigin)</code> - Not documented yet.
* <code>[SetLength(long)](#SetLength_long)</code> - Not documented yet.
* <code>[Write(byte[], int, int)](#Write_byte_int_int)</code> - Not documented yet.

<a id="Void_ctor_System_IO_Stream_Int64_Int64"></a>
### PartialStream Constructor

    public PartialStream(
        System.IO.Stream stream,
        long start,
        long length);

Initializes a new instance of the [PeterO.PartialStream](PeterO.PartialStream.md) class.

<b>Parameters:</b>

 * <i>stream</i>: The parameter  <i>stream</i>
 is a Stream object.

 * <i>start</i>: The parameter  <i>start</i>
 is a 64-bit signed integer.

 * <i>length</i>: The parameter  <i>length</i>
 is a 64-bit signed integer.

<a id="Void_ctor_System_IO_Stream_Int64_Int64_Boolean"></a>
### PartialStream Constructor

    public PartialStream(
        System.IO.Stream stream,
        long start,
        long length,
        bool closeOnDispose);

Initializes a new instance of the [PeterO.PartialStream](PeterO.PartialStream.md) class.

<b>Parameters:</b>

 * <i>stream</i>: The parameter  <i>stream</i>
 is a Stream object.

 * <i>start</i>: The start of the partial stream from the underlying stream.

 * <i>length</i>: The length of the partial stream in bytes.

 * <i>closeOnDispose</i>: If true, closes the underlying stream when disposing the partial stream.

<b>Exceptions:</b>

 * System.ArgumentException:
The parameter  <i>stream</i>
 doesn't support seeking, the length or start is less than 0 or greater than the underlying stream's length, or the partial stream would go beyond the underlying stream.

 * System.ArgumentNullException:
The parameter  <i>stream</i>
 or  <i>stream</i>
 is null.

<a id="CanRead"></a>
### CanRead

    public override bool CanRead { get; }

Gets a value indicating whether the underlying stream supports reading.

<b>Returns:</b>

 `true`  If the underlying stream supports reading; otherwise,  `false` .

<a id="CanSeek"></a>
### CanSeek

    public override bool CanSeek { get; }

Gets a value indicating whether the underlying stream supports seeking.

<b>Returns:</b>

 `true`  If the underlying stream supports seeking; otherwise,  `false` .

<a id="CanWrite"></a>
### CanWrite

    public override bool CanWrite { get; }

Gets a value indicating whether the underlying stream supports writing.

<b>Returns:</b>

 `true`  If the underlying stream supports writing; otherwise,  `false` .

<a id="Length"></a>
### Length

    public override long Length { get; }

Gets the partial stream's length in bytes.

<b>Returns:</b>

The partial stream's length in bytes.

<a id="Position"></a>
### Position

    public override long Position { get; set; }

Gets the partial stream's current byte position.

<b>Returns:</b>

The partial stream's current byte position.

<a id="Flush"></a>
### Flush

    public override void Flush();

Not documented yet.

<a id="Read_byte_int_int"></a>
### Read

    public override int Read(
        byte[] buffer,
        int offset,
        int count);

Not documented yet.

<b>Parameters:</b>

 * <i>buffer</i>: The parameter  <i>buffer</i>
 is a.Byte[] object.

 * <i>offset</i>: An index starting at 0 showing where the desired portion of  <i>buffer</i>
 begins.

 * <i>count</i>: The number of elements in the desired portion of  <i>buffer</i>
 (but not more than  <i>buffer</i>
 's length).

<b>Return Value:</b>

A 32-bit signed integer.

<b>Exceptions:</b>

 *  T:System.ArgumentException:
Either  <i> offset</i>
 or  <i> count</i>
 is less than 0 or greater than  <i>buffer</i>
 's length, or  <i> buffer</i>
 's length minus  <i>offset</i>
 is less than  <i>count</i>
.

 * System.ArgumentNullException:
The parameter  <i>buffer</i>
 is null.

 * System.ArgumentException:
Either  <i>offset</i>
 or  <i>count</i>
 is less than 0 or greater than  <i>buffer</i>
 's length, or  <i>buffer</i>
 's length minus  <i>offset</i>
 is less than  <i>count</i>
.

<a id="Seek_long_System_IO_SeekOrigin"></a>
### Seek

    public override long Seek(
        long offset,
        System.IO.SeekOrigin origin);

Not documented yet.

<b>Parameters:</b>

 * <i>offset</i>: The parameter  <i>offset</i>
 is a 64-bit signed integer.

 * <i>origin</i>: The parameter  <i>origin</i>
 is a.IO.SeekOrigin object.

<b>Return Value:</b>

A 64-bit signed integer.

<a id="SetLength_long"></a>
### SetLength

    public override void SetLength(
        long value);

Not documented yet.

<b>Parameters:</b>

 * <i>value</i>: The parameter  <i>value</i>
 is a 64-bit signed integer.

<a id="Write_byte_int_int"></a>
### Write

    public override void Write(
        byte[] buffer,
        int offset,
        int count);

Not documented yet.

<b>Parameters:</b>

 * <i>buffer</i>: The parameter  <i>buffer</i>
 is a.Byte[] object.

 * <i>offset</i>: An index starting at 0 showing where the desired portion of  <i>buffer</i>
 begins.

 * <i>count</i>: The number of elements in the desired portion of  <i>buffer</i>
 (but not more than  <i>buffer</i>
 's length).

<b>Exceptions:</b>

 * System.ArgumentException:
Either  <i>offset</i>
 or  <i>count</i>
 is less than 0 or greater than  <i>buffer</i>
 's length, or  <i> buffer</i>
 's length minus  <i>offset</i>
 is less than  <i>count</i>
.

 * System.ArgumentNullException:
The parameter  <i>buffer</i>
 is null.
