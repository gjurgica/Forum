using AutoMapper;
using Forum.DataAccess.Interfaces;
using Forum.DomainClasses.Models;
using Forum.Services.Interfaces;
using Forum.WebModels.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Forum.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly IRepository<Category> _categoryRepository;

        private readonly IMapper _mapper;

        public CategoryService(IRepository<Category> threadRepository, IMapper mapper)
        {
            _categoryRepository = threadRepository;
            _mapper = mapper;
        }

        public void CreateCategory(CategoryViewModel category)
        {
            _categoryRepository.Insert(_mapper.Map<Category>(category)); ;
        }

        public void DeleteCategory(string id)
        {
            Category category = _categoryRepository.GetById(id);
            if (category == null)
                throw new Exception("Category does not exist");

            _categoryRepository.Delete(id);
        }

        public IEnumerable<CategoryViewModel> GetAllCategories()
        {
            return _mapper.Map<IEnumerable<CategoryViewModel>>(_categoryRepository.GetAll());
        }

        public CategoryViewModel GetCategoryById(string id)
        {
            Category thread = _categoryRepository.GetById(id);

            if (thread == null)
                throw new Exception("Category does't exist.");

            return _mapper.Map<CategoryViewModel>(thread);
        }

        public void UpdateCategory(CategoryViewModel entity)
        {
            Category thread = _mapper.Map<Category>(_categoryRepository.GetById(entity.Id));

            thread.Title = entity.Title;

            _categoryRepository.Update(thread);
        }
    }
}
