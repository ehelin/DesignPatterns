using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Patterns.Bridge.Parent;
using Patterns.Bridge.Interfaces;
using Patterns.Bridge.ConcreteImplemetations;
using Patterns.Bridge.Child;

namespace Patterns.Bridge
{
    public class Bridge
    {
        //Simply stated, the bridge pattern allows a parent class (agent) to hold a reference to an 
        //interface (IOffice) that can be set by any child classes (CiaAgent) with concrete 
        //implementations (CiaOffice & FbiOffice) that can be called (.GiveSupport()) and exist together.
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
