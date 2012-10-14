## PeterO.ListSegment<T>

    public sealed class ListSegment<T> :
        System.Collections.Generic.IList<T>,
        System.Collections.Generic.ICollection<T>,
        System.Collections.Generic.IEnumerable<T>,
        System.Collections.IEnumerable

Specifies a segment of a list defined by an offset and length. This class cannot be inherited.

<b>Parameters:</b>

 * &lt;T&gt;: Any object type.

### ListSegment Constructor

    public ListSegment(
        System.Collections.Generic.IList<T> list,
        int start,
        int count);

### Count

    public sealed int Count { get; }

Gets a value not documented yet.

<b>Returns:</b>

A value not documented yet.

### IsReadOnly

    public sealed bool IsReadOnly { get; }

Gets a value indicating whether this list segment is read only.

The read-only status of the list segment is the same as that of the underlying list. However, operations that would change the list segment's size, such as adding and removing items, are not supported.

<b>Returns:</b>

True if this list segment is read only; otherwise, false.

### StartIndex

    public int StartIndex { get; }

Gets the starting index within the underlying list for this list segment.

<b>Returns:</b>

The starting index within the underlying list for this list segment.

### Add

    public sealed void Add(
        T item);

This method is not supported.

<b>Parameters:</b>

 * <i>item</i>: The parameter  <i>item</i>
 is not documented yet.

<b>Exceptions:</b>

 * System.NotSupportedException:
Always thrown, because changing the size of a list segment is not supported.

### Clear

    public sealed void Clear();

This method is not supported.

<b>Exceptions:</b>

 * System.NotSupportedException:
Always thrown, because changing the size of a list segment is not supported.

### Contains

    public sealed bool Contains(
        T item);

Not documented yet.

<b>Parameters:</b>

 * <i>item</i>: A T object.

<b>Returns:</b>

A Boolean object.

### GetEnumerator

    public sealed System.Collections.Generic.IEnumerator<T> GetEnumerator();

Not documented yet.

<b>Returns:</b>

An IEnumerator(T) object.

### IndexOf

    public sealed int IndexOf(
        T item);

Not documented yet.

<b>Parameters:</b>

 * <i>item</i>: A T object.

<b>Returns:</b>

A 32-bit signed integer.

### Insert

    public sealed void Insert(
        int index,
        T item);

This method is not supported.

<b>Parameters:</b>

 * <i>index</i>: A 32-bit signed integer.

 * <i>item</i>: A T object.

<b>Exceptions:</b>

 * System.NotSupportedException:
Always thrown, because changing the size of a list segment is not supported.

### Remove

    public sealed bool Remove(
        T item);

This method is not supported.

<b>Parameters:</b>

 * <i>item</i>: A T object.

<b>Returns:</b>

A Boolean object.

<b>Exceptions:</b>

 * System.NotSupportedException:
Always thrown, because changing the size of a list segment is not supported.

### RemoveAt

    public sealed void RemoveAt(
        int index);

This method is not supported.

<b>Parameters:</b>

 * <i>index</i>: A 32-bit signed integer.

<b>Exceptions:</b>

 * System.NotSupportedException:
Always thrown, because changing the size of a list segment is not supported.
