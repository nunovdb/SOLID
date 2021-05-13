using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OCP.Vehicles;

namespace OCP
{
    class Program
    {
        static void Main(string[] args)
        {
            // Testar Carro e mota
            //TypeVehicle type = TypeVehicle.CAR; 
            TypeVehicle type = TypeVehicle.MOTORCYCLE;

            if (type == TypeVehicle.CAR)
            {
                Car car = new Car("Red", 2022, 2.0, 5, 4);
            }
            else 
            {
                Mortorcycle mortorcycle = new Mortorcycle("Yellow", 2021, 250);
               
            }

            Console.ReadLine();
        }
    }
}
