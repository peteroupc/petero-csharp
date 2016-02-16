## PeterO.InvariantText

    public static class InvariantText

Contains string processing operations that should be consistent regardless of locale. This class, along with the CulturedText class, supports the correct use of string functions in the framework. InvariantText is intended for use in locale-independent string processing, such as data and file system processing, while CulturedText is intended for text display.

### Compare

    public static int Compare(
        string value1,
        string value2);

Compares a text string with a string.

<b>Parameters:</b>

 * <i>value1</i>: A text string.

 * <i>value2</i>: Another string object.

<b>Return Value:</b>

A 32-bit signed integer.

### CompareIgnoreCase

    public static int CompareIgnoreCase(
        string value1,
        string value2);

Not documented yet.

<b>Parameters:</b>

 * <i>value1</i>: A text string.

 * <i>value2</i>: Another string object.

<b>Return Value:</b>

A 32-bit signed integer.

### EndsWith

    public static bool EndsWith(
        string value1,
        string value2);

Not documented yet.

<b>Parameters:</b>

 * <i>value1</i>: A text string.

 * <i>value2</i>: Another string object.

<b>Return Value:</b>

A Boolean object.

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

 * <i>formattedText</i>: Another string object.

 * <i>options</i>: A params object.

<b>Return Value:</b>

A text string.

### ParseInt32

    public static int ParseInt32(
        string value);

Not documented yet.

<b>Parameters:</b>

 * <i>value</i>: A text string.

<b>Return Value:</b>

A 32-bit signed integer.

### ParseInt32Hex

    public static int ParseInt32Hex(
        string value);

Not documented yet.

<b>Parameters:</b>

 * <i>value</i>: A text string.

<b>Return Value:</b>

A 32-bit signed integer.

### StartsWith

    public static bool StartsWith(
        string value1,
        string value2);

Not documented yet.

<b>Parameters:</b>

 * <i>value1</i>: A text string.

 * <i>value2</i>: Another string object.

<b>Return Value:</b>

A Boolean object.

<b>Exceptions:</b>

 * System.ArgumentNullException:
The parameter <i>value1</i>
 is null.

### ToString

    public static string ToString(
        byte value);

Converts this object to a text string.

<b>Parameters:</b>

 * <i>value</i>: A Byte object.

<b>Return Value:</b>

A text string.

### ToString

    public static string ToString(
        double value);

Converts this object to a text string.

<b>Parameters:</b>

 * <i>value</i>: A 64-bit floating-point number.

<b>Return Value:</b>

A text string.

### ToString

    public static string ToString(
        float value);

Converts this object to a text string.

<b>Parameters:</b>

 * <i>value</i>: A 32-bit floating-point number.

<b>Return Value:</b>

A text string.

### ToString

    public static string ToString(
        int value);

Converts this object to a text string.

<b>Parameters:</b>

 * <i>value</i>: A 32-bit signed integer.

<b>Return Value:</b>

A text string.

### ToString

    public static string ToString(
        long value);

Converts this object to a text string.

<b>Parameters:</b>

 * <i>value</i>: A 64-bit signed integer.

<b>Return Value:</b>

A text string.

### ToString

    public static string ToString(
        object value);

Converts this object to a text string.

<b>Parameters:</b>

 * <i>value</i>: An arbitrary object.

<b>Return Value:</b>

A text string.

### ToString

    public static string ToString(
        short value);

Converts this object to a text string.

<b>Parameters:</b>

 * <i>value</i>: A 16-bit signed integer.

<b>Return Value:</b>

A text string.
