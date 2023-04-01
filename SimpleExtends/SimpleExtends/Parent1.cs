using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmoClasses
{
    public class Parent
    {
        int i = 10;
        string s = "привет";

        public void show()
        {
            Console.WriteLine($"строковое поле равно {s}, а числовое {i}, а объект, который его вызывает {GetType().Name}");
        }
    }
}
