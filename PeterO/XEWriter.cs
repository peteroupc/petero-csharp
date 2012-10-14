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
    /// <include file='../docs.xml'
    /// path='docs/doc[@name="T:PeterO.XEWriter"]/*'/>
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

    /// <include file='../docs.xml'
    /// path='docs/doc[@name="M:PeterO.XEWriter.Dispose"]/*'/>
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

    /// <include file='../docs.xml'
    /// path='docs/doc[@name="M:PeterO.XEWriter.AddAttribute(System.String,System.String)"]/*'/>
    public void AddAttribute(string key, string value) {
      this.writer.WriteAttributeString(key, value);
    }

    /// <include file='../docs.xml'
    /// path='docs/doc[@name="M:PeterO.XEWriter.AddAttribute(System.String,System.String,System.String)"]/*'/>
    public void AddAttribute(string key, string ns, string value) {
      this.writer.WriteAttributeString(key, ns, value);
    }

    /// <include file='../docs.xml'
    /// path='docs/doc[@name="M:PeterO.XEWriter.AddContent(System.String)"]/*'/>
    public void AddContent(string str) {
      this.writer.WriteString(str);
    }

    /// <include file='../docs.xml'
    /// path='docs/doc[@name="M:PeterO.XEWriter.AddElement(System.String)"]/*'/>
    public XEWriter AddElement(string localName) {
      return Create(this.writer, localName);
    }

    /// <include file='../docs.xml'
    /// path='docs/doc[@name="M:PeterO.XEWriter.AddElement(System.String,System.String)"]/*'/>
    public XEWriter AddElement(string localName, string ns) {
      return Create(this.writer, localName, ns);
    }

    /// <include file='../docs.xml'
    /// path='docs/doc[@name="M:PeterO.XEWriter.AddComment(System.String)"]/*'/>
    public void AddComment(string value) {
      if (String.IsNullOrEmpty(value)) {
        this.writer.WriteComment(String.Empty);
      } else {
        this.writer.WriteComment(value);
      }
    }

    /// <include file='../docs.xml'
    /// path='docs/doc[@name="M:PeterO.XEWriter.AddSimpleElement(System.String,System.String)"]/*'/>
    public void AddSimpleElement(string localName, string value) {
      this.AddSimpleElement(localName, String.Empty, value);
    }

    /// <include file='../docs.xml'
    /// path='docs/doc[@name="M:PeterO.XEWriter.AddSimpleElement(System.String,System.String,System.String)"]/*'/>
    public void AddSimpleElement(string localName, string ns, string value) {
      if (String.IsNullOrEmpty(ns)) {
        this.writer.WriteStartElement(localName);
      } else {
        this.writer.WriteStartElement(localName, ns);
      }
      this.writer.WriteString(value);
      this.writer.WriteEndElement();
    }

    /// <include file='../docs.xml'
    /// path='docs/doc[@name="M:PeterO.XEWriter.Create(System.String,System.String)"]/*'/>
    public static XEWriter Create(string file, string localName) {
      return Create(file, localName, String.Empty, false);
    }

    /// <include file='../docs.xml'
    /// path='docs/doc[@name="M:PeterO.XEWriter.Create(System.String,System.String,System.Boolean)"]/*'/>
    public static XEWriter Create(string file, string localName, bool indent) {
      return Create(file, localName, String.Empty, indent);
    }

    /// <include file='../docs.xml'
    /// path='docs/doc[@name="M:PeterO.XEWriter.Create(System.String,System.String,System.String)"]/*'/>
    public static XEWriter Create(string file, string localName, string ns) {
      return Create(file, localName, ns, false);
    }

    /// <include file='../docs.xml'
    /// path='docs/doc[@name="M:PeterO.XEWriter.Create(System.String,System.String,System.String,System.Boolean)"]/*'/>
    public static XEWriter Create(
string file,
string localName,
string ns,
bool indent) {
      if (file == null) {
        throw new ArgumentNullException("file");
      }
      if (file.Length == 0) {
        throw new ArgumentException("file" + " is empty.");
      }
      if (localName == null) {
        throw new ArgumentNullException("localName");
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

    /// <include file='../docs.xml'
    /// path='docs/doc[@name="M:PeterO.XEWriter.Create(System.Xml.XmlWriter,System.String)"]/*'/>
    public static XEWriter Create(XmlWriter writer, string localName) {
      return Create(writer, localName, String.Empty);
    }

    /// <include file='../docs.xml'
    /// path='docs/doc[@name="M:PeterO.XEWriter.Create(System.Xml.XmlWriter,System.String,System.String)"]/*'/>
 public static XEWriter Create(XmlWriter writer, string localName, string ns) {
      if (writer == null) {
        throw new ArgumentNullException("writer");
      }
      if (localName == null) {
        throw new ArgumentNullException("localName");
      } if (localName.Length == 0) {
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
