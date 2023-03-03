using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace GROUP16
{
    public enum Role {
        Driver,
        Roll,
        CEO,
        Cut,
        [Description("Production Manager")] PM,
        [Description("Graphic_Designer")] GD,
        HP
    }
}
