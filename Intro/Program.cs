using Intro.Business;
using Intro.DataAccess.Concretes;
using Intro.Entities;

Console.WriteLine("Bu kodun dosyası değiştirilmiştir");

string message1 = "Krediler";
int term = 12;
double amount = 100000;

//variables -->camelCase
bool isAuthenticated = true;
Console.WriteLine(message1);

//condition
if (isAuthenticated)
{
    Console.WriteLine("Buton-->Hoşgeldin Engin");
}
else
{
    Console.WriteLine("Buton-->Sisteme giriş yap");
}

string[] loans = {"Kredi 1","Kredi 2", "Kredi 3", "Kredi 4", "Kredi 5", "Kredi 6" };//dbden gelecek
//string[] loans2 = new string[6];
//loans2[0] = "Kredi 1";

      //start    condition        //increment
for (int i = 0; i < loans.Length; i++)
{
    Console.WriteLine(loans[i]);
}



CourseManager courseManager = new(new EfCourseDal());
List<Course> courses2 = courseManager.GetAll();
for (int i = 0; i < courses2.Count; i++)
{
    Console.WriteLine(courses2[i].Name + " / " + courses2[i].Price);
}


Console.WriteLine("kod bitti");

IndividualCustomer customer1 = new IndividualCustomer();
customer1.Id = 1;
customer1.CustomerNumber = "12345";
customer1.FirstName = "Engin";
customer1.LastName = "Demiroğ";
customer1.NationalIdentity = "1234567890";

IndividualCustomer customer2 = new IndividualCustomer();
customer2.Id = 2;
customer2.CustomerNumber = "54321";
customer2.FirstName = "Derin";
customer2.LastName = "Demiroğ";
customer2.NationalIdentity = "0987654321";

CorporateCustomer customer3 = new CorporateCustomer();
customer3.Id = 3;
customer3.CustomerNumber = "99999";
customer3.Name = "Kodlama.io";
customer3.TaxNumber = "1234567890";

CorporateCustomer customer4 = new CorporateCustomer();
customer4.Id = 4;
customer4.CustomerNumber = "88888";
customer4.Name = "ABC";
customer4.TaxNumber = "1234567895";


// polimorfizm
BaseCustomer[] customers = { customer1, customer2, customer3, customer4 };

foreach (var customer in customers)
{
    Console.WriteLine(customer.CustomerNumber);
}