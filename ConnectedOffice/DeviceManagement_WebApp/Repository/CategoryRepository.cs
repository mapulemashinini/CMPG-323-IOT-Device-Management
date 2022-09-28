using DeviceManagement_WebApp.Models;
using DeviceManagement_WebApp.Data;
using System.Linq;

namespace DeviceManagement_WebApp.Repository
{
    public class CategoryRepository : GenericRepository<Category>, ICategoryRepository
    {
        public CategoryRepository(ConnectedOfficeContext context) : base(context)
        {
        }

        public Category GetMostRecentCategory()
        {
            return _context.Category.OrderByDescending(service => service.CreatedDate).FirstOrDefault();
        }
    }

}
