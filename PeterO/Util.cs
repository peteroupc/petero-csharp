/*
 *
 * This file is in the public domain.
 *
 */
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace PeterO {
    /// <include file='../docs.xml'
    /// path='docs/doc[@name="T:PeterO.Util"]/*'/>
  public static class Util {
    /// <include file='../docs.xml'
    /// path='docs/doc[@name="M:PeterO.Util.MakePair``2(``0,``1)"]/*'/>
    public static Pair<TFirst, TSecond> MakePair<TFirst, TSecond>(
      TFirst f,
      TSecond s) {
      return new Pair<TFirst, TSecond>(f, s);
    }

    /// <include file='../docs.xml'
    /// path='docs/doc[@name="M:PeterO.Util.ArrayToString``1(System.Collections.Generic.IEnumerable{``0})"]/*'/>
    public static string ArrayToString<T>(this IEnumerable<T> array) {
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
        b.Append(String.Empty + value);
        first = false;
      }
      b.Append("}");
      return b.ToString();
    }

    /// <include file='../docs.xml'
    /// path='docs/doc[@name="M:PeterO.Util.AddOverwrite``2(System.Collections.Generic.IDictionary{``0,``1},``0,``1)"]/*'/>
    public static void AddOverwrite<TKey, TValue>(
      this IDictionary<TKey,
      TValue> dict,
      TKey key,
      TValue value) {
      if (dict == null) {
        throw new ArgumentNullException("dict");
      }
      if (dict.ContainsKey(key)) {
        dict[key] = value;
      } else {
        dict.Add(key, value);
      }
    }

    /// <include file='../docs.xml'
    /// path='docs/doc[@name="M:PeterO.Util.AddIfMissing``2(System.Collections.Generic.IDictionary{``0,``1},``0,``1)"]/*'/>
    public static void AddIfMissing<TKey, TValue>(
      this IDictionary<TKey,
      TValue> dict,
      TKey key,
      TValue value) {
      if (dict == null) {
        throw new ArgumentNullException("dict");
      }
      if (!dict.ContainsKey(key)) {
        dict.Add(key, value);
      }
    }

    /// <include file='../docs.xml'
    /// path='docs/doc[@name="M:PeterO.Util.AddIfMissing``1(System.Collections.Generic.IList{``0},``0)"]/*'/>
    public static void AddIfMissing<T>(
      this IList<T> dict,
      T value) {
      if (dict == null) {
        throw new ArgumentNullException("dict");
      }
      if (!dict.Contains(value)) {
        dict.Add(value);
      }
    }

    /// <include file='../docs.xml'
    /// path='docs/doc[@name="M:PeterO.Util.MaxOrDefault``1(System.Collections.Generic.IEnumerable{``0})"]/*'/>
    public static T MaxOrDefault<T>(this IEnumerable<T> coll) where T :
      IComparable<T> {
      var i = 0;
      if (coll == null) {
        throw new ArgumentNullException("coll");
      }
      var curr = default(T);
      foreach (T value in coll) {
        if (i == 0 || value.CompareTo(curr) > 0) {
          curr = value;
        }
        i = 1;
      }
      return curr;
    }

    /// <include file='../docs.xml'
    /// path='docs/doc[@name="M:PeterO.Util.MinOrDefault``1(System.Collections.Generic.IEnumerable{``0})"]/*'/>
    public static T MinOrDefault<T>(this IEnumerable<T> coll) where T :
      IComparable<T> {
      var i = 0;
      if (coll == null) {
        throw new ArgumentNullException("coll");
      }
      var curr = default(T);
      foreach (T value in coll) {
        if (i == 0 || value.CompareTo(curr) < 0) {
          curr = value;
        }
        i = 1;
      }
      return curr;
    }

    /// <include file='../docs.xml'
    /// path='docs/doc[@name="M:PeterO.Util.StructureSize(PeterO.IStructure)"]/*'/>
    public static int StructureSize(this IStructure s) {
      if (s == null) {
        throw new ArgumentNullException("s");
      }
      using (var ms = new MemoryStream()) {
        s.Write(ms);
        return (int)ms.Position;
      }
    }

    /// <include file='../docs.xml'
    /// path='docs/doc[@name="M:PeterO.Util.UpToExcluding(System.Int32,System.Int32)"]/*'/>
public static IEnumerable<int> UpToExcluding(this int minValue, int maxValue) {
      if (minValue > maxValue) {
        throw new ArgumentException("minValue (" + minValue +
                    ") is more than " + maxValue);
      }
      for (int i = minValue; i < maxValue; ++i) {
        yield return i;
      }
    }

    /// <include file='../docs.xml'
    /// path='docs/doc[@name="M:PeterO.Util.UpToIncluding(System.Int32,System.Int32)"]/*'/>
public static IEnumerable<int> UpToIncluding(this int minValue, int maxValue) {
      if (minValue > maxValue) {
        throw new ArgumentException("minValue (" + minValue +
                    ") is more than " + maxValue);
      }
      for (int i = minValue; i < maxValue; ++i) {
        yield return i;
      }
      yield return maxValue;
    }

    /// <include file='../docs.xml'
    /// path='docs/doc[@name="M:PeterO.Util.Implode``1(System.Collections.Generic.IEnumerable{``0},System.String)"]/*'/>
    public static string Implode<T>(this IEnumerable<T> col, string separator) {
      if (col == null) {
        throw new ArgumentNullException("col");
      }
      if (separator == null) {
        throw new ArgumentNullException("separator");
      }
      var sb = new StringBuilder();
      var first = true;
      foreach (T i in col) {
        if (!first) {
          sb.Append(separator);
        } else {
          first = false;
        }
        sb.Append(i);
      }
      return sb.ToString();
    }

    /// <include file='../docs.xml'
    /// path='docs/doc[@name="M:PeterO.Util.IndexOf``1(System.Collections.Generic.IList{``0},``0)"]/*'/>
    public static int IndexOf<T>(this IList<T> list, T obj) {
      if (list == null) {
        throw new ArgumentNullException("list");
      }
      for (int i = 0; i < list.Count; ++i) {
        if (list[i].Equals(obj)) {
          return i;
        }
      }
      return -1;
    }

    /// <include file='../docs.xml'
    /// path='docs/doc[@name="M:PeterO.Util.IndexOf``1(System.Collections.Generic.IList{``0},System.Predicate{``0})"]/*'/>
    public static int IndexOf<T>(this IList<T> list, Predicate<T> match) {
      if (list == null) {
        throw new ArgumentNullException("list");
      }
      if (match == null) {
        throw new ArgumentNullException("match");
      }
      for (int i = 0; i < list.Count; ++i) {
        if (match(list[i])) {
          return i;
        }
      }
      return -1;
    }

    /// <include file='../docs.xml'
    /// path='docs/doc[@name="M:PeterO.Util.RemoveAll``1(System.Collections.Generic.IList{``0},System.Predicate{``0})"]/*'/>
    public static int RemoveAll<T>(this IList<T> list, Predicate<T> match) {
      if (list == null) {
        throw new ArgumentNullException("list");
      }
      if (match == null) {
        throw new ArgumentNullException("match");
      }
      var concreteList = list as List<T>;
      if (concreteList != null) {
        return concreteList.RemoveAll(match);
      }
      var offset = 0;
      for (int i = 0; i < list.Count; ++i) {
        if (match(list[i])) {
          ++offset;
        } else if (offset != 0) {
          list[i - offset] = list[i];
        }
      }
      var newCount = list.Count - offset;
      while (list.Count > newCount) {
        list.RemoveAt(newCount);
      }
      return offset;
    }

    /// <include file='../docs.xml'
    /// path='docs/doc[@name="M:PeterO.Util.CopyStructure``1(``0)"]/*'/>
    public static T CopyStructure<T>(this T structure)
      where T : IStructure, new() {
      if ((object)structure == (object)default(T)) {
        throw new ArgumentNullException("structure");
      }
      using (var ms = new MemoryStream()) {
        structure.Write(ms);
        T retval;
        try {
          retval = new T();
          ms.Position = 0;
          retval.Read(ms);
        } catch (NotSupportedException) {
          try {
            // Try to run the copy constructor
            // for immutable structures
            ms.Position = 0;
            retval = (T)Activator.CreateInstance(typeof(T), ms);
          } catch (MissingMethodException e2) {
            throw new NotSupportedException(String.Empty, e2);
          }
        }
        return retval;
      }
    }

    /// <include file='../docs.xml'
    /// path='docs/doc[@name="M:PeterO.Util.AllSame``1(System.Collections.Generic.IEnumerable{``0})"]/*'/>
    public static bool AllSame<T>(
      this IEnumerable<T> col) {
      if (col == null) {
        throw new ArgumentNullException("col");
      }
      var count = 0;
      var firstItem = default(T);
      foreach (T tc in col) {
        var i = tc;
        if (count == 0) {
          firstItem = i;
          ++count;
        } else {
          if (!Object.Equals(i, firstItem)) {
            return false;
          }
        }
      }
      return true;
    }

    /// <include file='../docs.xml'
    /// path='docs/doc[@name="M:PeterO.Util.AllSame``2(System.Collections.Generic.IEnumerable{``0},System.Func{``0,``1})"]/*'/>
    public static bool AllSame<TContainer, TItem>(
      this IEnumerable<TContainer> containers,
      Func<TContainer, TItem> func) {
      if (containers == null) {
        throw new ArgumentNullException("containers");
      }
      if (func == null) {
        throw new ArgumentNullException("func");
      }
      var count = 0;
      var firstItem = default(TItem);
      foreach (TContainer tc in containers) {
        var i = func(tc);
        if (count == 0) {
          firstItem = i;
          ++count;
        } else {
          if (!Object.Equals(i, firstItem)) {
            return false;
          }
        }
      }
      return true;
    }

    /// <include file='../docs.xml'
    /// path='docs/doc[@name="M:PeterO.Util.Transform``2(System.Collections.Generic.IEnumerable{``0},System.Func{``0,``1})"]/*'/>
    public static IEnumerable<TOutput> Transform<TInput, TOutput>(
      this IEnumerable<TInput> containers,
      Func<TInput, TOutput> func) {
      foreach (TInput item in containers) {
        yield return func(item);
      }
    }

    /// <include file='../docs.xml'
    /// path='docs/doc[@name="M:PeterO.Util.Sum``1(System.Collections.Generic.IEnumerable{``0},System.Func{``0,System.Int32})"]/*'/>
    public static int Sum<T>(
      this IEnumerable<T> containers,
      Func<T, int> func) {
      var value = 0;
      foreach (var item in containers) {
        value += func(item);
      }
      return value;
    }

    /// <include file='../docs.xml'
    /// path='docs/doc[@name="M:PeterO.Util.HasUnique``1(System.Collections.Generic.IEnumerable{``0})"]/*'/>
    public static bool HasUnique<T>(
      this IEnumerable<T> col) {
      if (col == null) {
        throw new ArgumentNullException("col");
      }
      var items = new List<T>();
      foreach (T tc in col) {
        if (items.Contains(tc)) {
          return false;
        }
        items.Add(tc);
      }
      return true;
    }

    /// <include file='../docs.xml'
    /// path='docs/doc[@name="M:PeterO.Util.HasUnique``2(System.Collections.Generic.IEnumerable{``0},System.Func{``0,``1})"]/*'/>
    public static bool HasUnique<TContainer, TItem>(
      this IEnumerable<TContainer> containers,
      Func<TContainer, TItem> func) {
      if (containers == null) {
        throw new ArgumentNullException("containers");
      }
      if (func == null) {
        throw new ArgumentNullException("func");
      }
      var items = new List<TItem>();
      foreach (TContainer tc in containers) {
        var i = func(tc);
        if (items.Contains(i)) {
          return false;
        }
        items.Add(i);
      }
      return true;
    }

    private class NullDisposableClass : IDisposable {
    /// <include file='../docs.xml'
    /// path='docs/doc[@name="M:PeterO.Util.NullDisposableClass.Dispose"]/*'/>
      public void Dispose() {
      }
    }

    /// <include file='../docs.xml'
    /// path='docs/doc[@name="F:PeterO.Util.NullDisposable"]/*'/>
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Usage",
      "CC0033:Dispose Fields Properly",
      Justification = "This object's dispose method does nothing.")]
 public static readonly IDisposable NullDisposable = new
      NullDisposableClass();

    /// <include file='../docs.xml'
    /// path='docs/doc[@name="M:PeterO.Util.GetSegment``1(System.Collections.Generic.IList{``0},System.Int32)"]/*'/>
    public static ListSegment<T> GetSegment<T>(this IList<T> list, int start) {
      if (list == null) {
        throw new ArgumentNullException("list");
      }
      return new ListSegment<T>(list, start, list.Count - start);
    }

    /// <include file='../docs.xml'
    /// path='docs/doc[@name="M:PeterO.Util.GetSegment``1(System.Collections.Generic.IList{``0},System.Int32,System.Int32)"]/*'/>
    public static ListSegment<T> GetSegment<T>(
      this IList<T> list,
      int start,
      int count) {
      if (list == null) {
        throw new ArgumentNullException("list");
      }
      return new ListSegment<T>(list, start, count);
    }

    /// <include file='../docs.xml'
    /// path='docs/doc[@name="M:PeterO.Util.ValueOrDefault``1(System.Collections.Generic.IList{``0},System.Int32)"]/*'/>
    public static T ValueOrDefault<T>(this IList<T> list, int index) {
      if (list == null) {
        throw new ArgumentNullException("list");
      }
      if (index < 0) {
  throw new ArgumentException("index (" + index +
    ") is less than " + 0);
}
      return (index >= list.Count) ? default(T) : list[index];
    }

    /// <include file='../docs.xml'
    /// path='docs/doc[@name="M:PeterO.Util.SetIfMissing``1(System.Collections.Generic.IList{``0},System.Int32,``0)"]/*'/>
    public static T SetIfMissing<T>(this IList<T> list, int index, T value) {
      if (list == null) {
        throw new ArgumentNullException("list");
      }
      if (index < 0) {
        throw new ArgumentException("index less than " + "0 (" +
                    Convert.ToString(
                    index,
                    System.Globalization.CultureInfo.InvariantCulture) + ")");
      }
      if (index >= list.Count) {
        list.SetValue(index, value);
        return value;
      } else {
        var v = list[index];
        if (Object.Equals(v, default(T))) {
          list[index] = value;
          return value;
        }
        return v;
      }
    }

    /// <include file='../docs.xml'
    /// path='docs/doc[@name="M:PeterO.Util.SetNewIfMissing``1(System.Collections.Generic.IList{``0},System.Int32)"]/*'/>
    public static T SetNewIfMissing<T>(this IList<T> list, int index) where T :
      new() {
      if (list == null) {
        throw new ArgumentNullException("list");
      }
      if (index < 0) {
        throw new ArgumentException("index less than " + "0 (" +
                    Convert.ToString(
                    index,
                    System.Globalization.CultureInfo.InvariantCulture) + ")");
      }
      if (index >= list.Count) {
        var value = new T();
        list.SetValue(index, value);
        return value;
      } else {
        var v = list[index];
        if (Object.Equals(v, default(T))) {
          var value = new T();
          list[index] = value;
          return value;
        }
        return v;
      }
    }

    /// <include file='../docs.xml'
    /// path='docs/doc[@name="M:PeterO.Util.SetIfMissing``1(System.Collections.Generic.IList{``0},System.Int32,System.Func{``0})"]/*'/>
    public static T SetIfMissing<T>(
      this IList<T> list,
      int index,
      Func<T> valuefunc) {
      if (list == null) {
        throw new ArgumentNullException("list");
      }
      if (index < 0) {
        throw new ArgumentException("index less than " + "0 (" +
                    Convert.ToString(
                    index,
                    System.Globalization.CultureInfo.InvariantCulture) + ")");
      }
      if (index >= list.Count) {
        var value = valuefunc();
        list.SetValue(index, value);
        return value;
      } else {
        var v = list[index];
        if (Object.Equals(v, default(T))) {
          var value = valuefunc();
          list[index] = value;
          return value;
        }
        return v;
      }
    }

    /// <include file='../docs.xml'
    /// path='docs/doc[@name="M:PeterO.Util.SetValue``1(System.Collections.Generic.IList{``0},System.Int32,``0)"]/*'/>
    public static void SetValue<T>(this IList<T> list, int index, T value) {
      if (list == null) {
        throw new ArgumentNullException("list");
      }
      if (index < 0) {
        throw new ArgumentException("index less than " + "0 (" +
                    Convert.ToString(
                    index,
                    System.Globalization.CultureInfo.InvariantCulture) + ")");
      }
      while (index >= list.Count) {
        list.Add(default(T));
      }
      list[index] = value;
    }

    /// <include file='../docs.xml'
    /// path='docs/doc[@name="M:PeterO.Util.MakeList``1(``0[])"]/*'/>
    public static IList<T> MakeList<T>(params T[] items) {
      return new List<T>(items);
    }

    /// <include file='../docs.xml'
    /// path='docs/doc[@name="M:PeterO.Util.CopyStream(System.IO.Stream,System.Int32,System.IO.Stream)"]/*'/>
  public static void CopyStream(this Stream input, int length, Stream output) {
      if (input == null) {
  throw new ArgumentNullException("input");
}
      if (output == null) {
  throw new ArgumentNullException("output");
}
      if (length < 0) {
  throw new ArgumentException("length (" + length +
    ") is less than " + 0);
}
      var buffer = new byte[32768];
      var totalLength = length;
      while (totalLength > 0 && length > 0) {
        var readLength = Math.Min(buffer.Length, totalLength);
        if (input.CanSeek) {
          readLength = (int)Math.Min(input.Length - input.Position, readLength);
        }
        if (readLength <= 0) {
          return;
        }
        var read = input.Read(buffer, 0, readLength);
        if (read <= 0) {
          return;
        }
        output.Write(buffer, 0, read);
        totalLength -= readLength;
      }
    }

    /// <include file='../docs.xml'
    /// path='docs/doc[@name="M:PeterO.Util.CopyStream(System.IO.Stream,System.IO.Stream)"]/*'/>
    public static void CopyStream(this Stream input, Stream output) {
      if (input == null) {
  throw new ArgumentNullException("input");
}
      if (output == null) {
  throw new ArgumentNullException("output");
}
      var buffer = new byte[32768];
      while (true) {
        var readLength = buffer.Length;
        if (input.CanSeek) {
          readLength = (int)Math.Min(input.Length - input.Position, readLength);
        }
        if (readLength <= 0) {
          return;
        }
        var read = input.Read(buffer, 0, readLength);
        if (read <= 0) {
          return;
        }
        output.Write(buffer, 0, read);
      }
    }

    /// <include file='../docs.xml'
    /// path='docs/doc[@name="M:PeterO.Util.EachWithIndex``1(System.Collections.Generic.IEnumerable{``0})"]/*'/>
    public static IEnumerable<Pair<T, int>> EachWithIndex<T>(this IEnumerable<T>
                    arr) {
      if (arr == null) {
        throw new ArgumentNullException("arr");
      }
      var i = 0;
      foreach (T o in arr) {
        yield return new Pair<T, int>(o, i);
        ++i;
      }
    }
  }
}
