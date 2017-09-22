
using Bukimedia.PrestaSharp.Factories;
using PrestaPOC.Droid;
using System.Runtime.CompilerServices;
using Xamarin.Forms;

[assembly: Xamarin.Forms.Dependency(typeof(ButtonPresta))]
namespace PrestaPOC.Droid
{
    public class ButtonPresta : IButtonPresta
    {
        public void GetCartFromID(int iID)
        {
			string sYourPrestashopURL = ""; //sample : @"http://myprestashop.com/api/"
			string sYourPrestashopAPIKey = "";
			string sYourPrestashopAPIPassword = "";
			
            CartFactory cartFactory = new CartFactory(sYourPrestashopURL, sYourPrestashopAPIKey, sYourPrestashopAPIPassword);
            var tmp = cartFactory.Get(iID);
        }
    }
}