using System;
using System.Collections.Generic;
using System.Text;

namespace MyJope
{
    //1 задание
    public delegate void CharAction(char c);

    public class CharDelegate
    {
        private char symb;

        public char Symb
        {
            get
            {
                return symb;
            }
        }

        public void SetSymb(char c)
        {
            symb = c;
        }
    }
}
