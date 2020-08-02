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
        public SecondApp()
        {
            InitializeComponent();

            switch (Device.RuntimePlatform)
            {
                case Device.iOS:
                    Padding = new Thickness(0, 20, 0, 0);
                    break;
            }

            Months.ItemsSource = new List<int>()
            {
               1, 2, 3, 4,5,6,7,8,9,10,11,12
            };
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            double loanAmount = 0;
            double loanRate = 0;
            var amount = Amount.Text;
            var rate = LoanRate.Text;

            var months = (Picker)Months;
            int selectedIndexMonths = months.SelectedIndex;

            if (selectedIndexMonths < 0
                || !Double.TryParse(amount, out loanAmount)
                || !Double.TryParse(rate, out loanRate))
            {
                DisplayAlert("Error", "Some values are empty", "OK");
                return;
            }

            var monthsNumber = (int)months.ItemsSource[selectedIndexMonths];
            double t = loanRate / 1200;
            double b = Math.Pow((1 + t), monthsNumber);
            var montlyAmount = t * loanAmount * b / (b - 1);
            loanMontlyAmount.Text = montlyAmount.ToString("C2");
        }
    }
}