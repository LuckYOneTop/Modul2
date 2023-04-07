using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul2
{
    internal class TaxiPark
    {
        private List<Car> cars;

        public TaxiPark(List<Car> cars)
        {
            this.cars = cars;
        }

        public double CalculateTotalPrice()
        {
            return cars.Sum(car => car.CalculatePrice());
        }

        public List<Car> SortByFuelConsumption()
        {
            return cars.OrderBy(car => car.FuelConsumption).ToList();
        }

        public List<Car> FindCarsByRange(double minFuelConsumption, double maxFuelConsumption)
        {
            return cars.Where(car => car.FuelConsumption >= minFuelConsumption && car.FuelConsumption <= maxFuelConsumption).ToList();
        }
    }
}

