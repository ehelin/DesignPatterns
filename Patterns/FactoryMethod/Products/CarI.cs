using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Patterns.FactoryMethod;

namespace Patterns.FactoryMethod.Products
{
    public class CarI : Car
    {
        public CarI()
        {
            this.CarName = "CarI";
        }
    }
}
