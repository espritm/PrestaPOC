using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PrestaPOC
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            btnPresta.Clicked += BtnPresta_Clicked;
        }

        private void BtnPresta_Clicked(object sender, EventArgs e)
        {
            DependencyService.Get<IButtonPresta>()?.GetCartFromID(26);
        }
    }
}
