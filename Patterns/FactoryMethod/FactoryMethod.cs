using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Patterns.FactoryMethod.Abstract;
using Patterns.FactoryMethod.Implementations;
using Patterns.FactoryMethod.Products;

namespace Patterns.FactoryMethod
{
    public class FactoryMethod
    {
        //This pattern creates an abstract class that create a base product.  Concrete factories
        //inherit this class and turn out child products.
        public void Run()
        {
            Console.WriteLine("Starting Factory Method Example");

            RunFactoryMethodExample();

            Console.WriteLine("List Factory Method Completed!");
        }

        private void RunFactoryMethodExample()
        {
            Car c = null;
            IList<AbsCarFactory> factories = PopulateFactories();

            foreach(AbsCarFactory factory in factories)
            {
                Console.WriteLine("Factory " + factory.FactoryName + " running");

                c = factory.BuildCar();
                Console.WriteLine("Car " + c.CarName + " is built");
            }
        }

        private IList<AbsCarFactory> PopulateFactories()
        {
            IList<AbsCarFactory> factories = new List<AbsCarFactory>();
            
            Console.WriteLine("Populating factories");

            factories.Add(new CarFactoryA("Factory A"));
            factories.Add(new CarFactoryB("Factory B"));
            factories.Add(new CarFactoryC("Factory C"));
            factories.Add(new CarFactoryD("Factory D"));
            factories.Add(new CarFactoryE("Factory E"));
            factories.Add(new CarFactoryF("Factory F"));
            factories.Add(new CarFactoryG("Factory G"));
            factories.Add(new CarFactoryH("Factory H"));
            factories.Add(new CarFactoryI("Factory I"));

            return factories;
        }
    }
}
