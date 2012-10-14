/*
 *
 * This file is in the public domain.
 *
 */
using System;
using System.Linq;
using System.Xml;

namespace PeterO {
    /// <include file='../docs.xml'
    /// path='docs/doc[@name="T:PeterO.XEReader"]/*'/>
  public sealed class XEReader : IDisposable {
    private readonly XmlReader reader;
    private readonly bool leaveOpen;
    private bool disposed;
    private bool contentRead;
    private bool reading;
    private bool isUnread;
    private int depth;

    private XEReader() {
    }

    private XEReader(XmlReader reader, bool leaveOpen) {
      this.reader = reader;
      this.leaveOpen = leaveOpen;
    }

    /// <include file='../docs.xml'
    /// path='docs/doc[@name="P:PeterO.XEReader.LocalName"]/*'/>
    public string LocalName {
      get {
        if (this.reading) {
          throw new InvalidOperationException("Content already read.");
        }
        return this.reader.LocalName;
      }
    }

    /// <include file='../docs.xml'
    /// path='docs/doc[@name="P:PeterO.XEReader.NamespaceName"]/*'/>
    public string NamespaceName {
      get {
        if (this.reading) {
          throw new InvalidOperationException("Content already read.");
        }
        return this.reader.NamespaceURI;
      }
    }

    /// <include file='../docs.xml'
    /// path='docs/doc[@name="P:PeterO.XEReader.Name"]/*'/>
    public string Name {
      get {
        if (this.reading) {
          throw new InvalidOperationException("Content already read.");
        }
        return this.reader.Name;
      }
    }

    /// <include file='../docs.xml'
    /// path='docs/doc[@name="P:PeterO.XEReader.IsEmptyElement"]/*'/>
    public bool IsEmptyElement {
      get {
        if (this.reading) {
          throw new InvalidOperationException("Content already read.");
        }
        return this.reader.IsEmptyElement;
      }
    }

    /// <include file='../docs.xml'
    /// path='docs/doc[@name="P:PeterO.XEReader.Item(System.String)"]/*'/>
    public string this[string attribute] {
      get {
        if (this.reading) {
          throw new InvalidOperationException("Content already read.");
        }
        return this.reader[attribute];
      }
    }

    /// <include file='../docs.xml'
    /// path='docs/doc[@name="M:PeterO.XEReader.IsElement(System.String,System.String)"]/*'/>
    public bool IsElement(string localName, string namespaceName) {
      if (this.reading) {
        throw new InvalidOperationException("Content already read.");
      }
      return this.reader.IsStartElement(localName, namespaceName);
    }

    /// <include file='../docs.xml'
    /// path='docs/doc[@name="M:PeterO.XEReader.IsElement(System.String)"]/*'/>
    public bool IsElement(string localName) {
      if (this.reading) {
        throw new InvalidOperationException("Content already read.");
      }
      return this.reader.IsStartElement(localName);
    }

    /// <include file='../docs.xml'
    /// path='docs/doc[@name="M:PeterO.XEReader.MoveNext(System.String,System.String)"]/*'/>
    public bool MoveNext(string localName, string namespaceName) {
      while (this.MoveNext()) {
        if (this.reader.IsStartElement(localName, namespaceName)) {
          return true;
        }
      }
      return false;
    }

    /// <include file='../docs.xml'
    /// path='docs/doc[@name="M:PeterO.XEReader.MoveNext(System.String)"]/*'/>
    public bool MoveNext(string localName) {
      while (this.MoveNext()) {
        if (this.reader.IsStartElement(localName)) {
          return true;
        }
      }
      return false;
    }

    /// <include file='../docs.xml'
    /// path='docs/doc[@name="M:PeterO.XEReader.MoveNext"]/*'/>
    public bool MoveNext() {
      if (!this.reading && this.reader.IsEmptyElement) {
        this.reader.Read();
        this.reading = true;
        this.contentRead = true;
        return false;
      }
      if (!this.reading || this.isUnread) {
        this.reader.Read();
        this.reading = true;
        this.isUnread = false;
      }
      while (this.reader.MoveToContent() != XmlNodeType.None) {
     if (this.reader.IsStartElement() && this.reader.Depth == this.depth + 1) {
          this.isUnread = true;
          return true;
        }
        if (this.reader.Depth <= this.depth) {
          break;
        }
        this.reader.Read();
      }
      this.isUnread = false;
      this.contentRead = true;
      return false;
    }

    /// <include file='../docs.xml'
    /// path='docs/doc[@name="M:PeterO.XEReader.Current"]/*'/>
    public XEReader Current() {
      if (!this.reading) {
     throw new InvalidOperationException("MoveNext wasn't called previously.");
      }
      if (this.contentRead) {
        throw new InvalidOperationException("Content already read.");
      }
      this.isUnread = false;
      return Create(this.reader);
    }

    /// <include file='../docs.xml'
    /// path='docs/doc[@name="M:PeterO.XEReader.ReadContent"]/*'/>
    public string ReadContent() {
      if (this.disposed) {
        throw new ObjectDisposedException("this");
      }
      this.contentRead = true;
      this.reading = true;
      return this.reader.ReadElementContentAsString();
    }

    /// <include file='../docs.xml'
    /// path='docs/doc[@name="M:PeterO.XEReader.Dispose"]/*'/>
    public void Dispose() {
      if (this.disposed) {
        return;
      }
      while (this.MoveNext()) {
      }
      this.contentRead = true;
      this.reading = true;
      if (!this.leaveOpen) {
        ((IDisposable)this.reader).Dispose();
      }
      this.disposed = true;
    }

    /// <include file='../docs.xml'
    /// path='docs/doc[@name="M:PeterO.XEReader.Create(System.String)"]/*'/>
    public static XEReader Create(string file) {
      if (file == null) {
        throw new ArgumentNullException("file");
      } if (file.Length == 0) {
        throw new ArgumentException("file" + " is empty.");
      }
      return Create(XmlReader.Create(file));
    }

    /// <include file='../docs.xml'
    /// path='docs/doc[@name="M:PeterO.XEReader.Create(System.Xml.XmlReader)"]/*'/>
    public static XEReader Create(XmlReader reader) {
      if (reader == null) {
        throw new ArgumentNullException("reader");
      }
      var w = new XEReader(reader, true);
      w.reader.MoveToContent();
      w.depth = w.reader.Depth;
      return w;
    }
  }
}
