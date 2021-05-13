using System;
namespace OCP.Vehicles
{
    public class Mortorcycle : Vehicle
    {
        public Mortorcycle(string color, int year, double engine) : base(color, year, engine)
        {
            ConfigureMotorcycle();
        }

        public void ConfigureMotorcycle()
        {
            Console.WriteLine($"A criar uma mota {Color}, {Year}, {Engine} cilindrada");
            StartVehicle();
        }
    }
}
