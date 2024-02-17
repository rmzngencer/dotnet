using Business.Concretes;
using DataAccess.Concretes;
using Entities;

namespace UI
{
    public class InstructorUI
    {
        InstructorManager instructorManager ;    
        public InstructorUI()
        {
            instructorManager = new InstructorManager(new InstructorDal()); 
            
        }

        public void AddInstructor()
        {
            Instructor instructor = new Instructor();
            Random random = new Random();
            instructor.Id = random.Next(1, 100);
            Console.WriteLine("Lütfen Eklemek  istediğiniz Eğitmen isim girin:");   
            instructor.Name = Console.ReadLine();
            Console.WriteLine("Lütfen Eklemek  istediğiniz Eğitmen soyisim girin:");
            instructor.Surname = Console.ReadLine();
            Console.WriteLine("Lütfen Eklemek  istediğiniz Eğitmen Açıklaması girin:");
            instructor.Explanation = Console.ReadLine();


            instructorManager.Add(instructor);
            Console.WriteLine("Eğitmen eklendi.");
        }

        public void DeleteInstructor()
        {
            Console.WriteLine("Silmek istediğiniz eğitmenin id'sini girin:");
            int id = Convert.ToInt32(Console.ReadLine());
            instructorManager.Delete(id);
            Console.WriteLine("Eğitmen silindi.");
        }
        public void GetAllInstructors()
        {
            foreach (var instructor in instructorManager.GetAll())
            {
                Console.WriteLine("Id: " + instructor.Id + " Name: " + instructor.Name + " Surname: " + instructor.Surname + " Explanation: " + instructor.Explanation);
            }
        }
        public void GetInstructorById()
        {
            Console.WriteLine("Bilgilerini görmek istediğiniz eğitmenin id'sini girin:");
            int id = Convert.ToInt32(Console.ReadLine());
            Instructor instructor = instructorManager.GetInstructorById(id);
            Console.WriteLine("Id: " + instructor.Id + " Name: " + instructor.Name + " Surname: " + instructor.Surname + " Explanation: " + instructor.Explanation);
        }

    }
}
