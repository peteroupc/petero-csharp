## PeterO.IniFile

    public sealed class IniFile :
        System.Collections.Generic.IEnumerable,
        System.Collections.IEnumerable

Not documented yet.

### Member Summary
* <code>[AddSection(string)](#AddSection_string)</code> - Not documented yet.
* <code>[AddSection(string, PeterO.IniMergeBehavior)](#AddSection_string_PeterO_IniMergeBehavior)</code> - Not documented yet.
* <code>[Count](#Count)</code> - Gets a value not documented yet.
* <code>[GetSection(string)](#GetSection_string)</code> - Not documented yet.
* <code>[GetValue(string, string)](#GetValue_string_string)</code> - Not documented yet.
* <code>[RemoveSection(string)](#RemoveSection_string)</code> - Not documented yet.
* <code>[Save(string)](#Save_string)</code> - Not documented yet.
* <code>[SetValue(string, string, string)](#SetValue_string_string_string)</code> - Not documented yet.
* <code>[ToString()](#ToString)</code> - Converts this object to a text string.
* <code>[WriteToStream(System.IO.StreamWriter)](#WriteToStream_System_IO_StreamWriter)</code> - Not documented yet.

<a id="Void_ctor_System_String"></a>
### IniFile Constructor

    public IniFile(
        string path);

Initializes a new instance of the [PeterO.IniFile](PeterO.IniFile.md) class.

<b>Parameters:</b>

 * <i>path</i>: The parameter  <i>path</i>
 is a text string.

<a id="Void_ctor_System_String_PeterO_IniMergeBehavior"></a>
### IniFile Constructor

    public IniFile(
        string path,
        PeterO.IniMergeBehavior behavior);

Initializes a new instance of the [PeterO.IniFile](PeterO.IniFile.md) class.

<b>Parameters:</b>

 * <i>path</i>: The parameter  <i>path</i>
 is a text string.

 * <i>behavior</i>: The parameter  <i>behavior</i>
 is an IniMergeBehavior object.

<b>Exceptions:</b>

 * System.ArgumentNullException:
The parameter  <i>path</i>
 is null.

<a id="Void_ctor"></a>
### IniFile Constructor

    public IniFile();

Initializes a new instance of the [PeterO.IniFile](PeterO.IniFile.md) class.

<a id="Count"></a>
### Count

    public int Count { get; }

Gets a value not documented yet.

<b>Returns:</b>

A value not documented yet.

<a id="AddSection_string"></a>
### AddSection

    public PeterO.IniSection AddSection(
        string sectionName);

Not documented yet.

<b>Parameters:</b>

 * <i>sectionName</i>: The parameter  <i>sectionName</i>
 is a text string.

<b>Return Value:</b>

An IniSection object.

<a id="AddSection_string_PeterO_IniMergeBehavior"></a>
### AddSection

    public PeterO.IniSection AddSection(
        string sectionName,
        PeterO.IniMergeBehavior behavior);

Not documented yet.

<b>Parameters:</b>

 * <i>sectionName</i>: The parameter  <i>sectionName</i>
 is a text string.

 * <i>behavior</i>: The parameter  <i>behavior</i>
 is an IniMergeBehavior object.

<b>Return Value:</b>

An IniSection object.

<a id="GetSection_string"></a>
### GetSection

    public PeterO.IniSection GetSection(
        string sectionName);

Not documented yet.

<b>Parameters:</b>

 * <i>sectionName</i>: The parameter  <i>sectionName</i>
 is a text string.

<b>Return Value:</b>

An IniSection object.

<a id="GetValue_string_string"></a>
### GetValue

    public string GetValue(
        string sectionName,
        string keyName);

Not documented yet.

<b>Parameters:</b>

 * <i>sectionName</i>: The parameter  <i>sectionName</i>
 is a text string.

 * <i>keyName</i>: The parameter  <i>keyName</i>
 is a text string.

<b>Return Value:</b>

A text string.

<b>Exceptions:</b>

 * System.ArgumentNullException:
The parameter  <i>keyName</i>
 is null.

<a id="RemoveSection_string"></a>
### RemoveSection

    public void RemoveSection(
        string sectionName);

Not documented yet.

<b>Parameters:</b>

 * <i>sectionName</i>: The parameter  <i>sectionName</i>
 is a text string.

<a id="Save_string"></a>
### Save

    public void Save(
        string path);

Not documented yet.

<b>Parameters:</b>

 * <i>path</i>: The parameter  <i>path</i>
 is a text string.

<b>Exceptions:</b>

 * System.ArgumentNullException:
The parameter  <i>path</i>
 is null.

<a id="SetValue_string_string_string"></a>
### SetValue

    public void SetValue(
        string sectionName,
        string keyName,
        string value);

Not documented yet.

<b>Parameters:</b>

 * <i>sectionName</i>: The parameter  <i>sectionName</i>
 is a text string.

 * <i>keyName</i>: The parameter  <i>keyName</i>
 is a text string.

 * <i>value</i>: The parameter  <i>value</i>
 is a text string.

<b>Exceptions:</b>

 * System.ArgumentNullException:
The parameter  <i>keyName</i>
 or  <i>value</i>
 is null.

<a id="ToString"></a>
### ToString

    public override string ToString();

Converts this object to a text string.

<b>Return Value:</b>

A text string.

<a id="WriteToStream_System_IO_StreamWriter"></a>
### WriteToStream

    public void WriteToStream(
        System.IO.StreamWriter writer);

Not documented yet.

<b>Parameters:</b>

 * <i>writer</i>: The parameter  <i>writer</i>
 is a StreamWriter object.

<b>Exceptions:</b>

 * System.ArgumentNullException:
The parameter  <i>writer</i>
 is null.
