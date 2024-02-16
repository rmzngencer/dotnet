
using Entities;
namespace DataAccess.Abstracts
{
    public interface ICategoryDal
    {
        void Add(Category category);
        void Update(Category category);
        void Delete(int id);
        List<Category> GetAll();
        Category GetCategoryById(int id);

    }
}