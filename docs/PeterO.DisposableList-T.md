## PeterO.DisposableList<T>

    public sealed class DisposableList<T> :
        System.Collections.Generic.ICollection<T>,
        System.Collections.Generic.IEnumerable<T>,
        System.Collections.Generic.IList<T>,
        System.Collections.IEnumerable,
        System.IDisposable
        where T : System.IDisposableT

Holds a list of disposable objects, which can all be disposed at once when this object is disposed.

### Member Summary
* <code>[Add(T)](#Add_T)</code> - Not documented yet.
* <code>[Clear()](#Clear)</code> - Not documented yet.
* <code>[Contains(T)](#Contains_T)</code> - Not documented yet.
* <code>[CopyTo(PeterO.T&lt;&gt;[], int)](#CopyTo_PeterO_T_int)</code> - Not documented yet.
* <code>[Count](#Count)</code> - Gets a value not documented yet.
* <code>[Dispose()](#Dispose)</code> - Not documented yet.
* <code>[GetEnumerator()](#GetEnumerator)</code> - Not documented yet.
* <code>[IndexOf(T)](#IndexOf_T)</code> - Not documented yet.
* <code>[Insert(int, T)](#Insert_int_T)</code> - Not documented yet.
* <code>[IsReadOnly](#IsReadOnly)</code> - Gets a value indicating whether this list is read only.
* <code>[Remove(T)](#Remove_T)</code> - Not documented yet.
* <code>[RemoveAt(int)](#RemoveAt_int)</code> - Removes an item at a given index from the list.
* <code>[this[int]](#this_int)</code> - Not documented yet.

<b>Parameters:</b>

 * &lt;T&gt;: Any object type that implements IDisposable.

<a id="Void_ctor"></a>
### DisposableList Constructor

    public DisposableList();

Initializes a new instance of the  class.

<a id="Count"></a>
### Count

    public sealed int Count { get; }

Gets a value not documented yet.

<b>Returns:</b>

A value not documented yet.

<a id="IsReadOnly"></a>
### IsReadOnly

    public sealed bool IsReadOnly { get; }

Gets a value indicating whether this list is read only.

<b>Returns:</b>

 `true`  if this list is read only; otherwise,  `false` .

<a id="this_int"></a>
### Item

    public sealed T this[int item] { get; set; }

Not documented yet.

<b>Parameters:</b>

 * <i>item</i>: The parameter  <i>item</i>
 is a 32-bit signed integer.

<b>Return Value:</b>

A T object.

<a id="Add_T"></a>
### Add

    public sealed void Add(
        T item);

Not documented yet.

<b>Parameters:</b>

 * <i>item</i>: The parameter  <i>item</i>
 is a `0 object.

<a id="Clear"></a>
### Clear

    public sealed void Clear();

Not documented yet.

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

<a id="Dispose"></a>
### Dispose

    public sealed void Dispose();

Not documented yet.

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

Not documented yet.

<b>Parameters:</b>

 * <i>index</i>: The parameter  <i>index</i>
 is a 32-bit signed integer.

 * <i>item</i>: The parameter  <i>item</i>
 is a `0 object.

<a id="Remove_T"></a>
### Remove

    public sealed bool Remove(
        T item);

Not documented yet.

<b>Parameters:</b>

 * <i>item</i>: The parameter  <i>item</i>
 is a `0 object.

<b>Return Value:</b>

Either  `true`  or  `false` .

<a id="RemoveAt_int"></a>
### RemoveAt

    public sealed void RemoveAt(
        int index);

Removes an item at a given index from the list.

<b>Parameters:</b>

 * <i>index</i>: Zero-based index into the list.
