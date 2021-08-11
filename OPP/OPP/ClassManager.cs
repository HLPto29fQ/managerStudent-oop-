using System;
using System.Collections.Generic;


namespace ManagerSchool
{
    class ClassManager
    {
        public  void  ManagerClass()
        {
            List<Student> students = new List<Student>();
            List<TeacherInfo> teachers = new List<TeacherInfo>();
            List<int> classid= new List<int>();
        }
        public List<Student> students = null;
        public List<TeacherInfo> teachers = null;
        public int GenerateIDStudent()
        {
            int max = 1;
            if (students != null && students.Count > max)
            {
                max = students[0].ID;
                foreach (Student st in students)
                {
                    if (max < st.ID)
                    {
                        max = st.ID;
                    }
                }
                max++;
            }
            return max;
        }
        public int NumberStudent()
        {
            int count = 0;
            if (students != null)
            {
                count = students.Count;
            }
            return count;
        }
        public void AverageMark(Student st)
        {
            double am = (st.MarkMath + st.MarkPhys + st.MarkBio) / 3;
            st.Amark = Math.Round(am, 2, MidpointRounding.AwayFromZero);
        }
        private void SetAbility(Student st)
        {
            if (st.Amark >= 8)
            {
                st.Ability = "Gioi";
            }
            else if (st.Amark >= 6.5)
            {
                st.Ability = "Kha";
            }
            else if (st.Amark >= 5)
            {
                st.Ability = "Trung Binh";
            }
            else
            {
                st.Ability = "Yeu";
            }

        }
        public void SetStudent()
        {
            Student st = new Student();
            GenerateIDStudent();
            Console.WriteLine($" Ho va ten sinh vien : ");
            st.Name = Console.ReadLine();
            Console.WriteLine($" Tuoi : ");
            st.DOfB = DateTime.Parse(Console.ReadLine());
            Console.WriteLine($"Lop ");
           
            Console.WriteLine($"Ma lop hoc ");
            st.ClassID=int.Parse(Console.ReadLine());
            Console.WriteLine($" Dia chi : ");
            st.Address = Console.ReadLine();
            Console.WriteLine($"So dien thoai:");
            st.Phone = Console.ReadLine();
            Console.WriteLine($"Email :");
            st.Email = Console.ReadLine();
            Console.WriteLine($"Gioi tinh: ");
            st.Sex = Console.ReadLine();
            Console.WriteLine($"Diem Toan : ");
            st.MarkMath = double.Parse(Console.ReadLine());
            Console.WriteLine($"Diem Ly :");
            st.MarkPhys = double.Parse(Console.ReadLine());
            Console.WriteLine($"Diem Hoa: ");
            st.MarkBio = double.Parse(Console.ReadLine());
            AverageMark(st);
            SetAbility(st);
            students.Add(st);
        }
        public Student FindStudentById(int id)
        {
            Student result = null;
            if (students != null && students.Count > 0)
            {
                foreach (Student student in students)
                {
                    if (student.ID == id)
                    {
                        result = student;
                    }
                }
            }
            return result;
        }
        public bool DeletebyID(int id)
        {
            bool delete = false;
            Student st = FindStudentById(id);
            if (st != null)
            {
                delete = students.Remove(st);
            }
            return delete;
        }
        public void SortById()
        {
            students.Sort(delegate (Student st1, Student st2)
            {
                return st1.ID.CompareTo(st2.ID);
            });
        }
        public void SortByName()
        {
            students.Sort(delegate (Student st1, Student st2)
            {
                return st1.Name.CompareTo(st2.ID);
            });
        }
        public void UpdateStudent(int id)
        {
            Student st = FindStudentById(id);
            if (students != null)
            {
                Console.WriteLine("Nhap vao ten sinh vien : ");
                string name = Convert.ToString(Console.ReadLine());
                if (name != null && name.Length > 0)
                {
                    st.Name = name;
                }
                Console.WriteLine("Nhap vao ngay thang nam sinh :");
                DateTime dateTime = Convert.ToDateTime(Console.ReadLine());
                st.DOfB = dateTime;
                Console.WriteLine("Nhap vao diem mon Toan ");
                double markmath = Convert.ToDouble(Console.ReadLine());
                if (markmath != 0)
                {
                    st.MarkMath = markmath;
                }
                double markphys = Convert.ToDouble(Console.ReadLine());
                if (markphys != 0)
                {
                    st.MarkPhys = markphys;
                }
                double markbio = Convert.ToDouble(Console.ReadLine());
                if (markbio != 0)
                {
                    st.MarkBio = markbio;
                }
                AverageMark(st);
                SetAbility(st);

            }
            else
            {
                Console.WriteLine("Sinh vien khong ton tai");
            }
        }
        public List<Student> GetListStudent()
        {
            return students;
        }
        public  int GenerateIDTeacher()
        {
            int max = 1;
            if (teachers != null && teachers.Count > max)
            {
                max = teachers[0].ID;
                foreach (TeacherInfo tc in teachers)
                {
                    if (max < tc.ID)
                    {
                        max = tc.ID;
                    }
                }
                max++;
            }
            return max;
        }
        public int NumTeacher()
        {
            int count = 0;
            if(teachers != null)
            {
                count = teachers.Count;
            }
            return count;
        }
        public void SetTeacher()
        {
            TeacherInfo teacher = new TeacherInfo();
            Console.WriteLine($"Nhap vao ten giao vien:{teacher.Name = Console.ReadLine()}");
            Console.WriteLine($"Nhap vao id giao vien :{teacher.ID = int.Parse(Console.ReadLine())}");
            Console.WriteLine($"Nhap vao ngay sinh giao vien: {teacher.DOfB = DateTime.Parse(Console.ReadLine())}");
            Console.WriteLine($"Nhap vao dia chi giao vien : {teacher.Address = Console.ReadLine()}");
            Console.WriteLine($"Nhap vao so dien thoai giao vien : {teacher.Phone = Console.ReadLine()}");
            Console.WriteLine($"Nhap vao email giao vien : {teacher.Email = Console.ReadLine()}");
            Console.WriteLine($"Nhap vao danh sach ma lop day : ");
            List<int> idClass= new List<int>(5);
            for (int i = 0;i< 5; i++)
            {
                idClass[i] =int.Parse(Console.ReadLine());
            }
            Console.WriteLine($"Nhap vao ma lop chu nhiem:{teacher.ClassMainID = int.Parse(Console.ReadLine())}");
        }
        public TeacherInfo FindTeacherByID(int id)
        {
            TeacherInfo results = null;
            if(teachers!= null && teachers.Count > 0)
            {
                foreach(TeacherInfo t in teachers)
                {
                    if(t.ID == id)
                    {
                        results = t;
                    }
                }
            }
            return results;
        }
        public void ShowInforTeacher(int id)
        { 
            TeacherInfo teacher = FindTeacherByID (id);
            Console.WriteLine($"Ho va ten giao vien:{teacher.Name}");
            Console.WriteLine($"Ngay thang nam sinh :{teacher.DOfB}");
            Console.WriteLine($"Ma lop chu nhiem:{teacher.ClassMainID}");
            Console.WriteLine($"So dien thoai va email:{teacher.Phone}  {teacher.Email}");
        }
    }
}
