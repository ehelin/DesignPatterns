using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Patterns.ChainOfResponsibility.AbstractHandler;

namespace Patterns.ChainOfResponsibility.RequestHandlers
{
    public class RequestTwo : RequestHandler
    {        
        public RequestTwo(string requestName)
        {
            RequestName = requestName;
        }
        public override void ProcessRequest(RequestHandler rh)
        {
            if (rh.RequestName.Equals(this.RequestName))
                Console.WriteLine("Processing " + RequestName);
            else
            {
                Console.WriteLine("In " + RequestName);
                Console.WriteLine("Request name: " + rh.RequestName);
                Successor.ProcessRequest(rh);
            }
        }
    }
}
