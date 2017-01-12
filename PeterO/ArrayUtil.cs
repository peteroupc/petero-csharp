/*
Written by Peter O.
Any copyright is dedicated to the Public Domain.
http://creativecommons.org/publicdomain/zero/1.0/
If you like this, you should donate to Peter O.
at: http://peteroupc.github.io/
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace PeterO {
    /// <include file='../docs.xml'
    /// path='docs/doc[@name="T:PeterO.ArrayUtil"]/*'/>
  public static class ArrayUtil {
    /// <include file='../docs.xml'
    /// path='docs/doc[@name="M:PeterO.ArrayUtil.Shuffle``1(System.Collections.Generic.IList{``0},System.Random)"]/*'/>
    public static void Shuffle<T>(IList<T> list, Random random) {
      if (random == null) {
        throw new ArgumentNullException("random");
      }
      if (list == null) {
        throw new ArgumentNullException("list");
      }
      for (int i = list.Count - 1; i >= 1; --i) {
        var other = random.Next(i + 1);
        if (i != other) {
          var obj = list[i];
          list[i] = list[other];
          list[other] = obj;
        }
      }
    }

    /// <include file='../docs.xml'
    /// path='docs/doc[@name="M:PeterO.ArrayUtil.Reverse``1(System.Collections.Generic.IList{``0})"]/*'/>
    public static void Reverse<T>(IList<T> list) {
      if (list == null) {
        throw new ArgumentNullException("list");
      }
      var half = list.Count >> 1;
      var right = list.Count - 1;
      for (int i = 0; i < half; i++, right--) {
        var value = list[i];
        list[i] = list[right];
        list[right] = value;
      }
    }

    /// <include file='../docs.xml'
    /// path='docs/doc[@name="M:PeterO.ArrayUtil.Reverse``1(System.Collections.Generic.IList{``0},System.Int32,System.Int32)"]/*'/>
    public static void Reverse<T>(IList<T> list, int index, int count) {
      if (list == null) {
        throw new ArgumentNullException("list");
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

    /// <include file='../docs.xml'
    /// path='docs/doc[@name="M:PeterO.ArrayUtil.FindItem``1(System.Collections.Generic.IEnumerable{``0},``0,``0)"]/*'/>
    public static T FindItem<T>(
      IEnumerable<T> items,
      T itemToFind,
      T defaultValue) {
      if (items == null) {
        throw new ArgumentNullException("items");
      }
      var eqc = EqualityComparer<T>.Default;
      foreach (T item in items) {
        if (eqc.Equals(item, itemToFind)) {
          return item;
        }
      }
      return defaultValue;
    }

    /// <include file='../docs.xml'
    /// path='docs/doc[@name="M:PeterO.ArrayUtil.FindItem``1(System.Collections.Generic.IEnumerable{``0},System.Predicate{``0},``0)"]/*'/>
    public static T FindItem<T>(
      IEnumerable<T> items,
      Predicate<T> func,
      T defaultValue) {
      if (items == null) {
        throw new ArgumentNullException("items");
      }
      if (func == null) {
        throw new ArgumentNullException("func");
      }
      foreach (T item in items) {
        if (func(item)) {
          return item;
        }
      }
      return defaultValue;
    }

    /// <include file='../docs.xml'
    /// path='docs/doc[@name="M:PeterO.ArrayUtil.ToArray``1(System.Collections.Generic.IEnumerable{``0})"]/*'/>
    public static T[] ToArray<T>(IEnumerable<T> collection) {
      if (collection == null) {
        throw new ArgumentNullException("collection");
      }
      var list = collection as List<T>;
    return (list != null) ? list.ToArray() : new List<T>(collection).ToArray();
    }

    /// <include file='../docs.xml'
    /// path='docs/doc[@name="M:PeterO.ArrayUtil.CompareLists``1(System.Collections.Generic.IList{``0},System.Collections.Generic.IList{``0})"]/*'/>
    public static int CompareLists<T>(IList<T> list1, IList<T> list2) where T :
      IComparable<T> {
      return CompareLists(list1, list2, Comparer<T>.Default);
    }

    /// <include file='../docs.xml'
    /// path='docs/doc[@name="M:PeterO.ArrayUtil.CompareLists``1(System.Collections.Generic.IList{``0},System.Collections.Generic.IList{``0},System.Collections.Generic.IComparer{``0})"]/*'/>
    public static int CompareLists<T>(
      IList<T> list1,
      IList<T> list2,
      IComparer<T> comparer) where T : IComparable<T> {
      var c = 0;
      if (comparer == null) {
        throw new ArgumentNullException("comparer");
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
      var len = Math.Min(list1.Count, list2.Count);
      for (int i = 0; i < len; ++i) {
        c = comparer.Compare(list1[i], list2[i]);
        if (c != 0) {
          break;
        }
      }
      if (c == 0) {
        c = list1.Count - list2.Count;
      }
      return c;
    }

    /// <include file='../docs.xml'
    /// path='docs/doc[@name="M:PeterO.ArrayUtil.CompareArrays``1(System.Collections.Generic.IEnumerable{``0},System.Collections.Generic.IEnumerable{``0})"]/*'/>
    public static int CompareArrays<T>(
      IEnumerable<T> array1,
      IEnumerable<T> array2) where T : IComparable<T> {
      return CompareArrays(array1, array2, Comparer<T>.Default);
    }

    /// <include file='../docs.xml'
    /// path='docs/doc[@name="M:PeterO.ArrayUtil.CompareArrays``1(System.Collections.Generic.IEnumerable{``0},System.Collections.Generic.IEnumerable{``0},System.Collections.Generic.IComparer{``0})"]/*'/>
    public static int CompareArrays<T>(
      IEnumerable<T> array1,
      IEnumerable<T> array2,
      IComparer<T> comparer) where T : IComparable<T> {
      if (comparer == null) {
        throw new ArgumentNullException("comparer");
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
            var c = comparer.Compare(enumA.Current, enumB.Current);
            if (c != 0) {
              return c;
            }
          }
        }
      }
    }

    /// <include file='../docs.xml'
    /// path='docs/doc[@name="M:PeterO.ArrayUtil.StableSort``1(System.Collections.Generic.IList{``0})"]/*'/>
    public static void StableSort<T>(IList<T> list) where T : IComparable<T> {
      if (list == null) {
        throw new ArgumentNullException("list");
      }
      var da = new DeferredArray<T>(list.Count);
      StableSortInternal(
        list,
 0,
 list.Count,
        Comparer<T>.Default,
        da);
    }

    /// <include file='../docs.xml'
    /// path='docs/doc[@name="M:PeterO.ArrayUtil.StableSort``1(System.Collections.Generic.IList{``0},System.Collections.Generic.IComparer{``0})"]/*'/>
    /// <typeparam name='T'>Type parameter not documented yet.</typeparam>
    public static void StableSort<T>(IList<T> list, IComparer<T> comparer) {
      if (list == null) {
        throw new ArgumentNullException("list");
      }
      if (comparer == null) {
        throw new ArgumentNullException("comparer");
      }
      var da = new
        DeferredArray<T>(list.Count);
      StableSortInternal(
        list,
        0,
        list.Count,
        comparer,
        da);
    }

    /// <include file='../docs.xml'
    /// path='docs/doc[@name="M:PeterO.ArrayUtil.StableSort``1(System.Collections.Generic.IList{``0},System.Int32,System.Int32)"]/*'/>
    public static void StableSort<T>(IList<T> list, int offset, int count) where
      T : IComparable<T> {
      if (list == null) {
        throw new ArgumentNullException("list");
      }
      if (offset < 0) {
      throw new ArgumentException("offset (" + offset + ") is less than 0");
      }
      if (offset > list.Count) {
        throw new ArgumentException("offset (" + offset + ") is more than " +
                    list.Count);
      }
      if (count < 0) {
        throw new ArgumentException("count (" + count + ") is less than 0");
      }
      if (count > list.Count) {
        throw new ArgumentException("count (" + count + ") is more than " +
                    list.Count);
      }
      if (list.Count - offset < count) {
        throw new ArgumentException("list's length minus " + offset + " (" +
                    (list.Count - offset) + ") is less than " + count);
      }
      StableSortInternal(
        list,
        offset,
        count,
        Comparer<T>.Default,
        new DeferredArray<T>(count));
    }

    /// <include file='../docs.xml'
    /// path='docs/doc[@name="M:PeterO.ArrayUtil.StableSort``1(System.Collections.Generic.IList{``0},System.Int32,System.Int32,System.Collections.Generic.IComparer{``0})"]/*'/>
    public static void StableSort<T>(
      IList<T> list,
      int offset,
      int count,
      IComparer<T> comparer) {
      if (list == null) {
        throw new ArgumentNullException("list");
      }
      if (offset < 0) {
      throw new ArgumentException("offset (" + offset + ") is less than 0");
      }
      if (offset > list.Count) {
        throw new ArgumentException("offset (" + offset + ") is more than " +
                    list.Count);
      }
      if (count < 0) {
        throw new ArgumentException("count (" + count + ") is less than 0");
      }
      if (count > list.Count) {
        throw new ArgumentException("count (" + count + ") is more than " +
                    list.Count);
      }
      if (list.Count - offset < count) {
        throw new ArgumentException("list's length minus " + offset + " (" +
                    (list.Count - offset) + ") is less than " + count);
      }
      if (comparer == null) {
        throw new ArgumentNullException("comparer");
      }
StableSortInternal(list, offset, count, comparer, new DeferredArray<T>(count));
    }

    private class DeferredArray<T> {
      private readonly int arrayLen;

      private T[] array;

      public DeferredArray(int length) {
        #if DEBUG
        if (length < 0) {
      throw new ArgumentException("length (" + length + ") is less than 0");
        }
        #endif
        this.arrayLen = length;
      }

      public T[] GetArray() {
        this.array = this.array ?? (new T[this.arrayLen]);
        return this.array;
      }
    }

    private static void StableSortInternal<T>(
      IList<T> list,
      int a,
      int n,
      IComparer<T> comparer,
      DeferredArray<T> tempArray) {
      #if DEBUG
      if (list == null) {
        throw new ArgumentNullException("list");
      }
      if (a < 0) {
        throw new ArgumentException("a (" + a + ") is less than 0");
      }
      if (a > list.Count) {
        throw new ArgumentException("a (" + a + ") is more than " + list.Count);
      }
      if (n < 0) {
        throw new ArgumentException("n (" + n + ") is less than 0");
      }
      if (n > list.Count) {
        throw new ArgumentException("n (" + n + ") is more than " + list.Count);
      }
      if (list.Count - a < n) {
        throw new ArgumentException("list's length minus " + a + " (" +
                    (list.Count - a) + ") is less than " + n);
      }
      if (comparer == null) {
        throw new ArgumentNullException("comparer");
      }
      #endif
      int pl, pm;
      T tmp;
      if (n < 7) {
        // Use insertion sort (already a stable sort)
        for (pm = a + 1; pm < a + n; ++pm) {
  for (pl = pm; pl > a && comparer.Compare(list[pl - 1], list[pl]) > 0; --pl) {
            tmp = list[pl];
            list[pl] = list[pl - 1];
            list[pl - 1] = tmp;
          }
        }
        return;
      }
      var middle = n >> 1;
      StableSortInternal(list, a, middle, comparer, tempArray);
      StableSortInternal(list, a + middle, n - middle, comparer, tempArray);
      if (comparer.Compare(list[a + middle - 1], list[a + middle]) <= 0) {
        return;
      }
      var right = a + n;
      middle = a + middle;
      var temp = tempArray.GetArray();
      var i = a;
      var j = a;
      var k = middle;
      while (j < middle && k < right) {
        // "<=" ensures stable sort
        var leq = comparer.Compare(list[j], list[k]) <= 0;
        temp[i++] = leq ? list[j++] : list[k++];
      }
      while (j < middle) {
        temp[i++] = list[j++];
      }
      for (i = a; i < k; ++i) {
        list[i] = temp[i];
      }
    }

private static readonly SingleComparer ValueSglComparer = new
      SingleComparer();

private static readonly DoubleComparer ValueDblComparer = new
      DoubleComparer();

    /// <include file='../docs.xml'
    /// path='docs/doc[@name="M:PeterO.ArrayUtil.ArraysEqual``1(System.Collections.Generic.IEnumerable{``0},System.Collections.Generic.IEnumerable{``0})"]/*'/>
    public static bool ArraysEqual<T>(
      IEnumerable<T> array1,
      IEnumerable<T> array2) {
      return ArraysEqual(array1, array2, EqualityComparer<T>.Default);
    }

    /// <include file='../docs.xml'
    /// path='docs/doc[@name="M:PeterO.ArrayUtil.ArraysEqual(System.Collections.Generic.IEnumerable{System.Single},System.Collections.Generic.IEnumerable{System.Single})"]/*'/>
    public static bool ArraysEqual(
      IEnumerable<float> array1,
      IEnumerable<float> array2) {
      return ArraysEqual(array1, array2, ValueSglComparer);
    }

    /// <include file='../docs.xml'
    /// path='docs/doc[@name="M:PeterO.ArrayUtil.ArraysEqual(System.Collections.Generic.IEnumerable{System.Double},System.Collections.Generic.IEnumerable{System.Double})"]/*'/>
    public static bool ArraysEqual(
      IEnumerable<double> array1,
      IEnumerable<double> array2) {
      return ArraysEqual(array1, array2, ValueDblComparer);
    }

    /// <include file='../docs.xml'
    /// path='docs/doc[@name="M:PeterO.ArrayUtil.ArraysEqual``1(System.Collections.Generic.IEnumerable{``0},System.Collections.Generic.IEnumerable{``0},System.Collections.Generic.IEqualityComparer{``0})"]/*'/>
    public static bool ArraysEqual<T>(
      IEnumerable<T> array1,
      IEnumerable<T> array2,
      IEqualityComparer<T> comparer) {
      if (comparer == null) {
        throw new ArgumentNullException("comparer");
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
            if (!comparer.Equals(enumA.Current, enumB.Current)) {
              ret = false;
              break;
            }
          }
        }
      }
      return ret;
    }

    /// <include file='../docs.xml'
    /// path='docs/doc[@name="M:PeterO.ArrayUtil.ArrayToStringHex(System.Collections.Generic.IEnumerable{System.Byte})"]/*'/>
    public static string ArrayToStringHex(IEnumerable<byte> array) {
      if (array == null) {
        return "null";
      }
      var b = new StringBuilder();
      b.Append("{");
      var first = true;
      foreach (byte value in array) {
        if (!first) {
          b.Append(", ");
        }
        b.Append(InvariantText.Format("0x" + "{0:X2}", value));
        first = false;
      }
      b.Append("}");
      return b.ToString();
    }

    /// <include file='../docs.xml'
    /// path='docs/doc[@name="M:PeterO.ArrayUtil.ArrayToStringHex(System.Collections.Generic.IEnumerable{System.Int32})"]/*'/>
    public static string ArrayToStringHex(IEnumerable<int> array) {
      if (array == null) {
        return "null";
      }
      var b = new StringBuilder();
      b.Append("{");
      var first = true;
      foreach (int value in array) {
        if (!first) {
          b.Append(", ");
        }
        b.Append(InvariantText.Format("0x" + "{0:X}", value));
        first = false;
      }
      b.Append("}");
      return b.ToString();
    }

    /// <include file='../docs.xml'
    /// path='docs/doc[@name="M:PeterO.ArrayUtil.ArrayToStringHex``1(System.Collections.Generic.IEnumerable{``0})"]/*'/>
    public static string ArrayToStringHex<T>(IEnumerable<T> array) {
      if (array == null) {
        return "null";
      }
      var b = new StringBuilder();
      b.Append("{");
      var first = true;
      foreach (T value in array) {
        if (!first) {
          b.Append(", ");
        }
        b.Append(InvariantText.Format("0x" + "{0:X}", value));
        first = false;
      }
      b.Append("}");
      return b.ToString();
    }

    /// <include file='../docs.xml'
    /// path='docs/doc[@name="M:PeterO.ArrayUtil.ArrayToString``1(System.Collections.Generic.IEnumerable{``0})"]/*'/>
    public static string ArrayToString<T>(IEnumerable<T> array) {
      if (array == null) {
        return "null";
      }
      var b = new StringBuilder();
      b.Append("{");
      var first = true;
      foreach (T value in array) {
        if (!first) {
          b.Append(", ");
        }
        b.Append(InvariantText.Format(String.Empty + value));
        first = false;
      }
      b.Append("}");
      return b.ToString();
    }

    /// <include file='../docs.xml'
    /// path='docs/doc[@name="M:PeterO.ArrayUtil.ArrayHashCode(System.Collections.Generic.IEnumerable{System.Byte})"]/*'/>
    public static int ArrayHashCode(IEnumerable<byte> array) {
      var ret = 17;
      if (array != null) {
        foreach (byte value in array) {
          ret = (37 * ret) + (int)value;
        }
      }
      return ret;
    }

    /// <include file='../docs.xml'
    /// path='docs/doc[@name="M:PeterO.ArrayUtil.ArrayHashCode(System.Collections.Generic.IEnumerable{System.Int32})"]/*'/>
    public static int ArrayHashCode(IEnumerable<int> array) {
      var ret = 17;
      if (array != null) {
        foreach (int value in array) {
          ret += (37 * ret) + value;
        }
      }
      return ret;
    }

    /// <include file='../docs.xml'
    /// path='docs/doc[@name="M:PeterO.ArrayUtil.ArrayHashCode(System.Collections.Generic.IEnumerable{System.Single})"]/*'/>
    public static int ArrayHashCode(IEnumerable<float> array) {
      var ret = 17;
      if (array != null) {
        foreach (float value in array) {
ret += (
  37 * ret) + BitConverter.ToInt32(
  BitConverter.GetBytes((float)value),
  0);
        }
      }
      return ret;
    }

    /// <include file='../docs.xml'
    /// path='docs/doc[@name="M:PeterO.ArrayUtil.ArrayHashCode(System.Collections.Generic.IEnumerable{System.Double})"]/*'/>
    public static int ArrayHashCode(IEnumerable<double> array) {
      var ret = 17;
      if (array != null) {
        foreach (double value in array) {
     var code = BitConverter.ToInt64(BitConverter.GetBytes((double)value), 0);
          ret += (37 * ret) + (int)(code ^ (code >> 32));
        }
      }
      return ret;
    }

    /// <include file='../docs.xml'
    /// path='docs/doc[@name="M:PeterO.ArrayUtil.ArrayHashCode``1(System.Collections.Generic.IEnumerable{``0})"]/*'/>
    public static int ArrayHashCode<T>(IEnumerable<T> array) {
      var ret = 17;
      if (array != null) {
        foreach (T value in array) {
          ret *= 37;
          if ((object)value != (object)default(T)) {
            ret += value.GetHashCode();
          }
        }
      }
      return ret;
    }
  }
}
