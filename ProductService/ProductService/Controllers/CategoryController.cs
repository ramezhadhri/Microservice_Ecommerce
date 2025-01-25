using Microsoft.AspNetCore.Mvc;
using ProductService.Services;
using ProductService.Models;

namespace ProductService.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class CategoryController:ControllerBase
    {
        private readonly ICategoryService categoryService;
        public CategoryController(ICategoryService categoryService)
        {
            this.categoryService = categoryService;
        }
        [HttpGet("GetCategories")]
       public IEnumerable<Category> GetCategories()
        {
            return categoryService.CategoryList();
        }
        [HttpGet("GetCategoryID")]
        public Category GetCategoryID(int id) { 
            return categoryService.GetCategoryById(id);
        }
        [HttpGet("GetCategoryName")]
        public IEnumerable<Category> GetCategoryName(string name) { 
            return categoryService.GetCategoryByName(name);
        }
        [HttpPost("PostCategory")]
        public Category PostCategory(Category category) {
            var res=categoryService.AddCategory(category);
            return res;
        }
        [HttpPut("UpdaCategory")]
        public Category PutCategory(Category category) { 
            return categoryService.AddCategory(category);
        }
        [HttpDelete("DeleteCategory")]
        public bool DeleteCategory(int id) { 
            return categoryService.DeleteCategory(id);
        }




    }
}
