using System;
using System.IO;

namespace Opdime.Console
{
  interface IConsoleReader
  {
    TextReader In { get; }
    void SetIn(TextReader reader);
    int Read();
    ConsoleKeyInfo ReadKey();
    ConsoleKeyInfo ReadKey(bool intercept);
    string ReadLine();
  }
}
