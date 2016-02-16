## PeterO.Png8BitIndexed

    public sealed class Png8BitIndexed

A simple class for encoding PNG image files.

### Png8BitIndexed Constructor

    public Png8BitIndexed(
        int width,
        int height);

Initializes a new instance of the[PeterO.Png8BitIndexed](PeterO.Png8BitIndexed.md) class.

<b>Parameters:</b>

 * <i>width</i>: A 32-bit signed integer.

 * <i>height</i>: Another 32-bit signed integer.

### Height

    public int Height { get; }

Gets a value not documented yet.

<b>Returns:</b>

A value not documented yet.

### Transparent

    public int Transparent { get; set;}

Gets or sets a value not documented yet.

<b>Returns:</b>

A value not documented yet.

### Width

    public int Width { get; }

Gets a value not documented yet.

<b>Returns:</b>

A value not documented yet.

### GetColor

    public byte[] GetColor(
        int index);

Not documented yet.

<b>Parameters:</b>

 * <i>index</i>: A 32-bit signed integer.

<b>Return Value:</b>

A byte array.

### GetFilter

    public byte GetFilter(
        int y);

Not documented yet.

<b>Parameters:</b>

 * <i>y</i>: A 32-bit signed integer.

<b>Return Value:</b>

A Byte object.

### GetPixel

    public int GetPixel(
        int x,
        int y);

Not documented yet.

<b>Parameters:</b>

 * <i>x</i>: Another 32-bit signed integer.

 * <i>y</i>: A 32-bit signed integer. (3).

<b>Return Value:</b>

A 32-bit signed integer.

### Save

    public void Save(
        string filename);

Not documented yet.

<b>Parameters:</b>

 * <i>filename</i>: A text string.

<b>Exceptions:</b>

 * System.ArgumentNullException:
The parameter <i>filename</i>
 is null.

### SetColor

    public void SetColor(
        int index,
        byte[] color);

Not documented yet.

<b>Parameters:</b>

 * <i>index</i>: A 32-bit signed integer.

 * <i>color</i>: A byte array.

<b>Exceptions:</b>

 * System.ArgumentNullException:
The parameter <i>color</i>
 is null.

### SetFilter

    public void SetFilter(
        int y,
        byte filter);

Not documented yet.

<b>Parameters:</b>

 * <i>y</i>: A 32-bit signed integer.

 * <i>filter</i>: A Byte object.

### SetPixel

    public void SetPixel(
        int x,
        int y,
        int pixel);

Not documented yet.

<b>Parameters:</b>

 * <i>x</i>: A 32-bit signed integer.

 * <i>y</i>: Another 32-bit signed integer.

 * <i>pixel</i>: A 32-bit signed integer. (3).
