using EFC_SQLite_XF.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EFC_SQLite_XF.Services
{
    public sealed class DbService : ISqlite
    {

        public  static  DbService DBInstance { get; private set; } = new DbService();
        private static DatabaseContext _databaseContext;
        static DbService()
        {
            _databaseContext = new DatabaseContext();
        }
        public async Task<bool> AddProductAsync<T>(T Item)
        {
            try
            {
                var tracking = await _databaseContext.AddAsync(Item);
                await _databaseContext.SaveChangesAsync();

                var isAdded = tracking.State == EntityState.Added;

                return isAdded;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public Task<T> GetProductByIdAsync<T>(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<T>> GetProductsAsync<T>()
        {
            try
            {
                var products = await _databaseContext.Products.ToListAsync();
                return null;
               // return products;
            }
            
            catch (Exception e)
            {
                return null;
            }
        }
        public async Task<List<ProductsModel>> GetProductsAsync()
        {
            try
            {
                var products = await _databaseContext.Products.ToListAsync();

                return products;
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public Task<List<T>> QueryProductsAsync<T>(Func<T, bool> predicate)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> RemoveProductAsync<T>(T Item)
        {
            try
            {
                var tracking = _databaseContext.Remove(Item);
                await _databaseContext.SaveChangesAsync();

                var isdeleted = tracking.State == EntityState.Deleted;

                return isdeleted;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public async Task<bool> UpdateProductAsync<T>(T Item)
        {
            try
            {
                var tracking = _databaseContext.Update(Item);
                await _databaseContext.SaveChangesAsync();

                var isModified = tracking.State == EntityState.Modified;

                return isModified;
            }
            catch (Exception)
            {

                return false;
            }
        }
    }
}
