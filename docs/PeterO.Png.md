## PeterO.Png

    public sealed class Png

A simple class for encoding PNG image files.

### Png Constructor

    public Png(
        int width,
        int height);

Initializes a new instance of the  class.

<b>Parameters:</b>

 * <i>width</i>: A 32-bit signed integer.

 * <i>height</i>: A 32-bit signed integer. (2).

### Height

    public int Height { get; }

Gets a value not documented yet.

<b>Returns:</b>

A value not documented yet.

### Width

    public int Width { get; }

Gets a value not documented yet.

<b>Returns:</b>

A value not documented yet.

### GetFilter

    public byte GetFilter(
        int y);

Not documented yet.

<b>Parameters:</b>

 * <i>y</i>: A 32-bit signed integer.

<b>Returns:</b>

A Byte object.

### GetPixel

    public byte[] GetPixel(
        int x,
        int y);

Not documented yet.

<b>Parameters:</b>

 * <i>x</i>: A 32-bit signed integer.

 * <i>y</i>: A 32-bit signed integer. (2).

<b>Returns:</b>

A byte array.

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
        byte r,
        byte g,
        byte b);

Not documented yet.

<b>Parameters:</b>

 * <i>x</i>: A 32-bit signed integer.

 * <i>y</i>: A 32-bit signed integer. (2).

 * <i>r</i>: A Byte object.

 * <i>g</i>: Another Byte object.

 * <i>b</i>: Another Byte object.

### SetPixel

    public void SetPixel(
        int x,
        int y,
        byte r,
        byte g,
        byte b,
        byte a);

Not documented yet.

<b>Parameters:</b>

 * <i>x</i>: A 32-bit signed integer.

 * <i>y</i>: A 32-bit signed integer. (2).

 * <i>r</i>: A Byte object.

 * <i>g</i>: Another Byte object.

 * <i>b</i>: Another Byte object.

 * <i>a</i>: A Byte object. (3).

### SetPixel

    public void SetPixel(
        int x,
        int y,
        byte[] pixel);

Not documented yet.

<b>Parameters:</b>

 * <i>x</i>: A 32-bit signed integer.

 * <i>y</i>: A 32-bit signed integer. (2).

 * <i>pixel</i>: A byte array.

<b>Exceptions:</b>

 * System.ArgumentNullException:
The parameter <i>pixel</i>
 is null.
