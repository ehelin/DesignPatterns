using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Patterns.Bridge.Interfaces;

namespace Patterns.Bridge.Implemetations
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
