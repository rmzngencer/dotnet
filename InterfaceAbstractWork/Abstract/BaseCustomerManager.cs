using Abstract;
using Entities;
namespace Abstract
{
   public abstract class BaseCustomerManager : ICustomerService
{
    public virtual void Save(Customer customer)
    {
        Console.WriteLine("Saved to db : " + customer.FirstName);
    }
}

}