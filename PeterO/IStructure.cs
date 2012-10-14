/*
Written by Peter O.
Any copyright is dedicated to the Public Domain.
http://creativecommons.org/publicdomain/zero/1.0/
If you like this, you should donate to Peter O.
at: http://upokecenter.dreamhosters.com/articles/donate-now-2/
 */
using System;
using System.IO;

namespace PeterO {
    /// <include file='../docs.xml'
    /// path='docs/doc[@name="T:PeterO.IStructure"]/*'/>
public interface IStructure {
    /// <include file='../docs.xml'
    /// path='docs/doc[@name="M:PeterO.IStructure.Read(System.IO.Stream)"]/*'/>
    void Read(Stream stream);

    /// <include file='../docs.xml'
    /// path='docs/doc[@name="M:PeterO.IStructure.Read(PeterO.BinaryIO)"]/*'/>
    void Read(BinaryIO bio);

    /// <include file='../docs.xml'
    /// path='docs/doc[@name="M:PeterO.IStructure.Write(System.IO.Stream)"]/*'/>
    void Write(Stream stream);

    /// <include file='../docs.xml'
    /// path='docs/doc[@name="M:PeterO.IStructure.Write(PeterO.BinaryIO)"]/*'/>
    void Write(BinaryIO bio);
  }
}
