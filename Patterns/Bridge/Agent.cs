using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Bridge
{
    public class Agent
    {
        protected IOffice SupportOffice {get;set;}

        public virtual string GiveSupport()
        {
            throw new NotImplementedException();
        }
    }
}
