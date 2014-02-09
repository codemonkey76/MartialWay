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
    public partial class MaintainStudentsGrading
    {
        partial void AddAllActiveStudents_Execute()
        {
            foreach (Student s in ActiveStudents)
            {
                StudentGrading sg = StudentGradings.AddNew();
                sg.Grading = this.Gradings.SelectedItem;
                sg.Student = s;
                sg.GradingDecision = 0;
                sg.InvitationGiven = false;
                //sg.RankToGradeFor = GetNextRank();
                
            }
            
        }
        
    }
}
