using System;
using System.Collections.Generic;
using System.Text;

namespace Opdime.Console
{
  interface IConsoleNavigation
  {
    int CursorLeft { get; set; }
    int CursorTop { get; set;  }
    bool CursorVisible { get; set; }

    void SetCursorPosition(int x, int y);
  }
}
