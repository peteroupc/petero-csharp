## PeterO.IniEntry

    public sealed class IniEntry

Not documented yet.

### IniEntry Constructor

    public IniEntry(
        PeterO.IniEntry entry);

Initializes a new instance of the[PeterO.IniEntry](PeterO.IniEntry.md) class.

<b>Parameters:</b>

 * <i>entry</i>: An IniEntry object.

<b>Exceptions:</b>

 * System.ArgumentNullException:
The parameter <i>entry</i>
 is null.

### IniEntry Constructor

    public IniEntry(
        string comment);

Initializes a new instance of the[PeterO.IniEntry](PeterO.IniEntry.md) class.

<b>Parameters:</b>

 * <i>comment</i>: A text string.

<b>Exceptions:</b>

 * System.ArgumentNullException:
The parameter <i>comment</i>
 is null.

### IniEntry Constructor

    public IniEntry(
        string key,
        string value);

Initializes a new instance of the[PeterO.IniEntry](PeterO.IniEntry.md) class.

<b>Parameters:</b>

 * <i>key</i>: A text string.

 * <i>value</i>: Another string object.

<b>Exceptions:</b>

 * System.ArgumentNullException:
The parameter <i>key</i>
 or  <i>value</i>
 is null.

### IsComment

    public bool IsComment { get; }

Gets a value indicating whether this entry is a comment line.

<b>Returns:</b>

 `true`  If this entry is a comment line; otherwise,. `false` .

### Key

    public string Key { get; }

Gets a value not documented yet.

<b>Returns:</b>

A value not documented yet.

### Value

    public string Value { get; }

Gets a value not documented yet.

<b>Returns:</b>

A value not documented yet.

### ToString

    public override string ToString();

Converts this object to a text string.

<b>Return Value:</b>

A text string.
