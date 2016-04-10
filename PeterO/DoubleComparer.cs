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
  internal sealed class DoubleComparer : IEqualityComparer<double> {
    public bool Equals(double x, double y) {
      return BitConverter.ToInt64(BitConverter.GetBytes((double)x), 0) ==
        BitConverter.ToInt64(BitConverter.GetBytes((double)y), 0);
    }

    /// <include file='../docs.xml'
    /// path='docs/doc[@name="M:PeterO.DoubleComparer.GetHashCode(System.Double)"]/*'/>
    public int GetHashCode(double obj) {
      var code = BitConverter.ToInt64(BitConverter.GetBytes((double)obj), 0);
      return (int)(code ^ (code >> 32));
    }
  }
}
