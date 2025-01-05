using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rashiIT
{
    public class parents
    {
        public void parent()
        {
            Console.WriteLine("we are parents");
        }
    }
    public class child : parents
    {
        public void chid()
        {
            Console.WriteLine("we are child");

        }
    } 

    public class grandchild : child
    {
        public void gc()
        {
            Console.WriteLine("i am grandchild");
        }
    }


}
    
        


        




    
 

