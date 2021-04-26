using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_3
{
    class Vehicle
    {
        public string Brand = "Ford";
        public void honk()
        {
            Console.WriteLine("tuut,tuut !");
        }

    }
    class Car : Vehicle
    {
        Car(string _model)
        {
            modelname = _model;
        }
  
        public string modelname { get; set; }

        public static void Main()
        {
            Car mycar = new Car("Mustang");
            mycar.honk();
            Console.WriteLine(mycar.Brand + " " + mycar.modelname);
            Console.ReadLine();
        }
    }
}
