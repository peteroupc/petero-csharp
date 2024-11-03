/*
 *
 * This file is in the public domain.
 *
 */
using System;
using System.Linq;
using System.Xml;

namespace PeterO {
  /// <summary>Not documented yet.</summary>
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

    /// <summary>Gets a value not documented yet.</summary>
    /// <value>A value not documented yet.</value>
    public string LocalName {
      get {
        if (this.reading) {
          throw new InvalidOperationException("Content already read.");
        }
        return this.reader.LocalName;
      }
    }

    /// <summary>Gets a value not documented yet.</summary>
    /// <value>A value not documented yet.</value>
    public string NamespaceName {
      get {
        if (this.reading) {
          throw new InvalidOperationException("Content already read.");
        }
        return this.reader.NamespaceURI;
      }
    }

    /// <summary>Gets a value not documented yet.</summary>
    /// <value>A value not documented yet.</value>
    public string Name {
      get {
        if (this.reading) {
          throw new InvalidOperationException("Content already read.");
        }
        return this.reader.Name;
      }
    }

    /// <summary>Gets a value indicating whether the currently read element
    /// is found to be empty.</summary>
    /// <value><c>true</c> if the currently read element is found to be
    /// empty; otherwise, <c>false</c>.</value>
    /// <returns>A text string.</returns>
    public bool IsEmptyElement {
      get {
        if (this.reading) {
          throw new InvalidOperationException("Content already read.");
        }
        return this.reader.IsEmptyElement;
      }
    }

    /// <summary>Gets an attribute from the currently read
    /// element.</summary>
    /// <param name='attribute'>The parameter <paramref name='attribute'/>
    /// is a text string.</param>
    /// <returns>A text string.</returns>
    public string this[string attribute] {
      get {
        if (this.reading) {
          throw new InvalidOperationException("Content already read.");
        }
        return this.reader[attribute];
      }
    }

    /// <summary>Not documented yet.</summary>
    /// <param name='localName'>The parameter <paramref name='localName'/>
    /// is a text string.</param>
    /// <param name='namespaceName'>The parameter <paramref
    /// name='namespaceName'/> is a text string.</param>
    /// <returns>Either <c>true</c> or <c>false</c>.</returns>
    /// <exception cref='InvalidOperationException'>This element's content
    /// was already read or being read.</exception>
    public bool IsElement(string localName, string namespaceName) {
      if (this.reading) {
        throw new InvalidOperationException("Content already read.");
      }
      return this.reader.IsStartElement(localName, namespaceName);
    }

    /// <summary>Not documented yet.</summary>
    /// <param name='localName'>The parameter <paramref name='localName'/>
    /// is a text string.</param>
    /// <returns>Either <c>true</c> or <c>false</c>.</returns>
    public bool IsElement(string localName) {
      if (this.reading) {
        throw new InvalidOperationException("Content already read.");
      }
      return this.reader.IsStartElement(localName);
    }

    /// <summary>Not documented yet.</summary>
    /// <param name='localName'>The parameter <paramref name='localName'/>
    /// is a text string.</param>
    /// <param name='namespaceName'>The parameter <paramref
    /// name='namespaceName'/> is a text string.</param>
    /// <returns>Either <c>true</c> or <c>false</c>.</returns>
    public bool MoveNext(string localName, string namespaceName) {
      while (this.MoveNext()) {
        if (this.reader.IsStartElement(localName, namespaceName)) {
          return true;
        }
      }
      return false;
    }

    /// <summary>Not documented yet.</summary>
    /// <param name='localName'>The parameter <paramref name='localName'/>
    /// is a text string.</param>
    /// <returns>Either <c>true</c> or <c>false</c>.</returns>
    public bool MoveNext(string localName) {
      while (this.MoveNext()) {
        if (this.reader.IsStartElement(localName)) {
          return true;
        }
      }
      return false;
    }

    /// <summary>Not documented yet.</summary>
    /// <returns>Either <c>true</c> or <c>false</c>.</returns>
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
        if (this.reader.IsStartElement() && this.reader.Depth == this.depth +
          1) {
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

    /// <summary>Not documented yet.</summary>
    /// <returns>A XEReader object.</returns>
    public XEReader Current() {
      if (!this.reading) {
        throw new InvalidOperationException("MoveNext wasn't called" +
"\u0020previously.");
      }
      if (this.contentRead) {
        throw new InvalidOperationException("Content already read.");
      }
      this.isUnread = false;
      return Create(this.reader);
    }

    /// <summary>Not documented yet.</summary>
    /// <returns>A text string.</returns>
    public string ReadContent() {
      if (this.disposed) {
        throw new ObjectDisposedException("this");
      }
      this.contentRead = true;
      this.reading = true;
      return this.reader.ReadElementContentAsString();
    }

    /// <summary>Not documented yet.</summary>
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

    /// <summary>Not documented yet.</summary>
    /// <param name='file'>The parameter <paramref name='file'/> is a text
    /// string.</param>
    /// <returns>A XEReader object.</returns>
    /// <exception cref='ArgumentNullException'>The parameter <paramref
    /// name='file'/> is null.</exception>
    public static XEReader Create(string file) {
      if (file == null) {
        throw new ArgumentNullException(nameof(file));
      }
      if (file.Length == 0) {
        throw new ArgumentException("file" + " is empty.");
      }
      return Create(XmlReader.Create(file));
    }

    /// <summary>Not documented yet.</summary>
    /// <param name='reader'>The parameter <paramref name='reader'/> is
    /// a.Xml.XmlReader object.</param>
    /// <returns>A XEReader object.</returns>
    /// <exception cref='ArgumentNullException'>The parameter <paramref
    /// name='reader'/> is null.</exception>
    public static XEReader Create(XmlReader reader) {
      if (reader == null) {
        throw new ArgumentNullException(nameof(reader));
      }
      var w = new XEReader(reader, true);
      w.reader.MoveToContent();
      w.depth = w.reader.Depth;
      return w;
    }
  }
}
