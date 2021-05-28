/*
Written by Peter O.
Any copyright to this work is released to the Public Domain.
In case this is not possible, this work is also
licensed under Creative Commons Zero (CC0):
https://creativecommons.org/publicdomain/zero/1.0/

 */
using System;
using System.IO;

namespace PeterO {
  /// <summary>Represents a portion of another data stream. For this to
  /// work, the underlying stream must be seekable and have a known
  /// length.</summary>
  public sealed class PartialStream : Stream {
    private readonly Stream stream;
    private readonly bool closeOnDispose;
    private readonly long length;
    private readonly long start;
    private long position;
    private bool isDisposed;

    /// <summary>Initializes a new instance of the
    /// <see cref='PeterO.PartialStream'/> class.</summary>
    /// <param name='stream'>The parameter <paramref name='stream'/> is a
    /// Stream object.</param>
    /// <param name='start'>The parameter <paramref name='start'/> is a
    /// 64-bit signed integer.</param>
    /// <param name='length'>The parameter <paramref name='length'/> is a
    /// 64-bit signed integer.</param>
    public PartialStream (Stream stream, long start, long length):
      this (stream, start, length, false) {
    }

    /// <summary>Initializes a new instance of the
    /// <see cref='PeterO.PartialStream'/> class.</summary>
    /// <param name='stream'>The parameter <paramref name='stream'/> is a
    /// Stream object.</param>
    /// <param name='start'>The start of the partial stream from the
    /// underlying stream.</param>
    /// <param name='length'>The length of the partial stream in
    /// bytes.</param>
    /// <param name='closeOnDispose'>If true, closes the underlying stream
    /// when disposing the partial stream.</param>
    /// <exception cref='ArgumentException'>The parameter <paramref
    /// name='stream'/> doesn't support seeking, the length or start is
    /// less than 0 or greater than the underlying stream's length, or the
    /// partial stream would go beyond the underlying stream.</exception>
    /// <exception cref='ArgumentNullException'>The parameter <paramref
    /// name='stream'/> or <paramref name='stream'/> is null.</exception>
    public PartialStream(
      Stream stream,
      long start,
      long length,
      bool closeOnDispose) {
      if (stream == null) {
        throw new ArgumentNullException(nameof(stream));
      }
      if (!stream.CanSeek) {
        throw new ArgumentException("Stream doesn't support seeking.");
      }
      if (stream == null) {
        throw new ArgumentNullException(nameof(stream));
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

    /// <summary>Gets a value indicating whether the underlying stream
    /// supports reading.</summary>
    /// <value><c>true</c> If the underlying stream supports reading;
    /// otherwise, <c>false</c>.</value>
    public override bool CanRead {
      get {
        if (this.isDisposed) {
          throw new ObjectDisposedException("PartialStream");
        }
        return this.stream.CanRead;
      }
    }

    /// <summary>Gets a value indicating whether the underlying stream
    /// supports seeking.</summary>
    /// <value><c>true</c> If the underlying stream supports seeking;
    /// otherwise, <c>false</c>.</value>
    public override bool CanSeek {
      get {
        if (this.isDisposed) {
          throw new ObjectDisposedException("PartialStream");
        }
        return this.stream.CanSeek;
      }
    }

    /// <summary>Gets a value indicating whether the underlying stream
    /// supports writing.</summary>
    /// <value><c>true</c> If the underlying stream supports writing;
    /// otherwise, <c>false</c>.</value>
    public override bool CanWrite {
      get {
        if (this.isDisposed) {
          throw new ObjectDisposedException("PartialStream");
        }
        return this.stream.CanWrite;
      }
    }

    /// <summary>Gets the partial stream's length in bytes.</summary>
    /// <value>The partial stream's length in bytes.</value>
    public override long Length {
      get {
        if (this.isDisposed) {
          throw new ObjectDisposedException("PartialStream");
        }
        return this.length;
      }
    }

    /// <summary>Gets the partial stream's current byte position.</summary>
    /// <value>The partial stream's current byte position.</value>
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

    /// <summary>Not documented yet.</summary>
    public override void Flush() {
      if (this.isDisposed) {
        throw new ObjectDisposedException("PartialStream");
      }
      this.stream.Flush();
    }

    /// <summary>Not documented yet.</summary>
    /// <param name='offset'>The parameter <paramref name='offset'/> is a
    /// 64-bit signed integer.</param>
    /// <param name='origin'>The parameter <paramref name='origin'/> is
    /// a.IO.SeekOrigin object.</param>
    /// <returns>A 64-bit signed integer.</returns>
    public override long Seek (long offset, SeekOrigin origin) {
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
      this.position = Math.Max (0, this.position);
      this.position = Math.Min (this.position, this.length);
      return this.position;
    }

    /// <summary>Not documented yet.</summary>
    /// <param name='value'>The parameter <paramref name='value'/> is a
    /// 64-bit signed integer.</param>
    public override void SetLength (long value) {
      if (this.isDisposed) {
        throw new ObjectDisposedException("PartialStream");
      }
      throw new NotSupportedException();
    }

    /// <summary>Not documented yet.</summary>
    /// <param name='buffer'>The parameter <paramref name='buffer'/> is
    /// a.Byte[] object.</param>
    /// <param name='offset'>An index starting at 0 showing where the
    /// desired portion of <paramref name='buffer'/> begins.</param>
    /// <param name='count'>The number of elements in the desired portion
    /// of <paramref name='buffer'/> (but not more than <paramref
    /// name='buffer'/> 's length).</param>
    /// <returns>A 32-bit signed integer.</returns>
    /// <exception cref=' T:System.ArgumentException'>Either <paramref
    /// name=' offset'/> or <paramref name=' count'/> is less than 0 or
    /// greater than <paramref name='buffer'/> 's length, or <paramref
    /// name=' buffer'/> 's length minus <paramref name='offset'/> is less
    /// than <paramref name='count'/>.</exception>
    /// <exception cref='ArgumentNullException'>The parameter <paramref
    /// name='buffer'/> is null.</exception>
    /// <exception cref='ArgumentException'>Either <paramref
    /// name='offset'/> or <paramref name='count'/> is less than 0 or
    /// greater than <paramref name='buffer'/> 's length, or <paramref
    /// name='buffer'/> 's length minus <paramref name='offset'/> is less
    /// than <paramref name='count'/>.</exception>
    public override int Read (byte[] buffer, int offset, int count) {
      if (this.isDisposed) {
        throw new ObjectDisposedException("PartialStream");
      }
      if (buffer == null) {
        throw new ArgumentNullException(nameof(buffer));
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
        var c = this.stream.Read (buffer, offset, count);
        checked { this.position += c;
        }
        return c;
      } else {
        var c = this.stream.Read(
            buffer,
            offset,
            Math.Min (count, (int)(this.length - this.position)));
        checked { this.position += c;
        }
        return c;
      }
    }

    /// <summary>Not documented yet.</summary>
    /// <param name='buffer'>The parameter <paramref name='buffer'/> is
    /// a.Byte[] object.</param>
    /// <param name='offset'>An index starting at 0 showing where the
    /// desired portion of <paramref name='buffer'/> begins.</param>
    /// <param name='count'>The number of elements in the desired portion
    /// of <paramref name='buffer'/> (but not more than <paramref
    /// name='buffer'/> 's length).</param>
    /// <exception cref='ArgumentException'>Either <paramref
    /// name='offset'/> or <paramref name='count'/> is less than 0 or
    /// greater than <paramref name='buffer'/> 's length, or <paramref
    /// name=' buffer'/> 's length minus <paramref name='offset'/> is less
    /// than <paramref name='count'/>.</exception>
    /// <exception cref='ArgumentNullException'>The parameter <paramref
    /// name='buffer'/> is null.</exception>
    public override void Write (byte[] buffer, int offset, int count) {
      if (this.isDisposed) {
        throw new ObjectDisposedException("PartialStream");
      }
      if (buffer == null) {
        throw new ArgumentNullException(nameof(buffer));
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
        count = Math.Min (count, (int)(this.length - this.position));
      }
      if (count > 0) {
        this.stream.Write (buffer, offset, count);
        checked { this.position += count;
        }
      }
    }

    /// <summary>Not documented yet.</summary>
    /// <param name='disposing'>The parameter <paramref name='disposing'/>
    /// is either <c>true</c> or <c>false</c>.</param>
    protected override void Dispose (bool disposing) {
      if (this.isDisposed) {
        return;
      }
      if (this.closeOnDispose) {
        this.stream.Dispose();
      }
      this.isDisposed = true;
      base.Dispose (disposing);
    }
  }
}
