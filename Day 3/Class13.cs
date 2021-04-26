using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_3
{
    interface Vehicle
    {
        void ChangeGear(int a);
        void SpeedUp(int a);
        void applyBrakes(int a);
    }

    class Bicycle : Vehicle
    {
        int speed;
        int gear;
        public void ChangeGear(int newGear)
        {
            gear = newGear;
        }
        public void SpeedUp(int increment)
        {
            speed = speed + increment;
        }
        public void applyBrakes(int decrement)
        {
            speed = speed - decrement;
        }
        public void PrintStates()
        {
            Console.WriteLine("speed" + speed + "gear" + gear);
        }

        class Client
        {
            public static void Main()
            {
                Bicycle bicycle = new Bicycle();
                bicycle.ChangeGear(2);
                bicycle.SpeedUp(3);
                bicycle.applyBrakes(1);
                Console.WriteLine("Bicycle present state");
                bicycle.PrintStates();
                Console.ReadLine();

                Console.WriteLine("------------------");
                Bicycle bike = new Bicycle();
                bike.ChangeGear(2);
                bike.SpeedUp(3);
                bike.applyBrakes(1);
                Console.WriteLine("Bicycle present state");
                bike.PrintStates();
                Console.ReadLine();
            }
        }
    }
}
