using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.LightSwitch;
using Microsoft.LightSwitch.Security.Server;
namespace LightSwitchApplication
{
    public partial class ApplicationDataService
    {
        partial void StudentsWithAge_PreprocessQuery(short? MinAge, short? MaxAge, bool? DisplayInactive, ref IQueryable<Student> query)
        {
            query = query.Where(
                item => 
                    (short)DateTime.Now.Year-item.DateOfBirth.Value.Year>=MinAge &&
                    (short)DateTime.Now.Year-item.DateOfBirth.Value.Year<=MaxAge &&
                    ((item.Active==true)||(DisplayInactive!=item.Active)));
        }
    }
}
