using System;

namespace Car
{
    public class Truck: ICar
    {
        public string _type { get; set; }
        public double  _fuelConsumption { get; set; }
        public int  _tankCapacity { get; set; }
        public double  _speed { get; set; }
        public int  _loadCapacity  { get; set; }

        public Truck(string type, double  fuelConsumption, int  tankCapacity, double  speed, int  loadCapacity)
        {
            _type = type;
            _fuelConsumption = fuelConsumption;
            _tankCapacity = tankCapacity;
            _speed = speed;
            _loadCapacity = loadCapacity;
        }

        
        
        public double PowerReserve()
        {
            return _tankCapacity / _fuelConsumption * 100;
        }
       
       
        public double PowerReserveLoadedCar()
        {
            if (_loadCapacity <= 2000&& _loadCapacity > 0)
            {
                double remainingInterest = 1 - _loadCapacity / 200 * 4 * 0.01;
                return _tankCapacity / _fuelConsumption * 100 * remainingInterest;
            }
            else
            {
                Console.WriteLine("Введите корректный вес");
                return 0;
            }
        }
       
       
        public  double TravelTime(double distance)
        {
            return distance / _speed;
        }
    }
}