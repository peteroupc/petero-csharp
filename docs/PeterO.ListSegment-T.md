## PeterO.ListSegment<T>

    public sealed class ListSegment<T> :
        System.Collections.Generic.ICollection<T>,
        System.Collections.Generic.IEnumerable<T>,
        System.Collections.Generic.IList<T>,
        System.Collections.IEnumerable

Specifies a segment of a list defined by an offset and length. This class cannot be inherited.

### Member Summary
* <code>[Add(T)](#Add_T)</code> - This method is not supported.
* <code>[Clear()](#Clear)</code> - This method is not supported.
* <code>[Contains(T)](#Contains_T)</code> - Not documented yet.
* <code>[CopyTo(PeterO.T&lt;&gt;[], int)](#CopyTo_PeterO_T_int)</code> - Not documented yet.
* <code>[Count](#Count)</code> - Gets a value not documented yet.
* <code>[GetEnumerator()](#GetEnumerator)</code> - Not documented yet.
* <code>[IndexOf(T)](#IndexOf_T)</code> - Not documented yet.
* <code>[Insert(int, T)](#Insert_int_T)</code> - This method is not supported.
* <code>[IsReadOnly](#IsReadOnly)</code> - Gets a value indicating whether this list segment is read only.
* <code>[Remove(T)](#Remove_T)</code> - This method is not supported.
* <code>[RemoveAt(int)](#RemoveAt_int)</code> - This method is not supported.
* <code>[StartIndex](#StartIndex)</code> - Gets the starting index within the underlying list for this list segment.
* <code>[this[int]](#this_int)</code> - Not documented yet.

<b>Parameters:</b>

 * &lt;T&gt;: Any object type.

<a id="Void_ctor_System_Collections_Generic_IList_1_T_Int32_Int32"></a>
### ListSegment Constructor

    public ListSegment(
        System.Collections.Generic.IList<T> list,
        int start,
        int count);

Initializes a new instance of the  class.

<b>Parameters:</b>

 * <i>list</i>: The parameter  <i>list</i>
 is an IList object.

 * <i>start</i>: The parameter  <i>start</i>
 is a 32-bit signed integer.

 * <i>count</i>: The parameter  <i>count</i>
 is a 32-bit signed integer.

<b>Exceptions:</b>

 * System.ArgumentNullException:
The parameter  <i>list</i>
 is null.

<a id="Count"></a>
### Count

    public sealed int Count { get; }

Gets a value not documented yet.

<b>Returns:</b>

A value not documented yet.

<a id="IsReadOnly"></a>
### IsReadOnly

    public sealed bool IsReadOnly { get; }

Gets a value indicating whether this list segment is read only.

The read-only status of the list segment is the same as that of the underlying list. However, operations that would change the list segment's size, such as adding and removing items, are not supported.

<b>Returns:</b>

 `true`  if this list segment is read only; otherwise,  `false` .

<a id="this_int"></a>
### Item

    public sealed T this[int index] { get; set; }

Not documented yet.

<b>Parameters:</b>

 * <i>index</i>: The parameter  <i>index</i>
 is a 32-bit signed integer.

<b>Return Value:</b>

A T object.

<a id="StartIndex"></a>
### StartIndex

    public int StartIndex { get; }

Gets the starting index within the underlying list for this list segment.

<b>Returns:</b>

The starting index within the underlying list for this list segment.

<a id="Add_T"></a>
### Add

    public sealed void Add(
        T item);

This method is not supported.

<b>Parameters:</b>

 * <i>item</i>: The parameter  <i>item</i>
 is a `0 object.

<b>Exceptions:</b>

 * System.NotSupportedException:
Always thrown, because changing the size of a list segment is not supported.

<a id="Clear"></a>
### Clear

    public sealed void Clear();

This method is not supported.

<a id="Contains_T"></a>
### Contains

    public sealed bool Contains(
        T item);

Not documented yet.

<b>Parameters:</b>

 * <i>item</i>: The parameter  <i>item</i>
 is a `0 object.

<b>Return Value:</b>

Either  `true`  or  `false` .

<a id="CopyTo_PeterO_T_int"></a>
### CopyTo

    public sealed void CopyTo(
        PeterO.T<>[] array,
        int arrayIndex);

Not documented yet.

<b>Parameters:</b>

 * <i>array</i>: The parameter  <i>array</i>
 is a `0[] object.

 * <i>arrayIndex</i>: The parameter  <i>arrayIndex</i>
 is a 32-bit signed integer.

<b>Exceptions:</b>

 * System.ArgumentNullException:
The parameter  <i>array</i>
 is null.

 * System.ArgumentException:
Array index and count must fit the bounds of the array.

<a id="GetEnumerator"></a>
### GetEnumerator

    public sealed System.Collections.Generic.IEnumerator<T> GetEnumerator();

Not documented yet.

<b>Return Value:</b>

An IEnumerator(T) object.

<a id="IndexOf_T"></a>
### IndexOf

    public sealed int IndexOf(
        T item);

Not documented yet.

<b>Parameters:</b>

 * <i>item</i>: The parameter  <i>item</i>
 is a `0 object.

<b>Return Value:</b>

A 32-bit signed integer.

<a id="Insert_int_T"></a>
### Insert

    public sealed void Insert(
        int index,
        T item);

This method is not supported.

<b>Parameters:</b>

 * <i>index</i>: The parameter  <i>index</i>
 is a 32-bit signed integer.

 * <i>item</i>: The parameter  <i>item</i>
 is a T object.

<a id="Remove_T"></a>
### Remove

    public sealed bool Remove(
        T item);

This method is not supported.

<b>Parameters:</b>

 * <i>item</i>: The parameter  <i>item</i>
 is a T object.

<b>Return Value:</b>

Either  `true`  or  `false` .

<a id="RemoveAt_int"></a>
### RemoveAt

    public sealed void RemoveAt(
        int index);

This method is not supported.

<b>Parameters:</b>

 * <i>index</i>: The parameter  <i>index</i>
 is a 32-bit signed integer.
