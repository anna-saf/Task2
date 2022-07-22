using System;
using System.Collections.Generic;
using System.Text;

namespace Task2
{  

    class Car
    {
        public string Model { get; set; }
        protected string Color { get; set; }
        protected string Description { get; set; }

        public override int GetHashCode()
        {
            return HashCode.Combine(Model, Color);
        }

        public bool Equals(Car car)
        {
            return car!=null && Model.Equals(car.Model) && Color.Equals(car.Color);
        }
    }

    
}
