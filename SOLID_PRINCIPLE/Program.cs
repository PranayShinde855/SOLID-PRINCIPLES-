using System;

namespace SOLID_PRINCIPLE
{
    class Program : AbstractClass
    {
        static void Main(string[] args)
        {
            SealedClass sealedClass = new SealedClass();

        }

        public override int Add(int a, int b)
        {
            throw new NotImplementedException();
        }



    }

    internal class Test : AbstractClass, InterfaceTest
    {
        public override int Add(int a, int b)
        {
            throw new NotImplementedException();
        }
    }

    interface InterfaceTest
    {
        int Add(int a, int b);
    }
    abstract class AbstractClass
    {
        //Cannot be instatiated
        //Can be inherited.
        //Abstract method can be created using 
        public abstract int Add(int a, int b);

        public int Substract(int a , int b)
        {
            int c = a - b;
            return c;
        }
    }

    sealed class SealedClass
    {
        //Can not be inherited
        //Can be instantiated
    }

    partial class PartialClass
    {

    }


}
