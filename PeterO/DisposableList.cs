/*
Written by Peter O.
Any copyright to this work is released to the Public Domain.
In case this is not possible, this work is also
licensed under Creative Commons Zero (CC0):
https://creativecommons.org/publicdomain/zero/1.0/

 */
using System;
using System.Collections.Generic;
using System.Linq;
using PeterO;

namespace PeterO {
  /// <summary>Holds a list of disposable objects, which can all be
  /// disposed at once when this object is disposed.</summary>
  /// <typeparam name='T'>Any object type that implements
  /// IDisposable.</typeparam>
  public sealed class DisposableList<T> : IList<T>, IDisposable
    where T : IDisposable {
    private readonly List<T> list;

    /// <summary>Not documented yet.</summary>
    public void Dispose() {
      foreach (T item in this.list) {
        if ((object)item != (object)default (T)) {
          item.Dispose();
        }
      }
      this.list.Clear();
    }

    /// <summary>Initializes a new instance of the
    /// <see cref='DisposableList'/> class.</summary>
    public DisposableList() {
      this.list = new List<T>();
    }

    /// <summary>Not documented yet.</summary>
    /// <param name='item'>The parameter <paramref name='item'/> is a
    /// 32-bit signed integer.</param>
    /// <returns>A T object.</returns>
    public T this[int item] {
      get {
        return this.list[item];
      }

      set {
        this.list[item] = value;
      }
    }

    /// <summary>Gets a value not documented yet.</summary>
    /// <value>A value not documented yet.</value>
    public int Count {
      get {
        return this.list.Count;
      }
    }

    /// <summary>Gets a value indicating whether this list is read
    /// only.</summary>
    /// <value><c>true</c> if this list is read only; otherwise,
    /// <c>false</c>.</value>
    public bool IsReadOnly {
      get {
        return ((ICollection<T>)this.list).IsReadOnly;
      }
    }

    /// <summary>Not documented yet.</summary>
    /// <param name='item'>The parameter <paramref name='item'/> is a `0
    /// object.</param>
    /// <returns>A 32-bit signed integer.</returns>
    public int IndexOf (T item) {
      return this.list.IndexOf (item);
    }

    /// <summary>Not documented yet.</summary>
    /// <param name='index'>The parameter <paramref name='index'/> is a
    /// 32-bit signed integer.</param>
    /// <param name='item'>The parameter <paramref name='item'/> is a `0
    /// object.</param>
    public void Insert (int index, T item) {
      this.list.Insert (index, item);
    }

    /// <summary>Removes an item at a given index from the list.</summary>
    /// <param name='index'>Zero-based index into the list.</param>
    public void RemoveAt (int index) {
      this.list.RemoveAt (index);
    }

    /// <summary>Not documented yet.</summary>
    /// <param name='item'>The parameter <paramref name='item'/> is a `0
    /// object.</param>
    public void Add (T item) {
      this.list.Add (item);
    }

    /// <summary>Not documented yet.</summary>
    public void Clear() {
      this.list.Clear();
    }

    /// <summary>Not documented yet.</summary>
    /// <param name='item'>The parameter <paramref name='item'/> is a `0
    /// object.</param>
    /// <returns>Either <c>true</c> or <c>false</c>.</returns>
    public bool Contains (T item) {
      return this.list.Contains (item);
    }

    /// <summary>Not documented yet.</summary>
    /// <param name='array'>The parameter <paramref name='array'/> is a
    /// `0[] object.</param>
    /// <param name='arrayIndex'>The parameter <paramref
    /// name='arrayIndex'/> is a 32-bit signed integer.</param>
    public void CopyTo (T[] array, int arrayIndex) {
      this.list.CopyTo (array, arrayIndex);
    }

    /// <summary>Not documented yet.</summary>
    /// <param name='item'>The parameter <paramref name='item'/> is a `0
    /// object.</param>
    /// <returns>Either <c>true</c> or <c>false</c>.</returns>
    public bool Remove (T item) {
      return this.list.Remove (item);
    }

    /// <summary>Not documented yet.</summary>
    /// <returns>An IEnumerator(T) object.</returns>
    public IEnumerator<T> GetEnumerator() {
      return this.list.GetEnumerator();
    }

    System.Collections.IEnumerator
    System.Collections.IEnumerable.GetEnumerator() {
      return this.list.GetEnumerator();
    }
  }
}
