using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace GROUP16
{
    public enum EventCategory
    {
        [Description("Business meeting")] BM,
        [Description("Private meeting")] PM,
        [Description("Social events")] SE
    }
}
