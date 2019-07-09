## PeterO.CulturedText

    public static class CulturedText

Contains string processing operations that should be formatted according to the current locale's formatting rules.

This class, along with the InvariantText class, supports the correct use f string functions in the framework. InvariantText is intended for use in ocale-independent string processing, such as data and file system rocessing, while CulturedText is intended for text display. Use ulturedText for formatting the messages of exceptions and within the onsole.Write method.

### Compare

    public static int Compare(
        string value1,
        string value2);

Compares a text string with a string.

<b>Parameters:</b>

 * <i>value1</i>: The parameter  <i>value1</i>
 is a text string.

 * <i>value2</i>: The parameter  <i>value2</i>
 is a text string.

<b>Return Value:</b>

A 32-bit signed integer.

### CompareIgnoreCase

    public static int CompareIgnoreCase(
        string value1,
        string value2);

Not documented yet.

<b>Parameters:</b>

 * <i>value1</i>: The parameter  <i>value1</i>
 is a text string.

 * <i>value2</i>: The parameter  <i>value2</i>
 is a text string.

<b>Return Value:</b>

A 32-bit signed integer.

### EndsWith

    public static bool EndsWith(
        string value1,
        string value2);

Not documented yet.

<b>Parameters:</b>

 * <i>value1</i>: The parameter  <i>value1</i>
 is a text string.

 * <i>value2</i>: The parameter  <i>value2</i>
 is a text string.

<b>Return Value:</b>

Either  `true`  or  `false` .

<b>Exceptions:</b>

 * System.ArgumentNullException:
The parameter <i>value1</i>
 is null.

### Format

    public static string Format(
        string formattedText,
        params object[] options);

Not documented yet.

<b>Parameters:</b>

 * <i>formattedText</i>: The parameter  <i>formattedText</i>
 is a text string.

 * <i>options</i>: The parameter  <i>options</i>
 is a params object.

<b>Return Value:</b>

A text string.

### ParseInt32

    public static int ParseInt32(
        string value);

Not documented yet.

<b>Parameters:</b>

 * <i>value</i>: The parameter  <i>value</i>
 is a text string.

<b>Return Value:</b>

A 32-bit signed integer.

### ParseInt32Hex

    public static int ParseInt32Hex(
        string value);

Not documented yet.

<b>Parameters:</b>

 * <i>value</i>: The parameter  <i>value</i>
 is a text string.

<b>Return Value:</b>

A 32-bit signed integer.

### StartsWith

    public static bool StartsWith(
        string value1,
        string value2);

Not documented yet.

<b>Parameters:</b>

 * <i>value1</i>: The parameter  <i>value1</i>
 is a text string.

 * <i>value2</i>: The parameter  <i>value2</i>
 is a text string.

<b>Return Value:</b>

Either  `true`  or  `false` .

<b>Exceptions:</b>

 * System.ArgumentNullException:
The parameter <i>value1</i>
 is null.

### ToString

    public static string ToString(
        byte value);

Converts this object to a text string.

<b>Parameters:</b>

 * <i>value</i>: The parameter  <i>value</i>
 is a byte (from 0 to 255).

<b>Return Value:</b>

A text string.

### ToString

    public static string ToString(
        double value);

Converts this object to a text string.

<b>Parameters:</b>

 * <i>value</i>: The parameter  <i>value</i>
 is a 64-bit floating-point number.

<b>Return Value:</b>

A text string.

### ToString

    public static string ToString(
        float value);

Converts this object to a text string.

<b>Parameters:</b>

 * <i>value</i>: The parameter  <i>value</i>
 is a 32-bit floating-point number.

<b>Return Value:</b>

A text string.

### ToString

    public static string ToString(
        int value);

Converts this object to a text string.

<b>Parameters:</b>

 * <i>value</i>: The parameter  <i>value</i>
 is a 32-bit signed integer.

<b>Return Value:</b>

A text string.

### ToString

    public static string ToString(
        long value);

Converts this object to a text string.

<b>Parameters:</b>

 * <i>value</i>: The parameter  <i>value</i>
 is a 64-bit signed integer.

<b>Return Value:</b>

A text string.

### ToString

    public static string ToString(
        object value);

Converts this object to a text string.

<b>Parameters:</b>

 * <i>value</i>: The parameter  <i>value</i>
 is an arbitrary object.

<b>Return Value:</b>

A text string.

### ToString

    public static string ToString(
        short value);

Converts this object to a text string.

<b>Parameters:</b>

 * <i>value</i>: The parameter  <i>value</i>
 is a 16-bit signed integer.

<b>Return Value:</b>

A text string.
