using ProductService.Models;

namespace ProductService.Services
{
    public interface ICategoryService

    {
        public IEnumerable<Category> CategoryList();
        public Category GetCategoryById(int id);
        public IEnumerable<Category> GetCategoryByName(string name);
        public Category AddCategory(Category category);
        public Category UpdateCategory(Category category);
        public bool DeleteCategory(int id);



    }
}
