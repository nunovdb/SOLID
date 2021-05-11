using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                Vehicle vehicle = new Vehicle("Red", 2022, 2.0, 5, 4);
                vehicle.Car();
            }
            else 
            {
                Vehicle vehicle = new Vehicle("Yellow", 2021, 250, 0, 0);
                vehicle.Motorcycle();
            }

            Console.ReadLine();
        }
    }
}
