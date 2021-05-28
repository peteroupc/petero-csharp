/*
Written by Peter O.
Any copyright to this work is released to the Public Domain.
In case this is not possible, this work is also
licensed under Creative Commons Zero (CC0):
https://creativecommons.org/publicdomain/zero/1.0/

 */
using System;
using System.Collections.Generic;

namespace PeterO {
  /// <summary>Specifies a segment of a list defined by an offset and
  /// length. This class cannot be inherited.</summary>
  /// <typeparam name='T'>Any object type.</typeparam>
  #if CODE_ANALYSIS
  [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute(
    "Microsoft.Naming",
    "CA1710:IdentifiersShouldHaveCorrectSuffix",
    Justification = "This is a part of a list and not just a collection.")]
  #endif
  public sealed class ListSegment<T> : IList<T> {
    private readonly int start;

    private readonly int count;

    private readonly IList<T> list;

    private readonly EqualityComparer<T> comparer = EqualityComparer<T>.Default;

    /// <summary>Initializes a new instance of the
    /// <see cref='ListSegment'/> class.</summary>
    /// <param name='list'>The parameter <paramref name='list'/> is an
    /// IList object.</param>
    /// <param name='start'>The parameter <paramref name='start'/> is a
    /// 32-bit signed integer.</param>
    /// <param name='count'>The parameter <paramref name='count'/> is a
    /// 32-bit signed integer.</param>
    /// <exception cref='ArgumentNullException'>The parameter <paramref
    /// name='list'/> is null.</exception>
    public ListSegment (IList<T> list, int start, int count) {
      if (list == null) {
        throw new ArgumentNullException(nameof(list));
      }
      if (start < 0) {
        throw new ArgumentException("start (" + start + ") is less than 0");
      }
      if (start > list.Count) {
        throw new ArgumentException("start (" + start + ") is more than " +
          list.Count);
      }
      if (count < 0) {
        throw new ArgumentException("count (" + count + ") is less than 0");
      }
      if (count > list.Count) {
        throw new ArgumentException("count (" + count + ") is more than " +
          list.Count);
      }
      if (list.Count - start < count) {
        throw new ArgumentException("list's length minus " + start + " (" +
          (list.Count - start) + ") is less than " + count);
      }
      this.list = list;
      this.start = start;
      this.count = count;
    }

    /// <summary>Gets the starting index within the underlying list for
    /// this list segment.</summary>
    /// <value>The starting index within the underlying list for this list
    /// segment.</value>
    public int StartIndex {
      get {
        return this.start;
      }
    }

    private event EventHandler ContentsModified = delegate {
    };

    /// <summary>Not documented yet.</summary>
    /// <param name='index'>The parameter <paramref name='index'/> is a
    /// 32-bit signed integer.</param>
    /// <returns>A T object.</returns>
    public T this[int index] {
      get {
        return this.list[this.start + index];
      }

      set {
        this.list[this.start + index] = value;
        this.ContentsModified (this, null);
      }
    }

    /// <summary>Gets a value not documented yet.</summary>
    /// <value>A value not documented yet.</value>
    public int Count {
      get {
        return this.count;
      }
    }

    /// <summary>Gets a value indicating whether this list segment is read
    /// only.</summary>
    /// <value><c>true</c> if this list segment is read only; otherwise,
    /// <c>false</c>.</value>
    /// <remarks>The read-only status of the list segment is the same as
    /// that of the underlying list. However, operations that would change
    /// the list segment's size, such as adding and removing items, are not
    /// supported.</remarks>
    public bool IsReadOnly {
      get {
        return this.list.IsReadOnly;
      }
    }

    /// <summary>Not documented yet.</summary>
    /// <param name='item'>The parameter <paramref name='item'/> is a `0
    /// object.</param>
    /// <returns>A 32-bit signed integer.</returns>
    public int IndexOf (T item) {
      for (int i = 0; i < this.count; ++i) {
        if (this.comparer.Equals (this.list[this.start + i], item)) {
          return this.start + i;
        }
      }
      return -1;
    }

    /// <summary>This method is not supported.</summary>
    /// <param name='index'>The parameter <paramref name='index'/> is a
    /// 32-bit signed integer.</param>
    /// <param name='item'>The parameter <paramref name='item'/> is a T
    /// object.</param>
    public void Insert (int index, T item) {
      throw new NotSupportedException("Changing the size of a list segment" +
"\u0020is not" +
"\u0020supported.");
    }

    /// <summary>This method is not supported.</summary>
    /// <param name='index'>The parameter <paramref name='index'/> is a
    /// 32-bit signed integer.</param>
    public void RemoveAt (int index) {
      throw new NotSupportedException("Changing the size of a list segment" +
"\u0020is not" +
"\u0020supported.");
    }

    /// <summary>This method is not supported.</summary>
    /// <param name='item'>The parameter <paramref name='item'/> is a `0
    /// object.</param>
    /// <exception cref='NotSupportedException'>Always thrown, because
    /// changing the size of a list segment is not supported.</exception>
    public void Add (T item) {
      throw new NotSupportedException("Changing the size of a list segment" +
"\u0020is not" +
"\u0020supported.");
    }

    /// <summary>This method is not supported.</summary>
    public void Clear() {
      throw new NotSupportedException("Changing the size of a list segment" +
"\u0020is not" +
"\u0020supported.");
    }

    /// <summary>Not documented yet.</summary>
    /// <param name='item'>The parameter <paramref name='item'/> is a `0
    /// object.</param>
    /// <returns>Either <c>true</c> or <c>false</c>.</returns>
    public bool Contains (T item) {
      return this.IndexOf (item) >= 0;
    }

    /// <summary>Not documented yet.</summary>
    /// <param name='array'>The parameter <paramref name='array'/> is a
    /// `0[] object.</param>
    /// <param name='arrayIndex'>The parameter <paramref
    /// name='arrayIndex'/> is a 32-bit signed integer.</param>
    /// <exception cref='ArgumentNullException'>The parameter <paramref
    /// name='array'/> is null.</exception>
    /// <exception cref='ArgumentException'>Array index and count must fit
    /// the bounds of the array.</exception>
    public void CopyTo (T[] array, int arrayIndex) {
      if (array == null) {
        throw new ArgumentNullException(nameof(array));
      }
      if (arrayIndex < 0) {
        throw new ArgumentException("arrayIndex less than " + "0 (" +
          Convert.ToString(
            arrayIndex,
            System.Globalization.CultureInfo.InvariantCulture) + ")");
      }
      if (arrayIndex + this.count > array.Length) {
        throw new ArgumentException("Array index and count must fit the" +
"\u0020bounds of the" +
"\u0020array.");
      }
      for (int i = 0; i < this.count; ++i) {
        array[arrayIndex + i] = this.list[this.start + i];
      }
    }

    /// <summary>This method is not supported.</summary>
    /// <param name='item'>The parameter <paramref name='item'/> is a T
    /// object.</param>
    /// <returns>Either <c>true</c> or <c>false</c>.</returns>
    public bool Remove (T item) {
      throw new NotSupportedException("Changing the size of a list segment" +
"\u0020is not" +
"\u0020supported.");
    }

    private sealed class ListSegmentEnumerator : IEnumerator<T> {
      private readonly ListSegment<T> list;
      private int index = -1;
      private bool wasModified;

      private void OnContentsModified (object sender, EventArgs eventArgs) {
        this.wasModified = true;
      }

      public ListSegmentEnumerator (ListSegment<T> list) {
        this.list = list;
        this.list.ContentsModified += this.OnContentsModified;
      }

      /// <summary>Gets a value not documented yet.</summary>
      /// <value>A value not documented yet.</value>
      public T Current {
        get {
          if (this.wasModified) {
            throw new InvalidOperationException("The list was modified" +
"\u0020during the" +
"\u0020enumeration.");
          }
          if (this.index < 0 || this.index >= this.list.Count) {
            throw new InvalidOperationException("The enumerator is out of" +
"\u0020range");
          }
          return this.list[this.index];
        }
      }

      object System.Collections.IEnumerator.Current {
        get {
          return this.Current;
        }
      }

      /// <summary>Not documented yet.</summary>
      /// <returns>Either <c>true</c> or <c>false</c>.</returns>
      public bool MoveNext() {
        if (this.wasModified) {
          throw new InvalidOperationException("The list was modified during" +
"\u0020the" +
"\u0020enumeration.");
        }
        ++this.index;
        return this.index < this.list.Count;
      }

      /// <summary>Not documented yet.</summary>
      public void Dispose() {
        this.list.ContentsModified -= this.OnContentsModified;
      }

      /// <summary>Not documented yet.</summary>
      public void Reset() {
        if (this.wasModified) {
          throw new InvalidOperationException("The list was modified during" +
"\u0020the" +
"\u0020enumeration.");
        }
        this.index = -1;
      }
    }

    /// <summary>Not documented yet.</summary>
    /// <returns>An IEnumerator(T) object.</returns>
    public IEnumerator<T> GetEnumerator() {
      return new ListSegmentEnumerator(this);
    }

    System.Collections.IEnumerator
    System.Collections.IEnumerable.GetEnumerator() {
      return new ListSegmentEnumerator(this);
    }
  }
}
