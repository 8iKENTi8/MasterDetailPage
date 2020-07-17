using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MasterDetail
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : MasterDetailPage
    {
        public MainPage()
        {
            InitializeComponent();

            Detail = new NavigationPage(new News()) { 
                BarBackgroundColor = Color.YellowGreen
               
            };

            IsPresented = true;

        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new News())
            {
                BarBackgroundColor = Color.YellowGreen

            };

            IsPresented = false;
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new Friends())
            {
                BarBackgroundColor = Color.FromHex("#00897b")
            };

            IsPresented = false;
        }
    }
}
