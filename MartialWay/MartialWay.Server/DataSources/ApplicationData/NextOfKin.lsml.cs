using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.LightSwitch;
namespace LightSwitchApplication
{
    public partial class NextOfKin
    {
        partial void FullName_Compute(ref string result)
        {
            result = this.LastName + ", " + this.FirstName;
        }
    }
}
