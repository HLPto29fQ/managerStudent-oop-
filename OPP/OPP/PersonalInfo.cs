using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

 namespace ManagerSchool
{
    class PersonalInfo
    {
        private int Id;
        private string name;
        private string sex;
        private DateTime dOfB;
        private string addr;
        private string phone;
        private string email;
       
        
        public int ID
        {
            get { return Id; }
            set { Id = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Sex
        {
            get { return sex; }
            set { sex = value; }
        }
        public DateTime DOfB
        {
            get { return dOfB; }
            set { dOfB = value; }
        }
        public string Address
        {
            get { return addr; }
            set { addr = value; }
        }
        public string Phone
        {
            get { return phone; }
            set { phone = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
    }
}
