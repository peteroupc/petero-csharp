## PeterO.DisposableLists

    public static class DisposableLists

Not documented yet.

### Member Summary
* <code>[Create()](#Create)</code> - Not documented yet.
* <code>[Create&lt;T&gt;(T) where T : System.IDisposableT](#Create_T_T_where_T_System_IDisposableT)</code> - Not documented yet.

<a id="Create"></a>
### Create

    public static PeterO.DisposableList Create();

Not documented yet.

<b>Return Value:</b>

A DisposableList(IDisposable) object.

<a id="Create_T_T_where_T_System_IDisposableT"></a>
### Create

    public static PeterO.DisposableList<T> Create<T>(
        T obj)
        where T : System.IDisposableT;

Not documented yet.

<b>Parameters:</b>

 * <i>obj</i>: The parameter  <i>obj</i>
 is a T object.

 * &lt;T&gt;: Any object type that implements IDisposable.

<b>Return Value:</b>

A DisposableList(T) object.
