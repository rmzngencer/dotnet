using DataAccess.Abstracts;
using Entities;

namespace DataAccess.Concretes
{
    public class CourseDal : ICourseDal
    {

        List<Course> Courses;

        public CourseDal()
        {
            Courses = new List<Course>
            {
                new Course
                {
                    Id = 1,
                    Name = "C#",
                    Explanation = "C# is a programming language",
                    Price = 0,
                    TeacherId = 1
                },
                new Course
                {
                    Id = 2,
                    Name = "Java",
                    Explanation = "Java is a programming language",
                    Price = 0,
                    TeacherId = 2
                },
                new Course
                {
                    Id = 3,
                    Name = "Python",
                    Explanation = "Python is a programming language",
                    Price = 0,
                    TeacherId = 3
                }
            };
        }
        
        public void Add(Course course)
        {
            Courses.Add(course);
        }

        

        public void Delete(int id)
        {
            Course course = GetCourseById(id);
            Courses.Remove(course);
        }
        public Course GetCourseById(int id)
        {
            try
            {
                return Courses.Where(c=>c.Id==id).FirstOrDefault();
            }
            catch (System.Exception)
            {
                
                throw new Exception("Girdiğiniz Id ile eşleşen bir kurs bulunmamaktadır.");
            }
        }

        public List<Course> GetAll()
        {
            return Courses;
        }

        public void Update(Course course)
        {
            Course course1 = GetCourseById(course.Id);
            course1.Name = course.Name;
            course1.Explanation = course.Explanation;
            course1.Price = course.Price;
            
        }
    }

    
}