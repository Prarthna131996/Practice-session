using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rashiIT
{
    public class A
    {
        public virtual void methodA()
        {
            Console.WriteLine("i am method A");
        }
    }

    public class B : A
    {
        public override void methodA()
        {
            Console.WriteLine("i am changed method");
        }

    }


    public class c : B
    {
        public override void methodA()
        {
            Console.WriteLine(" i am new method");
        }
    }
}
