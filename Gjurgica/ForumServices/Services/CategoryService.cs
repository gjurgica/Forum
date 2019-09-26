using AutoMapper;
using ForumDataAccess.Interfaces;
using ForumDomain;
using ForumServices.Interfaces;
using ForumViewModels.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ForumServices.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly IRepository<Category> _categoryService;
        private readonly IMapper _mapper;

        public CategoryService(IRepository<Category> categoryService, IMapper mapper)
        {
            _categoryService = categoryService;
            _mapper = mapper;
        }
        public void CreateCategory(CategoryViewModel category)
        {
            _categoryService.Insert(_mapper.Map<Category>(category));
        }

        public void DeleteCategory(int id)
        {
            _categoryService.Delete(id);
        }

        public IEnumerable<CategoryViewModel> GetAllCategories()
        {
            return _mapper.Map<IEnumerable<CategoryViewModel>>(_categoryService.GetAll());
        }

        public CategoryViewModel GetCategoryById(int id)
        {
            Category thread = _categoryService.GetById(id);

            if (thread == null)
                throw new Exception("Category does't exist.");

            return _mapper.Map<CategoryViewModel>(thread);
        }

        public void UpdateCategory(CategoryViewModel category)
        {
            _categoryService.Update(_mapper.Map<Category>(category));
        }
    }
}
