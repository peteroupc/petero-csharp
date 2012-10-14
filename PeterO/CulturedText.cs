/*
Written by Peter O.
Any copyright is dedicated to the Public Domain.
http://creativecommons.org/publicdomain/zero/1.0/
If you like this, you should donate to Peter O.
at: http://upokecenter.dreamhosters.com/articles/donate-now-2/
 */
using System;
using System.Globalization;

namespace PeterO {
    /// <include file='../docs.xml'
    /// path='docs/doc[@name="T:PeterO.CulturedText"]/*'/>
  public static class CulturedText {
    /// <include file='../docs.xml'
    /// path='docs/doc[@name="M:PeterO.CulturedText.Format(System.String,System.Object[])"]/*'/>
    public static string Format(string formattedText, params object[] options) {
      return String.Format(CultureInfo.CurrentCulture, formattedText, options);
    }

    /// <include file='../docs.xml'
    /// path='docs/doc[@name="M:PeterO.CulturedText.ToString(System.Int32)"]/*'/>
    public static string ToString(int value) {
      return Convert.ToString(value, CultureInfo.CurrentCulture);
    }

    /// <include file='../docs.xml'
    /// path='docs/doc[@name="M:PeterO.CulturedText.ToString(System.Int64)"]/*'/>
    public static string ToString(long value) {
      return Convert.ToString(value, CultureInfo.CurrentCulture);
    }

    /// <include file='../docs.xml'
    /// path='docs/doc[@name="M:PeterO.CulturedText.ToString(System.Int16)"]/*'/>
    public static string ToString(short value) {
      return Convert.ToString(value, CultureInfo.CurrentCulture);
    }

    /// <include file='../docs.xml'
    /// path='docs/doc[@name="M:PeterO.CulturedText.ToString(System.Byte)"]/*'/>
    public static string ToString(byte value) {
      return Convert.ToString(((int)value) & 0xff, CultureInfo.CurrentCulture);
    }

    /// <include file='../docs.xml'
    /// path='docs/doc[@name="M:PeterO.CulturedText.ToString(System.Single)"]/*'/>
    public static string ToString(float value) {
      return Convert.ToString(value, CultureInfo.CurrentCulture);
    }

    /// <include file='../docs.xml'
    /// path='docs/doc[@name="M:PeterO.CulturedText.ToString(System.Double)"]/*'/>
    public static string ToString(double value) {
      return Convert.ToString(value, CultureInfo.CurrentCulture);
    }

    /// <include file='../docs.xml'
    /// path='docs/doc[@name="M:PeterO.CulturedText.ToString(System.Object)"]/*'/>
    public static string ToString(object value) {
      return Convert.ToString(value, CultureInfo.CurrentCulture);
    }

    /// <include file='../docs.xml'
    /// path='docs/doc[@name="M:PeterO.CulturedText.Compare(System.String,System.String)"]/*'/>
    public static int Compare(string value1, string value2) {
      return String.Compare(value1, value2, StringComparison.CurrentCulture);
    }

    /// <include file='../docs.xml'
    /// path='docs/doc[@name="M:PeterO.CulturedText.CompareIgnoreCase(System.String,System.String)"]/*'/>
    public static int CompareIgnoreCase(string value1, string value2) {
      return String.Compare(
value1,
value2,
StringComparison.CurrentCultureIgnoreCase);
    }

    /// <include file='../docs.xml'
    /// path='docs/doc[@name="M:PeterO.CulturedText.StartsWith(System.String,System.String)"]/*'/>
    public static bool StartsWith(string value1, string value2) {
      if (value1 == null) {
        throw new ArgumentNullException("value1");
      }
      return value1.StartsWith(value2, StringComparison.CurrentCulture);
    }

    /// <include file='../docs.xml'
    /// path='docs/doc[@name="M:PeterO.CulturedText.EndsWith(System.String,System.String)"]/*'/>
    public static bool EndsWith(string value1, string value2) {
      if (value1 == null) {
        throw new ArgumentNullException("value1");
      }
      return value1.EndsWith(value2, StringComparison.CurrentCultureIgnoreCase);
    }

    /// <include file='../docs.xml'
    /// path='docs/doc[@name="M:PeterO.CulturedText.ParseInt32(System.String)"]/*'/>
    public static int ParseInt32(string value) {
      return Int32.Parse(value, CultureInfo.CurrentCulture);
    }

    /// <include file='../docs.xml'
    /// path='docs/doc[@name="M:PeterO.CulturedText.ParseInt32Hex(System.String)"]/*'/>
    public static int ParseInt32Hex(string value) {
 return Int32.Parse(value, NumberStyles.HexNumber, CultureInfo.CurrentCulture);
    }
  }
}
