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
	public partial class Login_Page : ContentPage
	{
		public Login_Page ()
		{
			InitializeComponent ();

            singInButton.Clicked += (s, e) =>
            {
                Navigation.PushAsync(new Pages.Sign_On_Page());
            };

            loginButton.Clicked += (s, e) =>
            {
                App.Current.MainPage = new MainPage();
            };
        }
	}
}