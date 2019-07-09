## PeterO.ArrayUtil

    public static class ArrayUtil

Not documented yet.

### Member Summary
* <code>[ArrayHashCode(System.Collections.Generic.IEnumerable)](#ArrayHashCode_System_Collections_Generic_IEnumerable)</code> - Not documented yet. Not documented yet. Not documented yet. Not documented yet.
* <code>[ArrayHashCode&lt;T&gt;(System.Collections.Generic.IEnumerable&lt;T&gt;)](#ArrayHashCode_T_System_Collections_Generic_IEnumerable_T)</code> - Not documented yet.
* <code>[ArraysEqual&lt;T&gt;(System.Collections.Generic.IEnumerable&lt;T&gt;, System.Collections.Generic.IEnumerable&lt;T&gt;)](#ArraysEqual_T_System_Collections_Generic_IEnumerable_T_System_Collections_Generic_IEnumerable_T)</code> - Determines whether two enumerable objects are equal.
* <code>[ArraysEqual&lt;T&gt;(System.Collections.Generic.IEnumerable&lt;T&gt;, System.Collections.Generic.IEnumerable&lt;T&gt;, System.Collections.Generic.IEqualityComparer&lt;T&gt;)](#ArraysEqual_T_System_Collections_Generic_IEnumerable_T_System_Collections_Generic_IEnumerable_T_System_Collections_Generic_IEqualityComparer_T)</code> - Determines whether two enumerable objects are equal.
* <code>[ArrayToString&lt;T&gt;(System.Collections.Generic.IEnumerable&lt;T&gt;)](#ArrayToString_T_System_Collections_Generic_IEnumerable_T)</code> - Not documented yet.
* <code>[ArrayToStringHex(System.Collections.Generic.IEnumerable)](#ArrayToStringHex_System_Collections_Generic_IEnumerable)</code> - Not documented yet. Not documented yet.
* <code>[CompareArrays&lt;T&gt;(System.Collections.Generic.IEnumerable&lt;T&gt;, System.Collections.Generic.IEnumerable&lt;T&gt;, System.Collections.Generic.IComparer&lt;T&gt;) where T : System.IComparable&lt;T&gt;T](#CompareArrays_T_System_Collections_Generic_IEnumerable_T_System_Collections_Generic_IEnumerable_T_System_Collections_Generic_IComparer_T_where_T_System_IComparable_T_T)</code> - Not documented yet.
* <code>[CompareArrays&lt;T&gt;(System.Collections.Generic.IEnumerable&lt;T&gt;, System.Collections.Generic.IEnumerable&lt;T&gt;) where T : System.IComparable&lt;T&gt;T](#CompareArrays_T_System_Collections_Generic_IEnumerable_T_System_Collections_Generic_IEnumerable_T_where_T_System_IComparable_T_T)</code> - Not documented yet.
* <code>[CompareLists&lt;T&gt;(System.Collections.Generic.IList&lt;T&gt;, System.Collections.Generic.IList&lt;T&gt;, System.Collections.Generic.IComparer&lt;T&gt;) where T : System.IComparable&lt;T&gt;T](#CompareLists_T_System_Collections_Generic_IList_T_System_Collections_Generic_IList_T_System_Collections_Generic_IComparer_T_where_T_System_IComparable_T_T)</code> - Compares two lists with the same type of items.
* <code>[CompareLists&lt;T&gt;(System.Collections.Generic.IList&lt;T&gt;, System.Collections.Generic.IList&lt;T&gt;) where T : System.IComparable&lt;T&gt;T](#CompareLists_T_System_Collections_Generic_IList_T_System_Collections_Generic_IList_T_where_T_System_IComparable_T_T)</code> - Compares two lists with the same type of items.
* <code>[FindItem&lt;T&gt;(System.Collections.Generic.IEnumerable&lt;T&gt;, System.Predicate&lt;T&gt;, T)](#FindItem_T_System_Collections_Generic_IEnumerable_T_System_Predicate_T_T)</code> - Not documented yet.
* <code>[FindItem&lt;T&gt;(System.Collections.Generic.IEnumerable&lt;T&gt;, T, T)](#FindItem_T_System_Collections_Generic_IEnumerable_T_T_T)</code> - Finds an item or returns a default value if an item is not found.
* <code>[Reverse&lt;T&gt;(System.Collections.Generic.IList&lt;T&gt;)](#Reverse_T_System_Collections_Generic_IList_T)</code> - Reverses the order of the elements in the given list.
* <code>[Reverse&lt;T&gt;(System.Collections.Generic.IList&lt;T&gt;, int, int)](#Reverse_T_System_Collections_Generic_IList_T_int_int)</code> - Reverses the order of the elements in the given list at the specified index and length.
* <code>[Shuffle&lt;T&gt;(System.Collections.Generic.IList&lt;T&gt;, System.Random)](#Shuffle_T_System_Collections_Generic_IList_T_System_Random)</code> - Randomizes the order of a list's items.
* <code>[ToArray&lt;T&gt;(System.Collections.Generic.IEnumerable&lt;T&gt;)](#ToArray_T_System_Collections_Generic_IEnumerable_T)</code> - Converts an enumerable to an array.

<a id="ArrayHashCode_System_Collections_Generic_IEnumerable"></a>
### ArrayHashCode

    public static int ArrayHashCode(
        System.Collections.Generic.IEnumerable array);

Not documented yet.

<b>Parameters:</b>

 * <i>array</i>: The parameter  <i>array</i>
 is a.Collections.Generic.IEnumerable{System.Double} object.

<b>Return Value:</b>

A 32-bit signed integer.

<a id="ArrayHashCode_T_System_Collections_Generic_IEnumerable_T"></a>
### ArrayHashCode

    public static int ArrayHashCode<T>(
        System.Collections.Generic.IEnumerable<T> array);

Not documented yet.

<b>Parameters:</b>

 * <i>array</i>: The parameter  <i>array</i>
 is a.Collections.Generic.IEnumerable{``0} object.

 * &lt;T&gt;: Type parameter not documented yet.

<b>Return Value:</b>

A 32-bit signed integer.

<a id="ArraysEqual_T_System_Collections_Generic_IEnumerable_T_System_Collections_Generic_IEnumerable_T"></a>
### ArraysEqual

    public static bool ArraysEqual<T>(
        System.Collections.Generic.IEnumerable<T> array1,
        System.Collections.Generic.IEnumerable<T> array2);

Determines whether two enumerable objects are equal.

<b>Parameters:</b>

 * <i>array1</i>: First enumerable to compare.

 * <i>array2</i>: Second enumerable to compare.

 * &lt;T&gt;: Any object type.

<b>Return Value:</b>

 `true`  if both enumerable objects are null or both enumerable objects have the same elements and number of elements in the same order; otherwise,  `false` .

<a id="ArraysEqual_T_System_Collections_Generic_IEnumerable_T_System_Collections_Generic_IEnumerable_T_System_Collections_Generic_IEqualityComparer_T"></a>
### ArraysEqual

    public static bool ArraysEqual<T>(
        System.Collections.Generic.IEnumerable<T> array1,
        System.Collections.Generic.IEnumerable<T> array2,
        System.Collections.Generic.IEqualityComparer<T> comparer);

Determines whether two enumerable objects are equal.

<b>Parameters:</b>

 * <i>array1</i>: The parameter  <i>array1</i>
 is a.Collections.Generic.IEnumerable{``0} object.

 * <i>array2</i>: The parameter  <i>array2</i>
 is a.Collections.Generic.IEnumerable{``0} object.

 * <i>comparer</i>: The parameter  <i>comparer</i>
 is a.Collections.Generic.IEqualityComparer{``0} object.

 * &lt;T&gt;: Not documented yet.

<b>Return Value:</b>

 `true`  if two enumerable objects are equal; otherwise,  `false` .

<b>Exceptions:</b>

 * System.ArgumentNullException:
The parameter  <i>comparer</i>
 is null.

<a id="ArrayToString_T_System_Collections_Generic_IEnumerable_T"></a>
### ArrayToString

    public static string ArrayToString<T>(
        System.Collections.Generic.IEnumerable<T> array);

Not documented yet.

<b>Parameters:</b>

 * <i>array</i>: The parameter  <i>array</i>
 is a.Collections.Generic.IEnumerable{``0} object.

 * &lt;T&gt;: Type parameter not documented yet.

<b>Return Value:</b>

A text string.

<a id="ArrayToStringHex_System_Collections_Generic_IEnumerable"></a>
### ArrayToStringHex

    public static string ArrayToStringHex(
        System.Collections.Generic.IEnumerable array);

Not documented yet.

<b>Parameters:</b>

 * <i>array</i>: The parameter  <i>array</i>
 is a.Collections.Generic.IEnumerable{System.Int32} object.

<b>Return Value:</b>

A text string.

<a id="CompareArrays_T_System_Collections_Generic_IEnumerable_T_System_Collections_Generic_IEnumerable_T_where_T_System_IComparable_T_T"></a>
### CompareArrays

    public static int CompareArrays<T>(
        System.Collections.Generic.IEnumerable<T> array1,
        System.Collections.Generic.IEnumerable<T> array2)
        where T : System.IComparable<T>T;

Not documented yet.

<b>Parameters:</b>

 * <i>array1</i>: The parameter  <i>array1</i>
 is a.Collections.Generic.IEnumerable{``0} object.

 * <i>array2</i>: The parameter  <i>array2</i>
 is a.Collections.Generic.IEnumerable{``0} object.

 * &lt;T&gt;: Type parameter not documented yet.

<b>Return Value:</b>

A 32-bit signed integer.

<a id="CompareArrays_T_System_Collections_Generic_IEnumerable_T_System_Collections_Generic_IEnumerable_T_System_Collections_Generic_IComparer_T_where_T_System_IComparable_T_T"></a>
### CompareArrays

    public static int CompareArrays<T>(
        System.Collections.Generic.IEnumerable<T> array1,
        System.Collections.Generic.IEnumerable<T> array2,
        System.Collections.Generic.IComparer<T> comparer)
        where T : System.IComparable<T>T;

Not documented yet.

<b>Parameters:</b>

 * <i>array1</i>: The parameter  <i>array1</i>
 is a.Collections.Generic.IEnumerable{``0} object.

 * <i>array2</i>: The parameter  <i>array2</i>
 is a.Collections.Generic.IEnumerable{``0} object.

 * <i>comparer</i>: The parameter  <i>comparer</i>
 is a.Collections.Generic.IComparer{``0} object.

 * &lt;T&gt;: Type parameter not documented yet.

<b>Return Value:</b>

A 32-bit signed integer.

<b>Exceptions:</b>

 * System.ArgumentNullException:
The parameter  <i>comparer</i>
 is null.

<a id="CompareLists_T_System_Collections_Generic_IList_T_System_Collections_Generic_IList_T_where_T_System_IComparable_T_T"></a>
### CompareLists

    public static int CompareLists<T>(
        System.Collections.Generic.IList<T> list1,
        System.Collections.Generic.IList<T> list2)
        where T : System.IComparable<T>T;

Compares two lists with the same type of items.

<b>Parameters:</b>

 * <i>list1</i>: The parameter  <i>list1</i>
 is a.Collections.Generic.IList{``0} object.

 * <i>list2</i>: The parameter  <i>list2</i>
 is a.Collections.Generic.IList{``0} object.

 * &lt;T&gt;: Type parameter not documented yet.

<b>Return Value:</b>

A 32-bit signed integer.

<a id="CompareLists_T_System_Collections_Generic_IList_T_System_Collections_Generic_IList_T_System_Collections_Generic_IComparer_T_where_T_System_IComparable_T_T"></a>
### CompareLists

    public static int CompareLists<T>(
        System.Collections.Generic.IList<T> list1,
        System.Collections.Generic.IList<T> list2,
        System.Collections.Generic.IComparer<T> comparer)
        where T : System.IComparable<T>T;

Compares two lists with the same type of items.

<b>Parameters:</b>

 * <i>list1</i>: The parameter  <i>list1</i>
 is a.Collections.Generic.IList{``0} object.

 * <i>list2</i>: The parameter  <i>list2</i>
 is a.Collections.Generic.IList{``0} object.

 * <i>comparer</i>: The parameter  <i>comparer</i>
 is a.Collections.Generic.IComparer{``0} object.

 * &lt;T&gt;: Not documented yet.

<b>Return Value:</b>

A 32-bit signed integer.

<b>Exceptions:</b>

 * System.ArgumentNullException:
The parameter  <i>comparer</i>
 is null.

<a id="FindItem_T_System_Collections_Generic_IEnumerable_T_System_Predicate_T_T"></a>
### FindItem

    public static T FindItem<T>(
        System.Collections.Generic.IEnumerable<T> items,
        System.Predicate<T> func,
        T defaultValue);

Not documented yet.

<b>Parameters:</b>

 * <i>items</i>: The parameter  <i>items</i>
 is a.Collections.Generic.IEnumerable{``0} object.

 * <i>func</i>: The parameter  <i>func</i>
 is a.Predicate{``0} object.

 * <i>defaultValue</i>: The parameter  <i>defaultValue</i>
 is a ``0 object.

 * &lt;T&gt;: Type parameter not documented yet.

<b>Return Value:</b>

A T object.

<b>Exceptions:</b>

 * System.ArgumentNullException:
The parameter  <i>items</i>
 or  <i>func</i>
 is null.

<a id="FindItem_T_System_Collections_Generic_IEnumerable_T_T_T"></a>
### FindItem

    public static T FindItem<T>(
        System.Collections.Generic.IEnumerable<T> items,
        T itemToFind,
        T defaultValue);

Finds an item or returns a default value if an item is not found.

<b>Parameters:</b>

 * <i>items</i>: The parameter  <i>items</i>
 is a.Collections.Generic.IEnumerable{``0} object.

 * <i>itemToFind</i>: The parameter  <i>itemToFind</i>
 is a ``0 object.

 * <i>defaultValue</i>: The parameter  <i>defaultValue</i>
 is a ``0 object.

 * &lt;T&gt;: Not documented yet.

<b>Return Value:</b>

A T object.

<b>Exceptions:</b>

 * System.ArgumentNullException:
The parameter  <i>items</i>
 is null.

<a id="Reverse_T_System_Collections_Generic_IList_T"></a>
### Reverse

    public static void Reverse<T>(
        System.Collections.Generic.IList<T> list);

Reverses the order of the elements in the given list.

<b>Parameters:</b>

 * <i>list</i>: The parameter  <i>list</i>
 is an IList object.

 * &lt;T&gt;: Any object type.

<b>Exceptions:</b>

 * System.ArgumentNullException:
The parameter  <i>list</i>
 is null.

<a id="Reverse_T_System_Collections_Generic_IList_T_int_int"></a>
### Reverse

    public static void Reverse<T>(
        System.Collections.Generic.IList<T> list,
        int index,
        int count);

Reverses the order of the elements in the given list at the specified index and length.

<b>Parameters:</b>

 * <i>list</i>: The list where the order of elements should be reversed.

 * <i>index</i>: An index starting at 0 showing where the desired portion of  <i>list</i>
 begins.

 * <i>count</i>: The number of elements in the desired portion of  <i>list</i>
 (but not more than  <i>list</i>
 's length).

 * &lt;T&gt;: Any object type.

<b>Exceptions:</b>

 * System.ArgumentException:
Either  <i>index</i>
 or  <i>count</i>
 is less than 0 or greater than  <i>list</i>
 's length, or  <i>list</i>
 's length minus  <i>index</i>
 is less than  <i>count</i>
.

 * System.ArgumentNullException:
The parameter  <i>list</i>
 is null.

<a id="Shuffle_T_System_Collections_Generic_IList_T_System_Random"></a>
### Shuffle

    public static void Shuffle<T>(
        System.Collections.Generic.IList<T> list,
        System.Random random);

Randomizes the order of a list's items.

<b>Parameters:</b>

 * <i>list</i>: The parameter  <i>list</i>
 is an IList object.

 * <i>random</i>: The parameter  <i>random</i>
 is a Random object.

 * &lt;T&gt;: Any object type.

<b>Exceptions:</b>

 * System.ArgumentNullException:
The parameter  <i>random</i>
 or  <i>list</i>
 is null.

<a id="ToArray_T_System_Collections_Generic_IEnumerable_T"></a>
### ToArray

    public static PeterO.T<>[] ToArray<T>(
        System.Collections.Generic.IEnumerable<T> collection);

Converts an enumerable to an array.

<b>Parameters:</b>

 * <i>collection</i>: The parameter  <i>collection</i>
 is a.Collections.Generic.IEnumerable{``0} object.

 * &lt;T&gt;: Not documented yet.

<b>Return Value:</b>

A T[] object.

<b>Exceptions:</b>

 * System.ArgumentNullException:
The parameter _collection_ is null.
