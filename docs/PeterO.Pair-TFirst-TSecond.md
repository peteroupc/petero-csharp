## PeterO.Pair<TFirst, TSecond>

    public sealed class Pair<TFirst, TSecond> :
        System.IEquatable<PeterO.Pair<TFirst, TSecond>>

Stores a pair of related objects.

### Member Summary
* <code>[Equals(object)](#Equals_object)</code> - Determines whether this object and another object are equal.
* <code>[Equals(PeterO.Pair&lt;TFirst, TSecond&gt;)](#Equals_PeterO_Pair_TFirst_TSecond)</code> - Not documented yet.
* <code>[First](#First)</code> - Gets the first object in the pair.
* <code>[GetHashCode()](#GetHashCode)</code> - Returns the hash code for this instance.
* <code>[Second](#Second)</code> - Gets the second object in the pair.
* <code>[ToString()](#ToString)</code> - Converts this object to a text string.

<b>Parameters:</b>

 * &lt;TFirst&gt;: Object type for the first object in the pair.

 * &lt;TSecond&gt;: Object type for the second object in the pair.

<a id="Void_ctor_TFirst_TSecond"></a>
### Pair Constructor

    public Pair(
        TFirst first,
        TSecond second);

<b>Parameters:</b>

 * <i>first</i>: The parameter  <i>first</i>
 is a TFirst object.

 * <i>second</i>: The parameter  <i>second</i>
 is a TSecond object.

<a id="First"></a>
### First

    public TFirst First { get; }

Gets the first object in the pair.

<b>Returns:</b>

The first object in the pair.

<a id="Second"></a>
### Second

    public TSecond Second { get; }

Gets the second object in the pair.

<b>Returns:</b>

The second object in the pair.

<b>Return Value:</b>

A TSecond object.

<a id="Equals_object"></a>
### Equals

    public override bool Equals(
        object obj);

Determines whether this object and another object are equal.

<b>Parameters:</b>

 * <i>obj</i>: The parameter  <i>obj</i>
 is an arbitrary object.

<b>Return Value:</b>

 `true`  if this object and another object are equal; otherwise,  `false` .

<a id="Equals_PeterO_Pair_TFirst_TSecond"></a>
### Equals

    public sealed bool Equals(
        PeterO.Pair<TFirst, TSecond> other);

Not documented yet.

<b>Parameters:</b>

 * <i>other</i>: The parameter  <i>other</i>
 is a.Pair{`0 object.

<b>Return Value:</b>

Either  `true`  or  `false` .

<a id="GetHashCode"></a>
### GetHashCode

    public override int GetHashCode();

Returns the hash code for this instance.

<b>Return Value:</b>

A 32-bit signed integer.

<a id="ToString"></a>
### ToString

    public override string ToString();

Converts this object to a text string.

<b>Return Value:</b>

A text string.
