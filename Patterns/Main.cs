using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Patterns.Bridge;
using Patterns.ChainOfResponsibility;

namespace Patterns
{
    public class Main
    {
        //patterns based on http://www.dofactory.com/ (though I did try to be somewhat original in each example :))
        public void Run()
        {
            RunBridge(); 
            RunChainOfResonsibility();
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
    }
}
