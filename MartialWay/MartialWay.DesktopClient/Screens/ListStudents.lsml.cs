using System;
using System.Linq;
using System.IO;
using System.IO.IsolatedStorage;
using System.Collections.Generic;
using Microsoft.LightSwitch;
using Microsoft.LightSwitch.Framework.Client;
using Microsoft.LightSwitch.Presentation;
using Microsoft.LightSwitch.Presentation.Extensions;
namespace LightSwitchApplication
{
    public partial class ListStudents
    {
        partial void NewNextOfKin_Execute()
        {
            this.Application.ShowMaintainNextOfKins();
        }

        partial void gridAddAndEditNew_CanExecute(ref bool result)
        {
            // Write your code here.

        }

        partial void gridAddAndEditNew_Execute()
        {
            Student newStudent = this.Students.AddNew();
            this.Students.SelectedItem = newStudent;
            this.OpenModalWindow("StudentEditDialog");
        }

        partial void gridEditSelected_CanExecute(ref bool result)
        {
            // Write your code here.

        }

        partial void gridEditSelected_Execute()
        {
            this.OpenModalWindow("StudentEditDialog");
        }
    }
}
