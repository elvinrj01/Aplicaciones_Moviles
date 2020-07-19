using Project.App.Data;
using Project.Infrastructure.Utils;
using Project.Model.ViewModels.Controls.Inputs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace name_app.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SecondApp : ContentPage
    {
        public PersonalInformationInputDTO Model { get; set; } = new PersonalInformationInputDTO();
        private Page _page;
        public SecondApp(Page page)
        {
            InitializeComponent();

            switch (Device.RuntimePlatform)
            {
                case Device.iOS:
                    Padding = new Thickness(0, 20, 0, 0);
                    break;
            }

            MaritalStatus.ItemsSource = new List<string>()
            {
                "Single",
                "Married",
                "Widowed",
                "Separated",
                "Divorced"
            }; 

            Mayor.ItemsSource = new List<string>()
            {
                "Software Engineer",
                "Teacher",
                "Doctor",
                "Nurse"
            };
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            // if (!ValidationHelper.IsFormValid(Model, _page)) { return; }

            var year = 0;
            var name = Name.Text;
            var lastName = LastName.Text;
            var birthPlace = BithPlace.Text;

            var maritalStatus = (Picker)MaritalStatus;
            var career = (Picker)Mayor;
            int selectedIndexMaritalStatus = maritalStatus.SelectedIndex;
            int selectedIndexCareer = career.SelectedIndex;

            if (!int.TryParse(BirthYear.Text, out year)
                || selectedIndexMaritalStatus <0
                || selectedIndexCareer<0
                || string.IsNullOrWhiteSpace(name)
                || string.IsNullOrWhiteSpace(lastName)
                || string.IsNullOrWhiteSpace(birthPlace))
            {
                DisplayAlert("Error", "Some values are empty", "OK");
                return;
            }

            var years = DateTime.Now.Year - year;

            if(years >100)
            {
                DisplayAlert("Error", "Invalid birth year", "OK");
                return;
            }

            var message = $"Hi! Mi name is {name} {lastName}, " +
                $"I'm {years} years old, I was born in {birthPlace}, " +
                $"currently I am {(string)maritalStatus.ItemsSource[selectedIndexMaritalStatus]} and I have " +
                $"a mayor in {(string)career.ItemsSource[selectedIndexCareer]}.";

            DisplayAlert("Personal Information", message, "OK");
        }
    }
}