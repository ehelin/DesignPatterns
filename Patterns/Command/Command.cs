using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Patterns.Command.Invoker;
using Patterns.Command.Abstract;
using Patterns.Command.Implementations.Receivers;
using Patterns.Command.Implementations.Commands;
using Patterns.Command.Interfaces;

namespace Patterns.Command
{
    public class Command
    {    
        //This pattern has an invoker class that takes an implementation of an abstract command
        //class that has reference to a receiver that can execute that command.  Concrete commands
        //inherit from the abstract command class.  The receiver reference is (here) an interface that
        //knows how to execute the command.  The invoker's command property is set with a concrete 
        //command/receiver Interface implemenation and executed.  Many commands/receivers can be
        //excuted without changes to the invoker, command or receiver structures.
        public void Run()
        {
            Console.WriteLine("Starting Command Example");

            RunCommandExample();

            Console.WriteLine("List Command Completed!");
        }
        
        private void RunCommandExample()
        {
            OrderInvoker ot = new OrderInvoker();
            
            Console.WriteLine("Creating commands with receivers");

            CmdAbstract create = new CmdCreateOrder(new RecCreateOrder());
            CmdAbstract fill = new CmdFillOrder(new RecFillOrder());
            CmdAbstract ship = new CmdShipOrder(new RecShipOrder());
            CmdAbstract archive = new CmdArchiveOrder(new RecArchiveOrder());
            
            Console.WriteLine("Setting create command in invoker");
            ot.SetCommand(create);
            Console.WriteLine("Invoker executing command");
            ot.Execute();
            
            Console.WriteLine("Setting fill command in invoker");
            ot.SetCommand(fill);
            Console.WriteLine("Invoker executing command");
            ot.Execute();
            
            Console.WriteLine("Setting ship command in invoker");
            ot.SetCommand(ship);
            Console.WriteLine("Invoker executing command");
            ot.Execute();
            
            Console.WriteLine("Setting archive command in invoker");
            ot.SetCommand(archive);
            Console.WriteLine("Invoker executing command");
            ot.Execute();
        }
    }
}
