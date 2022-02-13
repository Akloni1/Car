using System;

namespace Car
{
    public class SportCar : ICar
    {
        public string _type { get; set; }
        public double  _fuelConsumption { get; set; }
        public int  _tankCapacity { get; set; }
        public double  _speed { get; set; }
       

        public SportCar(string type, double  fuelConsumption, int  tankCapacity, double  speed)
        {
            _type = type;
            _fuelConsumption = fuelConsumption;
            _tankCapacity = tankCapacity;
            _speed = speed;
           
        }

        public double PowerReserve()
        {
            return _tankCapacity / _fuelConsumption * 100;
        }
       
       
        public double PowerReserveLoadedCar()
        {
            return _tankCapacity / _fuelConsumption * 100;// в задании не было указано чем нагружен спортивный автомобиль
        }
       
       
        public  double TravelTime(double distance)
        {
            return distance / _speed;
        }
    }
}