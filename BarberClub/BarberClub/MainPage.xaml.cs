using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace BarberClub
{
	public partial class MainPage : ContentPage
	{
        
		public MainPage()
		{
			InitializeComponent();

            var assembly = typeof(MainPage);
            mainLogo.Source = ImageSource.FromResource("BarberClub.Assets.Images.logo.png", assembly);
		}
    }

    
}
