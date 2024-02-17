using Entities;

namespace Business.Abstracts
{
    public interface IInstructorManager
    {
        void Add(Instructor instructor);
        void Delete(int  id);
        List<Instructor> GetAll();
        Instructor GetInstructorById(int id);
    }
}
