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
        //This pattern encapsulates a receiver (request action) within a command (requestO and the executes that in an invoker. The command, 
        //receiver and invoker know nothing about each other on specifics.  This way, any number of commands with receivers can be
        //executed by the invoker with no changes.
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
