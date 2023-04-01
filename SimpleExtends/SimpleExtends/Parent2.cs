using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmoClasses
{
    public class Parent2
    {
        public virtual void show()
        {
            Console.WriteLine("Я виртуальный метод родительского класса");
        }

        public virtual void show2()
        {
            Console.WriteLine("Я второй виртуальный метод родительского класса");
        }
    }
}
