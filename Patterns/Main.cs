using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Patterns.Bridge;

namespace Patterns
{
    public class Main
    {
        public void Run()
        {
            RunBridge(); 
        }

        private void RunBridge()
        {
            Bridge.Bridge b = new Bridge.Bridge();
            b.Run();
        }
    }
}
