using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace rashiITclass


{
    public class car
    {

        //////////////////////////////properties////////////////////////

        public string name { get; set; }
        public string brand { get; set; }
        public string color { get; set; }
        public int noofseat { get; set; }



        ////////////////////////////data functions///////////////

        public int Acclerator(int pressure)
        {
            int speed = pressure * 10;
            return speed;
        }

        public int Break(int pressure)
        {
            int speed = pressure / 10;

            return speed;
        }

        public int Clucth(int pressure)
        {
            int speed = pressure;

            return speed;
        }

    }
}   
