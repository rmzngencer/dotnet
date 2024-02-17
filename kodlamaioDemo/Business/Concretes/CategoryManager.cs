using Business.Abstracts;
using DataAccess.Abstracts;
using Entities;

// ...

namespace Business.Concretes
{
    public class CategoryManager : ICategoryManager
    {

        private readonly ICategoryDal _categoryDal;
        public CategoryManager(ICategoryDal categoryDal)
        {
        _categoryDal = categoryDal;
        }
        // Implement the methods from IcategoryManager interface here
        public void Add(Category category)
        {
            _categoryDal.Add(category);
        }

        public void Delete(int id)
        {
           
            _categoryDal.Delete(id);
        }

        public List<Category> GetAll()
        {
            return _categoryDal.GetAll();
        }

        public Category GetCategoryById(int id)
        {
            return _categoryDal.GetCategoryById(id);
        }

        public void Update(Category category, int id, string name)
        {
            _categoryDal.Update(category, id, name);
        }
        
            
    }
}
