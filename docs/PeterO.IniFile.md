## PeterO.IniFile

    public sealed class IniFile :
        System.Collections.Generic.IEnumerable,
        System.Collections.IEnumerable

Not documented yet.

### IniFile Constructor

    public IniFile(
        string path);

Initializes a new instance of the  class.

<b>Parameters:</b>

 * <i>path</i>: A text string.

### IniFile Constructor

    public IniFile(
        string path,
        PeterO.IniMergeBehavior behavior);

Initializes a new instance of the  class.

<b>Parameters:</b>

 * <i>path</i>: A text string.

 * <i>behavior</i>: An IniMergeBehavior object.

<b>Exceptions:</b>

 * System.ArgumentNullException:
The parameter <i>path</i>
 is null.

### IniFile Constructor

    public IniFile();

Initializes a new instance of the  class.

### Count

    public int Count { get; }

Gets a value not documented yet.

<b>Returns:</b>

A value not documented yet.

### AddSection

    public PeterO.IniSection AddSection(
        string sectionName);

Not documented yet.

<b>Parameters:</b>

 * <i>sectionName</i>: A text string.

<b>Returns:</b>

An IniSection object.

### AddSection

    public PeterO.IniSection AddSection(
        string sectionName,
        PeterO.IniMergeBehavior behavior);

Not documented yet.

<b>Parameters:</b>

 * <i>sectionName</i>: A text string.

 * <i>behavior</i>: An IniMergeBehavior object.

<b>Returns:</b>

An IniSection object.

### GetSection

    public PeterO.IniSection GetSection(
        string sectionName);

Not documented yet.

<b>Parameters:</b>

 * <i>sectionName</i>: A text string.

<b>Returns:</b>

An IniSection object.

### GetValue

    public string GetValue(
        string sectionName,
        string keyName);

Not documented yet.

<b>Parameters:</b>

 * <i>sectionName</i>: Another string object.

 * <i>keyName</i>: Another string object.

<b>Returns:</b>

A text string.

<b>Exceptions:</b>

 * System.ArgumentNullException:
The parameter <i>keyName</i>
 is null.

### RemoveSection

    public void RemoveSection(
        string sectionName);

Not documented yet.

<b>Parameters:</b>

 * <i>sectionName</i>: A text string.

### Save

    public void Save(
        string path);

Not documented yet.

<b>Parameters:</b>

 * <i>path</i>: A text string.

<b>Exceptions:</b>

 * System.ArgumentNullException:
The parameter <i>path</i>
 is null.

### SetValue

    public void SetValue(
        string sectionName,
        string keyName,
        string value);

Not documented yet.

<b>Parameters:</b>

 * <i>sectionName</i>: A text string.

 * <i>keyName</i>: Another string object.

 * <i>value</i>: Another string object.

<b>Exceptions:</b>

 * System.ArgumentNullException:
The parameter <i>keyName</i>
 or  <i>value</i>
 is null.

### ToString

    public override string ToString();

Converts this object to a text string.

<b>Returns:</b>

A text string.

### WriteToStream

    public void WriteToStream(
        System.IO.StreamWriter writer);

Not documented yet.

<b>Parameters:</b>

 * <i>writer</i>: A StreamWriter object.

<b>Exceptions:</b>

 * System.ArgumentNullException:
The parameter <i>writer</i>
 is null.
