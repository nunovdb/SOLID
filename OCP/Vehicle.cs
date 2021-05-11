using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP
{
    class Vehicle
    {
        private string Color;
        private int Year;
        private double Engine;
        private int Seats;
        private int Doors;

        public Vehicle(string color, int year, double engine, int seats, int doors)
        {
            Color = color;
            Year = year;
            Engine = engine;
            Seats = seats;
            Doors = doors;
        }

        public void Car() 
        {
            Console.WriteLine($"A criar um carro {Color}, {Year}, {Engine}, {Doors} e {Seats} bancos");
            StartVehicle();
        }
        public void Motorcycle()
        {
            Console.WriteLine($"A criar uma mota {Color}, {Year}, {Engine} cilindrada");
            StartVehicle();
        }

        public void StartVehicle() 
        {
            Console.WriteLine("A ligar os motores");
        }
    }
}
