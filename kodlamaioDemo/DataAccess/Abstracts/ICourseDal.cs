
using Entities;

namespace DataAccess.Abstracts
{
    public interface ICourseDal
    {
        void Add(Course course);
        void Update(Course course);
        void Delete(int id );
        List<Course> GetAll();
        Course GetCourseById(int id);

    }
}