using System;
using System.Collections.Generic;
using System.Linq;

namespace SpeedRacing
{
    public class StartUp
    {
        static void Main(string[] args)
        {            
            int n = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();

            for (int i = 0; i < n; i++)
            {
                string[] carData = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string model = carData[0];
                double fuelAmount = double.Parse(carData[1]);
                double fuelConsumForOneKm = double.Parse(carData[2]);

                //Car car = new Car(model, fuelAmount, fuelConsumForOneKm);
                 cars.Add(new Car(model, fuelAmount, fuelConsumForOneKm));
            }

            while (true)
            {
                string comand = Console.ReadLine();

                if (comand == "End")
                {
                    //ToDo
                    break;
                }

                string[] comandData = comand
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string currComand = comandData[0];
                string currCarModel = comandData[1];
                double distanceInkms = double.Parse(comandData[2]);

                if (currComand == "Drive")
                {
                     cars.Where(car => car.Model == currCarModel)
                        .ToList()
                        .ForEach(car => car.Drive(distanceInkms));
                }                
            }

            foreach (Car car in cars)
            {
                Console.WriteLine($"{car.Model} {car.FuelAmount:f2} {car.TravelledDistance}");
            }
        }
    }
}
