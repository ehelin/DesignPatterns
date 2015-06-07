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
    public class CmdCreateOrder : CmdAbstract
    {
        public CmdCreateOrder(IReceiver pR)
        {
            r = pR;
        }

        public override void Execute()
        {
            Console.WriteLine("Order Creation Request Made");
            r.Action();
        }
    }
}
