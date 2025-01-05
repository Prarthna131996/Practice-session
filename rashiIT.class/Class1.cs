using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace rashiIT
{
    public class Methods


    {
        //void//
        public void test()

        {
            Console.WriteLine("this is good");
        }

        ///with parameters//

        public void Sum(int num1, int num2)
        {
            int result = num1 + num2;
            Console.WriteLine(result);
        }

        //method with aaray parameter//


       public void sumarray(int[]arrayxx)
        {
            int result = 0;
            foreach (int i in arrayxx) 
            {
                result = result + i;
            }
                Console.WriteLine (result);
            
        }

        //method with return type//
        public int[] getarray(int a, int b)
        {
            int[] result = new int[2];
            result[0] = a;
            result[1] = b;
            return result;
        }

        //param parameter///
          
        public void xxx( params int[]value)
        {
            
            for (int i = 0; i< value.Length; i++)
            {
               Console.WriteLine(value[i]); 
                
            }
        }   

            






        
    }
}


