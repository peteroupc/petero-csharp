## PeterO.IniSection

    public sealed class IniSection :
        System.Collections.Generic.IEnumerable,
        System.Collections.IEnumerable

Not documented yet.

### IniSection Constructor

    public IniSection(
        PeterO.IniSection other);

Initializes a new instance of the  class.

<b>Parameters:</b>

 * <i>other</i>: An IniSection object.

<b>Exceptions:</b>

 * System.ArgumentNullException:
The parameter <i>other</i>
 is null.

### IniSection Constructor

    public IniSection(
        string name);

Initializes a new instance of the  class.

<b>Parameters:</b>

 * <i>name</i>: A text string.

### Count

    public int Count { get; }

Gets a value not documented yet.

<b>Returns:</b>

A value not documented yet.

### Name

    public string Name { get; }

Gets a value not documented yet.

<b>Returns:</b>

A value not documented yet.

### Add

    public void Add(
        PeterO.IniEntry entry);

Not documented yet.

<b>Parameters:</b>

 * <i>entry</i>: An IniEntry object.

### Add

    public void Add(
        PeterO.IniEntry entry,
        PeterO.IniMergeBehavior behavior);

Adds two IniEntry objects.

<b>Parameters:</b>

 * <i>entry</i>: An IniEntry object.

 * <i>behavior</i>: An IniMergeBehavior object.

<b>Exceptions:</b>

 * System.ArgumentNullException:
The parameter <i>entry</i>
 is null.

### AddComment

    public void AddComment(
        string comment);

Not documented yet.

<b>Parameters:</b>

 * <i>comment</i>: A text string.

### AddEntry

    public void AddEntry(
        string key,
        string value);

Not documented yet.

<b>Parameters:</b>

 * <i>key</i>: A text string.

 * <i>value</i>: Another string object.

### AddEntry

    public void AddEntry(
        string key,
        string value,
        PeterO.IniMergeBehavior behavior);

Not documented yet.

<b>Parameters:</b>

 * <i>key</i>: A text string.

 * <i>value</i>: Another string object.

 * <i>behavior</i>: An IniMergeBehavior object.

<b>Exceptions:</b>

 * System.ArgumentNullException:
The parameter "keyName" is null.

### Clear

    public void Clear();

Not documented yet.

### GetValue

    public string GetValue(
        string keyName);

Not documented yet.

<b>Parameters:</b>

 * <i>keyName</i>: Another string object.

<b>Returns:</b>

A text string.

<b>Exceptions:</b>

 * System.ArgumentNullException:
The parameter <i>keyName</i>
 is null.

### RemoveEntry

    public void RemoveEntry(
        string key);

Not documented yet.

<b>Parameters:</b>

 * <i>key</i>: A text string.

<b>Exceptions:</b>

 * System.ArgumentNullException:
The parameter "keyName" is null.

### SetValue

    public void SetValue(
        string keyName,
        string value);

Not documented yet.

<b>Parameters:</b>

 * <i>keyName</i>: A text string.

 * <i>value</i>: Another string object.

<b>Exceptions:</b>

 * System.ArgumentNullException:
The parameter <i>keyName</i>
 is null.

### ToString

    public override string ToString();

Converts this object to a text string.

<b>Returns:</b>

A text string.
