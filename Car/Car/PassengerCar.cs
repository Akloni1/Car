using System;

namespace Car
{
    public class PassengerCar : ICar
    {
       public string _type { get; set; }
       public double  _fuelConsumption { get; set; }
       public int  _tankCapacity { get; set; }
       public double  _speed { get; set; }
       public int  _passengersCount  { get; set; }

       public PassengerCar(string type, double  fuelConsumption, int  tankCapacity, double  speed, int  passengersCount)
       {
           _type = type;
           _fuelConsumption = fuelConsumption;
           _tankCapacity = tankCapacity;
           _speed = speed;
           _passengersCount = passengersCount;
       }

       public double PowerReserve()
       {
           return _tankCapacity / _fuelConsumption * 100;
       }
       
       
       public double PowerReserveLoadedCar()
       {
           if (_passengersCount <= 5&& _passengersCount > 0)
           {
               double remainingInterest = 1 - _passengersCount * 6 * 0.01;
               return _tankCapacity / _fuelConsumption * 100 * remainingInterest;
           }
           else
           {
               Console.WriteLine("Введите корректное число пассажиров");
               return 0;
           }
       }
       
       
       public  double TravelTime(double distance)
       {
           return distance / _speed;
       }
    }
}