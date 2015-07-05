using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.CQRS
{
    public class CQRS
    {        
        public void Run()
        {
            Console.WriteLine("Starting CQRS Example");

            RunCommandExample();

            Console.WriteLine("CQRS Completed!");
        }
        
        private void RunCommandExample()
        {
            Console.WriteLine("Implement CRQS");
        }
    }
}
