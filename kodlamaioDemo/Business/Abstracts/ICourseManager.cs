using Entities;

namespace Business.Abstracts
{
    public interface ICourseManager
    {
        void Add(Course course);
        void Update(Course course);
        void Delete(int id );
        List<Course> GetAll();
        Course GetCourseById(int id);
    }
}
