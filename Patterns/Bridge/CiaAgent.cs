using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Bridge
{
    public class CiaAgent : Agent
    {
        public CiaAgent(IOffice off)
        {
            this.SupportOffice = off;
        }

        public override string GiveSupport()
        {
            return this.SupportOffice.GiveSupport();
        }
    }
}
