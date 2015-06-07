using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Bridge
{
    public class CiaOffice : IOffice
    {
        public string GiveSupport()
        {
            string support = "Help from CIA office";

            return support;
        }
    }
}
