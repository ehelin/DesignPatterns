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
        //Simply stated, this pattern decouples the requestor from the request implementations. More specifically,
        //there is an abstract class (RequestHandler) that has a reference of the same type of class
        //and a method (ProcessRequest()) that must be implemented by any children.  Then, any children that implement that 
        //method also has a reference the same class type.  When used, this reference is set to the 'successor'
        //child.  If the current instance doesn't know how to handle the request, the class is passed along to 
        //the successor child.
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
