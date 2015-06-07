using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Patterns.Command.Abstract;
using Patterns.Command.Implementations.Receivers;
using Patterns.Command.Implementations.Commands;
using Patterns.Command.Interfaces;

namespace Patterns.Command.Invoker
{
    public class OrderInvoker
    {
        private CmdAbstract cmd = null;

        public void SetCommand(CmdAbstract pCmd)
        {
            cmd = pCmd;
        }

        public void Execute()
        {
            cmd.Execute();
        }
    }
}
