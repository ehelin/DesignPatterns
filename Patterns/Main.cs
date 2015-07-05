using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Patterns.Bridge;
using Patterns.ChainOfResponsibility;
using Patterns.Command;
using Patterns.FactoryMethod;
using Patterns.CQRS;

namespace Patterns
{
    public class Main
    {
        //patterns based on http://www.dofactory.com/ (though I did try to be somewhat original in each example :))
        public void Run()
        {
            RunBridge(); 
            RunChainOfResonsibility();
            RunCommand();
            RunFactoryMethod();
            RunCQRS();
        }

        private void RunBridge()
        {
            Bridge.Bridge b = new Bridge.Bridge();
            b.Run();
        }        
        private void RunChainOfResonsibility()
        {
            ChainOfResponsibility.ChainOfResponsibility cor = new ChainOfResponsibility.ChainOfResponsibility();
            cor.Run();
        }
        private void RunCommand()
        {
            Command.Command c = new Command.Command();
            c.Run();
        }
        private void RunFactoryMethod()
        {
            FactoryMethod.FactoryMethod fm = new FactoryMethod.FactoryMethod();
            fm.Run();
        }
        private void RunCQRS()
        {
            CQRS.CQRS c = new CQRS.CQRS();
            c.Run();
        }
    }
}
