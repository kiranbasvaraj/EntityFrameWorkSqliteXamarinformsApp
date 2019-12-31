using EFC_SQLite_XF.Models;
using EFC_SQLite_XF.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace EFC_SQLite_XF.ViewModels
{
    public class ProductsViewModel
    {

        private ObservableCollection<ProductsModel> _items;

        public ObservableCollection<ProductsModel> Items
        {
            get { return _items; }
            set { _items = value; }
        }



        public ProductsViewModel()
        {
        }

        public async Task GetItems()
        {
            Items =new ObservableCollection<ProductsModel>( await DbService.DBInstance.GetProductsAsync());
        }

        public async Task Save(ProductsModel item)
        {
            var res = await DbService.DBInstance.AddProductAsync<ProductsModel>(item);
        }
        public async Task DeleteItem(ProductsModel item)
        {
            var res = await DbService.DBInstance.RemoveProductAsync<ProductsModel>(item);
        }
    }
}
