## PeterO.XEWriter

    public sealed class XEWriter :
        System.IDisposable

Not documented yet.

### Member Summary
* <code>[AddAttribute(string, string)](#AddAttribute_string_string)</code> - Not documented yet.
* <code>[AddAttribute(string, string, string)](#AddAttribute_string_string_string)</code> - Not documented yet.
* <code>[AddComment(string)](#AddComment_string)</code> - Not documented yet.
* <code>[AddContent(string)](#AddContent_string)</code> - Not documented yet.
* <code>[AddElement(string)](#AddElement_string)</code> - Not documented yet.
* <code>[AddElement(string, string)](#AddElement_string_string)</code> - Not documented yet.
* <code>[AddSimpleElement(string, string)](#AddSimpleElement_string_string)</code> - Not documented yet.
* <code>[AddSimpleElement(string, string, string)](#AddSimpleElement_string_string_string)</code> - Not documented yet.
* <code>[Create(string, string)](#Create_string_string)</code> - Not documented yet.
* <code>[Create(string, string, bool)](#Create_string_string_bool)</code> - Not documented yet.
* <code>[Create(string, string, string)](#Create_string_string_string)</code> - Not documented yet.
* <code>[Create(string, string, string, bool)](#Create_string_string_string_bool)</code> - Not documented yet.
* <code>[Create(System.Xml.XmlWriter, string)](#Create_System_Xml_XmlWriter_string)</code> - Not documented yet.
* <code>[Create(System.Xml.XmlWriter, string, string)](#Create_System_Xml_XmlWriter_string_string)</code> - Not documented yet.
* <code>[Dispose()](#Dispose)</code> - Not documented yet.

<a id="AddAttribute_string_string_string"></a>
### AddAttribute

    public void AddAttribute(
        string key,
        string ns,
        string value);

Not documented yet.

<b>Parameters:</b>

 * <i>key</i>: The parameter  <i>key</i>
 is a text string.

 * <i>ns</i>: The parameter  <i>ns</i>
 is a text string.

 * <i>value</i>: The parameter  <i>value</i>
 is a text string.

<a id="AddAttribute_string_string"></a>
### AddAttribute

    public void AddAttribute(
        string key,
        string value);

Not documented yet.

<b>Parameters:</b>

 * <i>key</i>: The parameter  <i>key</i>
 is a text string.

 * <i>value</i>: The parameter  <i>value</i>
 is a text string.

<a id="AddComment_string"></a>
### AddComment

    public void AddComment(
        string value);

Not documented yet.

<b>Parameters:</b>

 * <i>value</i>: The parameter  <i>value</i>
 is a text string.

<a id="AddContent_string"></a>
### AddContent

    public void AddContent(
        string str);

Not documented yet.

<b>Parameters:</b>

 * <i>str</i>: The parameter  <i>str</i>
 is a text string.

<a id="AddElement_string"></a>
### AddElement

    public PeterO.XEWriter AddElement(
        string localName);

Not documented yet.

<b>Parameters:</b>

 * <i>localName</i>: The parameter  <i>localName</i>
 is a text string.

<b>Return Value:</b>

A XEWriter object.

<a id="AddElement_string_string"></a>
### AddElement

    public PeterO.XEWriter AddElement(
        string localName,
        string ns);

Not documented yet.

<b>Parameters:</b>

 * <i>localName</i>: The parameter  <i>localName</i>
 is a text string.

 * <i>ns</i>: The parameter  <i>ns</i>
 is a text string.

<b>Return Value:</b>

A XEWriter object.

<a id="AddSimpleElement_string_string_string"></a>
### AddSimpleElement

    public void AddSimpleElement(
        string localName,
        string ns,
        string value);

Not documented yet.

<b>Parameters:</b>

 * <i>localName</i>: The parameter  <i>localName</i>
 is a text string.

 * <i>ns</i>: The parameter  <i>ns</i>
 is a text string.

 * <i>value</i>: The parameter  <i>value</i>
 is a text string.

<a id="AddSimpleElement_string_string"></a>
### AddSimpleElement

    public void AddSimpleElement(
        string localName,
        string value);

Not documented yet.

<b>Parameters:</b>

 * <i>localName</i>: The parameter  <i>localName</i>
 is a text string.

 * <i>value</i>: The parameter  <i>value</i>
 is a text string.

<a id="Create_string_string"></a>
### Create

    public static PeterO.XEWriter Create(
        string file,
        string localName);

Not documented yet.

<b>Parameters:</b>

 * <i>file</i>: The parameter  <i>file</i>
 is a text string.

 * <i>localName</i>: The parameter  <i>localName</i>
 is a text string.

<b>Return Value:</b>

A XEWriter object.

<a id="Create_string_string_bool"></a>
### Create

    public static PeterO.XEWriter Create(
        string file,
        string localName,
        bool indent);

Not documented yet.

<b>Parameters:</b>

 * <i>file</i>: The parameter  <i>file</i>
 is a text string.

 * <i>localName</i>: The parameter  <i>localName</i>
 is a text string.

 * <i>indent</i>: The parameter  <i>indent</i>
 is either  `true`  or  `false` .

<b>Return Value:</b>

A XEWriter object.

<a id="Create_string_string_string"></a>
### Create

    public static PeterO.XEWriter Create(
        string file,
        string localName,
        string ns);

Not documented yet.

<b>Parameters:</b>

 * <i>file</i>: The parameter  <i>file</i>
 is a text string.

 * <i>localName</i>: The parameter  <i>localName</i>
 is a text string.

 * <i>ns</i>: The parameter  <i>ns</i>
 is a text string.

<b>Return Value:</b>

A XEWriter object.

<a id="Create_string_string_string_bool"></a>
### Create

    public static PeterO.XEWriter Create(
        string file,
        string localName,
        string ns,
        bool indent);

Not documented yet.

<b>Parameters:</b>

 * <i>file</i>: The parameter  <i>file</i>
 is a text string.

 * <i>localName</i>: The parameter  <i>localName</i>
 is a text string.

 * <i>ns</i>: The parameter  <i>ns</i>
 is a text string.

 * <i>indent</i>: The parameter  <i>indent</i>
 is either  `true`  or  `false` .

<b>Return Value:</b>

A XEWriter object.

<b>Exceptions:</b>

 * System.ArgumentNullException:
The parameter  <i>file</i>
 or  <i>localName</i>
 is null.

<a id="Create_System_Xml_XmlWriter_string"></a>
### Create

    public static PeterO.XEWriter Create(
        System.Xml.XmlWriter writer,
        string localName);

Not documented yet.

<b>Parameters:</b>

 * <i>writer</i>: The parameter  <i>writer</i>
 is a.Xml.XmlWriter object.

 * <i>localName</i>: The parameter  <i>localName</i>
 is a text string.

<b>Return Value:</b>

A XEWriter object.

<a id="Create_System_Xml_XmlWriter_string_string"></a>
### Create

    public static PeterO.XEWriter Create(
        System.Xml.XmlWriter writer,
        string localName,
        string ns);

Not documented yet.

<b>Parameters:</b>

 * <i>writer</i>: The parameter  <i>writer</i>
 is a.Xml.XmlWriter object.

 * <i>localName</i>: The parameter  <i>localName</i>
 is a text string.

 * <i>ns</i>: The parameter  <i>ns</i>
 is a text string.

<b>Return Value:</b>

A XEWriter object.

<b>Exceptions:</b>

 * System.ArgumentNullException:
The parameter  <i>writer</i>
 or  <i>localName</i>
 is null.

<a id="Dispose"></a>
### Dispose

    public sealed void Dispose();

Not documented yet.
