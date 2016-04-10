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
  internal sealed class SingleComparer : IEqualityComparer<float> {
    public bool Equals(float x, float y) {
      return BitConverter.ToInt32(BitConverter.GetBytes((float)x), 0) ==
        BitConverter.ToInt32(BitConverter.GetBytes((float)y), 0);
    }

    /// <include file='../docs.xml'
    /// path='docs/doc[@name="M:PeterO.SingleComparer.GetHashCode(System.Single)"]/*'/>
    public int GetHashCode(float obj) {
      return BitConverter.ToInt32(BitConverter.GetBytes((float)obj), 0);
    }
  }
}
