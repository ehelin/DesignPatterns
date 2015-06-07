using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Patterns.Command.Interfaces;

namespace Patterns.Command.Implementations.Receivers
{
    public class RecArchiveOrder : IReceiver
    {
        public void Action()
        {
            Console.WriteLine("Order Archived");
        }
    }
}
