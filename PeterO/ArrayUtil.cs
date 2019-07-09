/*
Written by Peter O.
Any copyright to this work is released to the Public Domain.
In case this is not possible, this work is also
licensed under Creative Commons Zero (CC0):
http://creativecommons.org/publicdomain/zero/1.0/
If you like this, you should donate to Peter O.
at: http://peteroupc.github.io/
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace PeterO {
  /// <summary>Not documented yet.</summary>
  public static class ArrayUtil {
    /// <summary>Randomizes the order of a list's items.</summary>
    /// <param name='list'>The parameter <paramref name='list'/> is an
    /// IList object.</param>
    /// <param name='random'>The parameter <paramref name='random'/> is a
    /// Random object.</param>
    /// <typeparam name='T'>Any object type.</typeparam>
    /// <exception cref='ArgumentNullException'>The parameter <paramref
    /// name='random'/> or <paramref name='list'/> is null.</exception>
    public static void Shuffle<T> (IList<T> list, Random random) {
      if (random == null) {
        throw new ArgumentNullException(nameof(random));
      }
      if (list == null) {
        throw new ArgumentNullException(nameof(list));
      }
      for (int i = list.Count - 1; i >= 1; --i) {
        var other = random.Next (i + 1);
        if (i != other) {
          var obj = list[i];
          list[i] = list[other];
          list[other] = obj;
        }
      }
    }

    /// <summary>Reverses the order of the elements in the given
    /// list.</summary>
    /// <param name='list'>The parameter <paramref name='list'/> is an
    /// IList object.</param>
    /// <typeparam name='T'>Any object type.</typeparam>
    /// <exception cref='ArgumentNullException'>The parameter <paramref
    /// name='list'/> is null.</exception>
    public static void Reverse<T> (IList<T> list) {
      if (list == null) {
        throw new ArgumentNullException(nameof(list));
      }
      var half = list.Count >> 1;
      var right = list.Count - 1;
      for (int i = 0; i < half; i++, right--) {
        var value = list[i];
        list[i] = list[right];
        list[right] = value;
      }
    }

    /// <summary>Reverses the order of the elements in the given list at
    /// the specified index and length.</summary>
    /// <param name='list'>The list where the order of elements should be
    /// reversed.</param>
    /// <param name='index'>An index starting at 0 showing where the
    /// desired portion of <paramref name='list'/> begins.</param>
    /// <param name='count'>The number of elements in the desired portion
    /// of <paramref name='list'/> (but not more than <paramref
    /// name='list'/> 's length).</param>
    /// <typeparam name='T'>Any object type.</typeparam>
    /// <exception cref='ArgumentException'>Either <paramref name='index'/>
    /// or <paramref name='count'/> is less than 0 or greater than
    /// <paramref name='list'/> 's length, or <paramref name='list'/> 's
    /// length minus <paramref name='index'/> is less than <paramref
    /// name='count'/>.</exception>
    /// <exception cref='ArgumentNullException'>The parameter <paramref
    /// name='list'/> is null.</exception>
    public static void Reverse<T> (IList<T> list, int index, int count) {
      if (list == null) {
        throw new ArgumentNullException(nameof(list));
      }
      if (index < 0) {
        throw new ArgumentException("index (" + index + ") is less than 0");
      }
      if (index > list.Count) {
        throw new ArgumentException("index (" + index + ") is more than " +
          list.Count);
      }
      if (count < 0) {
        throw new ArgumentException("count (" + count + ") is less than 0");
      }
      if (count > list.Count) {
        throw new ArgumentException("count (" + count + ") is more than " +
          list.Count);
      }
      if (list.Count - index < count) {
        throw new ArgumentException("list's length minus " + index + " (" +
          (list.Count - index) + ") is less than " + count);
      }
      var half = index + (count >> 1);
      var right = index + count - 1;
      for (int i = index; i < half; i++, right--) {
        var value = list[i];
        list[i] = list[right];
        list[right] = value;
      }
    }

    /// <summary>Finds an item or returns a default value if an item is not
    /// found.</summary>
    /// <param name='items'>The parameter <paramref name='items'/> is
    /// a.Collections.Generic.IEnumerable{``0} object.</param>
    /// <param name='itemToFind'>The parameter <paramref
    /// name='itemToFind'/> is a ``0 object.</param>
    /// <param name='defaultValue'>The parameter <paramref
    /// name='defaultValue'/> is a ``0 object.</param>
    /// <typeparam name='T'>Not documented yet.</typeparam>
    /// <returns>A T object.</returns>
    /// <exception cref='ArgumentNullException'>The parameter <paramref
    /// name='items'/> is null.</exception>
    public static T FindItem<T> (
      IEnumerable<T> items,
      T itemToFind,
      T defaultValue) {
      if (items == null) {
        throw new ArgumentNullException(nameof(items));
      }
      var eqc = EqualityComparer<T>.Default;
      foreach (T item in items) {
        if (eqc.Equals (item, itemToFind)) {
          return item;
        }
      }
      return defaultValue;
    }

    /// <summary>Not documented yet.</summary>
    /// <param name='items'>The parameter <paramref name='items'/> is
    /// a.Collections.Generic.IEnumerable{``0} object.</param>
    /// <param name='func'>The parameter <paramref name='func'/> is
    /// a.Predicate{``0} object.</param>
    /// <param name='defaultValue'>The parameter <paramref
    /// name='defaultValue'/> is a ``0 object.</param>
    /// <typeparam name='T'>Type parameter not documented yet.</typeparam>
    /// <returns>A T object.</returns>
    /// <exception cref='ArgumentNullException'>The parameter <paramref
    /// name='items'/> or <paramref name='func'/> is null.</exception>
    public static T FindItem<T> (
      IEnumerable<T> items,
      Predicate<T> func,
      T defaultValue) {
      if (items == null) {
        throw new ArgumentNullException(nameof(items));
      }
      if (func == null) {
        throw new ArgumentNullException(nameof(func));
      }
      foreach (T item in items) {
        if (func (item)) {
          return item;
        }
      }
      return defaultValue;
    }

    /// <summary>Converts an enumerable to an array.</summary>
    /// <param name='collection'>The parameter <paramref
    /// name='collection'/> is a.Collections.Generic.IEnumerable{``0}
    /// object.</param>
    /// <typeparam name='T'>Not documented yet.</typeparam>
    /// <returns>A T[] object.</returns>
    /// <exception cref='ArgumentNullException'>The parameter _collection_
    /// is null.</exception>
    public static T[] ToArray<T> (IEnumerable<T> collection) {
      if (collection == null) {
        throw new ArgumentNullException(nameof(collection));
      }
      var list = collection as List<T>;
      return (list != null) ? list.ToArray() : new
List<T>(collection).ToArray();
    }

    /// <summary>Compares two lists with the same type of items.</summary>
    /// <param name='list1'>The parameter <paramref name='list1'/> is
    /// a.Collections.Generic.IList{``0} object.</param>
    /// <param name='list2'>The parameter <paramref name='list2'/> is
    /// a.Collections.Generic.IList{``0} object.</param>
    /// <typeparam name='T'>Type parameter not documented yet.</typeparam>
    /// <returns>A 32-bit signed integer.</returns>
    public static int CompareLists<T> (IList<T> list1, IList<T> list2) where T :
      IComparable<T> {
      return CompareLists (list1, list2, Comparer<T>.Default);
    }

    /// <summary>Compares two lists with the same type of items.</summary>
    /// <param name='list1'>The parameter <paramref name='list1'/> is
    /// a.Collections.Generic.IList{``0} object.</param>
    /// <param name='list2'>The parameter <paramref name='list2'/> is
    /// a.Collections.Generic.IList{``0} object.</param>
    /// <param name='comparer'>The parameter <paramref name='comparer'/> is
    /// a.Collections.Generic.IComparer{``0} object.</param>
    /// <typeparam name='T'>Not documented yet.</typeparam>
    /// <returns>A 32-bit signed integer.</returns>
    /// <exception cref='ArgumentNullException'>The parameter <paramref
    /// name='comparer'/> is null.</exception>
    public static int CompareLists<T> (
      IList<T> list1,
      IList<T> list2,
      IComparer<T> comparer) where T : IComparable<T> {
      var c = 0;
      if (comparer == null) {
        throw new ArgumentNullException(nameof(comparer));
      }
      if (list1 == list2) {
        return 0;
      }
      if (list1 == null) {
        return -1;
      }
      if (list2 == null) {
        return 1;
      }
      var len = Math.Min (list1.Count, list2.Count);
      for (int i = 0; i < len; ++i) {
        c = comparer.Compare (list1[i], list2[i]);
        if (c != 0) {
          break;
        }
      }
      if (c == 0) {
        c = list1.Count - list2.Count;
      }
      return c;
    }

    /// <summary>Not documented yet.</summary>
    /// <param name='array1'>The parameter <paramref name='array1'/> is
    /// a.Collections.Generic.IEnumerable{``0} object.</param>
    /// <param name='array2'>The parameter <paramref name='array2'/> is
    /// a.Collections.Generic.IEnumerable{``0} object.</param>
    /// <typeparam name='T'>Type parameter not documented yet.</typeparam>
    /// <returns>A 32-bit signed integer.</returns>
    public static int CompareArrays<T> (
      IEnumerable<T> array1,
      IEnumerable<T> array2) where T : IComparable<T> {
      return CompareArrays (array1, array2, Comparer<T>.Default);
    }

    /// <summary>Not documented yet.</summary>
    /// <param name='array1'>The parameter <paramref name='array1'/> is
    /// a.Collections.Generic.IEnumerable{``0} object.</param>
    /// <param name='array2'>The parameter <paramref name='array2'/> is
    /// a.Collections.Generic.IEnumerable{``0} object.</param>
    /// <param name='comparer'>The parameter <paramref name='comparer'/> is
    /// a.Collections.Generic.IComparer{``0} object.</param>
    /// <typeparam name='T'>Type parameter not documented yet.</typeparam>
    /// <returns>A 32-bit signed integer.</returns>
    /// <exception cref='ArgumentNullException'>The parameter <paramref
    /// name='comparer'/> is null.</exception>
    public static int CompareArrays<T> (
      IEnumerable<T> array1,
      IEnumerable<T> array2,
      IComparer<T> comparer) where T : IComparable<T> {
      if (comparer == null) {
        throw new ArgumentNullException(nameof(comparer));
      }
      if (array1 == array2) {
        return 0;
      }
      if (array1 == null) {
        return -1;
      }
      if (array2 == null) {
        return 1;
      }
      using (IEnumerator<T> enumA = array1.GetEnumerator()) {
        using (IEnumerator<T> enumB = array2.GetEnumerator()) {
          while (true) {
            var moveA = enumA.MoveNext();
            var moveB = enumB.MoveNext();
            if (moveA && !moveB) {
              // a has more items than b
              return 1;
            }
            if (!moveA && moveB) {
              // b has more items than a
              return -1;
            }
            if (!moveA) {
              // both have no items left
              return 0;
            }
            var c = comparer.Compare (enumA.Current, enumB.Current);
            if (c != 0) {
              return c;
            }
          }
        }
      }
    }

    /// <summary>Determines whether two enumerable objects are
    /// equal.</summary>
    /// <param name='array1'>First enumerable to compare.</param>
    /// <param name='array2'>Second enumerable to compare.</param>
    /// <typeparam name='T'>Any object type.</typeparam>
    /// <returns><c>true</c> if both enumerable objects are null or both
    /// enumerable objects have the same elements and number of elements in
    /// the same order; otherwise, <c>false</c>.</returns>
    public static bool ArraysEqual<T> (
      IEnumerable<T> array1,
      IEnumerable<T> array2) {
      return ArraysEqual (array1, array2, EqualityComparer<T>.Default);
    }

    /// <summary>Determines whether two enumerable objects are
    /// equal.</summary>
    /// <param name='array1'>The parameter <paramref name='array1'/> is
    /// a.Collections.Generic.IEnumerable{``0} object.</param>
    /// <param name='array2'>The parameter <paramref name='array2'/> is
    /// a.Collections.Generic.IEnumerable{``0} object.</param>
    /// <param name='comparer'>The parameter <paramref name='comparer'/> is
    /// a.Collections.Generic.IEqualityComparer{``0} object.</param>
    /// <typeparam name='T'>Not documented yet.</typeparam>
    /// <returns><c>true</c> if two enumerable objects are equal;
    /// otherwise, <c>false</c>.</returns>
    /// <exception cref='ArgumentNullException'>The parameter <paramref
    /// name='comparer'/> is null.</exception>
    public static bool ArraysEqual<T> (
      IEnumerable<T> array1,
      IEnumerable<T> array2,
      IEqualityComparer<T> comparer) {
      if (comparer == null) {
        throw new ArgumentNullException(nameof(comparer));
      }
      if (array1 == array2) {
        return true;
      }
      if (array1 == null || array2 == null) {
        return false;
      }
      var ret = false;
      using (IEnumerator<T> enumA = array1.GetEnumerator()) {
        using (IEnumerator<T> enumB = array2.GetEnumerator()) {
          while (true) {
            var moveA = enumA.MoveNext();
            var moveB = enumB.MoveNext();
            if (moveA != moveB) {
              ret = false;
              break;
            }
            if (!moveA) {
              ret = true;
              break;
            }
            if (!comparer.Equals (enumA.Current, enumB.Current)) {
              ret = false;
              break;
            }
          }
        }
      }
      return ret;
    }

    /// <summary>Not documented yet.</summary>
    /// <param name='array'>The parameter <paramref name='array'/> is
    /// a.Collections.Generic.IEnumerable{System.Byte} object.</param>
    /// <returns>A text string.</returns>
    public static string ArrayToStringHex (IEnumerable<byte> array) {
      if (array == null) {
        return "null";
      }
      var b = new StringBuilder();
      b.Append ("{");
      var first = true;
      string hex = "0123456789ABCDEF";
      foreach (byte value in array) {
        if (!first) {
          b.Append (", ");
        }
        b.Append (hex[ (int)((value >> 4) & 15)]);
        b.Append (hex[ (int)(value & 15)]);
        first = false;
      }
      b.Append ("}");
      return b.ToString();
    }

    /// <summary>Not documented yet.</summary>
    /// <param name='array'>The parameter <paramref name='array'/> is
    /// a.Collections.Generic.IEnumerable{System.Int32} object.</param>
    /// <returns>A text string.</returns>
    public static string ArrayToStringHex (IEnumerable<int> array) {
      if (array == null) {
        return "null";
      }
      var b = new StringBuilder();
      b.Append ("{");
      var first = true;
      string hex = "0123456789ABCDEF";
      foreach (int value in array) {
        if (!first) {
          b.Append (", ");
        }
        b.Append (hex[ (int)((value >> 28) & 15)]);
        b.Append (hex[ (int)((value >> 24) & 15)]);
        b.Append (hex[ (int)((value >> 20) & 15)]);
        b.Append (hex[ (int)((value >> 16) & 15)]);
        b.Append (hex[ (int)((value >> 12) & 15)]);
        b.Append (hex[ (int)((value >> 8) & 15)]);
        b.Append (hex[ (int)((value >> 4) & 15)]);
        b.Append (hex[ (int)(value & 15)]);
        first = false;
      }
      b.Append ("}");
      return b.ToString();
    }

    /// <summary>Not documented yet.</summary>
    /// <param name='array'>The parameter <paramref name='array'/> is
    /// a.Collections.Generic.IEnumerable{``0} object.</param>
    /// <typeparam name='T'>Type parameter not documented yet.</typeparam>
    /// <returns>A text string.</returns>
    public static string ArrayToString<T> (IEnumerable<T> array) {
      if (array == null) {
        return "null";
      }
      var b = new StringBuilder();
      b.Append ("{");
      var first = true;
      foreach (T value in array) {
        if (!first) {
          b.Append (", ");
        }
        b.Append (String.Empty + value);
        first = false;
      }
      b.Append ("}");
      return b.ToString();
    }

    /// <summary>Not documented yet.</summary>
    /// <param name='array'>The parameter <paramref name='array'/> is
    /// a.Collections.Generic.IEnumerable{System.Byte} object.</param>
    /// <returns>A 32-bit signed integer.</returns>
    public static int ArrayHashCode (IEnumerable<byte> array) {
      var ret = 17;
      if (array != null) {
        foreach (byte value in array) {
          ret = (37 * ret) + (int)value;
        }
      }
      return ret;
    }

    /// <summary>Not documented yet.</summary>
    /// <param name='array'>The parameter <paramref name='array'/> is
    /// a.Collections.Generic.IEnumerable{System.Int32} object.</param>
    /// <returns>A 32-bit signed integer.</returns>
    public static int ArrayHashCode (IEnumerable<int> array) {
      var ret = 17;
      if (array != null) {
        foreach (int value in array) {
          ret += (37 * ret) + value;
        }
      }
      return ret;
    }

    /// <summary>Not documented yet.</summary>
    /// <param name='array'>The parameter <paramref name='array'/> is
    /// a.Collections.Generic.IEnumerable{System.Single} object.</param>
    /// <returns>A 32-bit signed integer.</returns>
    public static int ArrayHashCode (IEnumerable<float> array) {
      var ret = 17;
      if (array != null) {
        foreach (float value in array) {
          ret += (
              37 * ret) + BitConverter.ToInt32(
              BitConverter.GetBytes ((float)value),
              0);
        }
      }
      return ret;
    }

    /// <summary>Not documented yet.</summary>
    /// <param name='array'>The parameter <paramref name='array'/> is
    /// a.Collections.Generic.IEnumerable{System.Double} object.</param>
    /// <returns>A 32-bit signed integer.</returns>
    public static int ArrayHashCode (IEnumerable<double> array) {
      var ret = 17;
      if (array != null) {
        foreach (double value in array) {
          var code = BitConverter.ToInt64 (BitConverter.GetBytes
((double)value), 0);
          ret += (37 * ret) + (int)(code ^ (code >> 32));
        }
      }
      return ret;
    }

    /// <summary>Not documented yet.</summary>
    /// <param name='array'>The parameter <paramref name='array'/> is
    /// a.Collections.Generic.IEnumerable{``0} object.</param>
    /// <typeparam name='T'>Type parameter not documented yet.</typeparam>
    /// <returns>A 32-bit signed integer.</returns>
    public static int ArrayHashCode<T> (IEnumerable<T> array) {
      var ret = 17;
      if (array != null) {
        foreach (T value in array) {
          ret *= 37;
          if ((object)value != (object)default (T)) {
            ret += value.GetHashCode();
          }
        }
      }
      return ret;
    }
  }
}
