## PeterO.PartialStream

    public sealed class PartialStream :
        System.IO.Stream,
        System.IDisposable

Represents a portion of another data stream. For this to work, the underlying stream must be seekable and have a known length.

### PartialStream Constructor

    public PartialStream(
        System.IO.Stream stream,
        long start,
        long length);

Initializes a new instance of the  class.

<b>Parameters:</b>

 * <i>stream</i>: A Stream object.

 * <i>start</i>: A 64-bit signed integer.

 * <i>length</i>: A 64-bit signed integer. (2).

### PartialStream Constructor

    public PartialStream(
        System.IO.Stream stream,
        long start,
        long length,
        bool closeOnDispose);

Initializes a new instance of the  class.

<b>Parameters:</b>

 * <i>stream</i>: A Stream object.

 * <i>start</i>: The start of the partial stream from the underlying stream.

 * <i>length</i>: The length of the partial stream in bytes.

 * <i>closeOnDispose</i>: If true, closes the underlying stream when disposing the partial stream.

<b>Exceptions:</b>

 * System.ArgumentNullException:
The parameter <i>stream</i>
 or  <i>stream</i>
 is null.

 * System.ArgumentException:
The parameter <i>stream</i>
 doesn't support seeking, the length or start is less than 0 or greater than the underlying stream's length, or the partial stream would go beyond the underlying stream.

### CanRead

    public override bool CanRead { get; }

Gets a value indicating whether the underlying stream supports reading.

<b>Returns:</b>

True if the underlying stream supports reading; otherwise, false.

### CanSeek

    public override bool CanSeek { get; }

Gets a value indicating whether the underlying stream supports seeking.

<b>Returns:</b>

True if the underlying stream supports seeking; otherwise, false.

### CanWrite

    public override bool CanWrite { get; }

Gets a value indicating whether the underlying stream supports writing.

<b>Returns:</b>

True if the underlying stream supports writing; otherwise, false.

### Length

    public override long Length { get; }

Gets the partial stream's length in bytes.

<b>Returns:</b>

The partial stream's length in bytes.

### Position

    public override long Position { get; set;}

Gets the partial stream's current byte position.

<b>Returns:</b>

The partial stream's current byte position.

### Dispose

    protected override void Dispose(
        bool disposing);

Not documented yet.

<b>Parameters:</b>

 * <i>disposing</i>: A Boolean object.

### Flush

    public override void Flush();

Not documented yet.

### Read

    public override int Read(
        byte[] buffer,
        int offset,
        int count);

Not documented yet.

<b>Parameters:</b>

 * <i>buffer</i>: A byte array.

 * <i>offset</i>: A zero-based index showing where the desired portion of  <i>buffer</i>
 begins.

 * <i>count</i>: The number of elements in the desired portion of  <i>buffer</i>
 (but not more than  <i>buffer</i>
 's length).

<b>Returns:</b>

A 32-bit signed integer.

<b>Exceptions:</b>

 * System.ArgumentNullException:
The parameter <i>buffer</i>
 is null.

 * System.ArgumentException:
Either  <i>offset</i>
 or  <i>count</i>
 is less than 0 or greater than  <i>buffer</i>
 's length, or  <i>buffer</i>
 ' s length minus  <i>offset</i>
 is less than  <i>count</i>
.

### Seek

    public override long Seek(
        long offset,
        System.IO.SeekOrigin origin);

Not documented yet.

<b>Parameters:</b>

 * <i>offset</i>: A 64-bit signed integer. (2).

 * <i>origin</i>: A SeekOrigin object.

<b>Returns:</b>

A 64-bit signed integer.

### SetLength

    public override void SetLength(
        long value);

Not documented yet.

<b>Parameters:</b>

 * <i>value</i>: A 64-bit signed integer.

### Write

    public override void Write(
        byte[] buffer,
        int offset,
        int count);

Not documented yet.

<b>Parameters:</b>

 * <i>buffer</i>: A byte array.

 * <i>offset</i>: A zero-based index showing where the desired portion of  <i>buffer</i>
 begins.

 * <i>count</i>: The number of elements in the desired portion of  <i>buffer</i>
 (but not more than  <i>buffer</i>
 's length).

<b>Exceptions:</b>

 * System.ArgumentNullException:
The parameter <i>buffer</i>
 is null.

 * System.ArgumentException:
Either  <i>offset</i>
 or  <i>count</i>
 is less than 0 or greater than  <i>buffer</i>
 's length, or  <i>buffer</i>
 ' s length minus  <i>offset</i>
 is less than  <i>count</i>
.
