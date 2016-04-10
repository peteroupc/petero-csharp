/*
Written in 2009 by Peter O.
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
    /// path='docs/doc[@name="T:PeterO.IniFile"]/*'/>
  public sealed class IniFile : IEnumerable<IniSection> {
    private readonly List<IniSection> sections;

    private bool StartsWith(string value, char prefix) {
      return value.Length > 0 && value[0] == prefix;
    }

System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() {
      return this.sections.GetEnumerator();
    }

    IEnumerator<IniSection> IEnumerable<IniSection>.GetEnumerator() {
      return this.sections.GetEnumerator();
    }

    /// <include file='../docs.xml'
    /// path='docs/doc[@name="P:PeterO.IniFile.Count"]/*'/>
    public int Count {
      get {
        return this.sections.Count;
      }
    }

    /// <include file='../docs.xml'
    /// path='docs/doc[@name="M:PeterO.IniFile.#ctor"]/*'/>
    public IniFile() {
      this.sections = new List<IniSection>();
    }

    /// <include file='../docs.xml'
    /// path='docs/doc[@name="M:PeterO.IniFile.ToString"]/*'/>
    public override string ToString() {
      var builder = new StringBuilder();
      foreach (IniSection section in this.sections) {
        builder.Append(section.ToString());
      }
      return builder.ToString();
    }

    /// <include file='../docs.xml'
    /// path='docs/doc[@name="M:PeterO.IniFile.WriteToStream(System.IO.StreamWriter)"]/*'/>
    public void WriteToStream(StreamWriter writer) {
      if (writer == null) {
        throw new ArgumentNullException("writer");
      }
      foreach (IniSection section in this.sections) {
        writer.Write(section);
      }
    }

    /// <include file='../docs.xml'
    /// path='docs/doc[@name="M:PeterO.IniFile.Save(System.String)"]/*'/>
    public void Save(string path) {
      if (path == null) {
        throw new ArgumentNullException("path");
      }
      using (var writer = new StreamWriter(path)) {
        this.WriteToStream(writer);
      }
    }
    // <remarks>Section names can be null (null refers to the
    // anonymous section at the beginning of the file).</remarks>

    /// <include file='../docs.xml'
    /// path='docs/doc[@name="M:PeterO.IniFile.GetValue(System.String,System.String)"]/*'/>
    public string GetValue(string sectionName, string keyName) {
      if (keyName == null) {
        throw new ArgumentNullException("keyName");
      }
      foreach (IniSection section in this.sections) {
        if (Object.Equals(section.Name, sectionName)) {
          return section.GetValue(keyName);
        }
      }
      // Value not found
      return null;
    }

    /// <include file='../docs.xml'
    /// path='docs/doc[@name="M:PeterO.IniFile.SetValue(System.String,System.String,System.String)"]/*'/>
    public void SetValue(string sectionName, string keyName, string value) {
      if (keyName == null) {
        throw new ArgumentNullException("keyName");
      }
      if (value == null) {
        throw new ArgumentNullException("value");
      }
      this.AddSection(sectionName).SetValue(keyName, value);
    }

    /// <include file='../docs.xml'
    /// path='docs/doc[@name="M:PeterO.IniFile.AddSection(System.String)"]/*'/>
    public IniSection AddSection(string sectionName) {
      return this.AddSection(sectionName, IniMergeBehavior.Merge);
    }

    /// <include file='../docs.xml'
    /// path='docs/doc[@name="M:PeterO.IniFile.AddSection(System.String,PeterO.IniMergeBehavior)"]/*'/>
  public IniSection AddSection(string sectionName, IniMergeBehavior behavior) {
      if (behavior == IniMergeBehavior.Merge) {
        foreach (IniSection section in this.sections) {
          if (Object.Equals(section.Name, sectionName)) {
            return section;
          }
        }
      }
      var newSection = new IniSection(sectionName);
      if (newSection == null) {
        this.sections.Insert(0, newSection);
      } else {
        this.sections.Add(newSection);
      }
      return newSection;
    }

    /// <include file='../docs.xml'
    /// path='docs/doc[@name="M:PeterO.IniFile.RemoveSection(System.String)"]/*'/>
    public void RemoveSection(string sectionName) {
      for (int i = 0; i < this.sections.Count; ++i) {
        if (Object.Equals(this.sections[i].Name, sectionName)) {
          this.sections.RemoveAt(i);
          break;
        }
      }
    }

    /// <include file='../docs.xml'
    /// path='docs/doc[@name="M:PeterO.IniFile.GetSection(System.String)"]/*'/>
    public IniSection GetSection(string sectionName) {
      foreach (IniSection section in this.sections) {
        if (Object.Equals(section.Name, sectionName)) {
          return section;
        }
      }
      return null;
    }

    /// <include file='../docs.xml'
    /// path='docs/doc[@name="M:PeterO.IniFile.#ctor(System.String)"]/*'/>
    public IniFile(string path) : this(path, IniMergeBehavior.Merge) {
}

    /// <include file='../docs.xml'
    /// path='docs/doc[@name="M:PeterO.IniFile.#ctor(System.String,PeterO.IniMergeBehavior)"]/*'/>
    public IniFile(string path, IniMergeBehavior behavior) {
      if (path == null) {
        throw new ArgumentNullException("path");
      }
      // NOTE: Will merge sections with the same name into a single section
      this.sections = new List<IniSection>();
      var currentSection = this.AddSection(null, behavior);
      using (var reader = new StreamReader(path)) {
        string line;
        while ((line = reader.ReadLine()) != null) {
          if (this.StartsWith(line, ';') || this.StartsWith(line, '#')) {
            // Found a comment
            currentSection.AddComment(line);
            continue;
          }
          if (this.StartsWith(line, '[')) {
            var endBracket = line.LastIndexOf(']');
            if (endBracket > 0) {
              // Found new section
              var secName = line.Substring(1, endBracket - 1);
              currentSection = this.AddSection(secName, behavior);
            }
          }
          var equalSign = line.IndexOf('=');
          if (equalSign > 0) {
            // Found an entry
            var key = line.Substring(0, equalSign);
            var value = line.Substring(equalSign + 1);
            currentSection.AddEntry(key, value, behavior);
          }
        }
      }
    }
  }

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
        throw new ArgumentNullException("other");
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
        throw new ArgumentNullException("keyName");
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
        throw new ArgumentNullException("keyName");
      }
      this.AddEntry(keyName, value);
    }

    /// <include file='../docs.xml'
    /// path='docs/doc[@name="M:PeterO.IniSection.RemoveEntry(System.String)"]/*'/>
    public void RemoveEntry(string key) {
      if (key == null) {
        throw new ArgumentNullException("key");
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
        throw new ArgumentNullException("key");
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
        throw new ArgumentNullException("entry");
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
