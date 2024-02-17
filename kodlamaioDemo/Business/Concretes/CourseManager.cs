using Business.Abstracts;
using DataAccess.Abstracts;
using Entities;

namespace Business.Concretes
{
    public class CourseManager : ICourseManager
    {

        private readonly ICourseDal _courseDal;
        public CourseManager(ICourseDal courseDal)
        {
            _courseDal = courseDal;
        }

        // Add your code here
        public void Add(Course course)
        {
            _courseDal.Add(course);
        }

        public void Delete(int id)
        {
            _courseDal.Delete(id);
        }

        public List<Course> GetAll()
        {
            return _courseDal.GetAll();
        }

        public Course GetCourseById(int id)
        {
            return _courseDal.GetCourseById(id);
        }

        public void Update(Course course)
        {
            _courseDal.Update(course);
        }
    }

    
}
