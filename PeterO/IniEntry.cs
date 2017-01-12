/*
Written by Peter O. in 2009.
Any copyright is dedicated to the Public Domain.
http://creativecommons.org/publicdomain/zero/1.0/
If you like this, you should donate to Peter O.
at: http://peteroupc.github.io/
 */
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace PeterO {
    /// <include file='../docs.xml'
    /// path='docs/doc[@name="T:PeterO.IniEntry"]/*'/>
  public sealed class IniEntry {
    private readonly string value;
    private readonly string key;

    /// <include file='../docs.xml'
    /// path='docs/doc[@name="M:PeterO.IniEntry.#ctor(PeterO.IniEntry)"]/*'/>
    public IniEntry(IniEntry entry) {
      if (entry == null) {
        throw new ArgumentNullException("entry");
      }
      this.key = entry.key;
      this.value = entry.value;
    }

    /// <include file='../docs.xml'
    /// path='docs/doc[@name="M:PeterO.IniEntry.#ctor(System.String,System.String)"]/*'/>
    public IniEntry(string key, string value) {
      if (key == null) {
        throw new ArgumentNullException("key");
      }
      if (value == null) {
        throw new ArgumentNullException("value");
      }
      if (key.IndexOfAny(new[] {
        '\n',
        '\0',
        '=' }) >= 0) {
        throw new ArgumentException("Characters in key are not valid.");
      }
      if (value.IndexOfAny(new[] {
        '\n',
        '\0'
      }) >= 0) {
        throw new ArgumentException("Characters in value are not valid.");
      }
      this.key = key;
      this.value = value;
    }

    /// <include file='../docs.xml'
    /// path='docs/doc[@name="M:PeterO.IniEntry.#ctor(System.String)"]/*'/>
    public IniEntry(string comment) {
      if (comment == null) {
        throw new ArgumentNullException("comment");
      }
      if (comment.IndexOfAny(new[] {
        ';'  // ,'#'
      }) != 0) {
        throw new ArgumentException("Value is not a comment.");
      }
      if (comment.IndexOfAny(new[] {
        '\n',
        '\0'
      }) >= 0) {
        throw new ArgumentException("Characters in comment are not valid.");
      }
      this.key = null;
      this.value = comment;
    }

    /// <include file='../docs.xml'
    /// path='docs/doc[@name="P:PeterO.IniEntry.IsComment"]/*'/>
    public bool IsComment {
      get {
        return this.key == null;
      }
    }

    /// <include file='../docs.xml'
    /// path='docs/doc[@name="M:PeterO.IniEntry.ToString"]/*'/>
    public override string ToString() {
      var sb = new StringBuilder();
      if (this.key == null) {
        sb.Append(this.value);
      } else {
        sb.Append(this.key);
        sb.Append('=');
        sb.Append(this.value);
      }
      return sb.ToString();
    }

    /// <include file='../docs.xml'
    /// path='docs/doc[@name="P:PeterO.IniEntry.Key"]/*'/>
    public string Key {
      get {
        return this.key;
      }
    }

    /// <include file='../docs.xml'
    /// path='docs/doc[@name="P:PeterO.IniEntry.Value"]/*'/>
    public string Value {
      get {
        return this.value;
      }
    }
  }
}
