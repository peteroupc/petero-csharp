## PeterO.Png4BitIndexed

    public sealed class Png4BitIndexed

A simple class for encoding PNG image files.

### Png4BitIndexed Constructor

    public Png4BitIndexed(
        int width,
        int height);

Initializes a new instance of the[PeterO.Png4BitIndexed](PeterO.Png4BitIndexed.md) class.

<b>Parameters:</b>

 * <i>width</i>: A 32-bit signed integer.

 * <i>height</i>: Another 32-bit signed integer.

### Height

    public int Height { get; }

Gets the height of the image.

<b>Returns:</b>

The height of the image.

### Transparent

    public int Transparent { get; set;}

Gets or sets the index of the transparent color.

<b>Returns:</b>

The index of the transparent color.

### Width

    public int Width { get; }

Gets the width of the image.

<b>Returns:</b>

The width of the image.

### GetColor

    public byte[] GetColor(
        int index);

Not documented yet.

<b>Parameters:</b>

 * <i>index</i>: A 32-bit signed integer.

<b>Return Value:</b>

A byte array.

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
