using System;
namespace OCP.Vehicles
{
    public class Car : Vehicle
    {
        private int Seats;
        private int Doors;

        public Car(string color, int year, double engine, int seats, int doors) : base(color, year, engine)
        {
            Doors = doors;
            Seats = seats;

            ConfigureCar();
        }

        public void ConfigureCar()
        {
            Console.WriteLine($"A criar um carro {Color}, {Year}, {Engine}, {Doors} e {Seats} bancos");
            StartVehicle();
        }
    }
}
