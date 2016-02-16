## PeterO.XEReader

    public sealed class XEReader :
        System.IDisposable

Not documented yet.

### IsEmptyElement

    public bool IsEmptyElement { get; }

Gets a value indicating whether the currently read element is found to be empty.

<b>Returns:</b>

 `true`  If the currently read element is found to be empty; otherwise,.  `false` .

<b>Return Value:</b>

A text string.

### LocalName

    public string LocalName { get; }

Gets a value not documented yet.

<b>Returns:</b>

A value not documented yet.

<b>Exceptions:</b>

 * System.InvalidOperationException:
This element's content was already read or being read.

### Name

    public string Name { get; }

Gets a value not documented yet.

<b>Returns:</b>

A value not documented yet.

<b>Exceptions:</b>

 * System.InvalidOperationException:
This element's content was already read or being read.

### NamespaceName

    public string NamespaceName { get; }

Gets a value not documented yet.

<b>Returns:</b>

A value not documented yet.

<b>Exceptions:</b>

 * System.InvalidOperationException:
This element's content was already read or being read.

### Create

    public static PeterO.XEReader Create(
        string file);

Not documented yet.

<b>Parameters:</b>

 * <i>file</i>: A text string.

<b>Return Value:</b>

A XEReader object.

<b>Exceptions:</b>

 * System.ArgumentNullException:
The parameter <i>file</i>
 is null.

### Create

    public static PeterO.XEReader Create(
        System.Xml.XmlReader reader);

Not documented yet.

<b>Parameters:</b>

 * <i>reader</i>: A XmlReader object.

<b>Return Value:</b>

A XEReader object.

<b>Exceptions:</b>

 * System.ArgumentNullException:
The parameter <i>reader</i>
 is null.

### Current

    public PeterO.XEReader Current();

Not documented yet.

<b>Return Value:</b>

A XEReader object.

### Dispose

    public sealed void Dispose();

Not documented yet.

### IsElement

    public bool IsElement(
        string localName);

Not documented yet.

<b>Parameters:</b>

 * <i>localName</i>: A text string.

<b>Return Value:</b>

A Boolean object.

### IsElement

    public bool IsElement(
        string localName,
        string namespaceName);

Not documented yet.

<b>Parameters:</b>

 * <i>localName</i>: A text string.

 * <i>namespaceName</i>: Another string object.

<b>Return Value:</b>

A Boolean object.

<b>Exceptions:</b>

 * System.InvalidOperationException:
This element's content was already read or being read.

### MoveNext

    public bool MoveNext(
        string localName);

Not documented yet.

<b>Parameters:</b>

 * <i>localName</i>: A text string.

<b>Return Value:</b>

A Boolean object.

### MoveNext

    public bool MoveNext(
        string localName,
        string namespaceName);

Not documented yet.

<b>Parameters:</b>

 * <i>localName</i>: A text string.

 * <i>namespaceName</i>: Another string object.

<b>Return Value:</b>

A Boolean object.

### MoveNext

    public bool MoveNext();

Not documented yet.

<b>Return Value:</b>

A Boolean object.

### ReadContent

    public string ReadContent();

Not documented yet.

<b>Return Value:</b>

A text string.
