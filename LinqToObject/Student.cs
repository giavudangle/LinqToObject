using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqToObject
{
    class Student
    {
        private int studentID;
        private string studentName;
        private int age;
        private int standardID;

        public Student() { }
        public Student(int studentID, string studentName, int age, int standardID)
        {
            this.studentID = studentID;
            this.studentName = studentName;
            this.age = age;
            this.standardID = standardID;
        }

        public int StudentID { get => studentID; set => studentID = value; }
        public string StudentName { get => studentName; set => studentName = value; }
        public int StandardID { get => standardID; set => standardID = value; }
        public int Age { get => age; set => age = value; }
    }
}
