## PeterO.DisposableLists

    public static class DisposableLists

Not documented yet.

### Create

    public static PeterO.DisposableList Create();

Not documented yet.

<b>Return Value:</b>

A DisposableList(IDisposable) object.

### Create

    public static PeterO.DisposableList<T> Create<T>(
        T obj)
        where T : System.IDisposableT;

Not documented yet.

<b>Parameters:</b>

 * <i>obj</i>: A T object.

 * &lt;T&gt;: Any object type that implements IDisposable.

<b>Return Value:</b>

A DisposableList(T) object.
