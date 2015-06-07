using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Patterns.Bridge.Parent;
using Patterns.Bridge.Interfaces;

namespace Patterns.Bridge.Child
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
