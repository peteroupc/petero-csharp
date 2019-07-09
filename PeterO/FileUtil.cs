using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace PeterO {
  public static class FileUtil {
    /// <summary>Convenience function that combines two or more file paths
    /// into one, usually by putting path separators between
    /// them.</summary>
    /// <param name='paths'>A params object.</param>
    /// <returns>A string object.</returns>
    /// <exception cref='ArgumentException'>Paths[0] is null.</exception>
    public static string PathCombine (params string[] paths) {
      if (paths.Length == 0) {
        return String.Empty;
      }
      if (paths[0] == null) {
        throw new ArgumentException("paths[0] is null");
      }
      string ret = paths[0];
      for (int i = 1; i < paths.Length; ++i) {
        ret = Path.Combine (ret, paths[i]);
      }
      return ret;
    }

    /// <summary>Reads from a stream until it runs out and writes the data
    /// read to a file.
    /// <para>In the.NET implementation, this method is implemented as an
    /// extension method to any object implementing Stream and can be
    /// called as follows: <c>s.SaveStream(realPath)</c>. If the object's
    /// class already has a SaveStream method with the same parameters,
    /// that method takes precedence over this extension
    /// method.</para></summary>
    /// <param name='s'>A Stream object.</param>
    /// <param name='realPath'>A string object.</param>
    /// <exception cref='ArgumentNullException'>The parameter <paramref
    /// name='realPath'/> is null.</exception>
    public static void SaveStream(
      this Stream s,
      string realPath) {
      if (realPath == null) {
        throw new ArgumentNullException(nameof(realPath));
      }
      if (realPath.Length == 0) {
        throw new ArgumentException("realPath" + " is empty.");
      }
      using (var ws = new FileStream(realPath, FileMode.Create)) {
        CopyStream (s, ws);
      }
    }
  }
}
