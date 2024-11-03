/*
Any copyright to this work is released to the Public Domain.
In case this is not possible, this work is also
licensed under the Unlicense: https://unlicense.org/

 */
using System;
using System.Collections.Generic;

namespace PeterO {
  // <summary>Red-black tree, modified by Peter O. from public-domain
  // Java code originally written by Doug Lea.</summary>
  // <typeparam name='T'>Type of each Element in the tree.</typeparam>
  internal sealed class RedBlackTree<T> : ICollection<T> {
    // <summary>The comparator to use for ordering.</summary>
    private readonly IComparer<T> cmpValue;

    private int countValue;
    // instance variables

    // <summary>The Root of the tree. Null if empty.</summary>
    private RBCell treeValue;

    // <summary>Initializes a new instance of the RedBlackTree class. Make
    // an empty tree. Initialize to use DefaultIComparer for
    // ordering.</summary>
    public RedBlackTree() : this(null, null, 0) {
    }

    // <summary>Initializes a new instance of the RedBlackTree class. Make
    // an empty tree, using the supplied Element comparator for
    // ordering.</summary>
    // <param name='c'>An IComparer object.</param>
    public RedBlackTree(IComparer<T> c) : this(c, null, 0) {
    }

    // <summary>Initializes a new instance of the RedBlackTree class.
    // Special version of constructor needed by clone().</summary>
    // <param name='cmp'>An IComparer object.</param>
    // <param name='t'>A RBCell object.</param>
    // <param name='n'>A 32-bit signed integer.</param>
    private RedBlackTree(IComparer<T> cmp, RBCell t, int n) {
      this.countValue = n;
      this.treeValue = t;
      this.cmpValue = cmp ?? Comparer<T>.Default;
    }

    private enum OccurrenceMode {
      // <summary>Always add the Element even if it exists.</summary>
      AlwaysAdd,

      // <summary>Add the Element only if it exists.</summary>
      AddIfMissing,

      // <summary>Add the Element and remove the existing Element if
      // any.</summary>
      OverwriteIfExisting,
    }

    public int Count {
      get {
        return this.countValue;
      }
    }

    // <summary>Gets a value indicating whether this map is
    // read-only.</summary>
    // <value>Always false.</value>
    public bool IsReadOnly {
      get {
        return false;
      }
    }

    public void Add(T Element) {
      this.AddInternal(Element, OccurrenceMode.AlwaysAdd);
    }

    public bool AddIfMissing(T Element) {
      return this.AddInternal(Element, OccurrenceMode.AddIfMissing);
    }

    public bool AddOverwrite(T Element) {
      return this.AddInternal(Element, OccurrenceMode.OverwriteIfExisting);
    }

    // <summary>Implements collections.UpdatableCollection.clear. Time
    // complexity: O(1). @see
    // collections.UpdatableCollection#clear.</summary>
    public void Clear() {
      this.countValue = 0;
      this.treeValue = null;
    }

    // <summary>Implements collections.Collection.includes. Time
    // complexity: O(log n).</summary>
    // <param name='Element'></param>
    // <returns>A Boolean object.</returns>
    public bool Contains(T Element) {
      return (
          this.countValue != 0) && (
          this.treeValue.Find(
            Element,
            this.cmpValue) != null);
    }

    // <summary>Copies this object's data to a new array.</summary>
    // <param name='array'>A T[] object.</param>
    // <param name='arrayIndex'>Starting index to copy to.</param>
    public void CopyTo(T[] array, int arrayIndex) {
      if (array == null) {
        throw new ArgumentNullException(nameof(array));
      }
      if (arrayIndex < 0) {
        throw new ArgumentException("arrayIndex (" + arrayIndex +
          ") is less than 0");
      }
      if (this.treeValue != null) {
        RBCell t = this.treeValue.Leftmost();
        while (t != null && arrayIndex < array.Length) {
          T v = t.Element();
          if (arrayIndex >= 0 && arrayIndex < array.Length) {
            array[arrayIndex] = v;
          }
          ++arrayIndex;
          t = t.Successor();
        }
      }
    }

    public bool Find(T Element, out T outval) {
      if (this.countValue == 0) {
        outval = default(T);
        return false;
      }
      RBCell cell = this.treeValue.Find(Element, this.cmpValue);
      if (cell == null) {
        outval = default(T);
        return false;
      }
      outval = cell.Element();
      return true;
    }

    public IEnumerator<T> GetEnumerator() {
      return this.Iterator().GetEnumerator();
    }

    public int OccurrencesOf(T Element) {
      return (
          this.countValue == 0) ? 0 : this.treeValue.Count(
          Element,
          this.cmpValue);
    }

    // <summary>Implements collections.UpdatableCollection.take. Time
    // complexity: O(log n). Takes the least Element. @see
    // collections.UpdatableCollection#take.</summary>
    // <returns>A T object.</returns>
    public T Pop() {
      if (this.countValue != 0) {
        RBCell p = this.treeValue.Leftmost();
        T v = p.Element();
        this.treeValue = p.Delete(this.treeValue);
        this.DecCount();
        return v;
      }
      return default(T);
    }

    public bool Remove(T Element) {
      return this.Remove_(Element, false);
    }

    public void RemoveAll(T Element) {
      this.Remove_(Element, true);
    }
    // helper methods
    private bool AddInternal(T Element, OccurrenceMode checkOccurrence) {
      if (this.treeValue == null) {
        this.treeValue = new RBCell(Element);
        this.IncCount();
      } else {
        RBCell t = this.treeValue;
        for (; ;) {
          int diff = this.cmpValue.Compare(Element, t.Element());
          if (diff == 0 && checkOccurrence == OccurrenceMode.AddIfMissing) {
            return false;
          }
          if (diff == 0 && checkOccurrence ==
OccurrenceMode.OverwriteIfExisting) {
            t.Element(Element);
            return false;
          }
          if (diff <= 0) {
            if (t.Left() != null) {
              t = t.Left();
            } else {
              this.treeValue = t.InsertLeft(
                  new RBCell(Element),
                  this.treeValue);
              this.IncCount();
              return true;
            }
          } else {
            if (t.Right() != null) {
              t = t.Right();
            } else {
              this.treeValue = t.InsertRight(
                  new RBCell(Element),
                  this.treeValue);
              this.IncCount();
              return true;
            }
          }
        }
      }
      return true;
    }

    private void DecCount() {
      --this.countValue;
    }

    System.Collections.IEnumerator
System.Collections.IEnumerable.GetEnumerator() {
      return this.Iterator().GetEnumerator();
    }

    private void IncCount() {
      ++this.countValue;
    }

    private IEnumerable<T> Iterator() {
      if (this.treeValue != null) {
        RBCell t = this.treeValue.Leftmost();
        while (t != null) {
          T v = t.Element();
          yield return v;
          t = t.Successor();
        }
      }
    }

    private bool Remove_(T Element, bool allOccurrences) {
      var ret = false;
      while (this.countValue > 0) {
        RBCell p = this.treeValue.Find(Element, this.cmpValue);
        if (p != null) {
          this.treeValue = p.Delete(this.treeValue);
          this.DecCount();
          ret = true;
          if (!allOccurrences) {
            return ret;
          }
        } else {
          break;
        }
      }
      return ret;
    }

    private sealed class RBCell {
      private const bool RED = false;
      private const bool BLACK = true;

      // <summary>The Element held in the node.</summary>
      private T elementValue;

      // <summary>The node color (RED, BLACK).</summary>
      private bool colorValue = BLACK;

      // <summary>Pointer to Left child.</summary>
      private RBCell leftValue;

      // <summary>Pointer to Right child.</summary>
      private RBCell rightValue;

      // <summary>Pointer to Parent (null if Root).</summary>
      private RBCell parentValue;

      // <summary>Initializes a new instance of the RBCell class. Make a new
      // cell with given Element, null links, and BLACK color. Normally only
      // called to establish a new Root.</summary>
      // <param name='Element'>A T object.</param>
      public RBCell(T Element) {
        this.elementValue = Element;
      }

      // <summary>Return the Element value.</summary>
      // <returns>A T object.</returns>
      public T Element() {
        return this.elementValue;
      }

      // <summary>Set the Element value.</summary>
      // <param name='v'></param>
      public void Element(T v) {
        this.elementValue = v;
      }

      // <summary>Return Left child (or null).</summary>
      // <returns>A RBCell object.</returns>
      public RBCell Left() {
        return this.leftValue;
      }

      // <summary>Return Right child (or null).</summary>
      // <returns>A RBCell object.</returns>
      public RBCell Right() {
        return this.rightValue;
      }

      // <summary>Return Parent (or null).</summary>
      // <returns>A RBCell object.</returns>
      public RBCell Parent() {
        return this.parentValue;
      }

      // <summary>Return color of node p, or BLACK if p is null.</summary>
      // <param name='p'></param>
      // <returns>A Boolean object.</returns>
      private static bool ColorOf(RBCell p) {
        return (p == null) ? BLACK : p.colorValue;
      }

      // <summary>Return Parent of node p, or null if p is null.</summary>
      // <param name='p'></param>
      // <returns>A RBCell object.</returns>
      private static RBCell ParentOf(RBCell p) {
        return (p == null) ? null : p.parentValue;
      }

      // <summary>Set the color of node p, or do nothing if p is
      // null.</summary>
      // <param name='p'></param>
      // <param name='c'>A Boolean object.</param>
      private static void SetColor(RBCell p, bool c) {
        if (p != null) {
          p.colorValue = c;
        }
      }

      // <summary>Return Left child of node p, or null if p is
      // null.</summary>
      // <param name='p'></param>
      // <returns>A RBCell object.</returns>
      private static RBCell LeftOf(RBCell p) {
        return (p == null) ? null : p.leftValue;
      }

      // <summary>Return Right child of node p, or null if p is
      // null.</summary>
      // <param name='p'></param>
      // <returns>A RBCell object.</returns>
      private static RBCell RightOf(RBCell p) {
        return (p == null) ? null : p.rightValue;
      }

      // <summary>Copy all content fields from another node.</summary>
      // <param name='t'></param>
      private void CopyContents(RBCell t) {
        this.elementValue = t.elementValue;
      }

      // <summary>Return the minimum Element of the current
      // (sub)tree.</summary>
      // <returns>A RBCell object.</returns>
      public RBCell Leftmost() {
        RBCell p = this;
        for (; p.leftValue != null; p = p.leftValue) {
        }
        return p;
      }

      // <summary>Return the maximum Element of the current
      // (sub)tree.</summary>
      // <returns>A RBCell object.</returns>
      public RBCell Rightmost() {
        RBCell p = this;
        for (; p.rightValue != null; p = p.rightValue) {
        }
        return p;
      }

      // <summary>Return the Root (parentless node) of the tree.</summary>
      // <returns>A RBCell object.</returns>
      public RBCell Root() {
        RBCell p = this;
        for (; p.parentValue != null; p = p.parentValue) {
        }
        return p;
      }

      // <summary>Return true if node is a Root (i.e., has a null
      // Parent).</summary>
      // <returns>A Boolean object.</returns>
      public bool IsRoot() {
        return this.parentValue == null;
      }

      // <summary>Return the in-order Successor, or null if no
      // such.</summary>
      // <returns>A RBCell object.</returns>
      public RBCell Successor() {
        if (this.rightValue != null) {
          return this.rightValue.Leftmost();
        } else {
          RBCell p = this.parentValue;
          RBCell ch = this;
          while (p != null && ch == p.rightValue) {
            {
              ch = p;
            }
            p = p.parentValue;
          }
          return p;
        }
      }

      // <summary>Return the in-order Predecessor, or null if no
      // such.</summary>
      // <returns>A RBCell object.</returns>
      public RBCell Predecessor() {
        if (this.leftValue != null) {
          return this.leftValue.Rightmost();
        } else {
          RBCell p = this.parentValue;
          RBCell ch = this;
          while (p != null && ch == p.leftValue) {
            {
              ch = p;
            }
            p = p.parentValue;
          }
          return p;
        }
      }

      // <summary>Return the number of nodes in the sub-tree.</summary>
      // <returns>A 32-bit signed integer.</returns>
      public int Size() {
        var c = 1;
        if (this.leftValue != null) {
          c += this.leftValue.Size();
        }
        if (this.rightValue != null) {
          c += this.rightValue.Size();
        }
        return c;
      }

      // <summary>Return node of current sub-tree containing Element as
      // Element(), if it exists, else null. Uses IComparer <paramref
      // name='cmp '/> to Find and to check equality.</summary>
      // <param name='Element'></param>
      // <param name='cmp'>An IComparer object.</param>
      // <returns>A RBCell object.</returns>
      public RBCell Find(T Element, IComparer<T> cmp) {
        RBCell t = this;
        for (; ;) {
          int diff = cmp.Compare(Element, t.Element());
          if (diff == 0) {
            return t;
          }
          t = (diff < 0) ? t.leftValue : t.rightValue;
          if (t == null) {
            return null;
          }
        }
      }

      // <summary>Return number of nodes of current sub-tree containing
      // Element. Uses IComparer <paramref name='cmp '/> to Find and to
      // check equality.</summary>
      // <param name='Element'></param>
      // <param name='cmp'>An IComparer object.</param>
      // <returns>A 32-bit signed integer.</returns>
      public int Count(T Element, IComparer<T> cmp) {
        var c = 0;
        RBCell t = this;
        while (t != null) {
          int diff = cmp.Compare(Element, t.Element());
          if (diff == 0) {
            ++c;
            if (t.leftValue == null) {
              t = t.rightValue;
            } else if (t.rightValue == null) {
              t = t.leftValue;
            } else {
              c += t.rightValue.Count(Element, cmp);
              t = t.leftValue;
            }
          } else {
            t = (diff < 0) ? t.leftValue : t.rightValue;
          }
        }
        return c;
      }

      // <summary>Insert cell as the Left child of current node, and then
      // rebalance the tree it is in. @return the new Root of the current
      // tree. (Rebalancing can change the Root!).</summary>
      // <param name='cell'>The cell to add.</param>
      // <param name='Root'>Root, the Root of the current tree.</param>
      // <returns>A RBCell object.</returns>
      public RBCell InsertLeft(RBCell cell, RBCell Root) {
        this.leftValue = cell;
        cell.parentValue = this;
        return cell.FixAfterInsertion(Root);
      }

      // <summary>Insert cell as the Right child of current node, and then
      // rebalance the tree it is in.</summary>
      // <param name='cell'>The cell to add.</param>
      // <param name='Root'>The Root of the current tree.</param>
      // <returns>The new Root of the current tree. (Rebalancing can change
      // the Root!).</returns>
      public RBCell InsertRight(RBCell cell, RBCell Root) {
        this.rightValue = cell;
        cell.parentValue = this;
        return cell.FixAfterInsertion(Root);
      }

      // <summary>Delete the current node, and then rebalance the tree it is
      // in.</summary>
      // <param name='Root'>The Root of the current tree.</param>
      // <returns>The new Root of the current tree. Rebalancing can change
      // the Root.</returns>
      public RBCell Delete(RBCell Root) {
        // if strictly internal, swap contents with Successor and then Delete it
        if (this.leftValue != null && this.rightValue != null) {
          RBCell s = this.Successor();
          this.CopyContents(s);
          return s.Delete(Root);
        }
        // Start fixup at replacement node, if it exists
        RBCell replacement = this.leftValue ?? this.rightValue;
        if (replacement != null) {
          // link replacement to Parent
          replacement.parentValue = this.parentValue;
          if (this.parentValue == null) {
            Root = replacement;
          } else if (this == this.parentValue.leftValue) {
            this.parentValue.leftValue = replacement;
          } else {
            this.parentValue.rightValue = replacement;
          }
          // null out links so they are OK to use by FixAfterDeletion
          this.leftValue = null;
          this.rightValue = null;
          this.parentValue = null;
          // fix replacement
          if (this.colorValue) {
            Root = replacement.FixAfterDeletion(Root);
          }
          return Root;
        }
        if (this.parentValue == null) { // exit if we are the only node
          // if no children, use self as phantom replacement
          // and then unlink
          return null;
        }
        if (this.colorValue) {
          Root = this.FixAfterDeletion(Root);
        }
        // Unlink (Couldn't before since FixAfterDeletion needs Parent ptr)
        if (this.parentValue != null) {
          if (this == this.parentValue.leftValue) {
            this.parentValue.leftValue = null;
          } else if (this == this.parentValue.rightValue) {
            this.parentValue.rightValue = null;
          }
          this.parentValue = null;
        }
        return Root;
      }

      /** From CLR **/ private RBCell RotateLeft(RBCell rootValue) {
        RBCell r = this.rightValue;
        this.rightValue = r.leftValue;
        if (r.leftValue != null) {
          r.leftValue.parentValue = this;
        }
        r.parentValue = this.parentValue;
        if (this.parentValue == null) {
          rootValue = r;
        } else if (this.parentValue.leftValue == this) {
          this.parentValue.leftValue = r;
        } else {
          this.parentValue.rightValue = r;
        }
        r.leftValue = this;
        this.parentValue = r;
        return rootValue;
      }

      /** From CLR **/ private RBCell RotateRight(RBCell rootValue) {
        RBCell l = this.leftValue;
        this.leftValue = l.rightValue;
        if (l.rightValue != null) {
          l.rightValue.parentValue = this;
        }
        l.parentValue = this.parentValue;
        if (this.parentValue == null) {
          rootValue = l;
        } else if (this.parentValue.rightValue == this) {
          this.parentValue.rightValue = l;
        } else {
          this.parentValue.leftValue = l;
        }
        l.rightValue = this;
        this.parentValue = l;
        return rootValue;
      }

      /** From CLR **/ private RBCell FixAfterInsertion(RBCell rootValue) {
        this.colorValue = RED;
        RBCell x = this;
        while (x != null && x != rootValue && !x.parentValue.colorValue) {
          if (ParentOf(x) == LeftOf(ParentOf(ParentOf(x)))) {
            RBCell y = RightOf(ParentOf(ParentOf(x)));
            if (!ColorOf(y)) {
              SetColor(ParentOf(x), BLACK);
              SetColor(y, BLACK);
              SetColor(ParentOf(ParentOf(x)), RED);
              x = ParentOf(ParentOf(x));
            } else {
              if (x == RightOf(ParentOf(x))) {
                x = ParentOf(x);
                rootValue = x.RotateLeft(rootValue);
              }
              SetColor(ParentOf(x), BLACK);
              SetColor(ParentOf(ParentOf(x)), RED);
              if (ParentOf(ParentOf(x)) != null) {
                rootValue = ParentOf(ParentOf(x)).RotateRight(rootValue);
              }
            }
          } else {
            RBCell y = LeftOf(ParentOf(ParentOf(x)));
            if (!ColorOf(y)) {
              SetColor(ParentOf(x), BLACK);
              SetColor(y, BLACK);
              SetColor(ParentOf(ParentOf(x)), RED);
              x = ParentOf(ParentOf(x));
            } else {
              if (x == LeftOf(ParentOf(x))) {
                x = ParentOf(x);
                rootValue = x.RotateRight(rootValue);
              }
              SetColor(ParentOf(x), BLACK);
              SetColor(ParentOf(ParentOf(x)), RED);
              if (ParentOf(ParentOf(x)) != null) {
                rootValue = ParentOf(ParentOf(x)).RotateLeft(rootValue);
              }
            }
          }
        }
        rootValue.colorValue = BLACK;
        return rootValue;
      }
      /** From CLR **/
      private RBCell FixAfterDeletion(RBCell rootValue) {
        RBCell x = this;
        while (x != rootValue && ColorOf(x)) {
          if (x == LeftOf(ParentOf(x))) {
            RBCell sib = RightOf(ParentOf(x));
            if (!ColorOf(sib)) {
              SetColor(sib, BLACK);
              SetColor(ParentOf(x), RED);
              rootValue = ParentOf(x).RotateLeft(rootValue);
              sib = RightOf(ParentOf(x));
            }
            if (ColorOf(LeftOf(sib)) && ColorOf(RightOf(sib))) {
              SetColor(sib, RED);
              x = ParentOf(x);
            } else {
              if (ColorOf(RightOf(sib))) {
                SetColor(LeftOf(sib), BLACK);
                SetColor(sib, RED);
                rootValue = sib.RotateRight(rootValue);
                sib = RightOf(ParentOf(x));
              }
              SetColor(sib, ColorOf(ParentOf(x)));
              SetColor(ParentOf(x), BLACK);
              SetColor(RightOf(sib), BLACK);
              rootValue = ParentOf(x).RotateLeft(rootValue);
              x = rootValue;
            }
          } else { // symmetric
            RBCell sib = LeftOf(ParentOf(x));
            if (!ColorOf(sib)) {
              SetColor(sib, BLACK);
              SetColor(ParentOf(x), RED);
              rootValue = ParentOf(x).RotateRight(rootValue);
              sib = LeftOf(ParentOf(x));
            }
            if (ColorOf(RightOf(sib)) && ColorOf(LeftOf(sib))) {
              SetColor(sib, RED);
              x = ParentOf(x);
            } else {
              if (ColorOf(LeftOf(sib))) {
                SetColor(RightOf(sib), BLACK);
                SetColor(sib, RED);
                rootValue = sib.RotateLeft(rootValue);
                sib = LeftOf(ParentOf(x));
              }
              SetColor(sib, ColorOf(ParentOf(x)));
              SetColor(ParentOf(x), BLACK);
              SetColor(LeftOf(sib), BLACK);
              rootValue = ParentOf(x).RotateRight(rootValue);
              x = rootValue;
            }
          }
        }
        SetColor(x, BLACK);
        return rootValue;
      }
    }
  }
}
