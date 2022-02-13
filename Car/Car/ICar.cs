namespace Car
{
    public interface ICar
    {
         string _type { get; set; }
         double  _fuelConsumption { get; set; }
         int  _tankCapacity { get; set; }
         double  _speed { get; set; }


         double PowerReserve();
         double PowerReserveLoadedCar();
         double TravelTime(double distance); 
    }
}