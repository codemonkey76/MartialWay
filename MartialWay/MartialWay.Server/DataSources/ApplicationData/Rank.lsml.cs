using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.LightSwitch;
namespace LightSwitchApplication
{
    public partial class Rank
    {
        partial void BeltName_Compute(ref string result)
        {
            result = this.Belt + " Belt";
            if (this.Stripes != null)
                if (this.Stripes.Length > 0)
                    result += " - (" + this.Stripes + ")";
        }

        partial void MinimumTime_Compute(ref string result)
        {
            if (this.MinTimeInBelt < 12)
                result = this.MinTimeInBelt.ToString() + " months";
            else
            {
                result = (this.MinTimeInBelt / 12).ToString() + " years";
                if (this.MinTimeInBelt % 12 != 0)
                    result += " " + (this.MinTimeInBelt % 12).ToString() + " months";
            }
        }
    }
}
