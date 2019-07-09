## PeterO.IniSection

    public sealed class IniSection :
        System.Collections.Generic.IEnumerable,
        System.Collections.IEnumerable

Not documented yet.

### Member Summary
* <code>[Add(PeterO.IniEntry)](#Add_PeterO_IniEntry)</code> - Not documented yet.
* <code>[Add(PeterO.IniEntry, PeterO.IniMergeBehavior)](#Add_PeterO_IniEntry_PeterO_IniMergeBehavior)</code> - Adds two IniEntry objects.
* <code>[AddComment(string)](#AddComment_string)</code> - Not documented yet.
* <code>[AddEntry(string, string)](#AddEntry_string_string)</code> - Not documented yet.
* <code>[AddEntry(string, string, PeterO.IniMergeBehavior)](#AddEntry_string_string_PeterO_IniMergeBehavior)</code> - Not documented yet.
* <code>[Clear()](#Clear)</code> - Not documented yet.
* <code>[Count](#Count)</code> - Gets a value not documented yet.
* <code>[GetValue(string)](#GetValue_string)</code> - Not documented yet.
* <code>[Name](#Name)</code> - Gets a value not documented yet.
* <code>[RemoveEntry(string)](#RemoveEntry_string)</code> - Not documented yet.
* <code>[SetValue(string, string)](#SetValue_string_string)</code> - Not documented yet.
* <code>[this[int]](#this_int)</code> - Not documented yet.
* <code>[ToString()](#ToString)</code> - Converts this object to a text string.

<a id="Void_ctor_PeterO_IniSection"></a>
### IniSection Constructor

    public IniSection(
        PeterO.IniSection other);

Initializes a new instance of the [PeterO.IniSection](PeterO.IniSection.md) class.

<b>Parameters:</b>

 * <i>other</i>: The parameter  <i>other</i>
 is an IniSection object.

<b>Exceptions:</b>

 * System.ArgumentNullException:
The parameter  <i>other</i>
 is null.

<a id="Void_ctor_System_String"></a>
### IniSection Constructor

    public IniSection(
        string name);

Initializes a new instance of the [PeterO.IniSection](PeterO.IniSection.md) class.

<b>Parameters:</b>

 * <i>name</i>: The parameter  <i>name</i>
 is a text string.

<a id="Count"></a>
### Count

    public int Count { get; }

Gets a value not documented yet.

<b>Returns:</b>

A value not documented yet.

<a id="this_int"></a>
### Item

    public PeterO.IniEntry this[int index] { get; set; }

Not documented yet.

<b>Parameters:</b>

 * <i>index</i>: The parameter  <i>index</i>
 is a 32-bit signed integer.

<b>Return Value:</b>

An IniEntry object.

<a id="Name"></a>
### Name

    public string Name { get; }

Gets a value not documented yet.

<b>Returns:</b>

A value not documented yet.

<a id="Add_PeterO_IniEntry"></a>
### Add

    public void Add(
        PeterO.IniEntry entry);

Not documented yet.

<b>Parameters:</b>

 * <i>entry</i>: The parameter  <i>entry</i>
 is a IniEntry object.

<a id="Add_PeterO_IniEntry_PeterO_IniMergeBehavior"></a>
### Add

    public void Add(
        PeterO.IniEntry entry,
        PeterO.IniMergeBehavior behavior);

Adds two IniEntry objects.

<b>Parameters:</b>

 * <i>entry</i>: The parameter  <i>entry</i>
 is an IniEntry object.

 * <i>behavior</i>: The parameter  <i>behavior</i>
 is an IniMergeBehavior object.

<b>Exceptions:</b>

 * System.ArgumentNullException:
The parameter  <i>entry</i>
 is null.

<a id="AddComment_string"></a>
### AddComment

    public void AddComment(
        string comment);

Not documented yet.

<b>Parameters:</b>

 * <i>comment</i>: The parameter  <i>comment</i>
 is a text string.

<a id="AddEntry_string_string"></a>
### AddEntry

    public void AddEntry(
        string key,
        string value);

Not documented yet.

<b>Parameters:</b>

 * <i>key</i>: The parameter  <i>key</i>
 is a text string.

 * <i>value</i>: The parameter  <i>value</i>
 is a text string.

<a id="AddEntry_string_string_PeterO_IniMergeBehavior"></a>
### AddEntry

    public void AddEntry(
        string key,
        string value,
        PeterO.IniMergeBehavior behavior);

Not documented yet.

<b>Parameters:</b>

 * <i>key</i>: The parameter  <i>key</i>
 is a text string.

 * <i>value</i>: The parameter  <i>value</i>
 is a text string.

 * <i>behavior</i>: The parameter  <i>behavior</i>
 is a IniMergeBehavior object.

<b>Exceptions:</b>

 * System.ArgumentNullException:
The parameter "keyName" is null.

<a id="Clear"></a>
### Clear

    public void Clear();

Not documented yet.

<a id="GetValue_string"></a>
### GetValue

    public string GetValue(
        string keyName);

Not documented yet.

<b>Parameters:</b>

 * <i>keyName</i>: The parameter  <i>keyName</i>
 is a text string.

<b>Return Value:</b>

A text string.

<b>Exceptions:</b>

 * System.ArgumentNullException:
The parameter  <i>keyName</i>
 is null.

<a id="RemoveEntry_string"></a>
### RemoveEntry

    public void RemoveEntry(
        string key);

Not documented yet.

<b>Parameters:</b>

 * <i>key</i>: The parameter  <i>key</i>
 is a text string.

<b>Exceptions:</b>

 * System.ArgumentNullException:
The parameter  <i>key</i>
 is null.

<a id="SetValue_string_string"></a>
### SetValue

    public void SetValue(
        string keyName,
        string value);

Not documented yet.

<b>Parameters:</b>

 * <i>keyName</i>: The parameter  <i>keyName</i>
 is a text string.

 * <i>value</i>: The parameter  <i>value</i>
 is a text string.

<b>Exceptions:</b>

 * System.ArgumentNullException:
The parameter  <i>keyName</i>
 is null.

<a id="ToString"></a>
### ToString

    public override string ToString();

Converts this object to a text string.

<b>Return Value:</b>

A text string.
