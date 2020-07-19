using Project.Model.ViewModels.Controls.Outputs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.App.Data
{
    public static class StaticData
    {
        public static List<string> Careers()
        {
            return new List<string>()
            {
                "Software Engineer",
                "Teacher",
                "Doctor",
                "Nurse"
            };
        }

        public static List<string> MaritalStatus()
        {
            return new List<string>()
            {
                "Single",
                "Married",
                "Widowed",
                "Separated",
                "Divorced"
            };
        }
    }
}
