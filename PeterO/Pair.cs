/*
Written by Peter O.
Any copyright to this work is released to the Public Domain.
In case this is not possible, this work is also
licensed under the Unlicense: https://unlicense.org/

 */
using System;

namespace PeterO {
  /// <summary>Stores a pair of related objects.</summary>
  /// <typeparam name='TFirst'>Object type for the first object in the
  /// pair.</typeparam>
  /// <typeparam name='TSecond'>Object type for the second object in the
  /// pair.</typeparam>
  public sealed class Pair<TFirst, TSecond> :
    IEquatable<Pair<TFirst, TSecond>> {
    private readonly TFirst first;
    private readonly TSecond second;

    /// <param name='first'>The parameter <paramref name='first'/> is a
    /// TFirst object.</param>
    /// <param name='second'>The parameter <paramref name='second'/> is a
    /// TSecond object.</param>
    public Pair(TFirst first, TSecond second) {
      this.first = first;
      this.second = second;
    }

    /// <summary>Converts this object to a text string.</summary>
    /// <returns>A text string.</returns>
    public override string ToString() {
      return "[Pair First=" + this.first + " Second=" +
        this.second + "]";
    }

    /// <summary>Gets the first object in the pair.</summary>
    /// <value>The first object in the pair.</value>
    public TFirst First {
      get {
        return this.first;
      }
    }

    /// <summary>Gets the second object in the pair.</summary>
    /// <value>The second object in the pair.</value>
    /// <returns>A TSecond object.</returns>
    public TSecond Second {
      get {
        return this.second;
      }
    }

    /// <summary>Returns the hash code for this instance.</summary>
    /// <returns>A 32-bit signed integer.</returns>
    public override int GetHashCode() {
      var code = 17;
      unchecked {
        if ((object)this.first != (object)default(TFirst)) {
          code *= 19 + this.first.GetHashCode();
        }
        if ((object)this.second != (object)default(TSecond)) {
          code *= 23 + this.second.GetHashCode();
        }
      }
      return code;
    }

    /// <summary>Not documented yet.</summary>
    /// <param name='other'>The parameter <paramref name='other'/> is
    /// a.Pair{`0 object.</param>
    /// <returns>Either <c>true</c> or <c>false</c>.</returns>
    public bool Equals(Pair<TFirst, TSecond> other) {
      return Object.Equals(this.first, other.first) &&
        Object.Equals(this.second, other.second);
    }

    /// <summary>Determines whether this object and another object are
    /// equal.</summary>
    /// <param name='obj'>The parameter <paramref name='obj'/> is an
    /// arbitrary object.</param>
    /// <returns><c>true</c> if this object and another object are equal;
    /// otherwise, <c>false</c>.</returns>
    public override bool Equals(object obj) {
      var other = obj as Pair<TFirst, TSecond>;
      return (other != null) && (Object.Equals(this.first, other.first) &&
          Object.Equals(this.second, other.second));
    }
  }
}
