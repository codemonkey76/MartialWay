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
        partial void ListStudents_Created()
        {
            this.EnableFiltering = false;
            Filtering(this.EnableFiltering);
        }
        partial void EnableFiltering_Changed()
        {
            Filtering(this.EnableFiltering);
        }
        public void Filtering(bool enable)
        {
            if (enable)
            {
                var di = this.FindControl("DisplayInactive");
                di.IsVisible = true;
                var min = this.FindControl("MinAge");
                min.IsVisible = true;
                var max = this.FindControl("MaxAge");
                max.IsVisible = true;
                MinAge = 3;
                MaxAge = 15;
                DisplayInactive = false;
            }
            else
            {
                var di = this.FindControl("DisplayInactive");
                di.IsVisible = false;
                var min = this.FindControl("MinAge");
                min.IsVisible = false;
                var max = this.FindControl("MaxAge");
                max.IsVisible = false;
                DisplayInactive = true;
                MinAge = 0;
                MaxAge = 999;
            }
        }
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
            Student newStudent = this.StudentsWithAge.AddNew();
            this.StudentsWithAge.SelectedItem = newStudent;
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
