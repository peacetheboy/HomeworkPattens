using HomeworkPrac.Controllers;
using HomeworkPrac.Data;
using HomeworkPrac.Migrations;
using HomeworkPrac.Models;

namespace HomeworkPrac.Reopository
{
    public class ProductRepository
    {
        protected readonly practicedbContext _context = new practicedbContext();

        // GET ALL: Products
        public IEnumerable<Product> GetAll()
        {
            return _context.Products.ToList();
        }

        // TO DO: Add ‘Get By Id’
        // TO DO: Add ‘Create’
        // TO DO: Add ‘Edit’
        // TO DO: Add ‘Delete’
        // TO DO: Add ‘Exists’
    }

}
