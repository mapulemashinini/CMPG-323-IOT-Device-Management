using DeviceManagement_WebApp.Data;
using DeviceManagement_WebApp.Models;
using System.Collections.Generic;
using System.Linq;

namespace DeviceManagement_WebApp.Repository
{
    public class CategoryRepository
    {
        protected readonly ConnectedOfficeContext _context = new ConnectedOfficeContext();

        // GET ALL: Categories
        public IEnumerable<Category> GetAll()
        {
            return (IEnumerable<Category>)_context.Category.ToList();
        }

        // TO DO: Add ‘Get By Id’
        // TO DO: Add ‘Create’
        // TO DO: Add ‘Edit’
        // TO DO: Add ‘Delete’
        // TO DO: Add ‘Exists’

    }
}
