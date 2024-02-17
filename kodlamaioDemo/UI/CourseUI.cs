using System;
using System.Linq.Expressions;
using Business.Concretes;
using DataAccess.Concretes;
using Entities;

namespace UI
{
    public class CourseUI
    {
        CourseManager courseManager;
        public CourseUI()
        {
            courseManager = new CourseManager(new CourseDal());
           
        }

        public void AddCourse()
        {
            Random random = new Random();
            Course course = new Course();
            Console.WriteLine("Eklemek istediğiniz kursun ismini giriniz: ");
            course.Name = Console.ReadLine();
            course.Id = random.Next(0, 101);
            Console.WriteLine("Eklemek istediğiniz kursun eğitmeninin id'sini giriniz: ");
            course.TeacherId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Eklemek istediğiniz kursun açıklamasını id'sini giriniz: ");
            course.Explanation = Console.ReadLine();
            Console.WriteLine("Eklemek istediğiniz kursun ücretinbi giriniz: ");
            course.Price = Convert.ToInt32(Console.ReadLine());
            courseManager.Add(course);
            Console.WriteLine("Kurs eklendi.");
        }
        public void DeleteCourse()
        {
            Console.WriteLine("Silmek istediğiniz kursun id'sini giriniz: ");
            int id = Convert.ToInt32(Console.ReadLine());
            courseManager.Delete(id);
            Console.WriteLine("Kurs silindi.");
        }
        public void UpdateCourse()
        {
            Console.WriteLine("Güncellemek istediğiniz kursun id'sini giriniz: ");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Yeni ismi giriniz: ");
            string name = Console.ReadLine();
            Console.WriteLine("Yeni eğitmen id'sini giriniz: ");
            int teacherId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Yeni açıklamayı giriniz: ");
            string explanation = Console.ReadLine();
            Console.WriteLine("Yeni ücreti giriniz: ");
            int price = Convert.ToInt32(Console.ReadLine());
            courseManager.Update(new Course(){Id = id, Name = name, TeacherId = teacherId, Explanation = explanation, Price = price});
            Console.WriteLine("Kurs güncellendi.");
        }
        public void GetAllCourses()
        {
            foreach (var course in courseManager.GetAll())
            {
                Console.WriteLine("Id: " + course.Id + " Name: " + course.Name + " TeacherId: " + course.TeacherId + " Explanation: " + course.Explanation + " Price: " + course.Price);
            }
        }
        public void GetCourseById()
        {
            Console.WriteLine("Bilgilerini görmek istediğiniz kursun id'sini giriniz: ");
            int id = Convert.ToInt32(Console.ReadLine());
            Course course = courseManager.GetCourseById(id);
            Console.WriteLine("Id: " + course.Id + " Name: " + course.Name + " TeacherId: " + course.TeacherId + " Explanation: " + course.Explanation + " Price: " + course.Price);
        }




    }
}
