using System.Collections.Generic;
using Entities;


namespace Business.Abstracts
{
    public interface ICategoryManager
    {
       void Add(Category category);
        void Update(Category category, int id, string name);
        void Delete(int id);
        List<Category> GetAll();
        Category GetCategoryById(int id);

    }
}
