/*
 *
 * This file is in the public domain.
 *
 */
using System;
using System.Linq;
using System.Xml;
using PeterO;

namespace PeterO {
  /// <summary>Not documented yet.</summary>
  public sealed class XEWriter : IDisposable {
    private readonly XmlWriter writer;
    private readonly bool leaveOpen;
    private bool disposed;

    private XEWriter() {
    }

    private XEWriter(XmlWriter writer, bool leaveOpen) {
      this.writer = writer;
      this.leaveOpen = leaveOpen;
    }

    /// <summary>Not documented yet.</summary>
    public void Dispose() {
      if (this.disposed) {
        return;
      }
      this.writer.WriteEndElement();
      if (!this.leaveOpen) {
        ((IDisposable)this.writer).Dispose();
      }
      this.disposed = true;
    }

    /// <summary>Not documented yet.</summary>
    /// <param name='key'>The parameter <paramref name='key'/> is a text
    /// string.</param>
    /// <param name='value'>The parameter <paramref name='value'/> is a
    /// text string.</param>
    public void AddAttribute(string key, string value) {
      this.writer.WriteAttributeString(key, value);
    }

    /// <summary>Not documented yet.</summary>
    /// <param name='key'>The parameter <paramref name='key'/> is a text
    /// string.</param>
    /// <param name='ns'>The parameter <paramref name='ns'/> is a text
    /// string.</param>
    /// <param name='value'>The parameter <paramref name='value'/> is a
    /// text string.</param>
    public void AddAttribute(string key, string ns, string value) {
      this.writer.WriteAttributeString(key, ns, value);
    }

    /// <summary>Not documented yet.</summary>
    /// <param name='str'>The parameter <paramref name='str'/> is a text
    /// string.</param>
    public void AddContent(string str) {
      this.writer.WriteString(str);
    }

    /// <summary>Not documented yet.</summary>
    /// <param name='localName'>The parameter <paramref name='localName'/>
    /// is a text string.</param>
    /// <returns>A XEWriter object.</returns>
    public XEWriter AddElement(string localName) {
      return Create(this.writer, localName);
    }

    /// <summary>Not documented yet.</summary>
    /// <param name='localName'>The parameter <paramref name='localName'/>
    /// is a text string.</param>
    /// <param name='ns'>The parameter <paramref name='ns'/> is a text
    /// string.</param>
    /// <returns>A XEWriter object.</returns>
    public XEWriter AddElement(string localName, string ns) {
      return Create(this.writer, localName, ns);
    }

    /// <summary>Not documented yet.</summary>
    /// <param name='value'>The parameter <paramref name='value'/> is a
    /// text string.</param>
    public void AddComment(string value) {
      if (String.IsNullOrEmpty(value)) {
        this.writer.WriteComment(String.Empty);
      } else {
        this.writer.WriteComment(value);
      }
    }

    /// <summary>Not documented yet.</summary>
    /// <param name='localName'>The parameter <paramref name='localName'/>
    /// is a text string.</param>
    /// <param name='value'>The parameter <paramref name='value'/> is a
    /// text string.</param>
    public void AddSimpleElement(string localName, string value) {
      this.AddSimpleElement(localName, String.Empty, value);
    }

    /// <summary>Not documented yet.</summary>
    /// <param name='localName'>The parameter <paramref name='localName'/>
    /// is a text string.</param>
    /// <param name='ns'>The parameter <paramref name='ns'/> is a text
    /// string.</param>
    /// <param name='value'>The parameter <paramref name='value'/> is a
    /// text string.</param>
    public void AddSimpleElement(string localName, string ns, string value) {
      if (String.IsNullOrEmpty(ns)) {
        this.writer.WriteStartElement(localName);
      } else {
        this.writer.WriteStartElement(localName, ns);
      }
      this.writer.WriteString(value);
      this.writer.WriteEndElement();
    }

    /// <summary>Not documented yet.</summary>
    /// <param name='file'>The parameter <paramref name='file'/> is a text
    /// string.</param>
    /// <param name='localName'>The parameter <paramref name='localName'/>
    /// is a text string.</param>
    /// <returns>A XEWriter object.</returns>
    public static XEWriter Create(string file, string localName) {
      return Create(file, localName, String.Empty, false);
    }

    /// <summary>Not documented yet.</summary>
    /// <param name='file'>The parameter <paramref name='file'/> is a text
    /// string.</param>
    /// <param name='localName'>The parameter <paramref name='localName'/>
    /// is a text string.</param>
    /// <param name='indent'>The parameter <paramref name='indent'/> is
    /// either <c>true</c> or <c>false</c>.</param>
    /// <returns>A XEWriter object.</returns>
    public static XEWriter Create(string file, string localName, bool indent) {
      return Create(file, localName, String.Empty, indent);
    }

    /// <summary>Not documented yet.</summary>
    /// <param name='file'>The parameter <paramref name='file'/> is a text
    /// string.</param>
    /// <param name='localName'>The parameter <paramref name='localName'/>
    /// is a text string.</param>
    /// <param name='ns'>The parameter <paramref name='ns'/> is a text
    /// string.</param>
    /// <returns>A XEWriter object.</returns>
    public static XEWriter Create(string file, string localName, string ns) {
      return Create(file, localName, ns, false);
    }

    /// <summary>Not documented yet.</summary>
    /// <param name='file'>The parameter <paramref name='file'/> is a text
    /// string.</param>
    /// <param name='localName'>The parameter <paramref name='localName'/>
    /// is a text string.</param>
    /// <param name='ns'>The parameter <paramref name='ns'/> is a text
    /// string.</param>
    /// <param name='indent'>The parameter <paramref name='indent'/> is
    /// either <c>true</c> or <c>false</c>.</param>
    /// <returns>A XEWriter object.</returns>
    /// <exception cref='ArgumentNullException'>The parameter <paramref
    /// name='file'/> or <paramref name='localName'/> is null.</exception>
    public static XEWriter Create(
      string file,
      string localName,
      string ns,
      bool indent) {
      if (file == null) {
        throw new ArgumentNullException(nameof(file));
      }
      if (file.Length == 0) {
        throw new ArgumentException("file" + " is empty.");
      }
      if (localName == null) {
        throw new ArgumentNullException(nameof(localName));
      }
      if (localName.Length == 0) {
        throw new ArgumentException("localName" + " is empty.");
      }
      var xws = new XmlWriterSettings();
      xws.Indent = indent;
      var w = new XEWriter(XmlWriter.Create(file, xws), false);
      if (String.IsNullOrEmpty(ns)) {
        w.writer.WriteStartElement(localName);
      } else {
        w.writer.WriteStartElement(localName, ns);
      }
      return w;
    }

    /// <summary>Not documented yet.</summary>
    /// <param name='writer'>The parameter <paramref name='writer'/> is
    /// a.Xml.XmlWriter object.</param>
    /// <param name='localName'>The parameter <paramref name='localName'/>
    /// is a text string.</param>
    /// <returns>A XEWriter object.</returns>
    public static XEWriter Create(XmlWriter writer, string localName) {
      return Create(writer, localName, String.Empty);
    }

    /// <summary>Not documented yet.</summary>
    /// <param name='writer'>The parameter <paramref name='writer'/> is
    /// a.Xml.XmlWriter object.</param>
    /// <param name='localName'>The parameter <paramref name='localName'/>
    /// is a text string.</param>
    /// <param name='ns'>The parameter <paramref name='ns'/> is a text
    /// string.</param>
    /// <returns>A XEWriter object.</returns>
    /// <exception cref='ArgumentNullException'>The parameter <paramref
    /// name='writer'/> or <paramref name='localName'/> is
    /// null.</exception>
    public static XEWriter Create(
      XmlWriter writer,
      string localName,
      string ns) {
      if (writer == null) {
        throw new ArgumentNullException(nameof(writer));
      }
      if (localName == null) {
        throw new ArgumentNullException(nameof(localName));
      }
      if (localName.Length == 0) {
        throw new ArgumentException("localName" + " is empty.");
      }
      var w = new XEWriter(writer, true);
      if (String.IsNullOrEmpty(ns)) {
        w.writer.WriteStartElement(localName);
      } else {
        w.writer.WriteStartElement(localName, ns);
      }
      return w;
    }
  }
}
