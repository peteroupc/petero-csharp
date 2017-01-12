/*
Written by Peter O. in 2010.
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
    /// path='docs/doc[@name="T:PeterO.DisposableLists"]/*'/>
  public static class DisposableLists {
    /// <include file='../docs.xml'
    /// path='docs/doc[@name="M:PeterO.DisposableLists.Create"]/*'/>
    public static DisposableList<IDisposable> Create() {
      return new DisposableList<IDisposable>();
    }

    /// <include file='../docs.xml'
    /// path='docs/doc[@name="M:PeterO.DisposableLists.Create``1(``0)"]/*'/>
    public static DisposableList<T> Create<T>(T obj) where T : IDisposable {
      var ret = new DisposableList<T>();
      ret.Add(obj);
      return ret;
    }
  }
}
