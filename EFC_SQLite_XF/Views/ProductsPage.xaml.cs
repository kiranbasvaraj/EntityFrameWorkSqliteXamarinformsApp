using EFC_SQLite_XF.Models;
using EFC_SQLite_XF.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EFC_SQLite_XF.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProductsPage : ContentPage
    {
        public ProductsPage()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            var contx = this.BindingContext as ProductsViewModel;
            await contx.Save(new ProductsModel() { ProductName = e1.Text, ProductDescription = e2.Text });
            await contx.GetItems();
            list.ItemsSource = contx.Items;
        }

        protected async override void OnAppearing()
        {
            var contx = this.BindingContext as ProductsViewModel;
            base.OnAppearing();
            await contx.GetItems();
            list.ItemsSource = contx.Items;
        }

        private async void Button_Clicked_1(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            var x = btn.BindingContext as ProductsModel;
            var contx = this.BindingContext as ProductsViewModel;
            await contx.DeleteItem(x);
            await contx.GetItems();
            list.ItemsSource = contx.Items;

        }
    }
}