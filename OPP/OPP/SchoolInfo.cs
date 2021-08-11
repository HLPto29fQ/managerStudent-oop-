using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerSchool
{
    class SchoolInfo 
    {
      
        public List<int> classId { get; set; }
        public string schoolAddress {  get; set; }
        public string schoolName { get; set; }
        public string schoolType { get; set; }
        public SchoolInfo()
        {

        }
        public SchoolInfo(string schoolname,string schooltype,string schooladdress)
        {
            this.schoolName = schoolname;
            this.schoolType = schooltype;
            this.schoolAddress = schooladdress;
            Console.WriteLine($"Ten Truong hoc:{schoolName}");
            Console.WriteLine($"Kieu truong hoc:{schoolType}");
            Console.WriteLine($"Dia chi truong hoc : {schoolAddress}");
        }
    }
}
