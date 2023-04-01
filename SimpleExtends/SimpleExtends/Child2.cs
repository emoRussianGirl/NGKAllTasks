using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmoClasses
{
    public class Child2 : Parent2
    {
        public override void show()
        {
            Console.WriteLine("Я переопределеный метод в производном классе.");
        }

        new public void show2()
        {
            Console.WriteLine("Я замещенный метод в производном классе.");
        }
    }
}
