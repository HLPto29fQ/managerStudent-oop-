using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerSchool
{
    class SchoolManager 
    {
        SchoolInfo mSchoolInfo= null;
        private int studentId;
        public SchoolManager(SchoolInfo schoolInfo)
        {
            mSchoolInfo = schoolInfo;

        }
        public void ManagerSchool()
        {
            List<ClassInfo> classes= new List<ClassInfo>();
        }
        public void InformationClass(int IdClass)
        {
            ClassInfo classInfo= new ClassInfo();

        }
    }
}
