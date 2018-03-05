using System;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms;

namespace Listview
{
	public partial class MainPage : ContentPage
	{
        //private string keyword;
        private List<Product> products = new List<Product>
            {
                new Product
                {
                    ImageProduct="a.jpg",
                    NameProduct="Gucci Hand Bag Light Brown",
                    StatusProduct="Almost New",
                    PriceProduct="3000.00 SAR"

                },
                new Product
                {
                    ImageProduct="a.jpg",
                    NameProduct="Boss Hand",
                    StatusProduct="Almost New",
                    PriceProduct="3000.00 SAR"
                },
                new Product
                {
                    ImageProduct="a.jpg",
                    NameProduct="Clarks Shoes",
                    StatusProduct="Almost New",
                    PriceProduct="3000.00 SAR"
                },
                new Product
                {
                    ImageProduct="a.jpg",
                    NameProduct="Adidas Shoes",
                    StatusProduct="Almost New",
                    PriceProduct="3000.00 SAR"
                },
                new Product
                {
                    ImageProduct="a.jpg",
                    NameProduct="Levis Clothes",
                    StatusProduct="Almost New",
                    PriceProduct="3000.00 SAR"
                },
            };

        public MainPage()
		{
			InitializeComponent();

         

           
            ProductslistView.ItemsSource = products;



        }// end constructor

       /* public async void Product_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var product = e.Item as Product;
            await DisplayAlert("Current product", "Product is:" + product.NameProduct, "Ok");
        }*/

        public void Search(object sender, EventArgs e)
        {
            var keyword = MainSearchBar.Text;
            IEnumerable<Product> searchReasult = products.Where<Product>(product=>product.NameProduct.ToLower().Contains(keyword.ToLower()));
           
            ProductslistView.ItemsSource = searchReasult;
        }
	    public void Close(object sender, EventArgs e)
	    {
	        //DisplayAlert("closed","ok","ok");
	        //Navigation.RemovePage(this);
	    }

    }
}
