using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace rashiIT
{
    public interface icar
    {
        void acclerator();
        void breakee();

        int varint(int a, int b);
        void sum (int a, int b);
    }
    
    public class Honda : icar
    {
      public  void acclerator()
        {
            Console.WriteLine("i m acclerator method ");
        }

      public   void breakee()
        {
            Console.WriteLine(" i am break");
        }

       public  int varint (int a, int b)
        {
            int result1 = b + a;
            return result1;
            
            
        }

        public void sum (int a, int b)
        {
            Console.WriteLine(a + b);
        }
    }
}
