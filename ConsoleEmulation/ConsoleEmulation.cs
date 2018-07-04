using System;
using System.IO;

namespace Opdime.Console
{
  public class ConsoleEmulation : IConsoleWriter, IConsoleReader, IConsoleNavigation
  {
    public int CursorLeft { get; set; }
    public int CursorTop { get; set; }
    public bool CursorVisible { get; set; } = true;
    public TextWriter Out { get; protected set; }
    public TextReader In { get; protected set; }

    public ConsoleEmulation(TextReader p_in, TextWriter p_out)
    {
      this.Out = p_out;
      this.In = p_in;
    }

    public int Read() => this.In.Read();

    public ConsoleKeyInfo ReadKey()
    {
      throw new NotImplementedException();
    }

    public ConsoleKeyInfo ReadKey(bool intercept)
    {
      return this.ReadKey();
    }

    public string ReadLine() => this.In.ReadLine();

    public void SetCursorPosition(int x, int y)
    {
      throw new NotImplementedException();
    }

    public void SetIn(TextReader reader)
    {
      this.In = reader;
    }

    public void SetOut(TextWriter writer)
    {
      this.Out = writer;
    }

    public void Write(char c) => this.Out.Write(c);
    public void Write(string s) => this.Out.Write(s);
    public void Write(char[] c) => this.Out.Write(c);
    public void WriteLine(char c) => this.Out.Write(c);
    public void WriteLine(string s) => this.Out.Write(s);
    public void WriteLine(char[] c) => this.Out.Write(c);
  }
}
