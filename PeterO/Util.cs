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
  /// <summary>Not documented yet.</summary>
  public static class Util {
    /// <summary>Not documented yet.</summary>
    /// <param name='f'>The parameter <paramref name='f'/> is a ``0
    /// object.</param>
    /// <param name='s'>The parameter <paramref name='s'/> is a ``1
    /// object.</param>
    /// <typeparam name='TFirst'>The parameter
    /// <typeparamref name='TFirst'/> is not documented yet.</typeparam>
    /// <typeparam name='TSecond'>Any object type.</typeparam>
    /// <returns>A Pair(TFirst, TSecond) object.</returns>
    public static Pair<TFirst, TSecond> MakePair<TFirst, TSecond>(
      TFirst f,
      TSecond s) {
      return new Pair<TFirst, TSecond> (f, s);
    }

    /// <summary>Not documented yet.
    /// <para>In the.NET implementation, this method is implemented as an
    /// extension method to any object implementing IEnumerable and can be
    /// called as follows: <c>array.ArrayToString&lt;T&gt;()</c>. If the
    /// object's class already has a ArrayToString&lt;T&gt; method with the
    /// same parameters, that method takes precedence over this extension
    /// method.</para>
    /// <para>In the.NET implementation, this method is implemented as an
    /// extension method to any object implementing IEnumerable and can be
    /// called as follows: <c>array.ArrayToString&lt;T&gt;()</c>. If the
    /// object's class already has a <c>ArrayToString&lt;T&gt;</c> method
    /// with the same parameters, that method takes precedence over this
    /// extension method.</para></summary>
    /// <param name='array'>The parameter <paramref name='array'/> is
    /// a.Collections.Generic.IEnumerable{``0} object.</param>
    /// <typeparam name='T'>Type parameter not documented yet.</typeparam>
    /// <returns>A text string.</returns>
    public static string ArrayToString<T> (this IEnumerable<T> array) {
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

    /// <summary>Adds the overwrite.
    /// <para>In the.NET implementation, this method is implemented as an
    /// extension method to any object implementing IDictionary and can be
    /// called as follows: <c>dict.AddOverwrite&lt;TKey, TValue&gt;(key,
    /// value)</c>. If the object's class already has a
    /// <c>AddOverwrite&lt;TKey, TValue&gt;</c> method with the same
    /// parameters, that method takes precedence over this extension
    /// method.</para></summary>
    /// <param name='dict'>The parameter <paramref name='dict'/> is
    /// a.Collections.Generic.IDictionary{``0 object.</param>
    /// <param name='key'>The parameter <paramref name='key'/> is a ``1}
    /// object.</param>
    /// <param name='value'>The parameter <paramref name='value'/> is a ``0
    /// object.</param>
    /// <typeparam name='TKey'>The 1st type parameter.</typeparam>
    /// <typeparam name='TValue'>The 2nd type parameter.</typeparam>
    /// <exception cref='ArgumentNullException'>The parameter <paramref
    /// name='dict'/> is null.</exception>
    public static void AddOverwrite<TKey, TValue> (
      this IDictionary<TKey, TValue> dict,
      TKey key,
      TValue value) {
      if (dict == null) {
        throw new ArgumentNullException(nameof(dict));
      }
      if (dict.ContainsKey (key)) {
        dict[key] = value;
      } else {
        dict.Add (key, value);
      }
    }

    /// <summary>Adds if missing.
    /// <para>In the.NET implementation, this method is implemented as an
    /// extension method to any object implementing IDictionary and can be
    /// called as follows: <c>dict.AddIfMissing&lt;TKey, TValue&gt;(key,
    /// value)</c>. If the object's class already has a
    /// <c>AddIfMissing&lt;TKey, TValue&gt;</c> method with the same
    /// parameters, that method takes precedence over this extension
    /// method.</para></summary>
    /// <param name='dict'>The parameter <paramref name='dict'/> is
    /// a.Collections.Generic.IDictionary{``0 object.</param>
    /// <param name='key'>The parameter <paramref name='key'/> is a ``1}
    /// object.</param>
    /// <param name='value'>The parameter <paramref name='value'/> is a ``0
    /// object.</param>
    /// <typeparam name='TKey'>The 1st type parameter.</typeparam>
    /// <typeparam name='TValue'>The 2nd type parameter.</typeparam>
    /// <exception cref='ArgumentNullException'>The parameter <paramref
    /// name='dict'/> is null.</exception>
    public static void AddIfMissing<TKey, TValue> (
      this IDictionary<TKey, TValue> dict,
      TKey key,
      TValue value) {
      if (dict == null) {
        throw new ArgumentNullException(nameof(dict));
      }
      if (!dict.ContainsKey (key)) {
        dict.Add (key, value);
      }
    }

    /// <summary>Not documented yet.
    /// <para>In the.NET implementation, this method is implemented as an
    /// extension method to any object implementing IList and can be called
    /// as follows: <c>dict.AddIfMissing&lt;T&gt;(value)</c>. If the
    /// object's class already has a AddIfMissing&lt;T&gt; method with the
    /// same parameters, that method takes precedence over this extension
    /// method.</para>
    /// <para>In the.NET implementation, this method is implemented as an
    /// extension method to any object implementing IList and can be called
    /// as follows: <c>dict.AddIfMissing&lt;T&gt;(value)</c>. If the
    /// object's class already has a <c>AddIfMissing&lt;T&gt;</c> method
    /// with the same parameters, that method takes precedence over this
    /// extension method.</para></summary>
    /// <param name='dict'>The parameter <paramref name='dict'/> is
    /// a.Collections.Generic.IList{``0} object.</param>
    /// <param name='value'>The parameter <paramref name='value'/> is a ``0
    /// object.</param>
    /// <typeparam name='T'>Type parameter not documented yet.</typeparam>
    /// <exception cref='ArgumentNullException'>The parameter <paramref
    /// name='dict'/> is null.</exception>
    public static void AddIfMissing<T> (
      this IList<T> dict,
      T value) {
      if (dict == null) {
        throw new ArgumentNullException(nameof(dict));
      }
      if (!dict.Contains (value)) {
        dict.Add (value);
      }
    }

    /// <summary>Not documented yet.
    /// <para>In the.NET implementation, this method is implemented as an
    /// extension method to any object implementing IEnumerable and can be
    /// called as follows: <c>coll.MaxOrDefault&lt;T&gt;()</c>. If the
    /// object's class already has a MaxOrDefault&lt;T&gt; method with the
    /// same parameters, that method takes precedence over this extension
    /// method.</para>
    /// <para>In the.NET implementation, this method is implemented as an
    /// extension method to any object implementing IEnumerable and can be
    /// called as follows: <c>coll.MaxOrDefault&lt;T&gt;()</c>. If the
    /// object's class already has a <c>MaxOrDefault&lt;T&gt;</c> method
    /// with the same parameters, that method takes precedence over this
    /// extension method.</para></summary>
    /// <param name='coll'>The parameter <paramref name='coll'/> is
    /// a.Collections.Generic.IEnumerable{``0} object.</param>
    /// <typeparam name='T'>Any object type that implements
    /// IComparable&lt;T&gt;.</typeparam>
    /// <returns>A T object.</returns>
    /// <exception cref='ArgumentNullException'>The parameter <paramref
    /// name='coll'/> is null.</exception>
    public static T MaxOrDefault<T> (this IEnumerable<T> coll) where T :
      IComparable<T> {
      var i = 0;
      if (coll == null) {
        throw new ArgumentNullException(nameof(coll));
      }
      var curr = default (T);
      foreach (T value in coll) {
        if (i == 0 || value.CompareTo (curr) > 0) {
          curr = value;
        }
        i = 1;
      }
      return curr;
    }

    /// <summary>Not documented yet.
    /// <para>In the.NET implementation, this method is implemented as an
    /// extension method to any object implementing IEnumerable and can be
    /// called as follows: <c>coll.MinOrDefault&lt;T&gt;()</c>. If the
    /// object's class already has a MinOrDefault&lt;T&gt; method with the
    /// same parameters, that method takes precedence over this extension
    /// method.</para>
    /// <para>In the.NET implementation, this method is implemented as an
    /// extension method to any object implementing IEnumerable and can be
    /// called as follows: <c>coll.MinOrDefault&lt;T&gt;()</c>. If the
    /// object's class already has a <c>MinOrDefault&lt;T&gt;</c> method
    /// with the same parameters, that method takes precedence over this
    /// extension method.</para></summary>
    /// <param name='coll'>The parameter <paramref name='coll'/> is
    /// a.Collections.Generic.IEnumerable{``0} object.</param>
    /// <typeparam name='T'>Type parameter not documented yet.</typeparam>
    /// <returns>A T object.</returns>
    /// <exception cref='ArgumentNullException'>The parameter <paramref
    /// name='coll'/> is null.</exception>
    public static T MinOrDefault<T> (this IEnumerable<T> coll) where T :
      IComparable<T> {
      var i = 0;
      if (coll == null) {
        throw new ArgumentNullException(nameof(coll));
      }
      var curr = default (T);
      foreach (T value in coll) {
        if (i == 0 || value.CompareTo (curr) < 0) {
          curr = value;
        }
        i = 1;
      }
      return curr;
    }

    /// <summary>Not documented yet.
    /// <para>In the.NET implementation, this method is implemented as an
    /// extension method to any object implementing IStructure and can be
    /// called as follows: <c>s.StructureSize()</c>. If the object's class
    /// already has a StructureSize method with the same parameters, that
    /// method takes precedence over this extension method.</para>
    /// <para>In the.NET implementation, this method is implemented as an
    /// extension method to any object implementing IStructure and can be
    /// called as follows: <c>s.StructureSize()</c>. If the object's class
    /// already has a <c>StructureSize</c> method with the same parameters,
    /// that method takes precedence over this extension
    /// method.</para></summary>
    /// <param name='s'>The parameter <paramref name='s'/> is a IStructure
    /// object.</param>
    /// <returns>A 32-bit signed integer.</returns>
    /// <exception cref='ArgumentNullException'>The parameter <paramref
    /// name='s'/> is null.</exception>
    public static int StructureSize (this IStructure s) {
      if (s == null) {
        throw new ArgumentNullException(nameof(s));
      }
      using (var ms = new MemoryStream()) {
        s.Write (ms);
        return (int)ms.Position;
      }
    }

    /// <summary>Creates an iterator of integers starting at a minimum
    /// value and ending at one less than the maximum.
    /// <para>In the.NET implementation, this method is implemented as an
    /// extension method to any object implementing Int32 and can be called
    /// as follows: <c>minValue.UpToExcluding(maxValue)</c>. If the
    /// object's class already has a UpToExcluding method with the same
    /// parameters, that method takes precedence over this extension
    /// method.</para>
    /// <para>In the.NET implementation, this method is implemented as an
    /// extension method to any object implementing Int32 and can be called
    /// as follows: <c>minValue.UpToExcluding(maxValue)</c>. If the
    /// object's class already has a <c>UpToExcluding</c> method with the
    /// same parameters, that method takes precedence over this extension
    /// method.</para></summary>
    /// <param name='minValue'>The parameter <paramref name='minValue'/> is
    /// a 32-bit signed integer.</param>
    /// <param name='maxValue'>The parameter <paramref name='maxValue'/> is
    /// a 32-bit signed integer.</param>
    /// <returns>An IEnumerable(int) object.</returns>
    /// <exception cref='ArgumentException'>The parameter _minValue_ is
    /// greater than _maxValue_.</exception>
    public static IEnumerable<int> UpToExcluding (this int minValue,
      int maxValue) {
      if (minValue > maxValue) {
        throw new ArgumentException("minValue (" + minValue +
          ") is more than " + maxValue);
      }
      for (int i = minValue; i < maxValue; ++i) {
        yield return i;
      }
    }

    /// <summary>Not documented yet.
    /// <para>In the.NET implementation, this method is implemented as an
    /// extension method to any object implementing Int32 and can be called
    /// as follows: <c>minValue.UpToIncluding(maxValue)</c>. If the
    /// object's class already has a UpToIncluding method with the same
    /// parameters, that method takes precedence over this extension
    /// method.</para>
    /// <para>In the.NET implementation, this method is implemented as an
    /// extension method to any object implementing Int32 and can be called
    /// as follows: <c>minValue.UpToIncluding(maxValue)</c>. If the
    /// object's class already has a <c>UpToIncluding</c> method with the
    /// same parameters, that method takes precedence over this extension
    /// method.</para></summary>
    /// <param name='minValue'>The parameter <paramref name='minValue'/> is
    /// a 32-bit signed integer.</param>
    /// <param name='maxValue'>The parameter <paramref name='maxValue'/> is
    /// a 32-bit signed integer.</param>
    /// <returns>An IEnumerable(int) object.</returns>
    public static IEnumerable<int> UpToIncluding (this int minValue,
      int maxValue) {
      if (minValue > maxValue) {
        throw new ArgumentException("minValue (" + minValue +
          ") is more than " + maxValue);
      }
      for (int i = minValue; i < maxValue; ++i) {
        yield return i;
      }
      yield return maxValue;
    }

    /// <summary>Not documented yet.
    /// <para>In the.NET implementation, this method is implemented as an
    /// extension method to any object implementing IEnumerable and can be
    /// called as follows: <c>col.Implode&lt;T&gt;(separator)</c>. If the
    /// object's class already has a Implode&lt;T&gt; method with the same
    /// parameters, that method takes precedence over this extension
    /// method.</para>
    /// <para>In the.NET implementation, this method is implemented as an
    /// extension method to any object implementing IEnumerable and can be
    /// called as follows: <c>col.Implode&lt;T&gt;(separator)</c>. If the
    /// object's class already has a <c>Implode&lt;T&gt;</c> method with
    /// the same parameters, that method takes precedence over this
    /// extension method.</para></summary>
    /// <param name='col'>The parameter <paramref name='col'/> is
    /// a.Collections.Generic.IEnumerable{``0} object.</param>
    /// <param name='separator'>The parameter <paramref name='separator'/>
    /// is a text string.</param>
    /// <typeparam name='T'>Type parameter not documented yet.</typeparam>
    /// <returns>A text string.</returns>
    /// <exception cref='ArgumentNullException'>The parameter <paramref
    /// name='col'/> or <paramref name='separator'/> is null.</exception>
    public static string Implode<T> (this IEnumerable<T> col,
      string separator) {
      if (col == null) {
        throw new ArgumentNullException(nameof(col));
      }
      if (separator == null) {
        throw new ArgumentNullException(nameof(separator));
      }
      var sb = new StringBuilder();
      var first = true;
      foreach (T i in col) {
        if (!first) {
          sb.Append (separator);
        } else {
          first = false;
        }
        sb.Append (i);
      }
      return sb.ToString();
    }

    /// <summary>Not documented yet.
    /// <para>In the.NET implementation, this method is implemented as an
    /// extension method to any object implementing IList and can be called
    /// as follows: <c>list.IndexOf&lt;T&gt;(obj)</c>. If the object's
    /// class already has a IndexOf&lt;T&gt; method with the same
    /// parameters, that method takes precedence over this extension
    /// method.</para>
    /// <para>In the.NET implementation, this method is implemented as an
    /// extension method to any object implementing IList and can be called
    /// as follows: <c>list.IndexOf&lt;T&gt;(obj)</c>. If the object's
    /// class already has a <c>IndexOf&lt;T&gt;</c> method with the same
    /// parameters, that method takes precedence over this extension
    /// method.</para></summary>
    /// <param name='list'>The parameter <paramref name='list'/> is
    /// a.Collections.Generic.IList{``0} object.</param>
    /// <param name='obj'>The parameter <paramref name='obj'/> is a ``0
    /// object.</param>
    /// <typeparam name='T'>Type parameter not documented yet.</typeparam>
    /// <returns>A 32-bit signed integer.</returns>
    /// <exception cref='ArgumentNullException'>The parameter <paramref
    /// name='list'/> is null.</exception>
    public static int IndexOf<T> (this IList<T> list, T obj) {
      if (list == null) {
        throw new ArgumentNullException(nameof(list));
      }
      for (int i = 0; i < list.Count; ++i) {
        if (list[i].Equals (obj)) {
          return i;
        }
      }
      return -1;
    }

    /// <summary>Not documented yet.
    /// <para>In the.NET implementation, this method is implemented as an
    /// extension method to any object implementing IList and can be called
    /// as follows: <c>list.IndexOf&lt;T&gt;(match)</c>. If the object's
    /// class already has a IndexOf&lt;T&gt; method with the same
    /// parameters, that method takes precedence over this extension
    /// method.</para>
    /// <para>In the.NET implementation, this method is implemented as an
    /// extension method to any object implementing IList and can be called
    /// as follows: <c>list.IndexOf&lt;T&gt;(match)</c>. If the object's
    /// class already has a <c>IndexOf&lt;T&gt;</c> method with the same
    /// parameters, that method takes precedence over this extension
    /// method.</para></summary>
    /// <param name='list'>The parameter <paramref name='list'/> is
    /// a.Collections.Generic.IList{``0} object.</param>
    /// <param name='match'>The parameter <paramref name='match'/> is
    /// a.Predicate{``0} object.</param>
    /// <typeparam name='T'>Type parameter not documented yet.</typeparam>
    /// <returns>A 32-bit signed integer.</returns>
    /// <exception cref='ArgumentNullException'>The parameter <paramref
    /// name='list'/> or <paramref name='match'/> is null.</exception>
    public static int IndexOf<T> (this IList<T> list, Predicate<T> match) {
      if (list == null) {
        throw new ArgumentNullException(nameof(list));
      }
      if (match == null) {
        throw new ArgumentNullException(nameof(match));
      }
      for (int i = 0; i < list.Count; ++i) {
        if (match (list[i])) {
          return i;
        }
      }
      return -1;
    }

    /// <summary>Not documented yet.
    /// <para>In the.NET implementation, this method is implemented as an
    /// extension method to any object implementing IList and can be called
    /// as follows: <c>list.RemoveAll&lt;T&gt;(match)</c>. If the object's
    /// class already has a RemoveAll&lt;T&gt; method with the same
    /// parameters, that method takes precedence over this extension
    /// method.</para>
    /// <para>In the.NET implementation, this method is implemented as an
    /// extension method to any object implementing IList and can be called
    /// as follows: <c>list.RemoveAll&lt;T&gt;(match)</c>. If the object's
    /// class already has a <c>RemoveAll&lt;T&gt;</c> method with the same
    /// parameters, that method takes precedence over this extension
    /// method.</para></summary>
    /// <param name='list'>The parameter <paramref name='list'/> is
    /// a.Collections.Generic.IList{``0} object.</param>
    /// <param name='match'>The parameter <paramref name='match'/> is
    /// a.Predicate{``0} object.</param>
    /// <typeparam name='T'>Type parameter not documented yet.</typeparam>
    /// <returns>A 32-bit signed integer.</returns>
    /// <exception cref='ArgumentNullException'>The parameter <paramref
    /// name='list'/> or <paramref name='match'/> is null.</exception>
    public static int RemoveAll<T> (this IList<T> list, Predicate<T> match) {
      if (list == null) {
        throw new ArgumentNullException(nameof(list));
      }
      if (match == null) {
        throw new ArgumentNullException(nameof(match));
      }
      var concreteList = list as List<T>;
      if (concreteList != null) {
        return concreteList.RemoveAll (match);
      }
      var offset = 0;
      for (int i = 0; i < list.Count; ++i) {
        if (match (list[i])) {
          ++offset;
        } else if (offset != 0) {
          list[i - offset] = list[i];
        }
      }
      var newCount = list.Count - offset;
      while (list.Count > newCount) {
        list.RemoveAt (newCount);
      }
      return offset;
    }

    /// <summary>Not documented yet.
    /// <para>In the.NET implementation, this method is implemented as an
    /// extension method to any object implementing T and can be called as
    /// follows: <c>structure.CopyStructure&lt;T&gt;()</c>. If the
    /// object's class already has a CopyStructure&lt;T&gt; method with the
    /// same parameters, that method takes precedence over this extension
    /// method.</para>
    /// <para>In the.NET implementation, this method is implemented as an
    /// extension method to any object implementing T and can be called as
    /// follows: <c>structure.CopyStructure&lt;T&gt;()</c>. If the
    /// object's class already has a <c>CopyStructure&lt;T&gt;</c> method
    /// with the same parameters, that method takes precedence over this
    /// extension method.</para></summary>
    /// <param name='structure'>The parameter <paramref name='structure'/>
    /// is a ``0 object.</param>
    /// <typeparam name='T'>Type parameter not documented yet.</typeparam>
    /// <returns>A T object.</returns>
    /// <exception cref='ArgumentNullException'>The parameter <paramref
    /// name='structure'/> is null.</exception>
    public static T CopyStructure<T> (this T structure)
    where T : IStructure, new () {
      if ((object)structure == (object)default (T)) {
        throw new ArgumentNullException(nameof(structure));
      }
      using (var ms = new MemoryStream()) {
        structure.Write (ms);
        T retval;
        try {
          retval = new T();
          ms.Position = 0;
          retval.Read (ms);
        } catch (NotSupportedException) {
          try {
            // Try to run the copy constructor
            // for immutable structures
            ms.Position = 0;
            retval = (T)Activator.CreateInstance (typeof(T), ms);
          } catch (MissingMethodException e2) {
            throw new NotSupportedException(String.Empty, e2);
          }
        }
        return retval;
      }
    }

    /// <summary>Not documented yet.
    /// <para>In the.NET implementation, this method is implemented as an
    /// extension method to any object implementing IEnumerable and can be
    /// called as follows: <c>col.AllSame&lt;T&gt;()</c>. If the object's
    /// class already has a AllSame&lt;T&gt; method with the same
    /// parameters, that method takes precedence over this extension
    /// method.</para>
    /// <para>In the.NET implementation, this method is implemented as an
    /// extension method to any object implementing IEnumerable and can be
    /// called as follows: <c>col.AllSame&lt;T&gt;()</c>. If the object's
    /// class already has a <c>AllSame&lt;T&gt;</c> method with the same
    /// parameters, that method takes precedence over this extension
    /// method.</para></summary>
    /// <param name='col'>The parameter <paramref name='col'/> is
    /// a.Collections.Generic.IEnumerable{``0} object.</param>
    /// <typeparam name='T'>Any object type.</typeparam>
    /// <returns>Either <c>true</c> or <c>false</c>.</returns>
    /// <exception cref='ArgumentNullException'>The parameter <paramref
    /// name='col'/> is null.</exception>
    public static bool AllSame<T> (
      this IEnumerable<T> col) {
      if (col == null) {
        throw new ArgumentNullException(nameof(col));
      }
      var count = 0;
      var firstItem = default (T);
      foreach (T tc in col) {
        var i = tc;
        if (count == 0) {
          firstItem = i;
          ++count;
        } else {
          if (!Object.Equals (i, firstItem)) {
            return false;
          }
        }
      }
      return true;
    }

    /// <summary>Not documented yet.
    /// <para>In the.NET implementation, this method is implemented as an
    /// extension method to any object implementing IEnumerable and can be
    /// called as follows: <c>containers.AllSame&lt;TContainer,
    /// TItem&gt;(func)</c>. If the object's class already has a
    /// AllSame&lt;TContainer, TItem&gt; method with the same parameters,
    /// that method takes precedence over this extension
    /// method.</para></summary>
    /// <param name='containers'>The parameter <paramref
    /// name='containers'/> is a.Collections.Generic.IEnumerable{``0}
    /// object.</param>
    /// <param name='func'>The parameter <paramref name='func'/> is
    /// a.Func{``0 object.</param>
    /// <typeparam name='TContainer'>The parameter
    /// <typeparamref name='TContainer'/> is not documented
    /// yet.</typeparam>
    /// <typeparam name='TItem'>Object type representing items stored in
    /// each container.</typeparam>
    /// <returns>Either <c>true</c> or <c>false</c>.</returns>
    /// <exception cref='ArgumentNullException'>The parameter <paramref
    /// name='containers'/> or <paramref name='func'/> is null.</exception>
    public static bool AllSame<TContainer, TItem> (
      this IEnumerable<TContainer> containers,
      Func<TContainer, TItem> func) {
      if (containers == null) {
        throw new ArgumentNullException(nameof(containers));
      }
      if (func == null) {
        throw new ArgumentNullException(nameof(func));
      }
      var count = 0;
      var firstItem = default (TItem);
      foreach (TContainer tc in containers) {
        var i = func (tc);
        if (count == 0) {
          firstItem = i;
          ++count;
        } else {
          if (!Object.Equals (i, firstItem)) {
            return false;
          }
        }
      }
      return true;
    }

    /// <summary>Not documented yet.
    /// <para>In the.NET implementation, this method is implemented as an
    /// extension method to any object implementing IEnumerable and can be
    /// called as follows: <c>containers.Transform&lt;TInput,
    /// TOutput&gt;(func)</c>. If the object's class already has a
    /// <c>Transform&lt;TInput, TOutput&gt;</c> method with the same
    /// parameters, that method takes precedence over this extension
    /// method.</para></summary>
    /// <param name='containers'>The parameter <paramref
    /// name='containers'/> is a.Collections.Generic.IEnumerable{``0}
    /// object.</param>
    /// <param name='func'>The parameter <paramref name='func'/> is
    /// a.Func{``0 object.</param>
    /// <typeparam name='TInput'>The 1st type parameter.</typeparam>
    /// <typeparam name='TOutput'>The 2nd type parameter.</typeparam>
    /// <returns>The transform.</returns>
    public static IEnumerable<TOutput> Transform<TInput, TOutput> (
      this IEnumerable<TInput> containers,
      Func<TInput, TOutput> func) {
      foreach (TInput item in containers) {
        yield return func (item);
      }
    }

    /// <summary>Not documented yet.
    /// <para>In the.NET implementation, this method is implemented as an
    /// extension method to any object implementing IEnumerable and can be
    /// called as follows: <c>containers.Sum&lt;T&gt;(func)</c>. If the
    /// object's class already has a Sum&lt;T&gt; method with the same
    /// parameters, that method takes precedence over this extension
    /// method.</para></summary>
    /// <param name='containers'>The parameter <paramref
    /// name='containers'/> is a.Collections.Generic.IEnumerable{``0}
    /// object.</param>
    /// <param name='func'>The parameter <paramref name='func'/> is
    /// a.Func{``0 object.</param>
    /// <typeparam name='T'>Type parameter not documented yet.</typeparam>
    /// <returns>A 32-bit signed integer.</returns>
    public static int Sum<T> (
      this IEnumerable<T> containers,
      Func<T, int> func) {
      var value = 0;
      foreach (var item in containers) {
        value += func (item);
      }
      return value;
    }

    /// <summary>Not documented yet.
    /// <para>In the.NET implementation, this method is implemented as an
    /// extension method to any object implementing IEnumerable and can be
    /// called as follows: <c>col.HasUnique&lt;T&gt;()</c>. If the
    /// object's class already has a HasUnique&lt;T&gt; method with the
    /// same parameters, that method takes precedence over this extension
    /// method.</para>
    /// <para>In the.NET implementation, this method is implemented as an
    /// extension method to any object implementing IEnumerable and can be
    /// called as follows: <c>col.HasUnique&lt;T&gt;()</c>. If the
    /// object's class already has a <c>HasUnique&lt;T&gt;</c> method with
    /// the same parameters, that method takes precedence over this
    /// extension method.</para></summary>
    /// <param name='col'>The parameter <paramref name='col'/> is
    /// a.Collections.Generic.IEnumerable{``0} object.</param>
    /// <typeparam name='T'>Type parameter not documented yet.</typeparam>
    /// <returns>Either <c>true</c> or <c>false</c>.</returns>
    /// <exception cref='ArgumentNullException'>The parameter <paramref
    /// name='col'/> is null.</exception>
    public static bool HasUnique<T> (
      this IEnumerable<T> col) {
      if (col == null) {
        throw new ArgumentNullException(nameof(col));
      }
      var items = new List<T>();
      foreach (T tc in col) {
        if (items.Contains (tc)) {
          return false;
        }
        items.Add (tc);
      }
      return true;
    }

    /// <summary>Not documented yet.
    /// <para>In the.NET implementation, this method is implemented as an
    /// extension method to any object implementing IEnumerable and can be
    /// called as follows: <c>containers.HasUnique&lt;TContainer,
    /// TItem&gt;(func)</c>. If the object's class already has a
    /// HasUnique&lt;TContainer, TItem&gt; method with the same parameters,
    /// that method takes precedence over this extension
    /// method.</para></summary>
    /// <param name='containers'>The parameter <paramref
    /// name='containers'/> is a.Collections.Generic.IEnumerable{``0}
    /// object.</param>
    /// <param name='func'>The parameter <paramref name='func'/> is
    /// a.Func{``0 object.</param>
    /// <typeparam name='TContainer'>The parameter
    /// <typeparamref name='TContainer'/> is not documented
    /// yet.</typeparam>
    /// <typeparam name='TItem'>Object type representing items stored in
    /// each container.</typeparam>
    /// <returns>Either <c>true</c> or <c>false</c>.</returns>
    /// <exception cref='ArgumentNullException'>The parameter <paramref
    /// name='containers'/> or <paramref name='func'/> is null.</exception>
    public static bool HasUnique<TContainer, TItem> (
      this IEnumerable<TContainer> containers,
      Func<TContainer, TItem> func) {
      if (containers == null) {
        throw new ArgumentNullException(nameof(containers));
      }
      if (func == null) {
        throw new ArgumentNullException(nameof(func));
      }
      var items = new List<TItem>();
      foreach (TContainer tc in containers) {
        var i = func (tc);
        if (items.Contains (i)) {
          return false;
        }
        items.Add (i);
      }
      return true;
    }

    private class NullDisposableClass : IDisposable {
      /// <summary>Not documented yet.</summary>
      public void Dispose() {
      }
    }

    /// <summary>An IDisposable object that does nothing when
    /// disposed.</summary>
    [System.Diagnostics.CodeAnalysis.SuppressMessage ("Usage",
        "CC0033:Dispose Fields Properly",
        Justification = "This object's dispose method does nothing.")]
    public static readonly IDisposable NullDisposable = new
    NullDisposableClass();

    /// <summary>Not documented yet.
    /// <para>In the.NET implementation, this method is implemented as an
    /// extension method to any object implementing IList and can be called
    /// as follows: <c>list.GetSegment&lt;T&gt;(start)</c>. If the
    /// object's class already has a GetSegment&lt;T&gt; method with the
    /// same parameters, that method takes precedence over this extension
    /// method.</para>
    /// <para>In the.NET implementation, this method is implemented as an
    /// extension method to any object implementing IList and can be called
    /// as follows: <c>list.GetSegment&lt;T&gt;(start)</c>. If the
    /// object's class already has a <c>GetSegment&lt;T&gt;</c> method with
    /// the same parameters, that method takes precedence over this
    /// extension method.</para></summary>
    /// <param name='list'>The parameter <paramref name='list'/> is
    /// a.Collections.Generic.IList{``0} object.</param>
    /// <param name='start'>The parameter <paramref name='start'/> is a
    /// 32-bit signed integer.</param>
    /// <typeparam name='T'>Type parameter not documented yet.</typeparam>
    /// <returns>A ListSegment(T) object.</returns>
    /// <exception cref='ArgumentNullException'>The parameter <paramref
    /// name='list'/> is null.</exception>
    public static ListSegment<T> GetSegment<T> (this IList<T> list, int start) {
      if (list == null) {
        throw new ArgumentNullException(nameof(list));
      }
      return new ListSegment<T>(list, start, list.Count - start);
    }

    /// <summary>Not documented yet.
    /// <para>In the.NET implementation, this method is implemented as an
    /// extension method to any object implementing IList and can be called
    /// as follows: <c>list.GetSegment&lt;T&gt;(start, count)</c>. If the
    /// object's class already has a GetSegment&lt;T&gt; method with the
    /// same parameters, that method takes precedence over this extension
    /// method.</para>
    /// <para>In the.NET implementation, this method is implemented as an
    /// extension method to any object implementing IList and can be called
    /// as follows: <c>list.GetSegment&lt;T&gt;(start, count)</c>. If the
    /// object's class already has a <c>GetSegment&lt;T&gt;</c> method with
    /// the same parameters, that method takes precedence over this
    /// extension method.</para></summary>
    /// <param name='list'>The parameter <paramref name='list'/> is
    /// a.Collections.Generic.IList{``0} object.</param>
    /// <param name='start'>The parameter <paramref name='start'/> is a
    /// 32-bit signed integer.</param>
    /// <param name='count'>The parameter <paramref name='count'/> is a
    /// 32-bit signed integer.</param>
    /// <typeparam name='T'>Any object type.</typeparam>
    /// <returns>A ListSegment(T) object.</returns>
    /// <exception cref='ArgumentNullException'>The parameter <paramref
    /// name='list'/> is null.</exception>
    public static ListSegment<T> GetSegment<T> (
      this IList<T> list,
      int start,
      int count) {
      if (list == null) {
        throw new ArgumentNullException(nameof(list));
      }
      return new ListSegment<T>(list, start, count);
    }

    /// <summary>Not documented yet.
    /// <para>In the.NET implementation, this method is implemented as an
    /// extension method to any object implementing IList and can be called
    /// as follows: <c>list.ValueOrDefault&lt;T&gt;(index)</c>. If the
    /// object's class already has a ValueOrDefault&lt;T&gt; method with
    /// the same parameters, that method takes precedence over this
    /// extension method.</para></summary>
    /// <param name='list'>The parameter <paramref name='list'/> is
    /// a.Collections.Generic.IList{``0} object.</param>
    /// <param name='index'>The parameter <paramref name='index'/> is a
    /// 32-bit signed integer.</param>
    /// <typeparam name='T'>Type parameter not documented yet.</typeparam>
    /// <returns>A T object.</returns>
    /// <exception cref='ArgumentNullException'>The parameter <paramref
    /// name='list'/> is null.</exception>
    public static T ValueOrDefault<T> (this IList<T> list, int index) {
      if (list == null) {
        throw new ArgumentNullException(nameof(list));
      }
      if (index < 0) {
        throw new ArgumentException("index (" + index +
          ") is less than 0");
      }
      return (index >= list.Count) ? default (T) : list[index];
    }

    /// <summary>Not documented yet.
    /// <para>In the.NET implementation, this method is implemented as an
    /// extension method to any object implementing IList and can be called
    /// as follows: <c>list.SetIfMissing&lt;T&gt;(index, value)</c>. If
    /// the object's class already has a SetIfMissing&lt;T&gt; method with
    /// the same parameters, that method takes precedence over this
    /// extension method.</para>
    /// <para>In the.NET implementation, this method is implemented as an
    /// extension method to any object implementing IList and can be called
    /// as follows: <c>list.SetIfMissing&lt;T&gt;(index, value)</c>. If
    /// the object's class already has a <c>SetIfMissing&lt;T&gt;</c>
    /// method with the same parameters, that method takes precedence over
    /// this extension method.</para></summary>
    /// <param name='list'>The parameter <paramref name='list'/> is
    /// a.Collections.Generic.IList{``0} object.</param>
    /// <param name='index'>The parameter <paramref name='index'/> is a
    /// 32-bit signed integer.</param>
    /// <param name='value'>The parameter <paramref name='value'/> is a ``0
    /// object.</param>
    /// <typeparam name='T'>Type parameter not documented yet.</typeparam>
    /// <returns>A T object.</returns>
    /// <exception cref='ArgumentNullException'>The parameter <paramref
    /// name='list'/> is null.</exception>
    public static T SetIfMissing<T> (this IList<T> list, int index, T value) {
      if (list == null) {
        throw new ArgumentNullException(nameof(list));
      }
      if (index < 0) {
        throw new ArgumentException("index less than " + "0 (" +
          Convert.ToString(
            index,
            System.Globalization.CultureInfo.InvariantCulture) + ")");
      }
      if (index >= list.Count) {
        list.SetValue (index, value);
        return value;
      } else {
        var v = list[index];
        if (Object.Equals (v, default (T))) {
          list[index] = value;
          return value;
        }
        return v;
      }
    }

    /// <summary>Not documented yet.
    /// <para>In the.NET implementation, this method is implemented as an
    /// extension method to any object implementing IList and can be called
    /// as follows: <c>list.SetNewIfMissing&lt;T&gt;(index)</c>. If the
    /// object's class already has a SetNewIfMissing&lt;T&gt; method with
    /// the same parameters, that method takes precedence over this
    /// extension method.</para></summary>
    /// <param name='list'>The parameter <paramref name='list'/> is
    /// a.Collections.Generic.IList{``0} object.</param>
    /// <param name='index'>The parameter <paramref name='index'/> is a
    /// 32-bit signed integer.</param>
    /// <typeparam name='T'>Type parameter not documented yet.</typeparam>
    /// <returns>A T object.</returns>
    /// <exception cref='ArgumentNullException'>The parameter <paramref
    /// name='list'/> is null.</exception>
    public static T SetNewIfMissing<T> (this IList<T> list, int index) where T :
      new () {
      if (list == null) {
        throw new ArgumentNullException(nameof(list));
      }
      if (index < 0) {
        throw new ArgumentException("index less than " + "0 (" +
          Convert.ToString(
            index,
            System.Globalization.CultureInfo.InvariantCulture) + ")");
      }
      if (index >= list.Count) {
        var value = new T();
        list.SetValue (index, value);
        return value;
      } else {
        var v = list[index];
        if (Object.Equals (v, default (T))) {
          var value = new T();
          list[index] = value;
          return value;
        }
        return v;
      }
    }

    /// <summary>Not documented yet.
    /// <para>In the.NET implementation, this method is implemented as an
    /// extension method to any object implementing IList and can be called
    /// as follows: <c>list.SetIfMissing&lt;T&gt;(index, valuefunc)</c>.
    /// If the object's class already has a SetIfMissing&lt;T&gt; method
    /// with the same parameters, that method takes precedence over this
    /// extension method.</para>
    /// <para>In the.NET implementation, this method is implemented as an
    /// extension method to any object implementing IList and can be called
    /// as follows: <c>list.SetIfMissing&lt;T&gt;(index, valuefunc)</c>.
    /// If the object's class already has a <c>SetIfMissing&lt;T&gt;</c>
    /// method with the same parameters, that method takes precedence over
    /// this extension method.</para></summary>
    /// <param name='list'>The parameter <paramref name='list'/> is
    /// a.Collections.Generic.IList{``0} object.</param>
    /// <param name='index'>The parameter <paramref name='index'/> is a
    /// 32-bit signed integer.</param>
    /// <param name='valuefunc'>The parameter <paramref name='valuefunc'/>
    /// is a.Func{``0} object.</param>
    /// <typeparam name='T'>Type parameter not documented yet.</typeparam>
    /// <returns>A T object.</returns>
    /// <exception cref='ArgumentNullException'>The parameter <paramref
    /// name='list'/> is null.</exception>
    public static T SetIfMissing<T> (
      this IList<T> list,
      int index,
      Func<T> valuefunc) {
      if (list == null) {
        throw new ArgumentNullException(nameof(list));
      }
      if (index < 0) {
        throw new ArgumentException("index less than " + "0 (" +
          Convert.ToString(
            index,
            System.Globalization.CultureInfo.InvariantCulture) + ")");
      }
      if (index >= list.Count) {
        var value = valuefunc();
        list.SetValue (index, value);
        return value;
      } else {
        var v = list[index];
        if (Object.Equals (v, default (T))) {
          var value = valuefunc();
          list[index] = value;
          return value;
        }
        return v;
      }
    }

    /// <summary>Not documented yet.
    /// <para>In the.NET implementation, this method is implemented as an
    /// extension method to any object implementing IList and can be called
    /// as follows: <c>list.SetValue&lt;T&gt;(index, value)</c>. If the
    /// object's class already has a SetValue&lt;T&gt; method with the same
    /// parameters, that method takes precedence over this extension
    /// method.</para>
    /// <para>In the.NET implementation, this method is implemented as an
    /// extension method to any object implementing IList and can be called
    /// as follows: <c>list.SetValue&lt;T&gt;(index, value)</c>. If the
    /// object's class already has a <c>SetValue&lt;T&gt;</c> method with
    /// the same parameters, that method takes precedence over this
    /// extension method.</para></summary>
    /// <param name='list'>The parameter <paramref name='list'/> is
    /// a.Collections.Generic.IList{``0} object.</param>
    /// <param name='index'>The parameter <paramref name='index'/> is a
    /// 32-bit signed integer.</param>
    /// <param name='value'>The parameter <paramref name='value'/> is a ``0
    /// object.</param>
    /// <typeparam name='T'>Type parameter not documented yet.</typeparam>
    /// <exception cref='ArgumentNullException'>The parameter <paramref
    /// name='list'/> is null.</exception>
    public static void SetValue<T> (this IList<T> list, int index, T value) {
      if (list == null) {
        throw new ArgumentNullException(nameof(list));
      }
      if (index < 0) {
        throw new ArgumentException("index less than " + "0 (" +
          Convert.ToString(
            index,
            System.Globalization.CultureInfo.InvariantCulture) + ")");
      }
      while (index >= list.Count) {
        list.Add (default (T));
      }
      list[index] = value;
    }

    /// <summary>Copies a certain number of bytes from one stream to
    /// another.
    /// <para>In the.NET implementation, this method is implemented as an
    /// extension method to any object implementing Stream and can be
    /// called as follows: <c>input.CopyStream(length, output)</c>. If the
    /// object's class already has a CopyStream method with the same
    /// parameters, that method takes precedence over this extension
    /// method.</para></summary>
    /// <param name='input'>The parameter <paramref name='input'/> is a
    /// Stream object.</param>
    /// <param name='length'>The parameter <paramref name='length'/> is a
    /// 32-bit signed integer.</param>
    /// <param name='output'>The parameter <paramref name='output'/> is a
    /// Stream object.</param>
    /// <exception cref='ArgumentNullException'>The parameter <paramref
    /// name='input'/> or <paramref name='output'/> is null.</exception>
    public static void CopyStream (this Stream input, int length,
      Stream output) {
      if (input == null) {
        throw new ArgumentNullException(nameof(input));
      }
      if (output == null) {
        throw new ArgumentNullException(nameof(output));
      }
      if (length < 0) {
        throw new ArgumentException("length (" + length +
          ") is less than 0");
      }
      var buffer = new byte[32768];
      var totalLength = length;
      while (totalLength > 0 && length > 0) {
        var readLength = Math.Min (buffer.Length, totalLength);
        if (input.CanSeek) {
          readLength = (int)Math.Min (input.Length - input.Position,
  readLength);
        }
        if (readLength <= 0) {
          return;
        }
        var read = input.Read (buffer, 0, readLength);
        if (read <= 0) {
          return;
        }
        output.Write (buffer, 0, read);
        totalLength -= readLength;
      }
    }

    /// <summary>Copies all bytes from one stream to another.
    /// <para>In the.NET implementation, this method is implemented as an
    /// extension method to any object implementing Stream and can be
    /// called as follows: <c>input.CopyStream(output)</c>. If the
    /// object's class already has a CopyStream method with the same
    /// parameters, that method takes precedence over this extension
    /// method.</para></summary>
    /// <param name='input'>The parameter <paramref name='input'/> is a
    /// Stream object.</param>
    /// <param name='output'>The parameter <paramref name='output'/> is a
    /// Stream object.</param>
    /// <exception cref='ArgumentNullException'>The parameter <paramref
    /// name='input'/> or <paramref name='output'/> is null.</exception>
    public static void CopyStream (this Stream input, Stream output) {
      if (input == null) {
        throw new ArgumentNullException(nameof(input));
      }
      if (output == null) {
        throw new ArgumentNullException(nameof(output));
      }
      var buffer = new byte[32768];
      while (true) {
        var readLength = buffer.Length;
        if (input.CanSeek) {
          readLength = (int)Math.Min (input.Length - input.Position,
  readLength);
        }
        if (readLength <= 0) {
          return;
        }
        var read = input.Read (buffer, 0, readLength);
        if (read <= 0) {
          return;
        }
        output.Write (buffer, 0, read);
      }
    }

    /// <summary>Not documented yet.</summary>
    /// <param name='arr'>The parameter <paramref name='arr'/> is
    /// a.Collections.Generic.IEnumerable{``0} object.</param>
    /// <typeparam name='T'>The type of each object to be
    /// enumerated.</typeparam>
    /// <returns>When enumerated, outputs the item and its index (starting
    /// at 0), in that order.</returns>
    public static IEnumerable<Pair<T, int>> EachWithIndex<T> (
      this IEnumerable<T> arr) {
      if (arr == null) {
        throw new ArgumentNullException(nameof(arr));
      }
      var i = 0;
      foreach (T o in arr) {
        yield return new Pair<T, int> (o, i);
        ++i;
      }
    }
  }
}
