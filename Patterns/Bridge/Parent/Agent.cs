using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Patterns.Bridge.Interfaces;

namespace Patterns.Bridge.Parent
{
    public abstract class Agent
    {
        protected IOffice SupportOffice {get;set;}

        public virtual string GiveSupport()
        {
            throw new NotImplementedException();
        }
    }
}
