/*
Written by Peter O.
Any copyright to this work is released to the Public Domain.
In case this is not possible, this work is also
licensed under the Unlicense: https://unlicense.org/

 */
using System;
using System.Globalization;

namespace PeterO {
  /// <summary>Contains string processing operations that should be
  /// consistent regardless of locale. This class, along with the
  /// CulturedText class, supports the correct use of string functions in
  /// the framework. InvariantText is intended for use in
  /// locale-independent string processing, such as data and file system
  /// processing, while CulturedText is intended for text
  /// display.</summary>
  public static class InvariantText {
    /// <summary>Not documented yet.</summary>
    /// <param name='formattedText'>The parameter <paramref
    /// name='formattedText'/> is a text string.</param>
    /// <param name='options'>The parameter <paramref name='options'/> is a
    /// params object.</param>
    /// <returns>A text string.</returns>
    public static string Format (string formattedText,
      params object[] options) {
      return String.Format (CultureInfo.InvariantCulture, formattedText,
  options);
    }
  }
}
