## PeterO.IniEntry

    public sealed class IniEntry

Not documented yet.

### Member Summary
* <code>[IsComment](#IsComment)</code> - Gets a value indicating whether this entry is a comment line.
* <code>[Key](#Key)</code> - Gets a value not documented yet.
* <code>[ToString()](#ToString)</code> - Converts this object to a text string.
* <code>[Value](#Value)</code> - Gets a value not documented yet.

<a id="Void_ctor_PeterO_IniEntry"></a>
### IniEntry Constructor

    public IniEntry(
        PeterO.IniEntry entry);

Initializes a new instance of the.

<b>Parameters:</b>

 * <i>entry</i>: The parameter  <i>entry</i>
 is an IniEntry object.

<b>Exceptions:</b>

 * System.ArgumentNullException:
The parameter  <i>entry</i>
 is null.

<a id="Void_ctor_System_String"></a>
### IniEntry Constructor

    public IniEntry(
        string comment);

Initializes a new instance of the.

<b>Parameters:</b>

 * <i>comment</i>: The parameter  <i>comment</i>
 is a text string.

<b>Exceptions:</b>

 * System.ArgumentNullException:
The parameter  <i>comment</i>
 is null.

 * System.ArgumentException:
Value is not a comment.; Characters in comment are not valid.

<a id="Void_ctor_System_String_System_String"></a>
### IniEntry Constructor

    public IniEntry(
        string key,
        string value);

Initializes a new instance of the.

<b>Parameters:</b>

 * <i>key</i>: The parameter  <i>key</i>
 is a text string.

 * <i>value</i>: The parameter  <i>value</i>
 is a text string.

<b>Exceptions:</b>

 * System.ArgumentNullException:
The parameter  <i>key</i>
 or  <i>value</i>
 is null.

 * System.ArgumentException:
Characters in key are not valid.; Characters in value are not valid.

<a id="IsComment"></a>
### IsComment

    public bool IsComment { get; }

Gets a value indicating whether this entry is a comment line.

<b>Returns:</b>

 `true`  if this entry is a comment line; otherwise,  `false` .

<a id="Key"></a>
### Key

    public string Key { get; }

Gets a value not documented yet.

<b>Returns:</b>

A value not documented yet.

<a id="Value"></a>
### Value

    public string Value { get; }

Gets a value not documented yet.

<b>Returns:</b>

A value not documented yet.

<a id="ToString"></a>
### ToString

    public override string ToString();

Converts this object to a text string.

<b>Return Value:</b>

A text string.
