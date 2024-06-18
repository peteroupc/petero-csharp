/*
Written by Peter O.
Any copyright to this work is released to the Public Domain.
In case this is not possible, this work is also
licensed under the Unlicense: https://unlicense.org/

 */
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace PeterO {
  /// <summary>Not documented yet.</summary>
  public sealed class IniSection : IEnumerable<IniEntry> {
    private readonly List<IniEntry> entries;
    private readonly string name;

    /// <summary>Initializes a new instance of the
    /// <see cref='PeterO.IniSection'/> class.</summary>
    /// <param name='name'>The parameter <paramref name='name'/> is a text
    /// string.</param>
    public IniSection (string name) {
      // Can be null
      this.name = name;
      this.entries = new List<IniEntry>();
    }

    /// <summary>Initializes a new instance of the
    /// <see cref='PeterO.IniSection'/> class.</summary>
    /// <param name='other'>The parameter <paramref name='other'/> is an
    /// IniSection object.</param>
    /// <exception cref='ArgumentNullException'>The parameter <paramref
    /// name='other'/> is null.</exception>
    public IniSection (IniSection other) {
      if (other == null) {
        throw new ArgumentNullException(nameof(other));
      }
      this.name = other.name;
      this.entries = new List<IniEntry>(other.entries);
    }

    /// <summary>Not documented yet.</summary>
    public void Clear() {
      this.entries.Clear();
    }

    /// <summary>Gets a value not documented yet.</summary>
    /// <value>A value not documented yet.</value>
    public string Name {
      get {
        return this.name;
      }
    }

    /// <summary>Gets a value not documented yet.</summary>
    /// <value>A value not documented yet.</value>
    public int Count {
      get {
        return this.entries.Count;
      }
    }

    /// <summary>Not documented yet.</summary>
    /// <param name='keyName'>The parameter <paramref name='keyName'/> is a
    /// text string.</param>
    /// <returns>A text string.</returns>
    /// <exception cref='ArgumentNullException'>The parameter <paramref
    /// name='keyName'/> is null.</exception>
    public string GetValue (string keyName) {
      if (keyName == null) {
        throw new ArgumentNullException(nameof(keyName));
      }
      foreach (IniEntry entry in this.entries) {
        if (Object.Equals (entry.Key, keyName)) {
          return entry.Value;
        }
      }
      return null;
    }

    /// <summary>Not documented yet.</summary>
    /// <param name='index'>The parameter <paramref name='index'/> is a
    /// 32-bit signed integer.</param>
    /// <returns>An IniEntry object.</returns>
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

    /// <summary>Not documented yet.</summary>
    /// <param name='keyName'>The parameter <paramref name='keyName'/> is a
    /// text string.</param>
    /// <param name='value'>The parameter <paramref name='value'/> is a
    /// text string.</param>
    /// <exception cref='ArgumentNullException'>The parameter <paramref
    /// name='keyName'/> is null.</exception>
    public void SetValue (string keyName, string value) {
      if (keyName == null) {
        throw new ArgumentNullException(nameof(keyName));
      }
      this.AddEntry (keyName, value);
    }

    /// <summary>Not documented yet.</summary>
    /// <param name='key'>The parameter <paramref name='key'/> is a text
    /// string.</param>
    /// <exception cref='ArgumentNullException'>The parameter <paramref
    /// name='key'/> is null.</exception>
    public void RemoveEntry (string key) {
      if (key == null) {
        throw new ArgumentNullException(nameof(key));
      }
      for (int i = 0; i < this.entries.Count; ++i) {
        if (Object.Equals (this.entries[i].Key, key)) {
          this.entries.RemoveAt (i);
          break;
        }
      }
    }

    System.Collections.IEnumerator
    System.Collections.IEnumerable.GetEnumerator() {
      return this.entries.GetEnumerator();
    }

    IEnumerator<IniEntry> IEnumerable<IniEntry>.GetEnumerator() {
      return this.entries.GetEnumerator();
    }

    /// <summary>Not documented yet.</summary>
    /// <param name='key'>The parameter <paramref name='key'/> is a text
    /// string.</param>
    /// <param name='value'>The parameter <paramref name='value'/> is a
    /// text string.</param>
    public void AddEntry (string key, string value) {
      this.AddEntry (key, value, IniMergeBehavior.Merge);
    }

    /// <summary>Not documented yet.</summary>
    /// <param name='key'>The parameter <paramref name='key'/> is a text
    /// string.</param>
    /// <param name='value'>The parameter <paramref name='value'/> is a
    /// text string.</param>
    /// <param name='behavior'>The parameter <paramref name='behavior'/> is
    /// a IniMergeBehavior object.</param>
    /// <exception cref='ArgumentNullException'>The parameter "keyName" is
    /// null.</exception>
    public void AddEntry (string key, string value, IniMergeBehavior behavior) {
      if (key == null) {
        throw new ArgumentNullException(nameof(key));
      }
      this.Add (new IniEntry(key, value), behavior);
    }

    /// <summary>Not documented yet.</summary>
    /// <param name='comment'>The parameter <paramref name='comment'/> is a
    /// text string.</param>
    public void AddComment (string comment) {
      this.Add (new IniEntry(comment));
    }

    /// <summary>Not documented yet.</summary>
    /// <param name='entry'>The parameter <paramref name='entry'/> is a
    /// IniEntry object.</param>
    public void Add (IniEntry entry) {
      this.Add (entry, IniMergeBehavior.Merge);
    }

    /// <summary>Adds two IniEntry objects.</summary>
    /// <param name='entry'>The parameter <paramref name='entry'/> is an
    /// IniEntry object.</param>
    /// <param name='behavior'>The parameter <paramref name='behavior'/> is
    /// an IniMergeBehavior object.</param>
    /// <exception cref='ArgumentNullException'>The parameter <paramref
    /// name='entry'/> is null.</exception>
    public void Add (IniEntry entry, IniMergeBehavior behavior) {
      if (entry == null) {
        throw new ArgumentNullException(nameof(entry));
      }
      if (!entry.IsComment) {
        var lastNonComment = -1;
        for (int i = 0; i < this.entries.Count; ++i) {
          if (behavior == IniMergeBehavior.Merge) {
            if (Object.Equals (this.entries[i].Key, entry.Key)) {
              this.entries[i] = entry;
              return;
            }
          }
          if (!this.entries[i].IsComment) {
            lastNonComment = i;
          }
        }
        // Insert after the last non-comment
        this.entries.Insert (lastNonComment + 1, entry);
      } else {
        this.entries.Add (entry);
      }
    }

    /// <summary>Converts this object to a text string.</summary>
    /// <returns>A text string.</returns>
    public override string ToString() {
      var builder = new StringBuilder();
      if (this.name != null) {
        builder.Append ("[").Append (this.name).Append ("]")
        .Append (Environment.NewLine);
      }
      foreach (IniEntry entry in this.entries) {
        builder.Append (entry);
        builder.Append (Environment.NewLine);
      }
      return builder.ToString();
    }
  }
}
