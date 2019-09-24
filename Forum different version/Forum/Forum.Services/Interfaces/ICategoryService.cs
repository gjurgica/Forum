using Forum.WebModels.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Forum.Services.Interfaces
{
    public interface ICategoryService
    {
        IEnumerable<CategoryViewModel> GetAllCategories();
        CategoryViewModel GetCategoryById(string id);
        void CreateCategory(CategoryViewModel category);
        void DeleteCategory(string id);
        void UpdateCategory(CategoryViewModel category);
    }
}
