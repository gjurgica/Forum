using ForumViewModels.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace ForumServices.Interfaces
{
    public interface ICategoryService
    {
        IEnumerable<CategoryViewModel> GetAllCategories();
        CategoryViewModel GetCategoryById(int id);
        void CreateCategory(CategoryViewModel category);
        void DeleteCategory(int id);
        void UpdateCategory(CategoryViewModel category);
    }
}
