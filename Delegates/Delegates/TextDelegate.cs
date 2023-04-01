using System;
using System.Collections.Generic;
using System.Text;

namespace MyJope
{
    //2 задание

    public delegate int TextDelegate(char symb, string text);

    public static class TextMethods
    {
        //Подсчет вхождений символа в строке.
        public static int CountSymbInText(char symb, string text)
        {
            int count = 0;

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == symb)
                {
                    count++;
                }
            }

            return count;
        }

        //Индекс первого вхождения символа в строке.
        public static int FirstIndexOfSymbInText(char symb, string text)
        {
            for (int i =0; i < text.Length; i++)
            {
                if (text[i] == symb)
                {
                    return i;
                }
            }

            return -1;
        }
    }
}
