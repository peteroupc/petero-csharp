## PeterO.Util

    public static class Util

Not documented yet.

### Member Summary
* <code>[AddIfMissing&lt;T&gt;(this System.Collections.Generic.IList&lt;T&gt;, T)](#AddIfMissing_T_this_System_Collections_Generic_IList_T_T)</code> - Not documented yet.
* <code>[AddIfMissing&lt;TKey, TValue&gt;(this System.Collections.Generic.IDictionary&lt;TKey, TValue&gt;, TKey, TValue)](#AddIfMissing_TKey_TValue_this_System_Collections_Generic_IDictionary_TKey_TValue_TKey_TValue)</code> - Adds if missing.
* <code>[AddOverwrite&lt;TKey, TValue&gt;(this System.Collections.Generic.IDictionary&lt;TKey, TValue&gt;, TKey, TValue)](#AddOverwrite_TKey_TValue_this_System_Collections_Generic_IDictionary_TKey_TValue_TKey_TValue)</code> - Adds the overwrite.
* <code>[AllSame&lt;T&gt;(this System.Collections.Generic.IEnumerable&lt;T&gt;)](#AllSame_T_this_System_Collections_Generic_IEnumerable_T)</code> - Not documented yet.
* <code>[AllSame&lt;TContainer, TItem&gt;(this System.Collections.Generic.IEnumerable&lt;TContainer&gt;, System.Func&lt;TContainer, TItem&gt;)](#AllSame_TContainer_TItem_this_System_Collections_Generic_IEnumerable_TContainer_System_Func_TContainer_TItem)</code> - Not documented yet.
* <code>[ArrayToString&lt;T&gt;(this System.Collections.Generic.IEnumerable&lt;T&gt;)](#ArrayToString_T_this_System_Collections_Generic_IEnumerable_T)</code> - Not documented yet.
* <code>[CopyStream(this System.IO.Stream, int, System.IO.Stream)](#CopyStream_this_System_IO_Stream_int_System_IO_Stream)</code> - Copies a certain number of bytes from one stream to another.
* <code>[CopyStream(this System.IO.Stream, System.IO.Stream)](#CopyStream_this_System_IO_Stream_System_IO_Stream)</code> - Copies all bytes from one stream to another.
* <code>[CopyStructure&lt;T&gt;(this T) where T : new(), PeterO.IStructureT](#CopyStructure_T_this_T_where_T_new_PeterO_IStructureT)</code> - Not documented yet.
* <code>[EachWithIndex&lt;T&gt;(this System.Collections.Generic.IEnumerable&lt;T&gt;)](#EachWithIndex_T_this_System_Collections_Generic_IEnumerable_T)</code> - Not documented yet.
* <code>[GetSegment&lt;T&gt;(this System.Collections.Generic.IList&lt;T&gt;, int)](#GetSegment_T_this_System_Collections_Generic_IList_T_int)</code> - Not documented yet.
* <code>[GetSegment&lt;T&gt;(this System.Collections.Generic.IList&lt;T&gt;, int, int)](#GetSegment_T_this_System_Collections_Generic_IList_T_int_int)</code> - Not documented yet.
* <code>[HasUnique&lt;T&gt;(this System.Collections.Generic.IEnumerable&lt;T&gt;)](#HasUnique_T_this_System_Collections_Generic_IEnumerable_T)</code> - Not documented yet.
* <code>[HasUnique&lt;TContainer, TItem&gt;(this System.Collections.Generic.IEnumerable&lt;TContainer&gt;, System.Func&lt;TContainer, TItem&gt;)](#HasUnique_TContainer_TItem_this_System_Collections_Generic_IEnumerable_TContainer_System_Func_TContainer_TItem)</code> - Not documented yet.
* <code>[Implode&lt;T&gt;(this System.Collections.Generic.IEnumerable&lt;T&gt;, string)](#Implode_T_this_System_Collections_Generic_IEnumerable_T_string)</code> - Not documented yet.
* <code>[IndexOf&lt;T&gt;(this System.Collections.Generic.IList&lt;T&gt;, System.Predicate&lt;T&gt;)](#IndexOf_T_this_System_Collections_Generic_IList_T_System_Predicate_T)</code> - Not documented yet.
* <code>[IndexOf&lt;T&gt;(this System.Collections.Generic.IList&lt;T&gt;, T)](#IndexOf_T_this_System_Collections_Generic_IList_T_T)</code> - Not documented yet.
* <code>[MakePair&lt;TFirst, TSecond&gt;(TFirst, TSecond)](#MakePair_TFirst_TSecond_TFirst_TSecond)</code> - Not documented yet.
* <code>[MaxOrDefault&lt;T&gt;(this System.Collections.Generic.IEnumerable&lt;T&gt;) where T : System.IComparable&lt;T&gt;T](#MaxOrDefault_T_this_System_Collections_Generic_IEnumerable_T_where_T_System_IComparable_T_T)</code> - Not documented yet.
* <code>[MinOrDefault&lt;T&gt;(this System.Collections.Generic.IEnumerable&lt;T&gt;) where T : System.IComparable&lt;T&gt;T](#MinOrDefault_T_this_System_Collections_Generic_IEnumerable_T_where_T_System_IComparable_T_T)</code> - Not documented yet.
* <code>[public static readonly System.IDisposable NullDisposable;](#NullDisposable)</code> - An IDisposable object that does nothing when disposed.
* <code>[RemoveAll&lt;T&gt;(this System.Collections.Generic.IList&lt;T&gt;, System.Predicate&lt;T&gt;)](#RemoveAll_T_this_System_Collections_Generic_IList_T_System_Predicate_T)</code> - Not documented yet.
* <code>[SetIfMissing&lt;T&gt;(this System.Collections.Generic.IList&lt;T&gt;, int, System.Func&lt;T&gt;)](#SetIfMissing_T_this_System_Collections_Generic_IList_T_int_System_Func_T)</code> - Not documented yet.
* <code>[SetIfMissing&lt;T&gt;(this System.Collections.Generic.IList&lt;T&gt;, int, T)](#SetIfMissing_T_this_System_Collections_Generic_IList_T_int_T)</code> - Not documented yet.
* <code>[SetNewIfMissing&lt;T&gt;(this System.Collections.Generic.IList&lt;T&gt;, int) where T : new()T](#SetNewIfMissing_T_this_System_Collections_Generic_IList_T_int_where_T_newT)</code> - Not documented yet.
* <code>[SetValue&lt;T&gt;(this System.Collections.Generic.IList&lt;T&gt;, int, T)](#SetValue_T_this_System_Collections_Generic_IList_T_int_T)</code> - Not documented yet.
* <code>[StructureSize(this PeterO.IStructure)](#StructureSize_this_PeterO_IStructure)</code> - Not documented yet.
* <code>[Sum&lt;T&gt;(this System.Collections.Generic.IEnumerable&lt;T&gt;, System.Func&lt;T, int&gt;)](#Sum_T_this_System_Collections_Generic_IEnumerable_T_System_Func_T_int)</code> - Not documented yet.
* <code>[Transform&lt;TInput, TOutput&gt;(this System.Collections.Generic.IEnumerable&lt;TInput&gt;, System.Func&lt;TInput, TOutput&gt;)](#Transform_TInput_TOutput_this_System_Collections_Generic_IEnumerable_TInput_System_Func_TInput_TOutput)</code> - Not documented yet.
* <code>[UpToExcluding(this int, int)](#UpToExcluding_this_int_int)</code> - Creates an iterator of integers starting at a minimum value and ending at one less than the maximum.
* <code>[UpToIncluding(this int, int)](#UpToIncluding_this_int_int)</code> - Not documented yet.
* <code>[ValueOrDefault&lt;T&gt;(this System.Collections.Generic.IList&lt;T&gt;, int)](#ValueOrDefault_T_this_System_Collections_Generic_IList_T_int)</code> - Not documented yet.

<a id="NullDisposable"></a>
### NullDisposable

    public static readonly System.IDisposable NullDisposable;

An IDisposable object that does nothing when disposed.

<a id="AddIfMissing_T_this_System_Collections_Generic_IList_T_T"></a>
### AddIfMissing

    public static void AddIfMissing<T>(
        this System.Collections.Generic.IList<T> dict,
        T value);

Not documented yet. In the.NET implementation, this method is implemented as an extension method to any object implementing IList and can be called as follows:  `dict.AddIfMissing<T>(value)` . If the object's class already has a AddIfMissing<T> method with the same parameters, that method takes precedence over this extension method.

In the.NET implementation, this method is implemented as an extension method to any object implementing IList and can be called as follows:  `dict.AddIfMissing<T>(value)` . If the object's class already has a  `AddIfMissing<T>`  method with the same parameters, that method takes precedence over this extension method.

<b>Parameters:</b>

 * <i>dict</i>: The parameter  <i>dict</i>
 is a.Collections.Generic.IList{``0} object.

 * <i>value</i>: The parameter  <i>value</i>
 is a ``0 object.

 * &lt;T&gt;: Type parameter not documented yet.

<b>Exceptions:</b>

 * System.ArgumentNullException:
The parameter  <i>dict</i>
 is null.

<a id="AddIfMissing_TKey_TValue_this_System_Collections_Generic_IDictionary_TKey_TValue_TKey_TValue"></a>
### AddIfMissing

    public static void AddIfMissing<TKey, TValue>(
        this System.Collections.Generic.IDictionary<TKey, TValue> dict,
        TKey key,
        TValue value);

Adds if missing. In the.NET implementation, this method is implemented as an extension method to any object implementing IDictionary and can be called as follows:  `dict.AddIfMissing<TKey, TValue>(key,
            value)` . If the object's class already has a  `AddIfMissing<TKey, TValue>`  method with the same parameters, that method takes precedence over this extension method.

<b>Parameters:</b>

 * <i>dict</i>: The parameter  <i>dict</i>
 is a.Collections.Generic.IDictionary{``0 object.

 * <i>key</i>: The parameter  <i>key</i>
 is a ``1} object.

 * <i>value</i>: The parameter  <i>value</i>
 is a ``0 object.

 * &lt;TKey&gt;: The 1st type parameter.

 * &lt;TValue&gt;: The 2nd type parameter.

<b>Exceptions:</b>

 * System.ArgumentNullException:
The parameter  <i>dict</i>
 is null.

<a id="AddOverwrite_TKey_TValue_this_System_Collections_Generic_IDictionary_TKey_TValue_TKey_TValue"></a>
### AddOverwrite

    public static void AddOverwrite<TKey, TValue>(
        this System.Collections.Generic.IDictionary<TKey, TValue> dict,
        TKey key,
        TValue value);

Adds the overwrite. In the.NET implementation, this method is implemented as an extension method to any object implementing IDictionary and can be called as follows:  `dict.AddOverwrite<TKey, TValue>(key,
            value)` . If the object's class already has a  `AddOverwrite<TKey, TValue>`  method with the same parameters, that method takes precedence over this extension method.

<b>Parameters:</b>

 * <i>dict</i>: The parameter  <i>dict</i>
 is a.Collections.Generic.IDictionary{``0 object.

 * <i>key</i>: The parameter  <i>key</i>
 is a ``1} object.

 * <i>value</i>: The parameter  <i>value</i>
 is a ``0 object.

 * &lt;TKey&gt;: The 1st type parameter.

 * &lt;TValue&gt;: The 2nd type parameter.

<b>Exceptions:</b>

 * System.ArgumentNullException:
The parameter  <i>dict</i>
 is null.

<a id="AllSame_T_this_System_Collections_Generic_IEnumerable_T"></a>
### AllSame

    public static bool AllSame<T>(
        this System.Collections.Generic.IEnumerable<T> col);

Not documented yet. In the.NET implementation, this method is implemented as an extension method to any object implementing IEnumerable and can be called as follows:  `col.AllSame<T>()` . If the object's class already has a AllSame<T> method with the same parameters, that method takes precedence over this extension method.

In the.NET implementation, this method is implemented as an extension method to any object implementing IEnumerable and can be called as follows:  `col.AllSame<T>()` . If the object's class already has a  `AllSame<T>`  method with the same parameters, that method takes precedence over this extension method.

<b>Parameters:</b>

 * <i>col</i>: The parameter  <i>col</i>
 is a.Collections.Generic.IEnumerable{``0} object.

 * &lt;T&gt;: Any object type.

<b>Return Value:</b>

Either  `true`  or  `false` .

<b>Exceptions:</b>

 * System.ArgumentNullException:
The parameter  <i>col</i>
 is null.

<a id="AllSame_TContainer_TItem_this_System_Collections_Generic_IEnumerable_TContainer_System_Func_TContainer_TItem"></a>
### AllSame

    public static bool AllSame<TContainer, TItem>(
        this System.Collections.Generic.IEnumerable<TContainer> containers,
        System.Func<TContainer, TItem> func);

Not documented yet. In the.NET implementation, this method is implemented as an extension method to any object implementing IEnumerable and can be called as follows:  `containers.AllSame<TContainer,
            TItem>(func)` . If the object's class already has a AllSame<TContainer, TItem> method with the same parameters, that method takes precedence over this extension method.

<b>Parameters:</b>

 * <i>containers</i>: The parameter  <i>containers</i>
 is a.Collections.Generic.IEnumerable{``0} object.

 * <i>func</i>: The parameter  <i>func</i>
 is a.Func{``0 object.

 * &lt;TContainer&gt;: The parameter  is not documented yet.

 * &lt;TItem&gt;: Object type representing items stored in each container.

<b>Return Value:</b>

Either  `true`  or  `false` .

<b>Exceptions:</b>

 * System.ArgumentNullException:
The parameter  <i>containers</i>
 or  <i>func</i>
 is null.

<a id="ArrayToString_T_this_System_Collections_Generic_IEnumerable_T"></a>
### ArrayToString

    public static string ArrayToString<T>(
        this System.Collections.Generic.IEnumerable<T> array);

Not documented yet. In the.NET implementation, this method is implemented as an extension method to any object implementing IEnumerable and can be called as follows:  `array.ArrayToString<T>()` . If the object's class already has a ArrayToString<T> method with the same parameters, that method takes precedence over this extension method.

In the.NET implementation, this method is implemented as an extension method to any object implementing IEnumerable and can be called as follows:  `array.ArrayToString<T>()` . If the object's class already has a  `ArrayToString<T>`  method with the same parameters, that method takes precedence over this extension method.

<b>Parameters:</b>

 * <i>array</i>: The parameter  <i>array</i>
 is a.Collections.Generic.IEnumerable{``0} object.

 * &lt;T&gt;: Type parameter not documented yet.

<b>Return Value:</b>

A text string.

<a id="CopyStream_this_System_IO_Stream_int_System_IO_Stream"></a>
### CopyStream

    public static void CopyStream(
        this System.IO.Stream input,
        int length,
        System.IO.Stream output);

Copies a certain number of bytes from one stream to another. In the.NET implementation, this method is implemented as an extension method to any object implementing Stream and can be called as follows:  `input.CopyStream(length, output)` . If the object's class already has a CopyStream method with the same parameters, that method takes precedence over this extension method.

<b>Parameters:</b>

 * <i>input</i>: The parameter  <i>input</i>
 is a Stream object.

 * <i>length</i>: The parameter  <i>length</i>
 is a 32-bit signed integer.

 * <i>output</i>: The parameter  <i>output</i>
 is a Stream object.

<b>Exceptions:</b>

 * System.ArgumentNullException:
The parameter  <i>input</i>
 or  <i>output</i>
 is null.

<a id="CopyStream_this_System_IO_Stream_System_IO_Stream"></a>
### CopyStream

    public static void CopyStream(
        this System.IO.Stream input,
        System.IO.Stream output);

Copies all bytes from one stream to another. In the.NET implementation, this method is implemented as an extension method to any object implementing Stream and can be called as follows:  `input.CopyStream(output)` . If the object's class already has a CopyStream method with the same parameters, that method takes precedence over this extension method.

<b>Parameters:</b>

 * <i>input</i>: The parameter  <i>input</i>
 is a Stream object.

 * <i>output</i>: The parameter  <i>output</i>
 is a Stream object.

<b>Exceptions:</b>

 * System.ArgumentNullException:
The parameter  <i>input</i>
 or  <i>output</i>
 is null.

<a id="CopyStructure_T_this_T_where_T_new_PeterO_IStructureT"></a>
### CopyStructure

    public static T CopyStructure<T>(
        this T structure)
        where T : new(), PeterO.IStructureT;

Not documented yet. In the.NET implementation, this method is implemented as an extension method to any object implementing T and can be called as follows:  `structure.CopyStructure<T>()` . If the object's class already has a CopyStructure<T> method with the same parameters, that method takes precedence over this extension method.

In the.NET implementation, this method is implemented as an extension method to any object implementing T and can be called as follows:  `structure.CopyStructure<T>()` . If the object's class already has a  `CopyStructure<T>`  method with the same parameters, that method takes precedence over this extension method.

<b>Parameters:</b>

 * <i>structure</i>: The parameter  <i>structure</i>
 is a ``0 object.

 * &lt;T&gt;: Type parameter not documented yet.

<b>Return Value:</b>

A T object.

<b>Exceptions:</b>

 * System.ArgumentNullException:
The parameter  <i>structure</i>
 is null.

<a id="EachWithIndex_T_this_System_Collections_Generic_IEnumerable_T"></a>
### EachWithIndex

    public static System.Collections.Generic.IEnumerable<PeterO.Pair<T, int>> EachWithIndex<T>(
        this System.Collections.Generic.IEnumerable<T> arr);

Not documented yet.

<b>Parameters:</b>

 * <i>arr</i>: The parameter  <i>arr</i>
 is a.Collections.Generic.IEnumerable{``0} object.

 * &lt;T&gt;: The type of each object to be enumerated.

<b>Return Value:</b>

When enumerated, outputs the item and its index (starting at 0), in that order.

<a id="GetSegment_T_this_System_Collections_Generic_IList_T_int"></a>
### GetSegment

    public static PeterO.ListSegment<T> GetSegment<T>(
        this System.Collections.Generic.IList<T> list,
        int start);

Not documented yet. In the.NET implementation, this method is implemented as an extension method to any object implementing IList and can be called as follows:  `list.GetSegment<T>(start)` . If the object's class already has a GetSegment<T> method with the same parameters, that method takes precedence over this extension method.

In the.NET implementation, this method is implemented as an extension method to any object implementing IList and can be called as follows:  `list.GetSegment<T>(start)` . If the object's class already has a  `GetSegment<T>`  method with the same parameters, that method takes precedence over this extension method.

<b>Parameters:</b>

 * <i>list</i>: The parameter  <i>list</i>
 is a.Collections.Generic.IList{``0} object.

 * <i>start</i>: The parameter  <i>start</i>
 is a 32-bit signed integer.

 * &lt;T&gt;: Type parameter not documented yet.

<b>Return Value:</b>

A ListSegment(T) object.

<b>Exceptions:</b>

 * System.ArgumentNullException:
The parameter  <i>list</i>
 is null.

<a id="GetSegment_T_this_System_Collections_Generic_IList_T_int_int"></a>
### GetSegment

    public static PeterO.ListSegment<T> GetSegment<T>(
        this System.Collections.Generic.IList<T> list,
        int start,
        int count);

Not documented yet. In the.NET implementation, this method is implemented as an extension method to any object implementing IList and can be called as follows:  `list.GetSegment<T>(start, count)` . If the object's class already has a GetSegment<T> method with the same parameters, that method takes precedence over this extension method.

In the.NET implementation, this method is implemented as an extension method to any object implementing IList and can be called as follows:  `list.GetSegment<T>(start, count)` . If the object's class already has a  `GetSegment<T>`  method with the same parameters, that method takes precedence over this extension method.

<b>Parameters:</b>

 * <i>list</i>: The parameter  <i>list</i>
 is a.Collections.Generic.IList{``0} object.

 * <i>start</i>: The parameter  <i>start</i>
 is a 32-bit signed integer.

 * <i>count</i>: The parameter  <i>count</i>
 is a 32-bit signed integer.

 * &lt;T&gt;: Any object type.

<b>Return Value:</b>

A ListSegment(T) object.

<b>Exceptions:</b>

 * System.ArgumentNullException:
The parameter  <i>list</i>
 is null.

<a id="HasUnique_T_this_System_Collections_Generic_IEnumerable_T"></a>
### HasUnique

    public static bool HasUnique<T>(
        this System.Collections.Generic.IEnumerable<T> col);

Not documented yet. In the.NET implementation, this method is implemented as an extension method to any object implementing IEnumerable and can be called as follows:  `col.HasUnique<T>()` . If the object's class already has a HasUnique<T> method with the same parameters, that method takes precedence over this extension method.

In the.NET implementation, this method is implemented as an extension method to any object implementing IEnumerable and can be called as follows:  `col.HasUnique<T>()` . If the object's class already has a  `HasUnique<T>`  method with the same parameters, that method takes precedence over this extension method.

<b>Parameters:</b>

 * <i>col</i>: The parameter  <i>col</i>
 is a.Collections.Generic.IEnumerable{``0} object.

 * &lt;T&gt;: Type parameter not documented yet.

<b>Return Value:</b>

Either  `true`  or  `false` .

<b>Exceptions:</b>

 * System.ArgumentNullException:
The parameter  <i>col</i>
 is null.

<a id="HasUnique_TContainer_TItem_this_System_Collections_Generic_IEnumerable_TContainer_System_Func_TContainer_TItem"></a>
### HasUnique

    public static bool HasUnique<TContainer, TItem>(
        this System.Collections.Generic.IEnumerable<TContainer> containers,
        System.Func<TContainer, TItem> func);

Not documented yet. In the.NET implementation, this method is implemented as an extension method to any object implementing IEnumerable and can be called as follows:  `containers.HasUnique<TContainer,
            TItem>(func)` . If the object's class already has a HasUnique<TContainer, TItem> method with the same parameters, that method takes precedence over this extension method.

<b>Parameters:</b>

 * <i>containers</i>: The parameter  <i>containers</i>
 is a.Collections.Generic.IEnumerable{``0} object.

 * <i>func</i>: The parameter  <i>func</i>
 is a.Func{``0 object.

 * &lt;TContainer&gt;: The parameter  is not documented yet.

 * &lt;TItem&gt;: Object type representing items stored in each container.

<b>Return Value:</b>

Either  `true`  or  `false` .

<b>Exceptions:</b>

 * System.ArgumentNullException:
The parameter  <i>containers</i>
 or  <i>func</i>
 is null.

<a id="Implode_T_this_System_Collections_Generic_IEnumerable_T_string"></a>
### Implode

    public static string Implode<T>(
        this System.Collections.Generic.IEnumerable<T> col,
        string separator);

Not documented yet. In the.NET implementation, this method is implemented as an extension method to any object implementing IEnumerable and can be called as follows:  `col.Implode<T>(separator)` . If the object's class already has a Implode<T> method with the same parameters, that method takes precedence over this extension method.

In the.NET implementation, this method is implemented as an extension method to any object implementing IEnumerable and can be called as follows:  `col.Implode<T>(separator)` . If the object's class already has a  `Implode<T>`  method with the same parameters, that method takes precedence over this extension method.

<b>Parameters:</b>

 * <i>col</i>: The parameter  <i>col</i>
 is a.Collections.Generic.IEnumerable{``0} object.

 * <i>separator</i>: The parameter  <i>separator</i>
 is a text string.

 * &lt;T&gt;: Type parameter not documented yet.

<b>Return Value:</b>

A text string.

<b>Exceptions:</b>

 * System.ArgumentNullException:
The parameter  <i>col</i>
 or  <i>separator</i>
 is null.

<a id="IndexOf_T_this_System_Collections_Generic_IList_T_System_Predicate_T"></a>
### IndexOf

    public static int IndexOf<T>(
        this System.Collections.Generic.IList<T> list,
        System.Predicate<T> match);

Not documented yet. In the.NET implementation, this method is implemented as an extension method to any object implementing IList and can be called as follows:  `list.IndexOf<T>(match)` . If the object's class already has a IndexOf<T> method with the same parameters, that method takes precedence over this extension method.

In the.NET implementation, this method is implemented as an extension method to any object implementing IList and can be called as follows:  `list.IndexOf<T>(match)` . If the object's class already has a  `IndexOf<T>`  method with the same parameters, that method takes precedence over this extension method.

<b>Parameters:</b>

 * <i>list</i>: The parameter  <i>list</i>
 is a.Collections.Generic.IList{``0} object.

 * <i>match</i>: The parameter  <i>match</i>
 is a.Predicate{``0} object.

 * &lt;T&gt;: Type parameter not documented yet.

<b>Return Value:</b>

A 32-bit signed integer.

<b>Exceptions:</b>

 * System.ArgumentNullException:
The parameter  <i>list</i>
 or  <i>match</i>
 is null.

<a id="IndexOf_T_this_System_Collections_Generic_IList_T_T"></a>
### IndexOf

    public static int IndexOf<T>(
        this System.Collections.Generic.IList<T> list,
        T obj);

Not documented yet. In the.NET implementation, this method is implemented as an extension method to any object implementing IList and can be called as follows:  `list.IndexOf<T>(obj)` . If the object's class already has a IndexOf<T> method with the same parameters, that method takes precedence over this extension method.

In the.NET implementation, this method is implemented as an extension method to any object implementing IList and can be called as follows:  `list.IndexOf<T>(obj)` . If the object's class already has a  `IndexOf<T>`  method with the same parameters, that method takes precedence over this extension method.

<b>Parameters:</b>

 * <i>list</i>: The parameter  <i>list</i>
 is a.Collections.Generic.IList{``0} object.

 * <i>obj</i>: The parameter  <i>obj</i>
 is a ``0 object.

 * &lt;T&gt;: Type parameter not documented yet.

<b>Return Value:</b>

A 32-bit signed integer.

<b>Exceptions:</b>

 * System.ArgumentNullException:
The parameter  <i>list</i>
 is null.

<a id="MakePair_TFirst_TSecond_TFirst_TSecond"></a>
### MakePair

    public static PeterO.Pair<TFirst, TSecond> MakePair<TFirst, TSecond>(
        TFirst f,
        TSecond s);

Not documented yet.

<b>Parameters:</b>

 * <i>f</i>: The parameter  <i>f</i>
 is a ``0 object.

 * <i>s</i>: The parameter  <i>s</i>
 is a ``1 object.

 * &lt;TFirst&gt;: The parameter  is not documented yet.

 * &lt;TSecond&gt;: Any object type.

<b>Return Value:</b>

A Pair(TFirst, TSecond) object.

<a id="MaxOrDefault_T_this_System_Collections_Generic_IEnumerable_T_where_T_System_IComparable_T_T"></a>
### MaxOrDefault

    public static T MaxOrDefault<T>(
        this System.Collections.Generic.IEnumerable<T> coll)
        where T : System.IComparable<T>T;

Not documented yet. In the.NET implementation, this method is implemented as an extension method to any object implementing IEnumerable and can be called as follows:  `coll.MaxOrDefault<T>()` . If the object's class already has a MaxOrDefault<T> method with the same parameters, that method takes precedence over this extension method.

In the.NET implementation, this method is implemented as an extension method to any object implementing IEnumerable and can be called as follows:  `coll.MaxOrDefault<T>()` . If the object's class already has a  `MaxOrDefault<T>`  method with the same parameters, that method takes precedence over this extension method.

<b>Parameters:</b>

 * <i>coll</i>: The parameter  <i>coll</i>
 is a.Collections.Generic.IEnumerable{``0} object.

 * &lt;T&gt;: Any object type that implements IComparable<T>.

<b>Return Value:</b>

A T object.

<b>Exceptions:</b>

 * System.ArgumentNullException:
The parameter  <i>coll</i>
 is null.

<a id="MinOrDefault_T_this_System_Collections_Generic_IEnumerable_T_where_T_System_IComparable_T_T"></a>
### MinOrDefault

    public static T MinOrDefault<T>(
        this System.Collections.Generic.IEnumerable<T> coll)
        where T : System.IComparable<T>T;

Not documented yet. In the.NET implementation, this method is implemented as an extension method to any object implementing IEnumerable and can be called as follows:  `coll.MinOrDefault<T>()` . If the object's class already has a MinOrDefault<T> method with the same parameters, that method takes precedence over this extension method.

In the.NET implementation, this method is implemented as an extension method to any object implementing IEnumerable and can be called as follows:  `coll.MinOrDefault<T>()` . If the object's class already has a  `MinOrDefault<T>`  method with the same parameters, that method takes precedence over this extension method.

<b>Parameters:</b>

 * <i>coll</i>: The parameter  <i>coll</i>
 is a.Collections.Generic.IEnumerable{``0} object.

 * &lt;T&gt;: Type parameter not documented yet.

<b>Return Value:</b>

A T object.

<b>Exceptions:</b>

 * System.ArgumentNullException:
The parameter  <i>coll</i>
 is null.

<a id="RemoveAll_T_this_System_Collections_Generic_IList_T_System_Predicate_T"></a>
### RemoveAll

    public static int RemoveAll<T>(
        this System.Collections.Generic.IList<T> list,
        System.Predicate<T> match);

Not documented yet. In the.NET implementation, this method is implemented as an extension method to any object implementing IList and can be called as follows:  `list.RemoveAll<T>(match)` . If the object's class already has a RemoveAll<T> method with the same parameters, that method takes precedence over this extension method.

In the.NET implementation, this method is implemented as an extension method to any object implementing IList and can be called as follows:  `list.RemoveAll<T>(match)` . If the object's class already has a  `RemoveAll<T>`  method with the same parameters, that method takes precedence over this extension method.

<b>Parameters:</b>

 * <i>list</i>: The parameter  <i>list</i>
 is a.Collections.Generic.IList{``0} object.

 * <i>match</i>: The parameter  <i>match</i>
 is a.Predicate{``0} object.

 * &lt;T&gt;: Type parameter not documented yet.

<b>Return Value:</b>

A 32-bit signed integer.

<b>Exceptions:</b>

 * System.ArgumentNullException:
The parameter  <i>list</i>
 or  <i>match</i>
 is null.

<a id="SetIfMissing_T_this_System_Collections_Generic_IList_T_int_System_Func_T"></a>
### SetIfMissing

    public static T SetIfMissing<T>(
        this System.Collections.Generic.IList<T> list,
        int index,
        System.Func<T> valuefunc);

Not documented yet. In the.NET implementation, this method is implemented as an extension method to any object implementing IList and can be called as follows:  `list.SetIfMissing<T>(index, valuefunc)` . If the object's class already has a SetIfMissing<T> method with the same parameters, that method takes precedence over this extension method.

In the.NET implementation, this method is implemented as an extension method to any object implementing IList and can be called as follows:  `list.SetIfMissing<T>(index, valuefunc)` . If the object's class already has a  `SetIfMissing<T>`  method with the same parameters, that method takes precedence over this extension method.

<b>Parameters:</b>

 * <i>list</i>: The parameter  <i>list</i>
 is a.Collections.Generic.IList{``0} object.

 * <i>index</i>: The parameter  <i>index</i>
 is a 32-bit signed integer.

 * <i>valuefunc</i>: The parameter  <i>valuefunc</i>
 is a.Func{``0} object.

 * &lt;T&gt;: Type parameter not documented yet.

<b>Return Value:</b>

A T object.

<b>Exceptions:</b>

 * System.ArgumentNullException:
The parameter  <i>list</i>
 is null.

<a id="SetIfMissing_T_this_System_Collections_Generic_IList_T_int_T"></a>
### SetIfMissing

    public static T SetIfMissing<T>(
        this System.Collections.Generic.IList<T> list,
        int index,
        T value);

Not documented yet. In the.NET implementation, this method is implemented as an extension method to any object implementing IList and can be called as follows:  `list.SetIfMissing<T>(index, value)` . If the object's class already has a SetIfMissing<T> method with the same parameters, that method takes precedence over this extension method.

In the.NET implementation, this method is implemented as an extension method to any object implementing IList and can be called as follows:  `list.SetIfMissing<T>(index, value)` . If the object's class already has a  `SetIfMissing<T>`  method with the same parameters, that method takes precedence over this extension method.

<b>Parameters:</b>

 * <i>list</i>: The parameter  <i>list</i>
 is a.Collections.Generic.IList{``0} object.

 * <i>index</i>: The parameter  <i>index</i>
 is a 32-bit signed integer.

 * <i>value</i>: The parameter  <i>value</i>
 is a ``0 object.

 * &lt;T&gt;: Type parameter not documented yet.

<b>Return Value:</b>

A T object.

<b>Exceptions:</b>

 * System.ArgumentNullException:
The parameter  <i>list</i>
 is null.

<a id="SetNewIfMissing_T_this_System_Collections_Generic_IList_T_int_where_T_newT"></a>
### SetNewIfMissing

    public static T SetNewIfMissing<T>(
        this System.Collections.Generic.IList<T> list,
        int index)
        where T : new()T;

Not documented yet. In the.NET implementation, this method is implemented as an extension method to any object implementing IList and can be called as follows:  `list.SetNewIfMissing<T>(index)` . If the object's class already has a SetNewIfMissing<T> method with the same parameters, that method takes precedence over this extension method.

<b>Parameters:</b>

 * <i>list</i>: The parameter  <i>list</i>
 is a.Collections.Generic.IList{``0} object.

 * <i>index</i>: The parameter  <i>index</i>
 is a 32-bit signed integer.

 * &lt;T&gt;: Type parameter not documented yet.

<b>Return Value:</b>

A T object.

<b>Exceptions:</b>

 * System.ArgumentNullException:
The parameter  <i>list</i>
 is null.

<a id="SetValue_T_this_System_Collections_Generic_IList_T_int_T"></a>
### SetValue

    public static void SetValue<T>(
        this System.Collections.Generic.IList<T> list,
        int index,
        T value);

Not documented yet. In the.NET implementation, this method is implemented as an extension method to any object implementing IList and can be called as follows:  `list.SetValue<T>(index, value)` . If the object's class already has a SetValue<T> method with the same parameters, that method takes precedence over this extension method.

In the.NET implementation, this method is implemented as an extension method to any object implementing IList and can be called as follows:  `list.SetValue<T>(index, value)` . If the object's class already has a  `SetValue<T>`  method with the same parameters, that method takes precedence over this extension method.

<b>Parameters:</b>

 * <i>list</i>: The parameter  <i>list</i>
 is a.Collections.Generic.IList{``0} object.

 * <i>index</i>: The parameter  <i>index</i>
 is a 32-bit signed integer.

 * <i>value</i>: The parameter  <i>value</i>
 is a ``0 object.

 * &lt;T&gt;: Type parameter not documented yet.

<b>Exceptions:</b>

 * System.ArgumentNullException:
The parameter  <i>list</i>
 is null.

<a id="StructureSize_this_PeterO_IStructure"></a>
### StructureSize

    public static int StructureSize(
        this PeterO.IStructure s);

Not documented yet. In the.NET implementation, this method is implemented as an extension method to any object implementing IStructure and can be called as follows:  `s.StructureSize()` . If the object's class already has a StructureSize method with the same parameters, that method takes precedence over this extension method.

In the.NET implementation, this method is implemented as an extension method to any object implementing IStructure and can be called as follows:  `s.StructureSize()` . If the object's class already has a  `StructureSize`  method with the same parameters, that method takes precedence over this extension method.

<b>Parameters:</b>

 * <i>s</i>: The parameter  <i>s</i>
 is a IStructure object.

<b>Return Value:</b>

A 32-bit signed integer.

<b>Exceptions:</b>

 * System.ArgumentNullException:
The parameter  <i>s</i>
 is null.

<a id="Sum_T_this_System_Collections_Generic_IEnumerable_T_System_Func_T_int"></a>
### Sum

    public static int Sum<T>(
        this System.Collections.Generic.IEnumerable<T> containers,
        System.Func<T, int> func);

Not documented yet. In the.NET implementation, this method is implemented as an extension method to any object implementing IEnumerable and can be called as follows:  `containers.Sum<T>(func)` . If the object's class already has a Sum<T> method with the same parameters, that method takes precedence over this extension method.

<b>Parameters:</b>

 * <i>containers</i>: The parameter  <i>containers</i>
 is a.Collections.Generic.IEnumerable{``0} object.

 * <i>func</i>: The parameter  <i>func</i>
 is a.Func{``0 object.

 * &lt;T&gt;: Type parameter not documented yet.

<b>Return Value:</b>

A 32-bit signed integer.

<a id="Transform_TInput_TOutput_this_System_Collections_Generic_IEnumerable_TInput_System_Func_TInput_TOutput"></a>
### Transform

    public static System.Collections.Generic.IEnumerable<TOutput> Transform<TInput, TOutput>(
        this System.Collections.Generic.IEnumerable<TInput> containers,
        System.Func<TInput, TOutput> func);

Not documented yet. In the.NET implementation, this method is implemented as an extension method to any object implementing IEnumerable and can be called as follows:  `containers.Transform<TInput,
            TOutput>(func)` . If the object's class already has a  `Transform<TInput, TOutput>`  method with the same parameters, that method takes precedence over this extension method.

<b>Parameters:</b>

 * <i>containers</i>: The parameter  <i>containers</i>
 is a.Collections.Generic.IEnumerable{``0} object.

 * <i>func</i>: The parameter  <i>func</i>
 is a.Func{``0 object.

 * &lt;TInput&gt;: The 1st type parameter.

 * &lt;TOutput&gt;: The 2nd type parameter.

<b>Return Value:</b>

The transform.

<a id="UpToExcluding_this_int_int"></a>
### UpToExcluding

    public static System.Collections.Generic.IEnumerable UpToExcluding(
        this int minValue,
        int maxValue);

Creates an iterator of integers starting at a minimum value and ending at one less than the maximum. In the.NET implementation, this method is implemented as an extension method to any object implementing Int32 and can be called as follows:  `minValue.UpToExcluding(maxValue)` . If the object's class already has a UpToExcluding method with the same parameters, that method takes precedence over this extension method.

In the.NET implementation, this method is implemented as an extension method to any object implementing Int32 and can be called as follows:  `minValue.UpToExcluding(maxValue)` . If the object's class already has a  `UpToExcluding`  method with the same parameters, that method takes precedence over this extension method.

<b>Parameters:</b>

 * <i>minValue</i>: The parameter  <i>minValue</i>
 is a 32-bit signed integer.

 * <i>maxValue</i>: The parameter  <i>maxValue</i>
 is a 32-bit signed integer.

<b>Return Value:</b>

An IEnumerable(int) object.

<b>Exceptions:</b>

 * System.ArgumentException:
The parameter _minValue_ is greater than _maxValue_.

<a id="UpToIncluding_this_int_int"></a>
### UpToIncluding

    public static System.Collections.Generic.IEnumerable UpToIncluding(
        this int minValue,
        int maxValue);

Not documented yet. In the.NET implementation, this method is implemented as an extension method to any object implementing Int32 and can be called as follows:  `minValue.UpToIncluding(maxValue)` . If the object's class already has a UpToIncluding method with the same parameters, that method takes precedence over this extension method.

In the.NET implementation, this method is implemented as an extension method to any object implementing Int32 and can be called as follows:  `minValue.UpToIncluding(maxValue)` . If the object's class already has a  `UpToIncluding`  method with the same parameters, that method takes precedence over this extension method.

<b>Parameters:</b>

 * <i>minValue</i>: The parameter  <i>minValue</i>
 is a 32-bit signed integer.

 * <i>maxValue</i>: The parameter  <i>maxValue</i>
 is a 32-bit signed integer.

<b>Return Value:</b>

An IEnumerable(int) object.

<a id="ValueOrDefault_T_this_System_Collections_Generic_IList_T_int"></a>
### ValueOrDefault

    public static T ValueOrDefault<T>(
        this System.Collections.Generic.IList<T> list,
        int index);

Not documented yet. In the.NET implementation, this method is implemented as an extension method to any object implementing IList and can be called as follows:  `list.ValueOrDefault<T>(index)` . If the object's class already has a ValueOrDefault<T> method with the same parameters, that method takes precedence over this extension method.

<b>Parameters:</b>

 * <i>list</i>: The parameter  <i>list</i>
 is a.Collections.Generic.IList{``0} object.

 * <i>index</i>: The parameter  <i>index</i>
 is a 32-bit signed integer.

 * &lt;T&gt;: Type parameter not documented yet.

<b>Return Value:</b>

A T object.

<b>Exceptions:</b>

 * System.ArgumentNullException:
The parameter  <i>list</i>
 is null.
