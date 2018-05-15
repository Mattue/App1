using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1.Pages
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Registration_Page : ContentPage
	{
		public Registration_Page ()
		{
			InitializeComponent ();

            saveButton.Clicked += (s, e) =>
            {
                App.Current.MainPage = new MainPage();
            };

            clientSityPicker.Items.Add("Омск");
            clientSityPicker.Items.Add("Москва");
            clientSityPicker.Items.Add("Питер");

            clientSityPicker.SelectedIndex = 0;
        }

        private void ReadConditions()
        {
            DisplayAlert("Условия", "Наши условия", "Прочитал");
        }

        private bool IsChecked()
        {
            return agreeCheckBox.IsChecked;
        }

    }
}