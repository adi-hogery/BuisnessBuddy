using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;


namespace GROUP16
{
    public enum Status {
        [Description("New Order")] NO,
        Graphic,
        HP,
        Cut,
        Roll,
        Delivery,
        Completed,
        Canceled,
        Waiting,
        Manager
    }
    
   
}
