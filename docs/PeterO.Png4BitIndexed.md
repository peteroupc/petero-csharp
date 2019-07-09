## PeterO.Png4BitIndexed

    public sealed class Png4BitIndexed

A simple class for encoding PNG image files.

### Member Summary
* <code>[GetColor(int)](#GetColor_int)</code> - Not documented yet.
* <code>[GetPixel(int, int)](#GetPixel_int_int)</code> - Not documented yet.
* <code>[Height](#Height)</code> - Gets the height of the image.
* <code>[Save(string)](#Save_string)</code> - Not documented yet.
* <code>[SetColor(int, byte[])](#SetColor_int_byte)</code> - Not documented yet.
* <code>[SetPixel(int, int, int)](#SetPixel_int_int_int)</code> - Not documented yet.
* <code>[Transparent](#Transparent)</code> - Gets or sets the index of the transparent color.
* <code>[Width](#Width)</code> - Gets the width of the image.

<a id="Void_ctor_Int32_Int32"></a>
### Png4BitIndexed Constructor

    public Png4BitIndexed(
        int width,
        int height);

Initializes a new instance of the [PeterO.Png4BitIndexed](PeterO.Png4BitIndexed.md) class.

<b>Parameters:</b>

 * <i>width</i>: The parameter  <i>width</i>
 is a 32-bit signed integer.

 * <i>height</i>: The parameter  <i>height</i>
 is a 32-bit signed integer.

<a id="Height"></a>
### Height

    public int Height { get; }

Gets the height of the image.

<b>Returns:</b>

The height of the image.

<a id="Transparent"></a>
### Transparent

    public int Transparent { get; set; }

Gets or sets the index of the transparent color.

<b>Returns:</b>

The index of the transparent color.

<a id="Width"></a>
### Width

    public int Width { get; }

Gets the width of the image.

<b>Returns:</b>

The width of the image.

<a id="GetColor_int"></a>
### GetColor

    public byte[] GetColor(
        int index);

Not documented yet.

<b>Parameters:</b>

 * <i>index</i>: The parameter  <i>index</i>
 is a 32-bit signed integer.

<b>Return Value:</b>

A byte array.

<a id="GetPixel_int_int"></a>
### GetPixel

    public int GetPixel(
        int x,
        int y);

Not documented yet.

<b>Parameters:</b>

 * <i>x</i>: The parameter  <i>x</i>
 is a 32-bit signed integer.

 * <i>y</i>: The parameter  <i>y</i>
 is a 32-bit signed integer.

<b>Return Value:</b>

A 32-bit signed integer.

<a id="Save_string"></a>
### Save

    public void Save(
        string filename);

Not documented yet.

<b>Parameters:</b>

 * <i>filename</i>: The parameter  <i>filename</i>
 is a text string.

<b>Exceptions:</b>

 * System.ArgumentNullException:
The parameter  <i>filename</i>
 is null.

<a id="SetColor_int_byte"></a>
### SetColor

    public void SetColor(
        int index,
        byte[] color);

Not documented yet.

<b>Parameters:</b>

 * <i>index</i>: The parameter  <i>index</i>
 is a 32-bit signed integer.

 * <i>color</i>: The parameter  <i>color</i>
 is a.Byte[] object.

<b>Exceptions:</b>

 * System.ArgumentNullException:
The parameter  <i>color</i>
 is null.

 * System.ArgumentException:
The parameter  <i>color</i>
 must have length 3 or more.

<a id="SetPixel_int_int_int"></a>
### SetPixel

    public void SetPixel(
        int x,
        int y,
        int pixel);

Not documented yet.

<b>Parameters:</b>

 * <i>x</i>: The parameter  <i>x</i>
 is a 32-bit signed integer.

 * <i>y</i>: The parameter  <i>y</i>
 is a 32-bit signed integer.

 * <i>pixel</i>: The parameter  <i>pixel</i>
 is a 32-bit signed integer.
