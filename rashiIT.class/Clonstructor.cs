using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace rashiIT
{
    public class Constructor
    {
        //new way to defining//
        public string Name { get; set; }

        ///old way//
           string _color;
        public string color { get{ return _color; } set { _color = value; } }

        int _number;
        public int number { get { return _number; } set { _number = value; } }

        //read only property//

        public int number2 { get; } = 100;


        //default values//
        public int integer;
        public string name;

        public Constructor()
        {
            integer = 500;
            name = "ram";
        }
        public static string word;
        
            

        public Constructor(int a,int b)

        {
            int result = a + b;
            Console.WriteLine(result);
            
            
        }
        // public int no;
        // public string b;
        public Constructor(string c, int a)
        {
            name = c;
            integer = a;

            // Console.WriteLine(true + no + b);
        }
        //copy constructor//

        public Constructor(Constructor kk)
        {
            integer = kk.integer;
            name = kk.name;
        }

        //static constructor///

        static Constructor()
        {
            Console.WriteLine("my family");
            
        }


    }

}
