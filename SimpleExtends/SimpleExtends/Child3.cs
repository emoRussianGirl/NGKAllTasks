using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmoClasses
{
    public class Child3 : Parent2
    {
        new public void show()
        {
            Console.WriteLine("Я замещенный метод в другом производном классе");
        }

        public override void show2()
        {
            Console.WriteLine("Я переопределенный метод в другом производном классе.");
        }
    }
}