using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rashiIT
{
    public class methodhiding
    {
        public void parent()
        {
            Console.WriteLine("i am hiding parent method");
        }
    }

    public class methodhiding2 : methodhiding
    {
        public new void parent()
        {
            Console.WriteLine("i am child hiding method");
        }
    }
}
