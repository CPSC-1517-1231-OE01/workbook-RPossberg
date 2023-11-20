using WestWindSystem.DAL;
using WestWindSystem.Entities;

namespace WestWindSystem.BLL
{
    public class SupplierServices
    {

        private readonly WestWindContext _context;
        //* internal = only accessible within the assembly

        /// <summary>
        /// Constructor to create an instance with the registered context.
        /// The internal keyword prevents access to the constructor from outside the assembly.
        /// This prevents external projects/assemblies from creating a new services object directly.
        /// </summary>
        /// <param name="context">The required WestWindContex</param>
        internal SupplierServices(WestWindContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Returns a list of all suppliers in the system
        /// </summary>
        /// <returns>The list of all suppliers in the system</returns>
        public List<Supplier>? GetAllSuppliers()
        {
            return _context.Suppliers.ToList<Supplier>();
        }
    }
}
