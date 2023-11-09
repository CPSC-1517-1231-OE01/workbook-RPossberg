using WestWindSystem.DAL;
using WestWindSystem.ENTITIES;

namespace WestWindSystem.BLL
{
    public class CategoryServices
    {
        private readonly WestWindContext _context;

        internal CategoryServices(WestWindContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Returns all categories in the system
        /// </summary>
        /// <returns>A list of categories, if any were found</returns>
        public List<Category>? GetCategories()
        {
            return _context.Categories.ToList<Category>();
        }
    }
}
