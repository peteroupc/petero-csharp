/*
Written by Peter O.
Any copyright to this work is released to the Public Domain.
In case this is not possible, this work is also
licensed under Creative Commons Zero (CC0):
https://creativecommons.org/publicdomain/zero/1.0/

 */
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace PeterO {
  /// <summary>Not documented yet.</summary>
  public sealed class IniEntry {
    private readonly string value;
    private readonly string key;

    /// <summary>Initializes a new instance of the.</summary>
    /// <param name='entry'>The parameter <paramref name='entry'/> is an
    /// IniEntry object.</param>
    /// <exception cref='ArgumentNullException'>The parameter <paramref
    /// name='entry'/> is null.</exception>
    public IniEntry (IniEntry entry) {
      if (entry == null) {
        throw new ArgumentNullException(nameof(entry));
      }
      this.key = entry.key;
      this.value = entry.value;
    }

    /// <summary>Initializes a new instance of the.</summary>
    /// <param name='key'>The parameter <paramref name='key'/> is a text
    /// string.</param>
    /// <param name='value'>The parameter <paramref name='value'/> is a
    /// text string.</param>
    /// <exception cref='ArgumentNullException'>The parameter <paramref
    /// name='key'/> or <paramref name='value'/> is null.</exception>
    /// <exception cref='ArgumentException'>Characters in key are not
    /// valid.; Characters in value are not valid.</exception>
    public IniEntry (string key, string value) {
      if (key == null) {
        throw new ArgumentNullException(nameof(key));
      }
      if (value == null) {
        throw new ArgumentNullException(nameof(value));
      }
      if (key.IndexOfAny (new[] {
        '\n',
        '\0',
        '='
      }) >= 0) {
        throw new ArgumentException("Characters in key are not valid.");
      }
      if (value.IndexOfAny (new[] {
        '\n',
        '\0'
      }) >= 0) {
        throw new ArgumentException("Characters in value are not valid.");
      }
      this.key = key;
      this.value = value;
    }

    /// <summary>Initializes a new instance of the.</summary>
    /// <param name='comment'>The parameter <paramref name='comment'/> is a
    /// text string.</param>
    /// <exception cref='ArgumentNullException'>The parameter <paramref
    /// name='comment'/> is null.</exception>
    /// <exception cref='ArgumentException'>Value is not a comment.;
    /// Characters in comment are not valid.</exception>
    public IniEntry (string comment) {
      if (comment == null) {
        throw new ArgumentNullException(nameof(comment));
      }
      if (comment.IndexOfAny (new[] {
      ';' // ,'#'
    }) != 0) {
        throw new ArgumentException("Value is not a comment.");
      }
      if (comment.IndexOfAny (new[] {
        '\n',
        '\0'
      }) >= 0) {
        throw new ArgumentException("Characters in comment are not valid.");
      }
      this.key = null;
      this.value = comment;
    }

    /// <summary>Gets a value indicating whether this entry is a comment
    /// line.</summary>
    /// <value><c>true</c> if this entry is a comment line; otherwise,
    /// <c>false</c>.</value>
    public bool IsComment {
      get {
        return this.key == null;
      }
    }

    /// <summary>Converts this object to a text string.</summary>
    /// <returns>A text string.</returns>
    public override string ToString() {
      var sb = new StringBuilder();
      if (this.key == null) {
        sb.Append (this.value);
      } else {
        sb.Append (this.key);
        sb.Append ('=');
        sb.Append (this.value);
      }
      return sb.ToString();
    }

    /// <summary>Gets a value not documented yet.</summary>
    /// <value>A value not documented yet.</value>
    public string Key {
      get {
        return this.key;
      }
    }

    /// <summary>Gets a value not documented yet.</summary>
    /// <value>A value not documented yet.</value>
    public string Value {
      get {
        return this.value;
      }
    }
  }
}
