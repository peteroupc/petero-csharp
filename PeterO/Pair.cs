/*
Written by Peter O.
Any copyright is dedicated to the Public Domain.
http://creativecommons.org/publicdomain/zero/1.0/
If you like this, you should donate to Peter O.
at: http://upokecenter.dreamhosters.com/articles/donate-now-2/
 */
using System;

namespace PeterO {
    /// <include file='../docs.xml'
    /// path='docs/doc[@name="T:PeterO.Pair`2"]/*'/>
public sealed class Pair<TFirst, TSecond> : IEquatable<Pair<TFirst, TSecond>> {
    private readonly TFirst first;
    private readonly TSecond second;

    /// <include file='../docs.xml'
    /// path='docs/doc[@name="M:PeterO.Pair`2.#ctor(`0,`1)"]/*'/>
    public Pair(TFirst first, TSecond second) {
      this.first = first;
      this.second = second;
    }

    /// <include file='../docs.xml'
    /// path='docs/doc[@name="M:PeterO.Pair`2.ToString"]/*'/>
    public override string ToString() {
      return "[Pair First=" + this.first + " Second=" +
                    this.second + "]";
    }

    /// <include file='../docs.xml'
    /// path='docs/doc[@name="P:PeterO.Pair`2.First"]/*'/>
    public TFirst First {
      get {
        return this.first;
      }
    }

    /// <include file='../docs.xml'
    /// path='docs/doc[@name="P:PeterO.Pair`2.Second"]/*'/>
    public TSecond Second {
      get {
        return this.second;
      }
    }

    /// <include file='../docs.xml'
    /// path='docs/doc[@name="M:PeterO.Pair`2.GetHashCode"]/*'/>
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

    /// <include file='../docs.xml'
    /// path='docs/doc[@name="M:PeterO.Pair`2.Equals(PeterO.Pair
    /// {`0,`1})"]'/>
    public bool Equals(Pair<TFirst, TSecond> other) {
      return Object.Equals(this.first, other.first) &&
        Object.Equals(this.second, other.second);
    }

    /// <include file='../docs.xml'
    /// path='docs/doc[@name="M:PeterO.Pair`2.Equals(System.Object)"]/*'/>
    public override bool Equals(object obj) {
      var other = obj as Pair<TFirst, TSecond>;
      return (other != null) && (Object.Equals(this.first, other.first) &&
        Object.Equals(this.second, other.second));
    }
  }
}
