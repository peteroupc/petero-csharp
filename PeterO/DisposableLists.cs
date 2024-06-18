/*
Written by Peter O.
Any copyright to this work is released to the Public Domain.
In case this is not possible, this work is also
licensed under the Unlicense: https://unlicense.org/

 */
using System;
using System.Collections.Generic;
using System.Linq;
using PeterO;

namespace PeterO {
  /// <summary>Not documented yet.</summary>
  public static class DisposableLists {
    /// <summary>Not documented yet.</summary>
    /// <returns>A DisposableList(IDisposable) object.</returns>
    public static DisposableList<IDisposable> Create() {
      return new DisposableList<IDisposable>();
    }

    /// <summary>Not documented yet.</summary>
    /// <param name='obj'>The parameter <paramref name='obj'/> is a T
    /// object.</param>
    /// <typeparam name='T'>Any object type that implements
    /// IDisposable.</typeparam>
    /// <returns>A DisposableList(T) object.</returns>
    public static DisposableList<T> Create<T> (T obj) where T : IDisposable {
      var ret = new DisposableList<T>();
      ret.Add (obj);
      return ret;
    }
  }
}
