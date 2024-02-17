using Business.Abstracts;
using DataAccess.Abstracts;
using Entities;

namespace Business.Concretes
{
    public class InstructorManager : IInstructorManager
    {
        // Class members and methods go here
        private readonly IInstructorDal _instructorDal;
        public InstructorManager(IInstructorDal instructorDal)
        {
            _instructorDal = instructorDal;
        }
        public void Add(Instructor instructor)
        {
            _instructorDal.Add(instructor);
        }

        public void Delete(int id)
        {
            _instructorDal.Delete(id);
        }

        public List<Instructor> GetAll()
        {
            return _instructorDal.GetAll();
        }

        public Instructor GetInstructorById(int id)
        {
            return _instructorDal.GetInstructorById(id);
        }
    }
}
