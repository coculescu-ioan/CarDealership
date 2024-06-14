using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDealership
{
    public class Car : IComparable<Car>
    {
        private static int GlobalId = 1;
        public int Id { get; set; }
        public DateTime ManufacturingDate { get; set; }
        public double Price { get; set; }
        public int ManufacturerId { get; set; }

        public Car()
        {
            Id = GlobalId++;
            ManufacturingDate = DateTime.Now;
        }

        public Car(DateTime manufacturingDate, double price, int manufacturerId)
        {
            Id = GlobalId++;
            ManufacturingDate = manufacturingDate;
            Price = price;
            ManufacturerId = manufacturerId;
        }

        public static explicit operator int(Car car)
        {
            return DateTime.Now.Subtract(car.ManufacturingDate).Days;
        }

        public int CompareTo(Car other)
        {
            if (other == null) return 1;
            return Price.CompareTo(other.Price);
        }
    }
}
