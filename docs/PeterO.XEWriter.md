## PeterO.XEWriter

    public sealed class XEWriter :
        System.IDisposable

Not documented yet.

### AddAttribute

    public void AddAttribute(
        string key,
        string ns,
        string value);

Not documented yet.

<b>Parameters:</b>

 * <i>key</i>: A text string.

 * <i>ns</i>: Another string object.

 * <i>value</i>: A text string. (3).

### AddAttribute

    public void AddAttribute(
        string key,
        string value);

Not documented yet.

<b>Parameters:</b>

 * <i>key</i>: A text string.

 * <i>value</i>: Another string object.

### AddComment

    public void AddComment(
        string value);

Not documented yet.

<b>Parameters:</b>

 * <i>value</i>: A text string.

### AddContent

    public void AddContent(
        string str);

Not documented yet.

<b>Parameters:</b>

 * <i>str</i>: A text string.

### AddElement

    public PeterO.XEWriter AddElement(
        string localName);

Not documented yet.

<b>Parameters:</b>

 * <i>localName</i>: A text string.

<b>Return Value:</b>

A XEWriter object.

### AddElement

    public PeterO.XEWriter AddElement(
        string localName,
        string ns);

Not documented yet.

<b>Parameters:</b>

 * <i>localName</i>: A text string.

 * <i>ns</i>: Another string object.

<b>Return Value:</b>

A XEWriter object.

### AddSimpleElement

    public void AddSimpleElement(
        string localName,
        string ns,
        string value);

Not documented yet.

<b>Parameters:</b>

 * <i>localName</i>: A text string.

 * <i>ns</i>: Another string object.

 * <i>value</i>: A text string. (3).

### AddSimpleElement

    public void AddSimpleElement(
        string localName,
        string value);

Not documented yet.

<b>Parameters:</b>

 * <i>localName</i>: A text string.

 * <i>value</i>: Another string object.

### Create

    public static PeterO.XEWriter Create(
        string file,
        string localName);

Not documented yet.

<b>Parameters:</b>

 * <i>file</i>: A text string.

 * <i>localName</i>: Another string object.

<b>Return Value:</b>

A XEWriter object.

### Create

    public static PeterO.XEWriter Create(
        string file,
        string localName,
        bool indent);

Not documented yet.

<b>Parameters:</b>

 * <i>file</i>: A text string.

 * <i>localName</i>: Another string object.

 * <i>indent</i>: A Boolean object.

<b>Return Value:</b>

A XEWriter object.

### Create

    public static PeterO.XEWriter Create(
        string file,
        string localName,
        string ns);

Not documented yet.

<b>Parameters:</b>

 * <i>file</i>: A text string.

 * <i>localName</i>: Another string object.

 * <i>ns</i>: A text string. (3).

<b>Return Value:</b>

A XEWriter object.

### Create

    public static PeterO.XEWriter Create(
        string file,
        string localName,
        string ns,
        bool indent);

Not documented yet.

<b>Parameters:</b>

 * <i>file</i>: A text string.

 * <i>localName</i>: Another string object.

 * <i>ns</i>: A text string. (3).

 * <i>indent</i>: A Boolean object.

<b>Return Value:</b>

A XEWriter object.

<b>Exceptions:</b>

 * System.ArgumentNullException:
The parameter <i>file</i>
 or  <i>localName</i>
 is null.

### Create

    public static PeterO.XEWriter Create(
        System.Xml.XmlWriter writer,
        string localName);

Not documented yet.

<b>Parameters:</b>

 * <i>writer</i>: A XmlWriter object.

 * <i>localName</i>: A text string.

<b>Return Value:</b>

A XEWriter object.

### Create

    public static PeterO.XEWriter Create(
        System.Xml.XmlWriter writer,
        string localName,
        string ns);

Not documented yet.

<b>Parameters:</b>

 * <i>writer</i>: A XmlWriter object.

 * <i>localName</i>: A text string.

 * <i>ns</i>: Another string object.

<b>Return Value:</b>

A XEWriter object.

<b>Exceptions:</b>

 * System.ArgumentNullException:
The parameter <i>writer</i>
 or  <i>localName</i>
 is null.

### Dispose

    public sealed void Dispose();

Not documented yet.
