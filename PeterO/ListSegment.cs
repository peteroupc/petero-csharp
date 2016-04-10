/*
Written by Peter O.
Any copyright is dedicated to the Public Domain.
http://creativecommons.org/publicdomain/zero/1.0/
If you like this, you should donate to Peter O.
at: http://peteroupc.github.io/
 */
using System;
using System.Collections.Generic;

namespace PeterO {
    /// <include file='../docs.xml'
    /// path='docs/doc[@name="T:PeterO.ListSegment`1"]/*'/>
#if CODE_ANALYSIS
  [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute(
    "Microsoft.Naming",
    "CA1710:IdentifiersShouldHaveCorrectSuffix",
    Justification="This is a part of a list and not just a collection.")]
#endif
  public sealed class ListSegment<T> : IList<T> {
    private readonly int start;

    private readonly int count;

    private readonly IList<T> list;

    private readonly EqualityComparer<T> comparer = EqualityComparer<T>.Default;

    /// <include file='../docs.xml'
    /// path='docs/doc[@name="M:PeterO.ListSegment`1.#ctor(System.Collections.Generic.IList{`0},System.Int32,System.Int32)"]/*'/>
    public ListSegment(IList<T> list, int start, int count) {
      if (list == null) {
        throw new ArgumentNullException("list");
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

    /// <include file='../docs.xml'
    /// path='docs/doc[@name="P:PeterO.ListSegment`1.StartIndex"]/*'/>
    public int StartIndex {
      get {
        return this.start;
      }
    }

    private event EventHandler ContentsModified = delegate {
    };

    /// <include file='../docs.xml'
    /// path='docs/doc[@name="P:PeterO.ListSegment`1.Item(System.Int32)"]/*'/>
    public T this[int index] {
      get {
        return this.list[this.start + index];
      }

      set {
        this.list[this.start + index] = value;
        this.ContentsModified(this, null);
      }
    }

    /// <include file='../docs.xml'
    /// path='docs/doc[@name="P:PeterO.ListSegment`1.Count"]/*'/>
    public int Count {
      get {
        return this.count;
      }
    }

    /// <include file='../docs.xml'
    /// path='docs/doc[@name="P:PeterO.ListSegment`1.IsReadOnly"]/*'/>
    public bool IsReadOnly {
      get {
        return this.list.IsReadOnly;
      }
    }

    /// <include file='../docs.xml'
    /// path='docs/doc[@name="M:PeterO.ListSegment`1.IndexOf(`0)"]/*'/>
    public int IndexOf(T item) {
      for (int i = 0; i < this.count; ++i) {
        if (this.comparer.Equals(this.list[this.start + i], item)) {
          return this.start + i;
        }
      }
      return -1;
    }

    /// <include file='../docs.xml'
    /// path='docs/doc[@name="M:PeterO.ListSegment`1.Insert(System.Int32,`0)"]/*'/>
    public void Insert(int index, T item) {
      throw new
NotSupportedException("Changing the size of a list segment is not supported.");
    }

    /// <include file='../docs.xml'
    /// path='docs/doc[@name="M:PeterO.ListSegment`1.RemoveAt(System.Int32)"]/*'/>
    public void RemoveAt(int index) {
      throw new
NotSupportedException("Changing the size of a list segment is not supported.");
    }

    /// <include file='../docs.xml'
    /// path='docs/doc[@name="M:PeterO.ListSegment`1.Add(`0)"]/*'/>
    public void Add(T item) {
      throw new
NotSupportedException("Changing the size of a list segment is not supported.");
    }

    /// <include file='../docs.xml'
    /// path='docs/doc[@name="M:PeterO.ListSegment`1.Clear"]/*'/>
    public void Clear() {
      throw new
NotSupportedException("Changing the size of a list segment is not supported.");
    }

    /// <include file='../docs.xml'
    /// path='docs/doc[@name="M:PeterO.ListSegment`1.Contains(`0)"]/*'/>
    public bool Contains(T item) {
      return this.IndexOf(item) >= 0;
    }

    /// <include file='../docs.xml'
    /// path='docs/doc[@name="M:PeterO.ListSegment`1.CopyTo(`0[],System.Int32)"]/*'/>
    public void CopyTo(T[] array, int arrayIndex) {
      if (array == null) {
        throw new ArgumentNullException("array");
      }
      if (arrayIndex < 0) {
        throw new ArgumentException("arrayIndex less than " + "0 (" +
                    Convert.ToString(
                    arrayIndex,
                    System.Globalization.CultureInfo.InvariantCulture) + ")");
      }
      if (arrayIndex + this.count > array.Length) {
        throw new
  ArgumentException("Array index and count must fit the bounds of the array.");
      }
      for (int i = 0; i < this.count; ++i) {
        array[arrayIndex + i] = this.list[this.start + i];
      }
    }

    /// <include file='../docs.xml'
    /// path='docs/doc[@name="M:PeterO.ListSegment`1.Remove(`0)"]/*'/>
    public bool Remove(T item) {
      throw new
NotSupportedException("Changing the size of a list segment is not supported.");
    }

    private sealed class ListSegmentEnumerator : IEnumerator<T> {
      private int index = -1;

      private readonly ListSegment<T> list;

      private bool wasModified;

      private void OnContentsModified(object sender, EventArgs eventArgs) {
        this.wasModified = true;
      }

      public ListSegmentEnumerator(ListSegment<T> list) {
        this.list = list;
        this.list.ContentsModified += this.OnContentsModified;
      }

    /// <include file='../docs.xml'
    /// path='docs/doc[@name="P:PeterO.ListSegment`1.ListSegmentEnumerator.Current"]/*'/>
      public T Current {
        get {
          if (this.wasModified) {
            throw new
    InvalidOperationException("The list was modified during the enumeration.");
          }
          if (this.index < 0 || this.index >= this.list.Count) {
         throw new InvalidOperationException("The enumerator is out of range");
          }
          return this.list[this.index];
        }
      }

      object System.Collections.IEnumerator.Current {
        get {
          return this.Current;
        }
      }

    /// <include file='../docs.xml'
    /// path='docs/doc[@name="M:PeterO.ListSegment`1.ListSegmentEnumerator.MoveNext"]/*'/>
      public bool MoveNext() {
        if (this.wasModified) {
          throw new
    InvalidOperationException("The list was modified during the enumeration.");
        }
        ++this.index;
        return this.index < this.list.Count;
      }

    /// <include file='../docs.xml'
    /// path='docs/doc[@name="M:PeterO.ListSegment`1.ListSegmentEnumerator.Dispose"]/*'/>
      public void Dispose() {
        this.list.ContentsModified -= this.OnContentsModified;
      }

    /// <include file='../docs.xml'
    /// path='docs/doc[@name="M:PeterO.ListSegment`1.ListSegmentEnumerator.Reset"]/*'/>
      public void Reset() {
        if (this.wasModified) {
          throw new
    InvalidOperationException("The list was modified during the enumeration.");
        }
        this.index = -1;
      }
    }

    /// <include file='../docs.xml'
    /// path='docs/doc[@name="M:PeterO.ListSegment`1.GetEnumerator"]/*'/>
    public IEnumerator<T> GetEnumerator() {
      return new ListSegmentEnumerator(this);
    }

System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() {
      return new ListSegmentEnumerator(this);
    }
  }
}
