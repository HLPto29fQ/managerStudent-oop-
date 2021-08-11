using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerSchool
{
    class TeacherInfo:PersonalInfo
    {
        public List<int> classId {  get; set; }
        private int classMainID {  get; set; }
        public int ClassMainID
        {
            get { return classMainID; }
            set { classMainID = value;}
        }
        public TeacherInfo()
        {

        }
        public TeacherInfo(string name,int id, DateTime dateOfB ,string add,string phone,string email,List<int> classid,int classMainID )
        {
            this.Name = name;
            this.ID = id;
            this.DOfB = dateOfB;
            this.Address = add;
            this.Phone = phone;
            this.Email = email;
            this.classId = classid;
            this.classMainID = classMainID;
        }
    }
}
