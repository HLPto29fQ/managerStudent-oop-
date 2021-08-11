using System;
using System.Collections.Generic;
using ManagerSchool;
namespace OPP
{  
   class Program
    {
        static void Main(string[] args)
        {   
            Student student= new Student();
            ClassManager classManager= new ClassManager();
            SchoolInfo schoolInfo= new SchoolInfo();
            while (true)
            {
                Console.WriteLine("\nCHUONG TRINH QUAN LY SINH VIEN C#");
                Console.WriteLine("*************************MENU**************************");
                Console.WriteLine("**  1. Them sinh vien.                               **");
                Console.WriteLine("**  2. Cap nhat thong tin sinh vien boi ID.          **");
                Console.WriteLine("**  3. Xoa sinh vien boi ID.                         **");
                Console.WriteLine("**  4. Tim kiem sinh vien theo ten.                  **");
                
                Console.WriteLine("*******************************************************");
                Console.Write("Nhap tuy chon: ");
                int key = Convert.ToInt32(Console.ReadLine());
                switch (key)
                {
                    case 1:
                        Console.WriteLine("\n Them sinh vien");
                        classManager.SetStudent();
                        Console.Write("Them sinh vien thanh cong");
                        break;
                    case 2:
                        Console.WriteLine("\n Cap nhat thong tin sinh vien");
                        if(classManager.NumberStudent() > 0)
                        {
                            int id;
                            Console.WriteLine("\n Cap nhat thong tin sinh vien ");
                            Console.WriteLine("Nhap ma sinh vien");
                            id = Convert.ToInt32(Console.ReadLine());
                            classManager.UpdateStudent(id);
                        }
                        else
                        {
                            Console.WriteLine("\n Danh sach sinh vien trong");
                        }

                        break;
                     case 3:
                        Console.WriteLine("Xoa thong tin sinh vien");
                        if(classManager.NumberStudent() > 0)
                        {
                            int id;
                            Console.WriteLine("\n Xoa Sinh vien ");
                            Console.WriteLine("Nhap vao ma sinh vien");
                            id = Convert.ToInt32(Console.ReadLine());
                            if (classManager.DeletebyID(id))
                            {
                                Console.WriteLine($"\n Da xoa sinh vien co id {id}");
                            }
                            else
                            {
                                Console.WriteLine("\n Danh sach trong");
                            }
                        } 
                        break;
                    case 4:
                        if(classManager.NumberStudent() > 0)
                        {
                            Console.WriteLine("Tim sinh vien theo ma sinh vien");
                            Console.WriteLine("Nhap ma sinh vien de tim ");
                            int id= Convert.ToInt32(Console.ReadLine());
                            Student student1= classManager.FindStudentById(id);
                        }
                        else
                        {
                            Console.WriteLine("Danh sach trong");
                        }
                        break;

                }
            }
        }
    }
}
