using ProductService.Data;
using ProductService.Models;

namespace ProductService.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly DbContextClass _dbContext;
        public CategoryService (DbContextClass dbContext) {
            _dbContext = dbContext;
        }

        public IEnumerable<Category> CategoryList() 
        {
            return _dbContext.Categories.ToList(); 
        }
        public Category GetCategoryById(int id) {
            return _dbContext.Categories.Where(x => x.CategoryId == id).FirstOrDefault();
        }
        public IEnumerable<Category> GetCategoryByName(string name)
        {
            return _dbContext.Categories.Where(x => x.CategoryName == name).ToList();
        }

        public Category AddCategory(Category category) { 
            var res=_dbContext.Categories.Add(category);
            _dbContext.SaveChanges();
            return res.Entity;
        }
        public Category UpdateCategory(Category category) {
            var res = _dbContext.Categories.Update(category);
            _dbContext.SaveChanges();
            return res.Entity;
        }
        public bool DeleteCategory(int id) {
            var res=_dbContext.Categories.Where(x => x.CategoryId == id).FirstOrDefault();
            _dbContext.Remove(res);
            _dbContext.SaveChanges();
            return res != null?true:false;
        }
        
           

}
}
