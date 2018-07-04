using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Opdime.Console
{
  interface IConsoleWriter
  {
    TextWriter Out { get; }
    void SetOut(TextWriter writer);
    void Write(char c);
    void Write(string s);
    void Write(char[] c);
    void WriteLine(char c);
    void WriteLine(string s);
    void WriteLine(char[] c);
  }
}
