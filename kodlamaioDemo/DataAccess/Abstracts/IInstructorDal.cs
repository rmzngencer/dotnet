using Entities;
namespace DataAccess.Abstracts
{
    public interface IInstructorDal
    {
        void Add(Instructor instructor);
        void Delete(int  id);
        List<Instructor> GetAll();
        Instructor GetInstructorById(int id);
    }
}