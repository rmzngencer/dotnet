using DataAccess.Abstracts;
using Entities;
namespace DataAccess.Concretes
{
    public class InstructorDal : IInstructorDal
    {

        List<Instructor> _instructors;
        public InstructorDal(){
            _instructors = new List<Instructor>{
                new Instructor{Id=1,Name="Engin",Surname="Demiroğ",Explanation="Yazılım Geliştirici Yetiştirme Kampı"},
                new Instructor{Id=2,Name="Kerem",Surname="Varış",Explanation="Yazılım Geliştirici Yetiştirme Kampı"},
                new Instructor{Id=3,Name="Berkay",Surname="Bilgin",Explanation="Yazılım Geliştirici Yetiştirme Kampı"},
                new Instructor{Id=4,Name="Murat",Surname="Kurtboğan",Explanation="Yazılım Geliştirici Yetiştirme Kampı"},
                new Instructor{Id=5,Name="Halil",Surname="İbrahim",Explanation="Yazılım Geliştirici Yetiştirme Kampı"}
            };
        }
         public void Add(Instructor instructor)
          {
                _instructors.Add(instructor);
          }
    
          

        public void Delete(int id)
        {
            Instructor instructor = GetInstructorById(id);
            _instructors.Remove(instructor);
        }

        public List<Instructor> GetAll()
          {
                return _instructors;
          }

        public Instructor GetInstructorById(int id)
        {
            try
            {
                return _instructors.Where(i=>i.Id==id).FirstOrDefault();
            }
            catch (System.Exception)
            {
                
                throw new Exception("Girdiğiniz Id ile eşleşen bir Eğitmen bulunmamaktadır.");
            }
        }
    }
}