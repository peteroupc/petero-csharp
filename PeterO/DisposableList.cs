/*
Written in 2010 by Peter O.
Any copyright is dedicated to the Public Domain.
http://creativecommons.org/publicdomain/zero/1.0/
If you like this, you should donate to Peter O.
at: http://peteroupc.github.io/
 */
using System;
using System.Collections.Generic;
using System.Linq;
using PeterO;

namespace PeterO {
    /// <include file='../docs.xml'
    /// path='docs/doc[@name="T:PeterO.DisposableList`1"]/*'/>
  public sealed class DisposableList<T> : IList<T>, IDisposable
    where T : IDisposable {
    private readonly List<T> list;

    /// <include file='../docs.xml'
    /// path='docs/doc[@name="M:PeterO.DisposableList`1.Dispose"]/*'/>
    public void Dispose() {
      foreach (T item in this.list) {
        if ((object)item != (object)default(T)) {
          item.Dispose();
        }
      }
      this.list.Clear();
    }

    /// <include file='../docs.xml'
    /// path='docs/doc[@name="M:PeterO.DisposableList`1.#ctor"]/*'/>
    public DisposableList() {
      this.list = new List<T>();
    }

    /// <include file='../docs.xml'
    /// path='docs/doc[@name="P:PeterO.DisposableList`1.Item(System.Int32)"]/*'/>
    public T this[int item] {
      get {
        return this.list[item];
      }

      set {
        this.list[item] = value;
      }
    }

    /// <include file='../docs.xml'
    /// path='docs/doc[@name="P:PeterO.DisposableList`1.Count"]/*'/>
    public int Count {
      get {
        return this.list.Count;
      }
    }

    /// <include file='../docs.xml'
    /// path='docs/doc[@name="P:PeterO.DisposableList`1.IsReadOnly"]/*'/>
    public bool IsReadOnly {
      get {
        return ((ICollection<T>)this.list).IsReadOnly;
      }
    }

    /// <include file='../docs.xml'
    /// path='docs/doc[@name="M:PeterO.DisposableList`1.IndexOf(`0)"]/*'/>
    public int IndexOf(T item) {
      return this.list.IndexOf(item);
    }

    /// <include file='../docs.xml'
    /// path='docs/doc[@name="M:PeterO.DisposableList`1.Insert(System.Int32,`0)"]/*'/>
    public void Insert(int index, T item) {
      this.list.Insert(index, item);
    }

    /// <include file='../docs.xml'
    /// path='docs/doc[@name="M:PeterO.DisposableList`1.RemoveAt(System.Int32)"]/*'/>
    public void RemoveAt(int index) {
      this.list.RemoveAt(index);
    }

    /// <include file='../docs.xml'
    /// path='docs/doc[@name="M:PeterO.DisposableList`1.Add(`0)"]/*'/>
    public void Add(T item) {
      this.list.Add(item);
    }

    /// <include file='../docs.xml'
    /// path='docs/doc[@name="M:PeterO.DisposableList`1.Clear"]/*'/>
    public void Clear() {
      this.list.Clear();
    }

    /// <include file='../docs.xml'
    /// path='docs/doc[@name="M:PeterO.DisposableList`1.Contains(`0)"]/*'/>
    public bool Contains(T item) {
      return this.list.Contains(item);
    }

    /// <include file='../docs.xml'
    /// path='docs/doc[@name="M:PeterO.DisposableList`1.CopyTo(`0[],System.Int32)"]/*'/>
    public void CopyTo(T[] array, int arrayIndex) {
      this.list.CopyTo(array, arrayIndex);
    }

    /// <include file='../docs.xml'
    /// path='docs/doc[@name="M:PeterO.DisposableList`1.Remove(`0)"]/*'/>
    public bool Remove(T item) {
      return this.list.Remove(item);
    }

    /// <include file='../docs.xml'
    /// path='docs/doc[@name="M:PeterO.DisposableList`1.GetEnumerator"]/*'/>
    public IEnumerator<T> GetEnumerator() {
      return this.list.GetEnumerator();
    }

System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() {
      return this.list.GetEnumerator();
    }
  }
}
