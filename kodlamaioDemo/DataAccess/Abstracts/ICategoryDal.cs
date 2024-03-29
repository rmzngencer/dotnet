
using Entities;
namespace DataAccess.Abstracts
{
    public interface ICategoryDal
    {
        void Add(Category category);
        void Update(Category category, int id, string name);
        void Delete(int id);
        List<Category> GetAll();
        Category GetCategoryById(int id);
        
    }
}