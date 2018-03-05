using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Listview
{
	public partial class MainPage : ContentPage
	{
        private string keyword;
        private List<Product> products = new List<Product>
            {
                new Product
                {
                    Img="a.jpg",
                    Name="Gucci Hand Bag Light Brown",
                    Status="Almost New",
                    Price="3000.00 SAR"

                },
                new Product
                {
                    Img="a.jpg",
                    Name="Boss Hand",
                    Status="Almost New",
                    Price="3000.00 SAR"
                },
                new Product
                {
                    Img="a.jpg",
                    Name="Clarks Shoes",
                    Status="Almost New",
                    Price="3000.00 SAR"
                },
                new Product
                {
                    Img="a.jpg",
                    Name="Adidas Shoes",
                    Status="Almost New",
                    Price="3000.00 SAR"
                },
                new Product
                {
                    Img="a.jpg",
                    Name="Levis Clothes",
                    Status="Almost New",
                    Price="3000.00 SAR"
                },
            };

        public MainPage()
		{
			InitializeComponent();

         

           
            ProductslistView.ItemsSource = products;



        }// end constructor

        public async void Product_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var product = e.Item as Product;
            await DisplayAlert("Current product", "Product is:" + product.Name, "Ok");
        }

        public void Search(object sender, EventArgs e)
        {
            keyword = MainSearchBar.Text;
            IEnumerable<Product> searchReasult = products.Where<Product>(product=>product.Name.ToLower().Contains(keyword.ToLower()));
           
            ProductslistView.ItemsSource = searchReasult;
        }
    }
}
