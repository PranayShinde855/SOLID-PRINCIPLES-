using System;

namespace Liskov_Substitution_Principle
{
    // Any parent should able to replace its child properties.
    public class Parent
    {
        public virtual string Color()
        {
            return "Red";
        }
    }

    class Child : Parent
    {
        public override string Color()
        {
            return "Green";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Parent parent = new Child();
            parent.Color();
            Console.Write(parent.Color());
        }
    }
}
