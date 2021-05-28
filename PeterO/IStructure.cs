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
  /// <summary>Not documented yet.</summary>
  public interface IStructure {
    /// <summary>Not documented yet.</summary>
    /// <param name='stream'>The parameter <paramref name='stream'/> is
    /// a.IO.Stream object.</param>
    void Read (Stream stream);

    /// <summary>Not documented yet.</summary>
    /// <param name='stream'>The parameter <paramref name='stream'/> is
    /// a.IO.Stream object.</param>
    void Write (Stream stream);
  }
}
