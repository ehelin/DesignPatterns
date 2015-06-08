using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Patterns.FactoryMethod.Products;

namespace Patterns.FactoryMethod.Abstract
{
    public abstract class AbsCarFactory
    {
        public string FactoryName {get;set;}
        public virtual Car BuildCar()
        {
            throw new NotImplementedException();
        }
    }
}
