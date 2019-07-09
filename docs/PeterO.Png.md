## PeterO.Png

    public sealed class Png

A simple class for encoding PNG image files.

### Member Summary
* <code>[GetFilter(int)](#GetFilter_int)</code> - Not documented yet.
* <code>[GetPixel(int, int)](#GetPixel_int_int)</code> - Not documented yet.
* <code>[Height](#Height)</code> - Gets a value not documented yet.
* <code>[Save(string)](#Save_string)</code> - Not documented yet.
* <code>[SetFilter(int, byte)](#SetFilter_int_byte)</code> - Not documented yet.
* <code>[SetPixel(int, int, byte[])](#SetPixel_int_int_byte)</code> - Sets the pixel.
* <code>[SetPixel(int, int, byte, byte, byte)](#SetPixel_int_int_byte_byte_byte)</code> - Not documented yet.
* <code>[SetPixel(int, int, byte, byte, byte, byte)](#SetPixel_int_int_byte_byte_byte_byte)</code> - Not documented yet.
* <code>[Width](#Width)</code> - Gets a value not documented yet.

<a id="Void_ctor_Int32_Int32"></a>
### Png Constructor

    public Png(
        int width,
        int height);

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

<a id="Width"></a>
### Width

    public int Width { get; }

Gets a value not documented yet.

<b>Returns:</b>

A value not documented yet.

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

    public byte[] GetPixel(
        int x,
        int y);

Not documented yet.

<b>Parameters:</b>

 * <i>x</i>: The parameter  <i>x</i>
 is a 32-bit signed integer.

 * <i>y</i>: The parameter  <i>y</i>
 is a 32-bit signed integer.

<b>Return Value:</b>

A byte array.

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

<a id="SetPixel_int_int_byte_byte_byte"></a>
### SetPixel

    public void SetPixel(
        int x,
        int y,
        byte r,
        byte g,
        byte b);

Not documented yet.

<b>Parameters:</b>

 * <i>x</i>: The parameter  <i>x</i>
 is a 32-bit signed integer.

 * <i>y</i>: The parameter  <i>y</i>
 is a 32-bit signed integer.

 * <i>r</i>: The parameter  <i>r</i>
 is a byte (from 0 to 255).

 * <i>g</i>: The parameter  <i>g</i>
 is a byte (from 0 to 255).

 * <i>b</i>: The parameter  <i>b</i>
 is a byte (from 0 to 255).

<a id="SetPixel_int_int_byte_byte_byte_byte"></a>
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

 * <i>x</i>: The parameter  <i>x</i>
 is a 32-bit signed integer.

 * <i>y</i>: The parameter  <i>y</i>
 is a 32-bit signed integer.

 * <i>r</i>: The parameter  <i>r</i>
 is a byte (from 0 to 255).

 * <i>g</i>: The parameter  <i>g</i>
 is a byte (from 0 to 255).

 * <i>b</i>: The parameter  <i>b</i>
 is a byte (from 0 to 255).

 * <i>a</i>: The parameter  <i>a</i>
 is a byte (from 0 to 255).

<a id="SetPixel_int_int_byte"></a>
### SetPixel

    public void SetPixel(
        int x,
        int y,
        byte[] pixel);

Sets the pixel.

<b>Parameters:</b>

 * <i>x</i>: The x coordinate.

 * <i>y</i>: The y coordinate.

 * <i>pixel</i>: The parameter  <i>pixel</i>
 is a.Byte[] object.

<b>Exceptions:</b>

 * System.ArgumentNullException:
The parameter  <i>pixel</i>
 is null.

 * System.ArgumentException:
The parameter  <i>pixel</i>
 has an improper length.
