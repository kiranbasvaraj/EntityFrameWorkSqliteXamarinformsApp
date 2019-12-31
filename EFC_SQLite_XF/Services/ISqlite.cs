using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EFC_SQLite_XF.Services
{
    public interface ISqlite
    {
        Task<List<T>> GetProductsAsync<T>();

        Task<T> GetProductByIdAsync<T>(int id);

        Task<bool> AddProductAsync<T>(T Item);

        Task<bool> UpdateProductAsync<T>(T Item);

        Task<bool> RemoveProductAsync<T>(T Item);

        Task<List<T>> QueryProductsAsync<T>(Func<T, bool> predicate);
    }
}
