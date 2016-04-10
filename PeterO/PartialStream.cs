/*
Written in 2010 by Peter O.
Any copyright is dedicated to the Public Domain.
http://creativecommons.org/publicdomain/zero/1.0/
If you like this, you should donate to Peter O.
at: http://peteroupc.github.io/
 */
using System;
using System.IO;

namespace PeterO {
    /// <include file='../docs.xml'
    /// path='docs/doc[@name="T:PeterO.PartialStream"]/*'/>
  public sealed class PartialStream : Stream
  {
    private readonly Stream stream;
    private readonly bool closeOnDispose;
    private long position;
    private readonly long length;
    private readonly long start;
    private bool isDisposed;

    /// <include file='../docs.xml'
    /// path='docs/doc[@name="M:PeterO.PartialStream.#ctor(System.IO.Stream,System.Int64,System.Int64)"]/*'/>
    public PartialStream(Stream stream, long start, long length) :
      this(stream, start, length, false) {
    }

    /// <include file='../docs.xml'
    /// path='docs/doc[@name="M:PeterO.PartialStream.#ctor(System.IO.Stream,System.Int64,System.Int64,System.Boolean)"]/*'/>
    public PartialStream(
  Stream stream,
  long start,
  long length,
  bool closeOnDispose) {
      if (stream == null) {
        throw new ArgumentNullException("stream");
      }
      if (!stream.CanSeek) {
        throw new ArgumentException("Stream doesn't support seeking.");
      }
      if (stream == null) {
        throw new ArgumentNullException("stream");
      }
      if (start < 0) {
        throw new ArgumentException("start (" + start +
                    ") is less than 0");
      }
      if (start > stream.Length) {
        throw new ArgumentException("start (" + start + ") is more than " +
                    stream.Length);
      }
      if (length < 0) {
        throw new ArgumentException("length (" + length +
                    ") is less than 0");
      }
      if (length > stream.Length) {
        throw new ArgumentException("length (" + length + ") is more than " +
                    stream.Length);
      }
      if (stream.Length - start < length) {
        throw new ArgumentException("stream's length minus " + start + " (" +
                    (stream.Length - start) + ") is less than " + length);
      }
      this.stream = stream;
      this.length = length;
      this.start = start;
      this.closeOnDispose = closeOnDispose;
    }

    /// <include file='../docs.xml'
    /// path='docs/doc[@name="P:PeterO.PartialStream.CanRead"]/*'/>
    public override bool CanRead {
      get {
        if (this.isDisposed) {
          throw new ObjectDisposedException("PartialStream");
        }
        return this.stream.CanRead;
      }
    }

    /// <include file='../docs.xml'
    /// path='docs/doc[@name="P:PeterO.PartialStream.CanSeek"]/*'/>
    public override bool CanSeek {
      get {
        if (this.isDisposed) {
          throw new ObjectDisposedException("PartialStream");
        }
        return this.stream.CanSeek;
      }
    }

    /// <include file='../docs.xml'
    /// path='docs/doc[@name="P:PeterO.PartialStream.CanWrite"]/*'/>
    public override bool CanWrite {
      get {
        if (this.isDisposed) {
          throw new ObjectDisposedException("PartialStream");
        }
        return this.stream.CanWrite;
      }
    }

    /// <include file='../docs.xml'
    /// path='docs/doc[@name="P:PeterO.PartialStream.Length"]/*'/>
    public override long Length {
      get {
        if (this.isDisposed) {
          throw new ObjectDisposedException("PartialStream");
        }
        return this.length;
      }
    }

    /// <include file='../docs.xml'
    /// path='docs/doc[@name="P:PeterO.PartialStream.Position"]/*'/>
    public override long Position {
      get {
        if (this.isDisposed) {
          throw new ObjectDisposedException("PartialStream");
        }
        return this.position;
      }

      set {
        if (this.isDisposed) {
          throw new ObjectDisposedException("PartialStream");
        }
        if (value < 0) {
          throw new ArgumentException("value (" + value +
                    ") is less than 0");
        }
        if (value > this.length) {
          throw new ArgumentException("value (" + value + ") is more than " +
                    this.length);
        }
        this.position = value;
      }
    }

    /// <include file='../docs.xml'
    /// path='docs/doc[@name="M:PeterO.PartialStream.Flush"]/*'/>
    public override void Flush() {
      if (this.isDisposed) {
        throw new ObjectDisposedException("PartialStream");
      }
      this.stream.Flush();
    }

    /// <include file='../docs.xml'
    /// path='docs/doc[@name="M:PeterO.PartialStream.Seek(System.Int64,System.IO.SeekOrigin)"]/*'/>
    public override long Seek(long offset, SeekOrigin origin) {
      if (this.isDisposed) {
        throw new ObjectDisposedException("PartialStream");
      }
      if (origin == SeekOrigin.Begin) {
        this.position = offset;
      }
      if (origin == SeekOrigin.Current) {
        this.position += offset;
      }
      if (origin == SeekOrigin.End) {
        this.position = this.length - offset;
      }
      this.position = Math.Max(0, this.position);
      this.position = Math.Min(this.position, this.length);
      return this.position;
    }

    /// <include file='../docs.xml'
    /// path='docs/doc[@name="M:PeterO.PartialStream.SetLength(System.Int64)"]/*'/>
    public override void SetLength(long value) {
      if (this.isDisposed) {
        throw new ObjectDisposedException("PartialStream");
      }
      throw new NotSupportedException();
    }

    /// <include file='../docs.xml'
    /// path='docs/doc[@name="M:PeterO.PartialStream.Read(System.Byte[],System.Int32,System.Int32)"]/*'/>
    public override int Read(byte[] buffer, int offset, int count) {
      if (this.isDisposed) {
        throw new ObjectDisposedException("PartialStream");
      }
      if (buffer == null) {
        throw new ArgumentNullException("buffer");
      }
      if (offset < 0) {
        throw new ArgumentException("offset (" + offset +
                    ") is less than 0");
      }
      if (offset > buffer.Length) {
        throw new ArgumentException("offset (" + offset + ") is more than " +
                    buffer.Length);
      }
      if (count < 0) {
        throw new ArgumentException("count (" + count +
                    ") is less than 0");
      }
      if (count > buffer.Length) {
        throw new ArgumentException("count (" + count + ") is more than " +
                    buffer.Length);
      }
      if (buffer.Length - offset < count) {
        throw new ArgumentException("buffer's length minus " + offset + " (" +
                    (buffer.Length - offset) + ") is less than " + count);
      }
      this.stream.Position = this.start + this.position;
      if (this.length - this.position > Int32.MaxValue) {
        var c = this.stream.Read(buffer, offset, count);
        checked { this.position += c;
        }
        return c;
      } else {
        var c = this.stream.Read(
  buffer,
  offset,
  Math.Min(count, (int)(this.length - this.position)));
        checked { this.position += c;
        }
        return c;
      }
    }

    /// <include file='../docs.xml'
    /// path='docs/doc[@name="M:PeterO.PartialStream.Write(System.Byte[],System.Int32,System.Int32)"]/*'/>
    public override void Write(byte[] buffer, int offset, int count) {
      if (this.isDisposed) {
        throw new ObjectDisposedException("PartialStream");
      }
      if (buffer == null) {
        throw new ArgumentNullException("buffer");
      }
      if (offset < 0) {
        throw new ArgumentException("offset (" + offset +
                    ") is less than 0");
      }
      if (offset > buffer.Length) {
        throw new ArgumentException("offset (" + offset + ") is more than " +
                    buffer.Length);
      }
      if (count < 0) {
        throw new ArgumentException("count (" + count +
                    ") is less than 0");
      }
      if (count > buffer.Length) {
        throw new ArgumentException("count (" + count + ") is more than " +
                    buffer.Length);
      }
      if (buffer.Length - offset < count) {
        throw new ArgumentException("buffer's length minus " + offset + " (" +
                    (buffer.Length - offset) + ") is less than " + count);
      }
      this.stream.Position = this.start + this.position;
      if (this.length - this.position <= Int32.MaxValue) {
        count = Math.Min(count, (int)(this.length - this.position));
      }
      if (count > 0) {
        this.stream.Write(buffer, offset, count);
        checked { this.position += count;
        }
      }
    }

    /// <include file='../docs.xml'
    /// path='docs/doc[@name="M:PeterO.PartialStream.Dispose(System.Boolean)"]/*'/>
    protected override void Dispose(bool disposing) {
      if (this.isDisposed) {
        return;
      }
      if (this.closeOnDispose) {
        this.stream.Dispose();
      }
      this.isDisposed = true;
      base.Dispose(disposing);
    }
  }
}
