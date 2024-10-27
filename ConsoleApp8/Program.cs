using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace H.W
{
    namespace ConsoleApp11
    {
        class vehicle
        {
            private string brand;
            public string Brand
            {
                get { return brand; }
                set { brand = value; }
            }
        }
        class motorevehicle : vehicle
        {
            private string modelname;
            public string Modelname
            {
                get { return modelname; }
                set { modelname = value; }
            }
        }
        class car : motorevehicle
        {
        }
        class truck : motorevehicle
        {
        }
        public class vecHW
        {
            static void Main(string[] args)
            {
                car vecl = new car();

                vecl.Brand = "Honday";
                vecl.Modelname = "ribbed";
                Console.WriteLine("Brand car is " + vecl.Brand);
                Console.WriteLine("Model Name car is " + vecl.Modelname);
                truck vecl2 = new truck();
                vecl2.Brand = "GMC";
                vecl2.Modelname = "GMC Yukon";
                Console.WriteLine("Brand truck is " + vecl2.Brand);
                Console.WriteLine("Model Name is " + vecl2.Modelname);
            }
        }
    }
}
