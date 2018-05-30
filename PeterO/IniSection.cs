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
    /// path='docs/doc[@name="T:PeterO.IniSection"]/*'/>
  public sealed class IniSection : IEnumerable<IniEntry> {
    private readonly List<IniEntry> entries;
    private readonly string name;

    /// <include file='../docs.xml'
    /// path='docs/doc[@name="M:PeterO.IniSection.#ctor(System.String)"]/*'/>
    public IniSection(string name) {
      // Can be null
      this.name = name;
      this.entries = new List<IniEntry>();
    }

    /// <include file='../docs.xml'
    /// path='docs/doc[@name="M:PeterO.IniSection.#ctor(PeterO.IniSection)"]/*'/>
    public IniSection(IniSection other) {
      if (other == null) {
        throw new ArgumentNullException(nameof(other));
      }
      this.name = other.name;
      this.entries = new List<IniEntry>(other.entries);
    }

    /// <include file='../docs.xml'
    /// path='docs/doc[@name="M:PeterO.IniSection.Clear"]/*'/>
    public void Clear() {
      this.entries.Clear();
    }

    /// <include file='../docs.xml'
    /// path='docs/doc[@name="P:PeterO.IniSection.Name"]/*'/>
    public string Name {
      get {
        return this.name;
      }
    }

    /// <include file='../docs.xml'
    /// path='docs/doc[@name="P:PeterO.IniSection.Count"]/*'/>
    public int Count {
      get {
        return this.entries.Count;
      }
    }

    /// <include file='../docs.xml'
    /// path='docs/doc[@name="M:PeterO.IniSection.GetValue(System.String)"]/*'/>
    public string GetValue(string keyName) {
      if (keyName == null) {
        throw new ArgumentNullException(nameof(keyName));
      }
      foreach (IniEntry entry in this.entries) {
        if (Object.Equals(entry.Key, keyName)) {
          return entry.Value;
        }
      }
      return null;
    }

    /// <include file='../docs.xml'
    /// path='docs/doc[@name="P:PeterO.IniSection.Item(System.Int32)"]/*'/>
    public IniEntry this[int index] {
      get {
        if (index < 0) {
          throw new ArgumentException("index (" + index +
                    ") is less than 0");
        }
        if (index > this.entries.Count - 1) {
          throw new ArgumentException("index (" + index + ") is more than " +
                    (this.entries.Count - 1));
        }
        return this.entries[index];
      }

      set {
        if (index < 0) {
          throw new ArgumentException("index (" + index +
                    ") is less than 0");
        }
        if (index > this.entries.Count - 1) {
          throw new ArgumentException("index (" + index + ") is more than " +
                    (this.entries.Count - 1));
        }
        this.entries[index] = value;
      }
    }

    /// <include file='../docs.xml'
    /// path='docs/doc[@name="M:PeterO.IniSection.SetValue(System.String,System.String)"]/*'/>
    public void SetValue(string keyName, string value) {
      if (keyName == null) {
        throw new ArgumentNullException(nameof(keyName));
      }
      this.AddEntry(keyName, value);
    }

    /// <include file='../docs.xml'
    /// path='docs/doc[@name="M:PeterO.IniSection.RemoveEntry(System.String)"]/*'/>
    public void RemoveEntry(string key) {
      if (key == null) {
        throw new ArgumentNullException(nameof(key));
      }
      for (int i = 0; i < this.entries.Count; ++i) {
        if (Object.Equals(this.entries[i].Key, key)) {
          this.entries.RemoveAt(i);
          break;
        }
      }
    }

System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() {
      return this.entries.GetEnumerator();
    }

    IEnumerator<IniEntry> IEnumerable<IniEntry>.GetEnumerator() {
      return this.entries.GetEnumerator();
    }

    /// <include file='../docs.xml'
    /// path='docs/doc[@name="M:PeterO.IniSection.AddEntry(System.String,System.String)"]/*'/>
    public void AddEntry(string key, string value) {
      this.AddEntry(key, value, IniMergeBehavior.Merge);
    }

    /// <include file='../docs.xml'
    /// path='docs/doc[@name="M:PeterO.IniSection.AddEntry(System.String,System.String,PeterO.IniMergeBehavior)"]/*'/>
    public void AddEntry(string key, string value, IniMergeBehavior behavior) {
      if (key == null) {
        throw new ArgumentNullException(nameof(key));
      }
      this.Add(new IniEntry(key, value), behavior);
    }

    /// <include file='../docs.xml'
    /// path='docs/doc[@name="M:PeterO.IniSection.AddComment(System.String)"]/*'/>
    public void AddComment(string comment) {
      this.Add(new IniEntry(comment));
    }

    /// <include file='../docs.xml'
    /// path='docs/doc[@name="M:PeterO.IniSection.Add(PeterO.IniEntry)"]/*'/>
    public void Add(IniEntry entry) {
      this.Add(entry, IniMergeBehavior.Merge);
    }

    /// <include file='../docs.xml'
    /// path='docs/doc[@name="M:PeterO.IniSection.Add(PeterO.IniEntry,PeterO.IniMergeBehavior)"]/*'/>
    public void Add(IniEntry entry, IniMergeBehavior behavior) {
      if (entry == null) {
        throw new ArgumentNullException(nameof(entry));
      }
      if (!entry.IsComment) {
        var lastNonComment = -1;
        for (int i = 0; i < this.entries.Count; ++i) {
          if (behavior == IniMergeBehavior.Merge) {
            if (Object.Equals(this.entries[i].Key, entry.Key)) {
              this.entries[i] = entry;
              return;
            }
          }
          if (!this.entries[i].IsComment) {
            lastNonComment = i;
          }
        }
        // Insert after the last non-comment
        this.entries.Insert(lastNonComment + 1, entry);
      } else {
        this.entries.Add(entry);
      }
    }

    /// <include file='../docs.xml'
    /// path='docs/doc[@name="M:PeterO.IniSection.ToString"]/*'/>
    public override string ToString() {
      var builder = new StringBuilder();
      if (this.name != null) {
        builder.Append("[").Append(this.name).Append("]")
          .Append(Environment.NewLine);
      }
      foreach (IniEntry entry in this.entries) {
        builder.Append(entry);
        builder.Append(Environment.NewLine);
      }
      return builder.ToString();
    }
  }
}
