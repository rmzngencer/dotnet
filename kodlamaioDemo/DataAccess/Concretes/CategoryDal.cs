using DataAccess.Abstracts;
using Entities;

namespace DataAccess.Conceretes;

public class CategoryDal : ICategoryDal

{
    List<Category> categories;

    public CategoryDal()
    {
        this.categories=new List<Category>(){
            //mevcut databasten gelen verileri simule ediyorum burada
            new Category() {Id=1,Name="Programlama"},
            new Category() {Id=2,Name="Grişim"},
            new Category() {Id=3,Name="Ekonomi"},
            new Category() {Id=4,Name="Matematik"}
        };
      
    }

    public void Add(Category category)
    {
        categories.Add(category);
    }

    public void Delete(int id)
    {
        Console.WriteLine("Delete methodu çalıştı");
        Category category = GetCategoryById(id);
        categories.Remove(category);
       
    }

    public List<Category> GetAll()
    {
       
        return categories;
    }

    public Category GetCategoryById(int id)
    {
        try
        {
            return categories.Where(c=>c.Id==id).FirstOrDefault();
        }
        catch (System.Exception)
        {
            
            throw new Exception("Girdiğiniz Id ile eşleşen bir Kategori bulunmamaktadır.");
        };
    }

    public void Update(Category category, int id, string name)
    {
        
        Delete(category.Id);
        Category newCategoru = new Category(){Id=id,Name=name};
        Add(newCategoru);
        
    }

   
}