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
	public partial class Sign_On_Page : ContentPage
	{
		public Sign_On_Page ()
		{
			InitializeComponent ();

            registrationButton.Clicked += (s, e) =>
            {
                Navigation.PushAsync(new Pages.Registration_Page());
            };
        }
	}
}