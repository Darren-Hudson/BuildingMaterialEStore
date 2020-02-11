using System.Collections.Generic;
using BmesRestApi.Database;
using BmesRestApi.Models.Product;

namespace BmesRestApi.Repositories.Implementations
{
    public class CategoryRepository : ICategoryRepository
    {
        public BmesDbContext _context;
        public CategoryRepository(BmesDbContext context)
        {
            _context = context;
        }
        public Category FindCategoryById(long id)
        {
            var category = _context.Category.Find(id);
            return category;
        }
        public IEnumerable<Category> GetAllCategories()
        {
            var categories = _context.Category;
            return categories;
        }
        public void SaveCategory(Category category)
        {
            _context.Category.Add(category);
            _context.SaveChanges();
        }
        public void UpdateCategory(Category category)
        {
            _context.Category.Update(category);
            _context.SaveChanges();
        }
        public void DeleteCategory(Category category)
        {
            _context.Category.Remove(category);
            _context.SaveChanges();
        }
    }
}
