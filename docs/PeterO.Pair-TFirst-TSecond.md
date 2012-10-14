## PeterO.Pair<TFirst, TSecond>

    public sealed class Pair<TFirst, TSecond> :
        System.IEquatable<PeterO.Pair<TFirst, TSecond>>

Stores a pair of related objects.

<b>Parameters:</b>

 * &lt;TFirst&gt;: Object type for the first object in the pair.

 * &lt;TSecond&gt;: Object type for the second object in the pair.

### Pair Constructor

    public Pair(
        TFirst first,
        TSecond second);

Initializes a new instance of the  class.

<b>Parameters:</b>

 * <i>first</i>: A TFirst object.

 * <i>second</i>: A TSecond object.

### First

    public TFirst First { get; }

Gets the first object in the pair.

<b>Returns:</b>

The first object in the pair.

### Second

    public TSecond Second { get; }

Gets the second object in the pair.

<b>Returns:</b>

The second object in the pair.

<b>Returns:</b>

A TSecond object.

### Equals

    public override bool Equals(
        object obj);

Determines whether this object and another object are equal.

<b>Parameters:</b>

 * <i>obj</i>: An arbitrary object.

<b>Returns:</b>

True if this object and another object are equal; otherwise, false.

### GetHashCode

    public override int GetHashCode();

Returns the hash code for this instance.

<b>Returns:</b>

A 32-bit signed integer.

### ToString

    public override string ToString();

Converts this object to a text string.

<b>Returns:</b>

A text string.
