// See https://aka.ms/new-console-template for more information
using Abstract;
using Concrete;
using Entities;

Console.WriteLine("Hello, World!");


BaseCustomerManager customerManager = new NeroCustomerManager();
customerManager.Save(new Customer { DateOfBirth = new DateTime(1985, 1, 6), FirstName = "ali", LastName = "ssrt", NationalityId = "11111111111" });