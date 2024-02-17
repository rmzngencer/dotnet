using System;
using Entities;
using UI;


namespace kodlamaioDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hoşgeldibniz, lLütfen Yapmak istediğiniz işlemi seçin:");
            Console.WriteLine("1- Kategori işlemleri");
            Console.WriteLine("2- Eğitmen işlemleri");
            Console.WriteLine("3- Kurs işlemleri");
            Console.WriteLine("4- Çıkış");
            int switch_on = Convert.ToInt32(Console.ReadLine());
            bool exit=true;

            CategoryUI categoryUI = new CategoryUI();
            InstructorUI instructorUI = new InstructorUI();
            CourseUI courseUI = new CourseUI();
            while (exit)
            {
                
                switch (switch_on)
                {
                    case 1:
                       
                        
                        Console.WriteLine("1- Kategori Ekle");
                        Console.WriteLine("2- Kategori Sil");
                        Console.WriteLine("3- Kategori Güncelle");
                   
                        int switch_on2 = Convert.ToInt32(Console.ReadLine());
                        switch (switch_on2)
                        {
                            case 1:
                                categoryUI.Add();
                                break;
                            case 2:
                                categoryUI.Delete();
                                break;
                            case 3:
                                categoryUI.Update();
                                break;
                            case 4:

                            default:
                                break;
                        }
                        break;
                    case 2:
                       
                        Console.WriteLine("1- Eğitmen Ekle");
                        Console.WriteLine("2- Eğitmen Sil");
                        Console.WriteLine("3- Eğitmen Güncelle");
                        Console.WriteLine("4- Eğitmenleri Listele");
                        Console.WriteLine("5- Eğitmen Bilgilerini Getir");
                        int switch_on3 = Convert.ToInt32(Console.ReadLine());
                        switch (switch_on3)
                        {
                            case 1:
                                instructorUI.AddInstructor();
                                break;
                            case 2:
                                instructorUI.DeleteInstructor();
                                break;
                            case 3:
                                break;
                            case 4:
                                instructorUI.GetAllInstructors();
                                break;
                            case 5:
                                instructorUI.GetInstructorById();
                                break;
                            default:
                                continue;
                        }
                        break;
                    case 3:
                        
                        Console.WriteLine("1- Kurs Ekle");
                        Console.WriteLine("2- Kurs Sil");
                        Console.WriteLine("3- Kurs Güncelle");
                        Console.WriteLine("4- Kursları Listele");
                        Console.WriteLine("5- Kurs Bilgilerini Getir");
                        int switch_on4 = Convert.ToInt32(Console.ReadLine());
                        switch (switch_on4)
                        {
                            case 1:
                                courseUI.AddCourse();
                                break;
                            case 2:
                                courseUI.DeleteCourse();
                                break;
                            case 3:
                                courseUI.UpdateCourse();
                                break;
                            case 4:
                                courseUI.GetAllCourses();
                                break;
                            case 5:
                                courseUI.GetCourseById();
                                break;
                            default:
                                break;
                        }
                        break;
                    case 4:
                        Console.WriteLine("Çıkış yapılıyor...");
                        exit=false;
                        break;
                    default:
                        break;
                }  
            }
            
                           
                

           









        }
    }
}
