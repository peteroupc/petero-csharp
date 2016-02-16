## PeterO.ArrayUtil

    public static class ArrayUtil

Not documented yet.

### ArrayHashCode

    public static int ArrayHashCode(
        System.Collections.Generic.IEnumerable array);

Not documented yet.

<b>Parameters:</b>

 * <i>array</i>: The parameter  <i>array</i>
 is not documented yet.

<b>Return Value:</b>

A 32-bit signed integer.

### ArrayHashCode

    public static int ArrayHashCode<T>(
        System.Collections.Generic.IEnumerable<T> array);

Not documented yet.

<b>Parameters:</b>

 * <i>array</i>: An IEnumerable object.

 * &lt;T&gt;: Type parameter not documented yet.

<b>Return Value:</b>

A 32-bit signed integer.

### ArraysEqual

    public static bool ArraysEqual(
        System.Collections.Generic.IEnumerable array1,
        System.Collections.Generic.IEnumerable array2);

Not documented yet.

<b>Parameters:</b>

 * <i>array1</i>: The parameter  <i>array1</i>
 is not documented yet.

 * <i>array2</i>: The parameter  <i>array2</i>
 is not documented yet.

<b>Return Value:</b>

A Boolean object.

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

 `true`  if both enumerable objects are null or both enumerable objects have the same elements and number of elements in the same order; otherwise, false .

### ArraysEqual

    public static bool ArraysEqual<T>(
        System.Collections.Generic.IEnumerable<T> array1,
        System.Collections.Generic.IEnumerable<T> array2,
        System.Collections.Generic.IEqualityComparer<T> comparer);

Determines whether two enumerable objects are equal.

<b>Parameters:</b>

 * <i>array1</i>: First enumerable to compare.

 * <i>array2</i>: Second enumerable to compare.

 * <i>comparer</i>: Equality comparer for comparing each element in the enumerable objects.

 * &lt;T&gt;: Not documented yet.

<b>Return Value:</b>

 `true`  if both enumerable objects are null or both enumerable objects have the same elements and number of elements in the same order; otherwise, false .

<b>Exceptions:</b>

 * System.ArgumentNullException:
The parameter <i>comparer</i>
 is null.

### ArrayToString

    public static string ArrayToString<T>(
        System.Collections.Generic.IEnumerable<T> array);

Not documented yet.

<b>Parameters:</b>

 * <i>array</i>: An IEnumerable object.

 * &lt;T&gt;: Type parameter not documented yet.

<b>Return Value:</b>

A text string.

### ArrayToStringHex

    public static string ArrayToStringHex(
        System.Collections.Generic.IEnumerable array);

Not documented yet.

<b>Parameters:</b>

 * <i>array</i>: The parameter  <i>array</i>
 is not documented yet.

<b>Return Value:</b>

A text string.

### ArrayToStringHex

    public static string ArrayToStringHex<T>(
        System.Collections.Generic.IEnumerable<T> array);

Not documented yet.

<b>Parameters:</b>

 * <i>array</i>: An IEnumerable object.

 * &lt;T&gt;: Type parameter not documented yet.

<b>Return Value:</b>

A text string.

### CompareArrays

    public static int CompareArrays<T>(
        System.Collections.Generic.IEnumerable<T> array1,
        System.Collections.Generic.IEnumerable<T> array2)
        where T : System.IComparable<T>T;

Not documented yet.

<b>Parameters:</b>

 * <i>array1</i>: An IEnumerable object.

 * <i>array2</i>: An IEnumerable object.

 * &lt;T&gt;: Type parameter not documented yet.

<b>Return Value:</b>

A 32-bit signed integer.

### CompareArrays

    public static int CompareArrays<T>(
        System.Collections.Generic.IEnumerable<T> array1,
        System.Collections.Generic.IEnumerable<T> array2,
        System.Collections.Generic.IComparer<T> comparer)
        where T : System.IComparable<T>T;

Not documented yet.

<b>Parameters:</b>

 * <i>array1</i>: An IEnumerable object.

 * <i>array2</i>: An IEnumerable object.

 * <i>comparer</i>: An IComparer object.

 * &lt;T&gt;: Type parameter not documented yet.

<b>Return Value:</b>

A 32-bit signed integer.

<b>Exceptions:</b>

 * System.ArgumentNullException:
The parameter <i>comparer</i>
 is null.

### CompareLists

    public static int CompareLists<T>(
        System.Collections.Generic.IList<T> list1,
        System.Collections.Generic.IList<T> list2)
        where T : System.IComparable<T>T;

Compares two lists with the same type of items.

The examples below will clarify the comparison rules used in this method. In the examples below, this method would return -1 if it were passed the following pairs of lists, since list 1 is less than list 2:

list1 = {0, 2, 5, 1}

list2 = {2, 2, 5, 1}

list1 = {0, 2, 5, 3}

list2 = {0, 2, 7, 1}

list1 = {0, 2, 5, 3, 0, 5, 6}

list2 = {0, 2, 7, 1}

list1 = null

list2 = {0}

list1 = {0, 2, 5}

list2 = {0, 2, 5, 0}

If instead, list1 and list2 were switched, the method would return 1, since list1 is now greater than list2.

<b>Parameters:</b>

 * <i>list1</i>: The first list to compare. Can be null.

 * <i>list2</i>: The second list of compare. Can be null.

 * &lt;T&gt;: Not documented yet.

<b>Return Value:</b>

A 32-bit signed integer.

### CompareLists

    public static int CompareLists<T>(
        System.Collections.Generic.IList<T> list1,
        System.Collections.Generic.IList<T> list2,
        System.Collections.Generic.IComparer<T> comparer)
        where T : System.IComparable<T>T;

Compares two lists with the same type of items.

See CompareLists(IList, IList) for an example of the comparison rules.

<b>Parameters:</b>

 * <i>list1</i>: The first list to compare. Can be null.

 * <i>list2</i>: The second list of compare. Can be null.

 * <i>comparer</i>: An IComparer object.

 * &lt;T&gt;: Not documented yet.

<b>Return Value:</b>

A 32-bit signed integer.

<b>Exceptions:</b>

 * System.ArgumentNullException:
The parameter <i>comparer</i>
 is null.

### FindItem

    public static T FindItem<T>(
        System.Collections.Generic.IEnumerable<T> items,
        System.Predicate<T> func,
        T defaultValue);

Not documented yet.

<b>Parameters:</b>

 * <i>items</i>: An IEnumerable object.

 * <i>func</i>: A Predicate object.

 * <i>defaultValue</i>: Another T object.

 * &lt;T&gt;: Type parameter not documented yet.

<b>Return Value:</b>

A T object.

<b>Exceptions:</b>

 * System.ArgumentNullException:
The parameter <i>items</i>
 or  <i>func</i>
 is null.

### FindItem

    public static T FindItem<T>(
        System.Collections.Generic.IEnumerable<T> items,
        T itemToFind,
        T defaultValue);

Finds an item or returns a default value if an item is not found.

<b>Parameters:</b>

 * <i>items</i>: An IEnumerable object.

 * <i>itemToFind</i>: An item to compare with each item in the list.

 * <i>defaultValue</i>: This value is returned if _itemToFind_ is not found.

 * &lt;T&gt;: Not documented yet.

<b>Return Value:</b>

The item within the list that equals _itemToFind_, or _defaultValue_ if the item is not found.

<b>Exceptions:</b>

 * System.ArgumentNullException:
The parameter <i>items</i>
 is null.

### Reverse

    public static void Reverse<T>(
        System.Collections.Generic.IList<T> list);

Reverses the order of the elements in the given list.

<b>Parameters:</b>

 * <i>list</i>: An IList object.

 * &lt;T&gt;: Any object type.

<b>Exceptions:</b>

 * System.ArgumentNullException:
The parameter "array" is null.

### Reverse

    public static void Reverse<T>(
        System.Collections.Generic.IList<T> list,
        int index,
        int count);

Reverses the order of the elements in the given list at the specified index and length.

<b>Parameters:</b>

 * <i>list</i>: The list where the order of elements should be reversed.

 * <i>index</i>: Starting index in the list.

 * <i>count</i>: Number of elements in the list to reverse.

 * &lt;T&gt;: Any object type.

<b>Exceptions:</b>

 * System.ArgumentNullException:
The parameter <i>list</i>
 is null.

 * System.ArgumentException:
Either  <i>index</i>
 or  <i>count</i>
 is less than 0 or greater than  <i>list</i>
 's length, or  <i>list</i>
 ' s length minus  <i>index</i>
 is less than  <i>count</i>
.

### Shuffle

    public static void Shuffle<T>(
        System.Collections.Generic.IList<T> list,
        System.Random random);

Randomizes the order of a list's items.

<b>Parameters:</b>

 * <i>list</i>: An IList object.

 * <i>random</i>: A Random object.

 * &lt;T&gt;: Any object type.

<b>Exceptions:</b>

 * System.ArgumentNullException:
The parameter <i>random</i>
 or  <i>list</i>
 is null.

### Sort

    public static void Sort(
        int[] array);

Not documented yet.

<b>Parameters:</b>

 * <i>array</i>: An array of 32-bit unsigned integers.

<b>Exceptions:</b>

 * System.ArgumentNullException:
The parameter <i>array</i>
 is null.

### Sort

    public static void Sort(
        int[] array,
        int offset,
        int count);

Not documented yet.

<b>Parameters:</b>

 * <i>array</i>: An array of 32-bit unsigned integers.

 * <i>offset</i>: A zero-based index showing where the desired portion of  <i>array</i>
 begins.

 * <i>count</i>: The number of elements in the desired portion of  <i>array</i>
 (but not more than  <i>array</i>
 's length).

<b>Exceptions:</b>

 * System.ArgumentNullException:
The parameter <i>array</i>
 is null.

 * System.ArgumentException:
Either  <i>offset</i>
 or  <i>count</i>
 is less than 0 or greater than  <i>array</i>
 's length, or  <i>array</i>
 ' s length minus  <i>offset</i>
 is less than  <i>count</i>
.

### Sort

    public static void Sort<T>(
        System.Collections.Generic.IList<T> array,
        System.Collections.Generic.IComparer<T> comparer);

Not documented yet.

<b>Parameters:</b>

 * <i>array</i>: An IList object.

 * <i>comparer</i>: An IComparer object.

 * &lt;T&gt;: Type parameter not documented yet.

<b>Exceptions:</b>

 * System.ArgumentNullException:
The parameter <i>array</i>
 or  <i>comparer</i>
 is null.

### Sort

    public static void Sort<T>(
        System.Collections.Generic.IList<T> list)
        where T : System.IComparable<T>T;

Not documented yet.

<b>Parameters:</b>

 * <i>list</i>: An IList object.

 * &lt;T&gt;: Type parameter not documented yet.

<b>Exceptions:</b>

 * System.ArgumentNullException:
The parameter <i>list</i>
 is null.

### Sort

    public static void Sort<T>(
        System.Collections.Generic.IList<T> list,
        int offset,
        int count)
        where T : System.IComparable<T>T;

Not documented yet.

<b>Parameters:</b>

 * <i>list</i>: An IList object.

 * <i>offset</i>: A zero-based index showing where the desired portion of  <i>list</i>
 begins.

 * <i>count</i>: The number of elements in the desired portion of  <i>list</i>
 (but not more than  <i>list</i>
 's length).

 * &lt; T&gt;: Type parameter not documented yet.

<b>Exceptions:</b>

 * !: T:System.ArgumentNullException:
The parameter <i>list</i>
 is null.

 * System.ArgumentException:
Either  <i>offset</i>
 or  <i>count</i>
 is less than 0 or greater than  <i>list</i>
 's length, or  <i>list</i>
 ' s length minus  <i>offset</i>
 is less than  <i>count</i>
.

 * System.ArgumentNullException:
The parameter  <i>list</i>
 is null.

### Sort

    public static void Sort<T>(
        System.Collections.Generic.IList<T> list,
        int offset,
        int count,
        System.Collections.Generic.IComparer<T> comparer);

Not documented yet.

<b>Parameters:</b>

 * <i>list</i>: An IList object.

 * <i>offset</i>: A zero-based index showing where the desired portion of  <i>list</i>
 begins.

 * <i>count</i>: The number of elements in the desired portion of  <i>list</i>
 (but not more than  <i>list</i>
 's length).

 * <i>comparer</i>: An IComparer object.

 * &lt; T&gt;: Type parameter not documented yet.

<b>Exceptions:</b>

 * !: T:System.ArgumentNullException:
The parameter <i>list</i>
 or  <i>comparer</i>
 is null.

 * System.ArgumentException:
Either  <i>offset</i>
 or  <i>count</i>
 is less than 0 or greater than  <i>list</i>
 's length, or  <i>list</i>
 ' s length minus  <i>offset</i>
 is less than  <i>count</i>
.

 * System.ArgumentNullException:
The parameter  <i>list</i>
 or  <i>comparer</i>
 is null.

### StableSort

    public static void StableSort<T>(
        System.Collections.Generic.IList<T> list)
        where T : System.IComparable<T>T;

Not documented yet.

<b>Parameters:</b>

 * <i>list</i>: An IList object.

 * &lt;T&gt;: Type parameter not documented yet.

<b>Exceptions:</b>

 * System.ArgumentNullException:
The parameter <i>list</i>
 is null.

### StableSort

    public static void StableSort<T>(
        System.Collections.Generic.IList<T> list,
        int offset,
        int count)
        where T : System.IComparable<T>T;

Sorts an array of objects using a sorting method that preserves the order of equal elements.

<b>Parameters:</b>

 * <i>list</i>: An IList object.

 * <i>offset</i>: A zero-based index showing where the desired portion of  <i>list</i>
 begins.

 * <i>count</i>: The number of elements in the desired portion of  <i>list</i>
 (but not more than  <i>list</i>
 's length).

 * &lt; T&gt;: Type parameter not documented yet.

<b>Exceptions:</b>

 * !: T:System.ArgumentNullException:
The parameter <i>list</i>
 is null.

 * System.ArgumentException:
Either  <i>offset</i>
 or  <i>count</i>
 is less than 0 or greater than  <i>list</i>
 's length, or  <i>list</i>
 ' s length minus  <i>offset</i>
 is less than  <i>count</i>
.

 * System.ArgumentNullException:
The parameter  <i>list</i>
 is null.

### StableSort

    public static void StableSort<T>(
        System.Collections.Generic.IList<T> list,
        int offset,
        int count,
        System.Collections.Generic.IComparer<T> comparer);

Sorts an array of objects using a sorting method that preserves the order of equal elements.

<b>Parameters:</b>

 * <i>list</i>: An IList object.

 * <i>offset</i>: A zero-based index showing where the desired portion of  <i>list</i>
 begins.

 * <i>count</i>: The number of elements in the desired portion of  <i>list</i>
 (but not more than  <i>list</i>
 's length).

 * <i>comparer</i>: An IComparer object.

 * &lt;T&gt;: Any object type.

<b>Exceptions:</b>

 * System.ArgumentNullException:
The parameter <i>list</i>
 or  <i>comparer</i>
 is null.

 * System.ArgumentException:
Either  <i>offset</i>
 or  <i>count</i>
 is less than 0 or greater than  <i>list</i>
 's length, or  <i>list</i>
 ' s length minus  <i>offset</i>
 is less than  <i>count</i>
.

### StableSort

    public static void StableSort<T>(
        System.Collections.Generic.IList<T> list,
        System.Collections.Generic.IComparer<T> comparer);

Not documented yet.

<b>Parameters:</b>

 * <i>list</i>: An IList object.

 * <i>comparer</i>: An IComparer object.

 * &lt;T&gt;: Type parameter not documented yet.

<b>Exceptions:</b>

 * System.ArgumentNullException:
The parameter <i>list</i>
 or  <i>comparer</i>
 is null.

### ToArray

    public static PeterO.T<>[] ToArray<T>(
        System.Collections.Generic.IEnumerable<T> collection);

Converts an enumerable to an array.

<b>Parameters:</b>

 * <i>collection</i>: An enumerable converted to an array.

 * &lt;T&gt;: Not documented yet.

<b>Return Value:</b>

An array generated from the specified enumerable. Note that the order of elements is not guaranteed if the enumerable does not implement IList.

<b>Exceptions:</b>

 * System.ArgumentNullException:
The parameter _collection_ is null.
