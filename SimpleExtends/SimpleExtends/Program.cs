using System;
using System.Runtime.CompilerServices;
namespace EmoClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Parent parent = new Parent();
            parent.show();

            Child1 child1 = new Child1();
            parent.show();

            Parent2 parent2 = new Parent2();
            parent2.show();
            parent2.show2();

            Parent2 child2 = new Child2();
            Parent2 child3 = new Child3();

            child2.show();
            child2.show2();
            
            child3.show();
            child3.show2();
           Console.ReadKey();
        }
    }
}