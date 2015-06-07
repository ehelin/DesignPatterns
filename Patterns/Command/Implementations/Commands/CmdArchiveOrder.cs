using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Patterns.Command.Abstract;
using Patterns.Command.Implementations.Receivers;
using Patterns.Command.Interfaces;

namespace Patterns.Command.Implementations.Commands
{
    public class CmdArchiveOrder : CmdAbstract
    {
        public CmdArchiveOrder(IReceiver pR)
        {
            r = pR;
        }

        public override void Execute()
        {
            Console.WriteLine("Order Archivation Request Made");            
            r.Action();
        }
    }
}
