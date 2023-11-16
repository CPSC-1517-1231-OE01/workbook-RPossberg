using Microsoft.EntityFrameworkCore;
using WestWindSystem.DAL;
using WestWindSystem.Entities;

namespace WestWindSystem.BLL
{
    public class ProductServices
    {
        private readonly WestWindContext _context;

        internal ProductServices(WestWindContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Returns products that match the product name or supplier name, if any.
        /// </summary>
        ///  <param name="id> The category id</param>
        /// <returns>A list of products, if any were found</returns>
        public List<Product>? GetProductsByCategoryId(int id)
        {
            return _context.Products
                .Where(p => p.CategoryId == id)
                .Include(p => p.Supplier)
                .ToList<Product>();
        }

        /// <summary>
        /// Returns products that partially match the product name or supplier name, if any.
        /// </summary>
        /// <param name="partial">The partial string to search for</param>
        /// <returns>A list of products, if any were found</returns>
        public List<Product>? GetProductsByNameOrSupplierName(string partial)
        {
            partial = partial.ToLower();
            return _context.Products
                .Where(p => p.ProductName.ToLower().Contains(partial) || p.Supplier.CompanyName.ToLower().Contains(partial))
                .Include(p => p.Supplier)
                .ToList<Product>();
        }

    }

}
