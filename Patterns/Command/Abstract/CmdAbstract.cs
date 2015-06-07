using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Patterns.Command.Interfaces;

namespace Patterns.Command.Abstract
{
    public class CmdAbstract 
    {
        protected IReceiver r = null;

        public virtual void Execute()
        {
            throw new NotImplementedException();
        }
    }
}
