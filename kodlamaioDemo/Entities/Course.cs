namespace Entities
{
    public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Explanation { get; set; }
        public double Price { get; set; }

        public int TeacherId { get; set; }

    }
}