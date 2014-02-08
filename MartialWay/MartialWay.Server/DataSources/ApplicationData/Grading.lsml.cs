using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.LightSwitch;
namespace LightSwitchApplication
{
    public partial class Grading
    {
        partial void Summary_Compute(ref string result)
        {
            result = "";
            if (this.EventDate!=null)
                result += this.EventDate.ToShortDateString() + " ";
            if (this.Description != null)
                result += this.Description + " ";
            if (this.Location !=null)
                result += this.Location;
            result = result.Trim();
        }
    }
}
