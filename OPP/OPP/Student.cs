using System;
using System.Collections.Generic;

namespace ManagerSchool
{
    class Student : PersonalInfo
    {
        private int classId ;
        private double markMath;
        private double markPhys;
        private double markBio;
        private string ability;
        private double amark;

        public Student(int id, int classID)
        {
            ID = id;
            ClassID = classID;
            classId = 0;
            markMath= 0;
            markPhys = 0;
            markBio = 0;
            ability = "";
            amark = 0;

        }
        public Student()
        {
            ID = 0;
            ClassID = 0;
            classId = 0;
            markMath = 0;
            markPhys = 0;
            markBio = 0;
            ability = "";
            amark = 0;

        }
        public int ClassID
        {
            get { return classId; }
            set { classId = value; }
        }
        public double MarkMath
        {
            get { return markMath; }
            set { markMath = value; }
        }
        public double MarkPhys
        {
            get { return markPhys; }
            set { markPhys = value; }
        }
        public double MarkBio
        {
            get { return markBio; }
            set { markBio = value; }
        }
        public string Ability
        {
            get { return ability; }
            set { ability = value; }
        }
        public double Amark
        {
            get { return amark; }
            set { amark = value; }
        }
    }
}
