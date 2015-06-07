using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.ChainOfResponsibility.AbstractHandler
{
    public abstract class RequestHandler
    {
        public RequestHandler Successor = null;
        public string RequestName = string.Empty;

        public virtual void ProcessRequest(RequestHandler rh)
        {
            throw new NotImplementedException();
        }
    }
}
