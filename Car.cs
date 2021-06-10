using System;
using System.Collections.Generic;
using System.Text;

namespace SpeedRacing
{
    public class Car
    {
        public Car(string model, double fuelAmount, double fuelConsumptionPerKm)
        {
            this.Model = model;
            this.FuelAmount = fuelAmount;
            this.FuelConsumptionPerKm = fuelConsumptionPerKm;
           // this.TravelledDistance = 0;

        }

        public string Model { get; private set; }
        public double FuelAmount { get; private set; }
        public double FuelConsumptionPerKm { get; private set; }
        public double TravelledDistance { get; set; }

        public void Drive(double dictanceInKms) 
        {
            double consumedFuel = (FuelConsumptionPerKm * dictanceInKms);
            bool canDrive = FuelAmount - consumedFuel >= 0;

            if (canDrive == true)
            {
                FuelAmount -= consumedFuel;
                TravelledDistance += dictanceInKms;
            }
            else
            {
                Console.WriteLine("Insufficient fuel for the drive");
            }
        }
    }
}
