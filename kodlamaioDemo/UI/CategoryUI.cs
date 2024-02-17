using Business.Concretes;
using DataAccess.Conceretes;
using Entities;

namespace UI
{
    public class CategoryUI
    {
        CategoryManager categoryManager ;    
        public CategoryUI()
        {
            categoryManager = new CategoryManager(new CategoryDal());    
            
        }

        public void Add()
        {
            Random random = new Random();
            Category category = new Category();
            Console.WriteLine("Lütfen bir metin girin:");
            category.Name = Console.ReadLine();
            category.Id = random.Next(0, 101);
            categoryManager.Add(category);
            Console.WriteLine("Kategori eklendi.");
        }

        public void Delete()
        {
            Console.WriteLine("Silmek istediğiniz kategorinin id'sini girin:");
            int id = Convert.ToInt32(Console.ReadLine());
            categoryManager.Delete(id);
            Console.WriteLine("Kategori silindi.");
        }
        public void Update()
        {
            Console.WriteLine("Güncellemek istediğiniz kategorinin id'sini girin:");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Yeni ismi girin:");
            string name = Console.ReadLine();
            categoryManager.Update(new Category(), id, name);
            Console.WriteLine("Kategori güncellendi.");
        }

        public void GetAll()
        {
            foreach (var category in categoryManager.GetAll())
            {
                Console.WriteLine("Id: " + category.Id + " Name: " + category.Name);
            }
        }

        public void GetCategoryById()
        {
            Console.WriteLine("Bilgilerini görmek istediğiniz kategorinin id'sini girin:");
            int id = Convert.ToInt32(Console.ReadLine());
            Category category = categoryManager.GetCategoryById(id);
            Console.WriteLine("Id: " + category.Id + " Name: " + category.Name);
        }

        
    }
}
