/*
Written by Peter O.
Any copyright is dedicated to the Public Domain.
http://creativecommons.org/publicdomain/zero/1.0/
If you like this, you should donate to Peter O.
at: http://peteroupc.github.io/
 */
using System;
using System.Globalization;

namespace PeterO {
    /// <include file='../docs.xml'
    /// path='docs/doc[@name="T:PeterO.InvariantText"]/*'/>
  public static class InvariantText {
    /// <include file='../docs.xml'
    /// path='docs/doc[@name="M:PeterO.InvariantText.Format(System.String,System.Object[])"]/*'/>
    public static string Format(string formattedText, params object[] options) {
    return String.Format(CultureInfo.InvariantCulture, formattedText, options);
    }

    /// <include file='../docs.xml'
    /// path='docs/doc[@name="M:PeterO.InvariantText.ToString(System.Int32)"]/*'/>
    public static string ToString(int value) {
      return Convert.ToString(value, CultureInfo.InvariantCulture);
    }

    /// <include file='../docs.xml'
    /// path='docs/doc[@name="M:PeterO.InvariantText.ToString(System.Int64)"]/*'/>
    public static string ToString(long value) {
      return Convert.ToString(value, CultureInfo.InvariantCulture);
    }

    /// <include file='../docs.xml'
    /// path='docs/doc[@name="M:PeterO.InvariantText.ToString(System.Int16)"]/*'/>
    public static string ToString(short value) {
      return Convert.ToString(value, CultureInfo.InvariantCulture);
    }

    /// <include file='../docs.xml'
    /// path='docs/doc[@name="M:PeterO.InvariantText.ToString(System.Byte)"]/*'/>
    public static string ToString(byte value) {
    return Convert.ToString(((int)value) & 0xff, CultureInfo.InvariantCulture);
    }

    /// <include file='../docs.xml'
    /// path='docs/doc[@name="M:PeterO.InvariantText.ToString(System.Single)"]/*'/>
    public static string ToString(float value) {
      return Convert.ToString(value, CultureInfo.InvariantCulture);
    }

    /// <include file='../docs.xml'
    /// path='docs/doc[@name="M:PeterO.InvariantText.ToString(System.Double)"]/*'/>
    public static string ToString(double value) {
      return Convert.ToString(value, CultureInfo.InvariantCulture);
    }

    /// <include file='../docs.xml'
    /// path='docs/doc[@name="M:PeterO.InvariantText.ToString(System.Object)"]/*'/>
    public static string ToString(object value) {
      return Convert.ToString(value, CultureInfo.InvariantCulture);
    }

    /// <include file='../docs.xml'
    /// path='docs/doc[@name="M:PeterO.InvariantText.Compare(System.String,System.String)"]/*'/>
    public static int Compare(string value1, string value2) {
      return String.Compare(value1, value2, StringComparison.Ordinal);
    }

    /// <include file='../docs.xml'
    /// path='docs/doc[@name="M:PeterO.InvariantText.CompareIgnoreCase(System.String,System.String)"]/*'/>
    public static int CompareIgnoreCase(string value1, string value2) {
      return String.Compare(value1, value2, StringComparison.OrdinalIgnoreCase);
    }

    /// <include file='../docs.xml'
    /// path='docs/doc[@name="M:PeterO.InvariantText.StartsWith(System.String,System.String)"]/*'/>
    public static bool StartsWith(string value1, string value2) {
      if (value1 == null) {
        throw new ArgumentNullException(nameof(value1));
      }
      return value1.StartsWith(value2, StringComparison.Ordinal);
    }

    /// <include file='../docs.xml'
    /// path='docs/doc[@name="M:PeterO.InvariantText.EndsWith(System.String,System.String)"]/*'/>
    public static bool EndsWith(string value1, string value2) {
      if (value1 == null) {
        throw new ArgumentNullException(nameof(value1));
      }
      return value1.EndsWith(value2, StringComparison.OrdinalIgnoreCase);
    }

    /// <include file='../docs.xml'
    /// path='docs/doc[@name="M:PeterO.InvariantText.ParseInt32(System.String)"]/*'/>
    public static int ParseInt32(string value) {
      return Int32.Parse(value, CultureInfo.InvariantCulture);
    }

    /// <include file='../docs.xml'
    /// path='docs/doc[@name="M:PeterO.InvariantText.ParseInt32Hex(System.String)"]/*'/>
    public static int ParseInt32Hex(string value) {
      return Int32.Parse(
  value,
  NumberStyles.HexNumber,
  CultureInfo.InvariantCulture);
    }
  }
}
