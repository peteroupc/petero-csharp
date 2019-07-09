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
  internal sealed class SingleComparer : IEqualityComparer<float> {
    public bool Equals (float x, float y) {
      return BitConverter.ToInt32 (BitConverter.GetBytes ((float)x), 0) ==
        BitConverter.ToInt32 (BitConverter.GetBytes ((float)y), 0);
    }

    /// <summary>Returns the hash code for this instance.</summary>
    /// <param name='obj'>The parameter <paramref name='obj'/> is not
    /// documented yet.</param>
    /// <returns>A 32-bit hash code.</returns>
    public int GetHashCode (float obj) {
      return BitConverter.ToInt32 (BitConverter.GetBytes ((float)obj), 0);
    }
  }
}
