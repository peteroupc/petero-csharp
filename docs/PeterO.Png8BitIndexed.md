## PeterO.Png8BitIndexed

    public sealed class Png8BitIndexed

A simple class for encoding PNG image files.

### Member Summary
* <code>[GetColor(int)](#GetColor_int)</code> - Not documented yet.
* <code>[GetFilter(int)](#GetFilter_int)</code> - Not documented yet.
* <code>[GetPixel(int, int)](#GetPixel_int_int)</code> - Not documented yet.
* <code>[Height](#Height)</code> - Gets a value not documented yet.
* <code>[Save(string)](#Save_string)</code> - Not documented yet.
* <code>[SetColor(int, byte[])](#SetColor_int_byte)</code> - Not documented yet.
* <code>[SetFilter(int, byte)](#SetFilter_int_byte)</code> - Not documented yet.
* <code>[SetPixel(int, int, int)](#SetPixel_int_int_int)</code> - Not documented yet.
* <code>[Transparent](#Transparent)</code> - Gets or sets a value not documented yet.
* <code>[Width](#Width)</code> - Gets a value not documented yet.

<a id="Void_ctor_Int32_Int32"></a>
### Png8BitIndexed Constructor

    public Png8BitIndexed(
        int width,
        int height);

Initializes a new instance of the [PeterO.Png8BitIndexed](PeterO.Png8BitIndexed.md) class.

<b>Parameters:</b>

 * <i>width</i>: The parameter  <i>width</i>
 is a 32-bit signed integer.

 * <i>height</i>: The parameter  <i>height</i>
 is a 32-bit signed integer.

<a id="Height"></a>
### Height

    public int Height { get; }

Gets a value not documented yet.

<b>Returns:</b>

A value not documented yet.

<a id="Transparent"></a>
### Transparent

    public int Transparent { get; set; }

Gets or sets a value not documented yet.

<b>Returns:</b>

A value not documented yet.

<a id="Width"></a>
### Width

    public int Width { get; }

Gets a value not documented yet.

<b>Returns:</b>

A value not documented yet.

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

<a id="GetFilter_int"></a>
### GetFilter

    public byte GetFilter(
        int y);

Not documented yet.

<b>Parameters:</b>

 * <i>y</i>: The parameter  <i>y</i>
 is a 32-bit signed integer.

<b>Return Value:</b>

A byte (from 0 to 255).

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

<a id="SetFilter_int_byte"></a>
### SetFilter

    public void SetFilter(
        int y,
        byte filter);

Not documented yet.

<b>Parameters:</b>

 * <i>y</i>: The parameter  <i>y</i>
 is a 32-bit signed integer.

 * <i>filter</i>: The parameter  <i>filter</i>
 is a byte (from 0 to 255).

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
