using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.LightSwitch;
namespace LightSwitchApplication
{
    public partial class Student
    {
        partial void FullName_Compute(ref string result)
        {
            result = this.LastName + ", " + this.FirstName;
        }

        partial void AddressSummary_Compute(ref string result)
        {
            result = ((this.AddressLine1==null)?"":this.AddressLine1) + 
                ((this.Suburb==null)?"":" " + this.Suburb.ToUpper() + ", ") + 
                ((this.State==null)?"":this.State + " ") + 
                ((this.Postcode==null)?"":this.Postcode);
        }

        partial void Age_Compute(ref short result)
        {
            if (this.DateOfBirth == null)
                result = 0;
            else
            {
                DateTime dob = (DateTime)this.DateOfBirth;
                result = (short)(DateTime.Now.Year - dob.Year);
            }
        }
    }
}
