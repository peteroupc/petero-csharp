## PeterO.XEReader

    public sealed class XEReader :
        System.IDisposable

Not documented yet.

### Member Summary
* <code>[Create(string)](#Create_string)</code> - Not documented yet.
* <code>[Create(System.Xml.XmlReader)](#Create_System_Xml_XmlReader)</code> - Not documented yet.
* <code>[Current()](#Current)</code> - Not documented yet.
* <code>[Dispose()](#Dispose)</code> - Not documented yet.
* <code>[IsElement(string)](#IsElement_string)</code> - Not documented yet.
* <code>[IsElement(string, string)](#IsElement_string_string)</code> - Not documented yet.
* <code>[IsEmptyElement](#IsEmptyElement)</code> - Gets a value indicating whether the currently read element is found to be empty.
* <code>[LocalName](#LocalName)</code> - Gets a value not documented yet.
* <code>[MoveNext()](#MoveNext)</code> - Not documented yet.
* <code>[MoveNext(string)](#MoveNext_string)</code> - Not documented yet.
* <code>[MoveNext(string, string)](#MoveNext_string_string)</code> - Not documented yet.
* <code>[Name](#Name)</code> - Gets a value not documented yet.
* <code>[NamespaceName](#NamespaceName)</code> - Gets a value not documented yet.
* <code>[ReadContent()](#ReadContent)</code> - Not documented yet.
* <code>[this[string]](#this_string)</code> - Gets an attribute from the currently read element.

<a id="IsEmptyElement"></a>
### IsEmptyElement

    public bool IsEmptyElement { get; }

Gets a value indicating whether the currently read element is found to be empty.

<b>Returns:</b>

 `true`  if the currently read element is found to be empty; otherwise,  `false` .

<b>Return Value:</b>

A text string.

<a id="this_string"></a>
### Item

    public string this[string attribute] { get; }

Gets an attribute from the currently read element.

<b>Parameters:</b>

 * <i>attribute</i>: The parameter  <i>attribute</i>
 is a text string.

<b>Return Value:</b>

A text string.

<a id="LocalName"></a>
### LocalName

    public string LocalName { get; }

Gets a value not documented yet.

<b>Returns:</b>

A value not documented yet.

<a id="Name"></a>
### Name

    public string Name { get; }

Gets a value not documented yet.

<b>Returns:</b>

A value not documented yet.

<a id="NamespaceName"></a>
### NamespaceName

    public string NamespaceName { get; }

Gets a value not documented yet.

<b>Returns:</b>

A value not documented yet.

<a id="Create_string"></a>
### Create

    public static PeterO.XEReader Create(
        string file);

Not documented yet.

<b>Parameters:</b>

 * <i>file</i>: The parameter  <i>file</i>
 is a text string.

<b>Return Value:</b>

A XEReader object.

<b>Exceptions:</b>

 * System.ArgumentNullException:
The parameter  <i>file</i>
 is null.

<a id="Create_System_Xml_XmlReader"></a>
### Create

    public static PeterO.XEReader Create(
        System.Xml.XmlReader reader);

Not documented yet.

<b>Parameters:</b>

 * <i>reader</i>: The parameter  <i>reader</i>
 is a.Xml.XmlReader object.

<b>Return Value:</b>

A XEReader object.

<b>Exceptions:</b>

 * System.ArgumentNullException:
The parameter  <i>reader</i>
 is null.

<a id="Current"></a>
### Current

    public PeterO.XEReader Current();

Not documented yet.

<b>Return Value:</b>

A XEReader object.

<a id="Dispose"></a>
### Dispose

    public sealed void Dispose();

Not documented yet.

<a id="IsElement_string"></a>
### IsElement

    public bool IsElement(
        string localName);

Not documented yet.

<b>Parameters:</b>

 * <i>localName</i>: The parameter  <i>localName</i>
 is a text string.

<b>Return Value:</b>

Either  `true`  or  `false` .

<a id="IsElement_string_string"></a>
### IsElement

    public bool IsElement(
        string localName,
        string namespaceName);

Not documented yet.

<b>Parameters:</b>

 * <i>localName</i>: The parameter  <i>localName</i>
 is a text string.

 * <i>namespaceName</i>: The parameter  <i>namespaceName</i>
 is a text string.

<b>Return Value:</b>

Either  `true`  or  `false` .

<b>Exceptions:</b>

 * System.InvalidOperationException:
This element's content was already read or being read.

<a id="MoveNext_string"></a>
### MoveNext

    public bool MoveNext(
        string localName);

Not documented yet.

<b>Parameters:</b>

 * <i>localName</i>: The parameter  <i>localName</i>
 is a text string.

<b>Return Value:</b>

Either  `true`  or  `false` .

<a id="MoveNext_string_string"></a>
### MoveNext

    public bool MoveNext(
        string localName,
        string namespaceName);

Not documented yet.

<b>Parameters:</b>

 * <i>localName</i>: The parameter  <i>localName</i>
 is a text string.

 * <i>namespaceName</i>: The parameter  <i>namespaceName</i>
 is a text string.

<b>Return Value:</b>

Either  `true`  or  `false` .

<a id="MoveNext"></a>
### MoveNext

    public bool MoveNext();

Not documented yet.

<b>Return Value:</b>

Either  `true`  or  `false` .

<a id="ReadContent"></a>
### ReadContent

    public string ReadContent();

Not documented yet.

<b>Return Value:</b>

A text string.
