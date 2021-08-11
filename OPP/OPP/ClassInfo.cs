using System;
using System.Collections.Generic;

namespace ManagerSchool
{
    class ClassInfo
    {
        public string nameOfSchool { get; set; }
        public string nameClass { get; set; }
        private int idClass { get; set; }
        public  List<Student> students = null;
        public List<TeacherInfo> teachers = null;
        public string mainTeacher { get; set; }
        public int IdClass
        {
            get {  return idClass; }
            set { IdClass = value; }
        }
        public ClassInfo()
        {

        }
        public ClassInfo(string schoolName, string className, int classId, List<Student> students, List<TeacherInfo> teacherInfos, string mainTeacher)
        {
            this.nameOfSchool = schoolName;
            this.nameClass = className;
            this.idClass = classId;
            this.students = students;
            this.teachers = teacherInfos;
            this.mainTeacher = mainTeacher;
        }
    }

}
