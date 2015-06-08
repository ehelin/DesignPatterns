using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Patterns.ChainOfResponsibility.AbstractHandler;
using Patterns.ChainOfResponsibility.RequestHandlers;

namespace Patterns.ChainOfResponsibility
{
    public class ChainOfResponsibility
    {
        //This pattern has an abstact request class that has a reference of the same type.  This reference is a 
        //successor.  In the implementation, concrete implementations of the abstract class are created.  Each 
        //one has the successor property set.  Then, if a this specific implementation can't handle the request,
        //it is past to the successor where hopefully it can be executed.
        public void Run()
        {
            Console.WriteLine("Starting Chain Of Responsibility Example");

            RunChainOfResponsibilityExample();

            Console.WriteLine("List Chain Of Responsibility Completed!");
        }

        private void RunChainOfResponsibilityExample()
        {
            RequestHandler rh1 = new RequestOne("Request 1");
            RequestHandler rh2 = new RequestTwo("Request 2");
            RequestHandler rh3 = new RequestThree("Request 3");
            RequestHandler rh4 = new RequestFour("Request 4");
       
            rh1.Successor = rh2;
            rh2.Successor = rh3;
            rh3.Successor = rh4;
            rh4.Successor = null;
            
            rh1.ProcessRequest(rh4);
            rh1.ProcessRequest(rh3);
            rh1.ProcessRequest(rh2);

            try
            {
                rh2.ProcessRequest(rh1);
                Console.WriteLine("Error: Successors shouldn't 'know' about pre-successors");
            }
            catch(Exception e)
            {
                Console.WriteLine("Worked: Successors shouldn't 'know' about pre-successors");
            }
        }
    }
}
