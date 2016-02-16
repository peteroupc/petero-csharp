## PeterO.Util

    public static class Util

Not documented yet.

### NullDisposable

    public static readonly System.IDisposable NullDisposable;

An IDisposable object that does nothing when disposed.

### AddIfMissing

    public static void AddIfMissing<T>(
        this System.Collections.Generic.IList<T> dict,
        T value);

Not documented yet.In the .NET implementation, this method is implemented as an extension method to any object implementing IList and can be called as follows:  `dict.AddIfMissing<T>(value)` . If the object's class already has a AddIfMissing<T> method with the same parameters, that method takes precedence over this extension method.

<b>Parameters:</b>

 * <i>dict</i>: An IList object.

 * <i>value</i>: A T object.

 * &lt;T&gt;: Type parameter not documented yet.

<b>Exceptions:</b>

 * System.ArgumentNullException:
The parameter <i>dict</i>
 is null.

### AddIfMissing

    public static void AddIfMissing<TKey, TValue>(
        this System.Collections.Generic.IDictionary<TKey, TValue> dict,
        TKey key,
        TValue value);

Not documented yet.In the .NET implementation, this method is implemented as an extension method to any object implementing IDictionary and can be called as follows:  `dict.AddIfMissing<TKey, TValue>(key,
            value)` . If the object's class already has a AddIfMissing<TKey, TValue> method with the same parameters, that method takes precedence over this extension method.

<b>Parameters:</b>

 * <i>dict</i>: An IDictionary object.

 * <i>key</i>: A TKey object.

 * <i>value</i>: A TValue object.

 * &lt;T&gt;: Type parameter not documented yet.

<b>Exceptions:</b>

 * System.ArgumentNullException:
The parameter <i>dict</i>
 is null.

### AddOverwrite

    public static void AddOverwrite<TKey, TValue>(
        this System.Collections.Generic.IDictionary<TKey, TValue> dict,
        TKey key,
        TValue value);

Not documented yet.In the .NET implementation, this method is implemented as an extension method to any object implementing IDictionary and can be called as follows:  `dict.AddOverwrite<TKey, TValue>(key,
            value)` . If the object's class already has a AddOverwrite<TKey, TValue> method with the same parameters, that method takes precedence over this extension method.

<b>Parameters:</b>

 * <i>dict</i>: An IDictionary object.

 * <i>key</i>: A TKey object.

 * <i>value</i>: A TValue object.

 * &lt;TKey&gt;: Type parameter not documented yet.

<b>Exceptions:</b>

 * System.ArgumentNullException:
The parameter <i>dict</i>
 is null.

### AllSame

    public static bool AllSame<T>(
        this System.Collections.Generic.IEnumerable<T> col);

Not documented yet.In the .NET implementation, this method is implemented as an extension method to any object implementing IEnumerable and can be called as follows:  `col.AllSame<T>()` . If the object's class already has a AllSame<T> method with the same parameters, that method takes precedence over this extension method.

<b>Parameters:</b>

 * <i>col</i>: An IEnumerable object.

 * &lt;T&gt;: Any object type.

<b>Return Value:</b>

A Boolean object.

<b>Exceptions:</b>

 * System.ArgumentNullException:
The parameter <i>col</i>
 is null.

### AllSame

    public static bool AllSame<TContainer, TItem>(
        this System.Collections.Generic.IEnumerable<TContainer> containers,
        System.Func<TContainer, TItem> func);

Not documented yet.In the .NET implementation, this method is implemented as an extension method to any object implementing IEnumerable and can be called as follows:  `containers.AllSame<TContainer,
            TItem>(func)` . If the object's class already has a AllSame<TContainer, TItem> method with the same parameters, that method takes precedence over this extension method.

<b>Parameters:</b>

 * <i>containers</i>: An IEnumerable object.

 * <i>func</i>: A Func object.

 * &lt;TContainer&gt;: Object type representing containers of items. Can also be the same type as TItem.

 * &lt;TItem&gt;: Object type representing items stored in each container.

<b>Return Value:</b>

A Boolean object.

<b>Exceptions:</b>

 * System.ArgumentNullException:
The parameter <i>containers</i>
 or  <i>func</i>
 is null.

### ArrayToString

    public static string ArrayToString<T>(
        this System.Collections.Generic.IEnumerable<T> array);

Not documented yet.In the .NET implementation, this method is implemented as an extension method to any object implementing IEnumerable and can be called as follows:  `array.ArrayToString<T>()` . If the object's class already has a ArrayToString<T> method with the same parameters, that method takes precedence over this extension method.

<b>Parameters:</b>

 * <i>array</i>: An IEnumerable object.

 * &lt;T&gt;: Type parameter not documented yet.

<b>Return Value:</b>

A text string.

### CopyStream

    public static void CopyStream(
        this System.IO.Stream input,
        int length,
        System.IO.Stream output);

Copies a certain number of bytes from one stream to another.In the .NET implementation, this method is implemented as an extension method to any object implementing Stream and can be called as follows:  `input.CopyStream(length, output)` . If the object's class already has a CopyStream method with the same parameters, that method takes precedence over this extension method.

<b>Parameters:</b>

 * <i>input</i>: A Stream object.

 * <i>length</i>: A 32-bit signed integer.

 * <i>output</i>: Another Stream object.

<b>Exceptions:</b>

 * System.ArgumentNullException:
The parameter <i>input</i>
 or  <i>output</i>
 is null.

### CopyStream

    public static void CopyStream(
        this System.IO.Stream input,
        System.IO.Stream output);

Copies all bytes from one stream to another.In the .NET implementation, this method is implemented as an extension method to any object implementing Stream and can be called as follows:  `input.CopyStream(output)` . If the object's class already has a CopyStream method with the same parameters, that method takes precedence over this extension method.

<b>Parameters:</b>

 * <i>input</i>: A Stream object.

 * <i>output</i>: Another Stream object.

<b>Exceptions:</b>

 * System.ArgumentNullException:
The parameter <i>input</i>
 or  <i>output</i>
 is null.

### CopyStructure

    public static T CopyStructure<T>(
        this T structure)
        where T : new(), PeterO.IStructureT;

Not documented yet.In the .NET implementation, this method is implemented as an extension method to any object implementing T and can be called as follows:  `structure.CopyStructure<T>()` . If the object's class already has a CopyStructure<T> method with the same parameters, that method takes precedence over this extension method.

<b>Parameters:</b>

 * <i>structure</i>: Another T object.

 * &lt;T&gt;: Type parameter not documented yet.

<b>Return Value:</b>

A T object.

<b>Exceptions:</b>

 * System.ArgumentNullException:
The parameter <i>structure</i>
 is null.

### EachWithIndex

    public static System.Collections.Generic.IEnumerable<PeterO.Pair<T, int>> EachWithIndex<T>(
        this System.Collections.Generic.IEnumerable<T> arr);

Not documented yet.

Useful in queries where the index must be manipulated r returned by the query. For example:    from o in Util.EachWithIndex(objects) where
    IndexMeetsCriteria(o.Second) select o.First

<b>Parameters:</b>

 * &lt;T&gt;: Type parameter not documented yet.

<b>Return Value:</b>

The return value'/> is not documented yet.

### GetSegment

    public static PeterO.ListSegment<T> GetSegment<T>(
        this System.Collections.Generic.IList<T> list,
        int start);

Not documented yet.In the .NET implementation, this method is implemented as an extension method to any object implementing IList and can be called as follows:  `list.GetSegment<T>(start)` . If the object's class already has a GetSegment<T> method with the same parameters, that method takes precedence over this extension method.

<b>Parameters:</b>

 * <i>list</i>: An IList object.

 * <i>start</i>: A 32-bit signed integer.

 * &lt;T&gt;: Type parameter not documented yet.

<b>Return Value:</b>

A ListSegment(T) object.

<b>Exceptions:</b>

 * System.ArgumentNullException:
The parameter <i>list</i>
 is null.

### GetSegment

    public static PeterO.ListSegment<T> GetSegment<T>(
        this System.Collections.Generic.IList<T> list,
        int start,
        int count);

Not documented yet.In the .NET implementation, this method is implemented as an extension method to any object implementing IList and can be called as follows:  `list.GetSegment<T>(start, count)` . If the object's class already has a GetSegment<T> method with the same parameters, that method takes precedence over this extension method.

<b>Parameters:</b>

 * <i>list</i>: An IList object.

 * <i>start</i>: A 32-bit signed integer.

 * <i>count</i>: Another 32-bit signed integer.

 * &lt;T&gt;: Any object type.

<b>Return Value:</b>

A ListSegment(T) object.

<b>Exceptions:</b>

 * System.ArgumentNullException:
The parameter <i>list</i>
 is null.

### HasUnique

    public static bool HasUnique<T>(
        this System.Collections.Generic.IEnumerable<T> col);

Not documented yet.In the .NET implementation, this method is implemented as an extension method to any object implementing IEnumerable and can be called as follows:  `col.HasUnique<T>()` . If the object's class already has a HasUnique<T> method with the same parameters, that method takes precedence over this extension method.

<b>Parameters:</b>

 * <i>col</i>: An IEnumerable object.

 * &lt;T&gt;: Type parameter not documented yet.

<b>Return Value:</b>

A Boolean object.

<b>Exceptions:</b>

 * System.ArgumentNullException:
The parameter <i>col</i>
 is null.

### HasUnique

    public static bool HasUnique<TContainer, TItem>(
        this System.Collections.Generic.IEnumerable<TContainer> containers,
        System.Func<TContainer, TItem> func);

Not documented yet.In the .NET implementation, this method is implemented as an extension method to any object implementing IEnumerable and can be called as follows:  `containers.HasUnique<TContainer,
            TItem>(func)` . If the object's class already has a HasUnique<TContainer, TItem> method with the same parameters, that method takes precedence over this extension method.

<b>Parameters:</b>

 * <i>containers</i>: An IEnumerable object.

 * <i>func</i>: A Func object.

 * &lt;TContainer&gt;: Object type representing containers of items. Can also be the same type as TItem.

 * &lt;TItem&gt;: Object type representing items stored in each container.

<b>Return Value:</b>

A Boolean object.

<b>Exceptions:</b>

 * System.ArgumentNullException:
The parameter <i>containers</i>
 or  <i>func</i>
 is null.

### Implode

    public static string Implode<T>(
        this System.Collections.Generic.IEnumerable<T> col,
        string separator);

Not documented yet.In the .NET implementation, this method is implemented as an extension method to any object implementing IEnumerable and can be called as follows:  `col.Implode<T>(separator)` . If the object's class already has a Implode<T> method with the same parameters, that method takes precedence over this extension method.

<b>Parameters:</b>

 * <i>col</i>: An IEnumerable object.

 * <i>separator</i>: Another string object.

 * &lt;T&gt;: Type parameter not documented yet.

<b>Return Value:</b>

A text string.

<b>Exceptions:</b>

 * System.ArgumentNullException:
The parameter <i>col</i>
 or  <i>separator</i>
 is null.

### IndexOf

    public static int IndexOf<T>(
        this System.Collections.Generic.IList<T> list,
        System.Predicate<T> match);

Not documented yet.In the .NET implementation, this method is implemented as an extension method to any object implementing IList and can be called as follows:  `list.IndexOf<T>(match)` . If the object's class already has a IndexOf<T> method with the same parameters, that method takes precedence over this extension method.

<b>Parameters:</b>

 * <i>list</i>: An IList object.

 * <i>match</i>: A Predicate object.

 * &lt;T&gt;: Type parameter not documented yet.

<b>Return Value:</b>

A 32-bit signed integer.

<b>Exceptions:</b>

 * System.ArgumentNullException:
The parameter <i>list</i>
 or  <i>match</i>
 is null.

### IndexOf

    public static int IndexOf<T>(
        this System.Collections.Generic.IList<T> list,
        T obj);

Not documented yet.In the .NET implementation, this method is implemented as an extension method to any object implementing IList and can be called as follows:  `list.IndexOf<T>(obj)` . If the object's class already has a IndexOf<T> method with the same parameters, that method takes precedence over this extension method.

<b>Parameters:</b>

 * <i>list</i>: An IList object.

 * <i>obj</i>: A T object.

 * &lt;T&gt;: Type parameter not documented yet.

<b>Return Value:</b>

A 32-bit signed integer.

<b>Exceptions:</b>

 * System.ArgumentNullException:
The parameter <i>list</i>
 is null.

### MakePair

    public static PeterO.Pair<TFirst, TSecond> MakePair<TFirst, TSecond>(
        TFirst f,
        TSecond s);

Not documented yet.

<b>Parameters:</b>

 * <i>f</i>: A TFirst object.

 * <i>s</i>: A TSecond object.

 * &lt;TFirst&gt;: Any object type.

 * &lt;TSecond&gt;: Any object type.

<b>Return Value:</b>

A Pair(TFirst, TSecond) object.

### MaxOrDefault

    public static T MaxOrDefault<T>(
        this System.Collections.Generic.IEnumerable<T> coll)
        where T : System.IComparable<T>T;

Not documented yet.In the .NET implementation, this method is implemented as an extension method to any object implementing IEnumerable and can be called as follows:  `coll.MaxOrDefault<T>()` . If the object's class already has a MaxOrDefault<T> method with the same parameters, that method takes precedence over this extension method.

<b>Parameters:</b>

 * <i>coll</i>: An IEnumerable object.

 * &lt;T&gt;: Any object type that implements IComparable<T>.

<b>Return Value:</b>

A T object.

<b>Exceptions:</b>

 * System.ArgumentNullException:
The parameter <i>coll</i>
 is null.

### MinOrDefault

    public static T MinOrDefault<T>(
        this System.Collections.Generic.IEnumerable<T> coll)
        where T : System.IComparable<T>T;

Not documented yet.In the .NET implementation, this method is implemented as an extension method to any object implementing IEnumerable and can be called as follows:  `coll.MinOrDefault<T>()` . If the object's class already has a MinOrDefault<T> method with the same parameters, that method takes precedence over this extension method.

<b>Parameters:</b>

 * <i>coll</i>: An IEnumerable object.

 * &lt;T&gt;: Type parameter not documented yet.

<b>Return Value:</b>

A T object.

<b>Exceptions:</b>

 * System.ArgumentNullException:
The parameter <i>coll</i>
 is null.

### RemoveAll

    public static int RemoveAll<T>(
        this System.Collections.Generic.IList<T> list,
        System.Predicate<T> match);

Not documented yet.In the .NET implementation, this method is implemented as an extension method to any object implementing IList and can be called as follows:  `list.RemoveAll<T>(match)` . If the object's class already has a RemoveAll<T> method with the same parameters, that method takes precedence over this extension method.

<b>Parameters:</b>

 * <i>list</i>: An IList object.

 * <i>match</i>: A Predicate object.

 * &lt;T&gt;: Type parameter not documented yet.

<b>Return Value:</b>

A 32-bit signed integer.

<b>Exceptions:</b>

 * System.ArgumentNullException:
The parameter <i>list</i>
 or  <i>match</i>
 is null.

### SetIfMissing

    public static T SetIfMissing<T>(
        this System.Collections.Generic.IList<T> list,
        int index,
        System.Func<T> valuefunc);

Not documented yet.In the .NET implementation, this method is implemented as an extension method to any object implementing IList and can be called as follows:  `list.SetIfMissing<T>(index, valuefunc)` . If the object's class already has a SetIfMissing<T> method with the same parameters, that method takes precedence over this extension method.

<b>Parameters:</b>

 * <i>list</i>: An IList object.

 * <i>index</i>: A 32-bit signed integer.

 * <i>valuefunc</i>: A Func object.

 * &lt;T&gt;: Type parameter not documented yet.

<b>Return Value:</b>

A T object.

<b>Exceptions:</b>

 * System.ArgumentNullException:
The parameter <i>list</i>
 is null.

### SetIfMissing

    public static T SetIfMissing<T>(
        this System.Collections.Generic.IList<T> list,
        int index,
        T value);

Not documented yet.In the .NET implementation, this method is implemented as an extension method to any object implementing IList and can be called as follows:  `list.SetIfMissing<T>(index, value)` . If the object's class already has a SetIfMissing<T> method with the same parameters, that method takes precedence over this extension method.

<b>Parameters:</b>

 * <i>list</i>: An IList object.

 * <i>index</i>: A 32-bit signed integer.

 * <i>value</i>: Another T object.

 * &lt;T&gt;: Type parameter not documented yet.

<b>Return Value:</b>

A T object.

<b>Exceptions:</b>

 * System.ArgumentNullException:
The parameter <i>list</i>
 is null.

### SetNewIfMissing

    public static T SetNewIfMissing<T>(
        this System.Collections.Generic.IList<T> list,
        int index)
        where T : new()T;

Not documented yet.In the .NET implementation, this method is implemented as an extension method to any object implementing IList and can be called as follows:  `list.SetNewIfMissing<T>(index)` . If the object's class already has a SetNewIfMissing<T> method with the same parameters, that method takes precedence over this extension method.

<b>Parameters:</b>

 * <i>list</i>: An IList object.

 * <i>index</i>: A 32-bit signed integer.

 * &lt;T&gt;: Type parameter not documented yet.

<b>Return Value:</b>

A T object.

<b>Exceptions:</b>

 * System.ArgumentNullException:
The parameter <i>list</i>
 is null.

### SetValue

    public static void SetValue<T>(
        this System.Collections.Generic.IList<T> list,
        int index,
        T value);

Not documented yet.In the .NET implementation, this method is implemented as an extension method to any object implementing IList and can be called as follows:  `list.SetValue<T>(index, value)` . If the object's class already has a SetValue<T> method with the same parameters, that method takes precedence over this extension method.

<b>Parameters:</b>

 * <i>list</i>: An IList object.

 * <i>index</i>: A 32-bit signed integer.

 * <i>value</i>: A T object.

 * &lt;T&gt;: Type parameter not documented yet.

<b>Exceptions:</b>

 * System.ArgumentNullException:
The parameter <i>list</i>
 is null.

### StructureSize

    public static int StructureSize(
        this PeterO.IStructure s);

Not documented yet.In the .NET implementation, this method is implemented as an extension method to any object implementing IStructure and can be called as follows:  `s.StructureSize()` . If the object's class already has a StructureSize method with the same parameters, that method takes precedence over this extension method.

<b>Parameters:</b>

 * <i>s</i>: An IStructure object.

<b>Return Value:</b>

A 32-bit signed integer.

<b>Exceptions:</b>

 * System.ArgumentNullException:
The parameter <i>s</i>
 is null.

### Sum

    public static int Sum<T>(
        this System.Collections.Generic.IEnumerable<T> containers,
        System.Func<T, int> func);

Not documented yet.In the .NET implementation, this method is implemented as an extension method to any object implementing IEnumerable and can be called as follows:  `containers.Sum<T>(func)` . If the object's class already has a Sum<T> method with the same parameters, that method takes precedence over this extension method.

<b>Parameters:</b>

 * <i>containers</i>: An IEnumerable object.

 * <i>func</i>: A Func object.

 * &lt;T&gt;: Type parameter not documented yet.

<b>Return Value:</b>

A 32-bit signed integer.

### Transform

    public static System.Collections.Generic.IEnumerable<TOutput> Transform<TInput, TOutput>(
        this System.Collections.Generic.IEnumerable<TInput> containers,
        System.Func<TInput, TOutput> func);

Not documented yet.In the .NET implementation, this method is implemented as an extension method to any object implementing IEnumerable and can be called as follows:  `containers.Transform<TInput,
            TOutput>(func)` . If the object's class already has a Transform<TInput, TOutput> method with the same parameters, that method takes precedence over this extension method.

<b>Parameters:</b>

 * <i>containers</i>: An IEnumerable object.

 * <i>func</i>: A Func object.

 * &lt;T&gt;: Type parameter not documented yet.

<b>Return Value:</b>

An IEnumerable(TOutput) object.

### UpToExcluding

    public static System.Collections.Generic.IEnumerable UpToExcluding(
        this int minValue,
        int maxValue);

Creates an iterator of integers starting at a minimum value and ending at one less than the maximum.In the .NET implementation, this method is implemented as an extension method to any object implementing Int32 and can be called as follows:  `minValue.UpToExcluding(maxValue)` . If the object's class already has a UpToExcluding method with the same parameters, that method takes precedence over this extension method.

<b>Parameters:</b>

 * <i>minValue</i>: A 32-bit signed integer.

 * <i>maxValue</i>: Another 32-bit signed integer.

<b>Return Value:</b>

An IEnumerable(int) object.

<b>Exceptions:</b>

 * System.ArgumentException:
The parameter _minValue_ is greater than _maxValue_.

### UpToIncluding

    public static System.Collections.Generic.IEnumerable UpToIncluding(
        this int minValue,
        int maxValue);

Not documented yet.In the .NET implementation, this method is implemented as an extension method to any object implementing Int32 and can be called as follows:  `minValue.UpToIncluding(maxValue)` . If the object's class already has a UpToIncluding method with the same parameters, that method takes precedence over this extension method.

<b>Parameters:</b>

 * <i>minValue</i>: A 32-bit signed integer.

 * <i>maxValue</i>: Another 32-bit signed integer.

<b>Return Value:</b>

An IEnumerable(int) object.

### ValueOrDefault

    public static T ValueOrDefault<T>(
        this System.Collections.Generic.IList<T> list,
        int index);

Not documented yet.In the .NET implementation, this method is implemented as an extension method to any object implementing IList and can be called as follows:  `list.ValueOrDefault<T>(index)` . If the object's class already has a ValueOrDefault<T> method with the same parameters, that method takes precedence over this extension method.

<b>Parameters:</b>

 * <i>list</i>: An IList object.

 * <i>index</i>: A 32-bit signed integer.

 * &lt;T&gt;: Type parameter not documented yet.

<b>Return Value:</b>

A T object.

<b>Exceptions:</b>

 * System.ArgumentNullException:
The parameter <i>list</i>
 is null.
