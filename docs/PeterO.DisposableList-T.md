## PeterO.DisposableList<T>

    public sealed class DisposableList<T> :
        System.Collections.Generic.IList<T>,
        System.Collections.Generic.ICollection<T>,
        System.Collections.Generic.IEnumerable<T>,
        System.Collections.IEnumerable,
        System.IDisposable
        where T : System.IDisposableT

Holds a list of disposable objects, which can all be disposed at once when this object is disposed.

<b>Parameters:</b>

 * &lt;T&gt;: Any object type that implements IDisposable.

### DisposableList Constructor

    public DisposableList();

Initializes a new instance of the class.

### Count

    public sealed int Count { get; }

Gets a value not documented yet.

<b>Returns:</b>

A value not documented yet.

### IsReadOnly

    public sealed bool IsReadOnly { get; }

Gets a value indicating whether this list is read only.

<b>Returns:</b>

 `true`  If this list is read only; otherwise,. `false` .

### Add

    public sealed void Add(
        T item);

Not documented yet.

<b>Parameters:</b>

 * <i>item</i>: A T object.

### Clear

    public sealed void Clear();

Not documented yet.

### Contains

    public sealed bool Contains(
        T item);

Not documented yet.

<b>Parameters:</b>

 * <i>item</i>: A T object.

<b>Return Value:</b>

A Boolean object.

### Dispose

    public sealed void Dispose();

Not documented yet.

### GetEnumerator

    public sealed System.Collections.Generic.IEnumerator<T> GetEnumerator();

Not documented yet.

<b>Return Value:</b>

An IEnumerator(T) object.

### IndexOf

    public sealed int IndexOf(
        T item);

Not documented yet.

<b>Parameters:</b>

 * <i>item</i>: A T object.

<b>Return Value:</b>

A 32-bit signed integer.

### Insert

    public sealed void Insert(
        int index,
        T item);

Not documented yet.

<b>Parameters:</b>

 * <i>index</i>: Zero-based index into the list.

 * <i>item</i>: A T object.

### Remove

    public sealed bool Remove(
        T item);

Not documented yet.

<b>Parameters:</b>

 * <i>item</i>: A T object.

<b>Return Value:</b>

A Boolean object.

### RemoveAt

    public sealed void RemoveAt(
        int index);

Removes an item at a given index from the list.

<b>Parameters:</b>

 * <i>index</i>: Zero-based index into the list.
