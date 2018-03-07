using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Listview
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Detail : ContentPage
	{
		public Detail (Product product)
		{
			InitializeComponent ();

		    Name.Text = product.NameProduct;
		}

	   public async void Close(object sender, EventArgs e)
	    {
            //DisplayAlert("closed","ok","ok");
            //Navigation.RemovePage(this);
	       // await Navigation.PopAsync();
            await Navigation.PopModalAsync();
	    }
    }
}