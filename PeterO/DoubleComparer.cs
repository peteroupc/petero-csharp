/*
Written by Peter O.
Any copyright to this work is released to the Public Domain.
In case this is not possible, this work is also
licensed under Creative Commons Zero (CC0):
http://creativecommons.org/publicdomain/zero/1.0/
If you like this, you should donate to Peter O.
at: http://peteroupc.github.io/
 */
using System;
using System.Collections.Generic;

namespace PeterO {
  internal sealed class DoubleComparer : IEqualityComparer<double> {
    public bool Equals (double x, double y) {
      return BitConverter.ToInt64 (BitConverter.GetBytes ((double)x), 0) ==
        BitConverter.ToInt64 (BitConverter.GetBytes ((double)y), 0);
    }

    /// <summary>Returns the hash code for this instance.</summary>
    /// <param name='obj'>The parameter <paramref name='obj'/> is not
    /// documented yet.</param>
    /// <returns>A 32-bit hash code.</returns>
    public int GetHashCode (double obj) {
      var code = BitConverter.ToInt64 (BitConverter.GetBytes ((double)obj), 0);
      return (int)(code ^ (code >> 32));
    }
  }
}
