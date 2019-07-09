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
using System.IO;
using System.Text;

namespace PeterO {
  /// <summary>Not documented yet.</summary>
  public sealed class IniFile : IEnumerable<IniSection> {
    private readonly List<IniSection> sections;

    private bool StartsWith (string value, char prefix) {
      return value.Length > 0 && value[0] == prefix;
    }

    System.Collections.IEnumerator
    System.Collections.IEnumerable.GetEnumerator() {
      return this.sections.GetEnumerator();
    }

    IEnumerator<IniSection> IEnumerable<IniSection>.GetEnumerator() {
      return this.sections.GetEnumerator();
    }

    /// <summary>Gets a value not documented yet.</summary>
    /// <value>A value not documented yet.</value>
    public int Count {
      get {
        return this.sections.Count;
      }
    }

    /// <summary>Initializes a new instance of the
    /// <see cref='PeterO.IniFile'/> class.</summary>
    public IniFile() {
      this.sections = new List<IniSection>();
    }

    /// <summary>Converts this object to a text string.</summary>
    /// <returns>A text string.</returns>
    public override string ToString() {
      var builder = new StringBuilder();
      foreach (IniSection section in this.sections) {
        builder.Append (section.ToString());
      }
      return builder.ToString();
    }

    /// <summary>Not documented yet.</summary>
    /// <param name='writer'>The parameter <paramref name='writer'/> is a
    /// StreamWriter object.</param>
    /// <exception cref='ArgumentNullException'>The parameter <paramref
    /// name='writer'/> is null.</exception>
    public void WriteToStream (StreamWriter writer) {
      if (writer == null) {
        throw new ArgumentNullException(nameof(writer));
      }
      foreach (IniSection section in this.sections) {
        writer.Write (section);
      }
    }

    /// <summary>Not documented yet.</summary>
    /// <param name='path'>The parameter <paramref name='path'/> is a text
    /// string.</param>
    /// <exception cref='ArgumentNullException'>The parameter <paramref
    /// name='path'/> is null.</exception>
    public void Save (string path) {
      if (path == null) {
        throw new ArgumentNullException(nameof(path));
      }
      using (var writer = new StreamWriter(path)) {
        this.WriteToStream (writer);
      }
    }
    // <remarks>Section names can be null (null refers to the
    // anonymous section at the beginning of the file).</remarks>

    /// <summary>Not documented yet.</summary>
    /// <param name='sectionName'>The parameter <paramref
    /// name='sectionName'/> is a text string.</param>
    /// <param name='keyName'>The parameter <paramref name='keyName'/> is a
    /// text string.</param>
    /// <returns>A text string.</returns>
    /// <exception cref='ArgumentNullException'>The parameter <paramref
    /// name='keyName'/> is null.</exception>
    public string GetValue (string sectionName, string keyName) {
      if (keyName == null) {
        throw new ArgumentNullException(nameof(keyName));
      }
      foreach (IniSection section in this.sections) {
        if (Object.Equals (section.Name, sectionName)) {
          return section.GetValue (keyName);
        }
      }
      // Value not found
      return null;
    }

    /// <summary>Not documented yet.</summary>
    /// <param name='sectionName'>The parameter <paramref
    /// name='sectionName'/> is a text string.</param>
    /// <param name='keyName'>The parameter <paramref name='keyName'/> is a
    /// text string.</param>
    /// <param name='value'>The parameter <paramref name='value'/> is a
    /// text string.</param>
    /// <exception cref='ArgumentNullException'>The parameter <paramref
    /// name='keyName'/> or <paramref name='value'/> is null.</exception>
    public void SetValue (string sectionName, string keyName, string value) {
      if (keyName == null) {
        throw new ArgumentNullException(nameof(keyName));
      }
      if (value == null) {
        throw new ArgumentNullException(nameof(value));
      }
      this.AddSection (sectionName).SetValue (keyName, value);
    }

    /// <summary>Not documented yet.</summary>
    /// <param name='sectionName'>The parameter <paramref
    /// name='sectionName'/> is a text string.</param>
    /// <returns>An IniSection object.</returns>
    public IniSection AddSection (string sectionName) {
      return this.AddSection (sectionName, IniMergeBehavior.Merge);
    }

    /// <summary>Not documented yet.</summary>
    /// <param name='sectionName'>The parameter <paramref
    /// name='sectionName'/> is a text string.</param>
    /// <param name='behavior'>The parameter <paramref name='behavior'/> is
    /// an IniMergeBehavior object.</param>
    /// <returns>An IniSection object.</returns>
    public IniSection AddSection (string sectionName,
      IniMergeBehavior behavior) {
      if (behavior == IniMergeBehavior.Merge) {
        foreach (IniSection section in this.sections) {
          if (Object.Equals (section.Name, sectionName)) {
            return section;
          }
        }
      }
      var newSection = new IniSection(sectionName);
      if (newSection == null) {
        this.sections.Insert (0, newSection);
      } else {
        this.sections.Add (newSection);
      }
      return newSection;
    }

    /// <summary>Not documented yet.</summary>
    /// <param name='sectionName'>The parameter <paramref
    /// name='sectionName'/> is a text string.</param>
    public void RemoveSection (string sectionName) {
      for (int i = 0; i < this.sections.Count; ++i) {
        if (Object.Equals (this.sections[i].Name, sectionName)) {
          this.sections.RemoveAt (i);
          break;
        }
      }
    }

    /// <summary>Not documented yet.</summary>
    /// <param name='sectionName'>The parameter <paramref
    /// name='sectionName'/> is a text string.</param>
    /// <returns>An IniSection object.</returns>
    public IniSection GetSection (string sectionName) {
      foreach (IniSection section in this.sections) {
        if (Object.Equals (section.Name, sectionName)) {
          return section;
        }
      }
      return null;
    }

    /// <summary>Initializes a new instance of the
    /// <see cref='PeterO.IniFile'/> class.</summary>
    /// <param name='path'>The parameter <paramref name='path'/> is a text
    /// string.</param>
    public IniFile (string path) : this (path, IniMergeBehavior.Merge) {
    }

    /// <summary>Initializes a new instance of the
    /// <see cref='PeterO.IniFile'/> class.</summary>
    /// <param name='path'>The parameter <paramref name='path'/> is a text
    /// string.</param>
    /// <param name='behavior'>The parameter <paramref name='behavior'/> is
    /// an IniMergeBehavior object.</param>
    /// <exception cref='ArgumentNullException'>The parameter <paramref
    /// name='path'/> is null.</exception>
    public IniFile (string path, IniMergeBehavior behavior) {
      if (path == null) {
        throw new ArgumentNullException(nameof(path));
      }
      // NOTE: Will merge sections with the same name into a single section
      this.sections = new List<IniSection>();
      var currentSection = this.AddSection (null, behavior);
      using (var reader = new StreamReader(path)) {
        string line;
        while ((line = reader.ReadLine()) != null) {
          if (this.StartsWith (line, ';') || this.StartsWith (line, '#')) {
            // Found a comment
            currentSection.AddComment (line);
            continue;
          }
          if (this.StartsWith (line, '[')) {
            var endBracket = line.LastIndexOf (']');
            if (endBracket > 0) {
              // Found new section
              var secName = line.Substring (1, endBracket - 1);
              currentSection = this.AddSection (secName, behavior);
            }
          }
          var equalSign = line.IndexOf ('=');
          if (equalSign > 0) {
            // Found an entry
            var key = line.Substring (0, equalSign);
            var value = line.Substring (equalSign + 1);
            currentSection.AddEntry (key, value, behavior);
          }
        }
      }
    }
  }
}
