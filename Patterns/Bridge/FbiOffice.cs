using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Bridge
{
    public class FbiOffice : IOffice
    {
        public string GiveSupport()
        {
            string support = "Help from FBI office";

            return support;
        }
    }
}
