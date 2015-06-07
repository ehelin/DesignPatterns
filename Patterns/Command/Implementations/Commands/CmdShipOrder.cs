using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Patterns.Command.Interfaces;
using Patterns.Command.Implementations.Receivers;
using Patterns.Command.Abstract;

namespace Patterns.Command.Implementations.Commands
{
    public class CmdShipOrder : CmdAbstract
    {
        public CmdShipOrder(IReceiver pR)
        {
            r = pR;
        }

        public override void Execute()
        {
            Console.WriteLine("Order Shipping Request Made");
            r.Action();
        }
    }
}
