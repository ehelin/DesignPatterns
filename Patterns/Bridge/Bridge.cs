using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Patterns.Bridge.Parent;
using Patterns.Bridge.Interfaces;
using Patterns.Bridge.Implemetations;
using Patterns.Bridge.Child;

namespace Patterns.Bridge
{
    public class Bridge
    {
        //This pattern separates the implementation (CiaOffice & FbiOffice) from the calling
        //abstraction (client).  The parent (Agent) is an abstract class that holds a reference to an 
        //interface (IOffice) that can be set by any child classes (CiaAgent) with concrete 
        //implementations (CiaOffice & FbiOffice) that can be called (.GiveSupport()).
        public void Run()
        {
            Console.WriteLine("Starting Bridge Example");

            RunBridgeExample();

            Console.WriteLine("List Bridge Completed!");
        }

        private void RunBridgeExample()
        {
            Agent agent = null;
            string msg = string.Empty;

            Console.WriteLine("Creating child class of parent with reference to concrete one implementation");
            agent = new CiaAgent(new CiaOffice());
            msg = agent.GiveSupport();            
            Console.WriteLine("Calling concrete implementation");
            Console.WriteLine(msg);
            
            Console.WriteLine("Creating child class of parent with reference to concrete two implementation");
            agent = new CiaAgent(new FbiOffice());
            msg = agent.GiveSupport();
            Console.WriteLine("Calling concrete implementation");
            Console.WriteLine(msg);
        }
    }
}
