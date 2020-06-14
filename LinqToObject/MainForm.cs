﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LinqToObject
{
    internal partial class MainForm : Form
    {
        #region MockData
        List<Standard> standardList = new List<Standard>() {
        new Standard(){ StandardID = 1, StandardName="Standard 1"},
        new Standard(){ StandardID = 2, StandardName="Standard 2"},
        new Standard(){ StandardID = 3, StandardName="Standard 3"}
        };

        List<Student> studentList = new List<Student>()
        {
                new Student() { StudentID = 1, StudentName = "John", Age = 18, StandardID = 1 } ,
                new Student() { StudentID = 2, StudentName = "Steve",  Age = 21, StandardID = 1 } ,
                new Student() { StudentID = 3, StudentName = "Bill",  Age = 18, StandardID = 2 } ,
                new Student() { StudentID = 4, StudentName = "Ram" , Age = 20, StandardID = 2 } ,
                new Student() { StudentID = 4, StudentName = "Gaga" , Age = 20, StandardID = 2 },
                new Student() { StudentID = 5, StudentName = "Ron" , Age = 21 }
        };

        internal List<Student> StudentList { get => studentList; set => studentList = value; }
        internal List<Standard> StandardList { get => standardList; set => standardList = value; }
        #endregion
        public MainForm()
        {
            InitializeComponent();
            LoadDataDisplay();
        }

        #region Events
        private void btnGreater_Click(object sender, EventArgs e)
        {
            GreaterCompare();
        }
        private void btnLesser_Click(object sender, EventArgs e)
        {
            LesserCompare();
        }
        private void btnEqual_Click(object sender, EventArgs e)
        {
            EqualCompare();
        }

        private void btnGroupStandardID_Ascending_Click(object sender, EventArgs e)
        {
            GroupAndSort_StandardID_Ascending();
        }

        private void btnGroupByStandardID_Descending_Click(object sender, EventArgs e)
        {
            GroupAndSort_StandardID_Descending();
        }

        private void btnGroupStudentID_Ascending_Click(object sender, EventArgs e)
        {
            GroupAndSort_StudentID_Ascending();
        }

        private void btnGroupStudentID_Descending_Click(object sender, EventArgs e)
        {
            GroupAndSort_StudentID_Descending();
        }

        private void btnGroupStudentName_Ascending_Click(object sender, EventArgs e)
        {
            GroupAndSort_StudentName_Ascending();
        }

        private void btnGroupStudentName_Descending_Click(object sender, EventArgs e)
        {
            GroupAndSort_StudentName_Descending();
        }

        private void btnGroupStudentAge_Ascending_Click(object sender, EventArgs e)
        {
            GroupAndSort_StudentAge_Ascending();
        }

        private void btnGroupStudentAge_Descending_Click(object sender, EventArgs e)
        {
            GroupAndSort_StudentAge_Descending();

        }

        private void btn_Select_ID_Click(object sender, EventArgs e)
        {
            SingleFilterStudentID();
        }

        private void btn_Select_StandardID_Click(object sender, EventArgs e)
        {
            SingleFilterStandardID();
        }

        private void btn_Select_StudentName_Click(object sender, EventArgs e)
        {
            SingleFilterStudentName();
        }

        private void btn_Select_StudentAge_Click(object sender, EventArgs e)
        {
            SingleFilterStudentAge();
        }

        #endregion

        #region Methods

        #region Common methods
        private void LoadDataDisplay()
        {
            dataDisplay.DataSource = StudentList;
        }

        private void ControlDataResult(object data)
        {
            dataResult.DataSource = data;
        }

        private bool IsValid()
        {
            return (txtAge.Text != "" && txtStandardID.Text != "") ? true : false;
        }
      
        #endregion

        #region Single Select
        private void SingleFilterStudentID()
        {           
            if (txtStudentID.Text != "")
            {
                int ID = int.Parse(txtStudentID.Text);
                var result =
                    from s in StudentList
                    where s.StudentID == ID
                    select new
                    {
                        StudentID = s.StudentID,
                        StandardID = s.StandardID,                      
                        StudentName = s.StudentName,
                        StudentAge = s.Age
                    };
                ControlDataResult(result.ToList());
            }else
            {
                MessageBox.Show("Vui lòng nhập StudentID");
            }
        }

        private void SingleFilterStandardID()
        {
            if(txtStdardID.Text != "")
            {
                int ID = int.Parse(txtStdardID.Text);
                var result =
                    from s in StudentList
                    where s.StandardID == ID
                    select new
                    {
                        StudentID = s.StudentID,
                        StandardID = s.StandardID,
                        StudentName = s.StudentName,
                        StudengAge = s.Age
                    };

                ControlDataResult(result.ToList());
            }else
            {
                MessageBox.Show("You must fill StandardID");
            }

        }

        private void SingleFilterStudentName()
        {
            if (txtName.Text != "")
            {
                string comp = txtName.Text;
                var result = StudentList
                    .Where(s => s.StudentName == comp)
                    .Select(s => new
                    {
                        StudentID = s.StudentID,
                        StandardID = s.StandardID,
                        StudentName= s.StudentName,
                        StudentAge = s.Age
                    });
                ControlDataResult(result.ToList());
            } else
            {
                MessageBox.Show("You must fill Student Name");
            }
        }

        private void SingleFilterStudentAge()
        {
            if (txtStudentAge.Text != "")
            {
                int ageComp = int.Parse(txtStudentAge.Text);
                var result = StudentList
                    .Where(s => s.Age == ageComp)
                    .Select(s => new
                    {
                        StudentID = s.StudentID,
                        StandardID = s.StandardID,
                        StudentName = s.StudentName,                      
                        StudentAge = s.Age
                    });
                ControlDataResult(result.ToList());
            }
            else
            {
                MessageBox.Show("Please fill Student Age");
            }
        }


        #endregion
        #region MultiSelect - Compare

        private void GreaterCompare()
        {
            if (IsValid())
            {
                int age = int.Parse(txtAge.Text);
                int standardID = int.Parse(txtStandardID.Text);

                IEnumerable<Student> greater =
                    StudentList.Where(s => s.Age > age)
                               .Select(s => s)
                               .Where(st => st.StandardID > standardID)
                               .Select(s => s);
                dataResult.DataSource = greater.ToList();

                /* Có thể dùng query expression thay cho Lambada Expression */
                // -> Query này select trả về một anonymous object hoặc collection 
                // -> Dùng var để hứng các return types kiểu anonymous.
                //var greater = from s in studentList
                //                       where s.age > 12 && s.age < 20
                //                       select new { StudentName = s.StudentName };

                //teenStudentsName.ToList().ForEach(s => Console.WriteLine(s.StudentName));
            }
            else
            {
                MessageBox.Show("Vui lòng nhập dữ liệu");
            }

        }
        private void LesserCompare()
        {
            if (IsValid())
            {
                int age = int.Parse(txtAge.Text);
                int standardID = int.Parse(txtStandardID.Text);

                IEnumerable<Student> lesser =
                    StudentList.Where(s => s.Age < age)
                               .Select(s => s)
                               .Where(st => st.StandardID < standardID)
                               .Select(s => s);
                ControlDataResult(lesser.ToList());
            }
            else
            {
                MessageBox.Show("Vui lòng nhập dữ liệu");
            }

        }

        private void EqualCompare()
        {
            if (IsValid())
            {
                int age = int.Parse(txtAge.Text);
                int standardID = int.Parse(txtStandardID.Text);

                IEnumerable<Student> equal =
                    StudentList.Where(s => s.Age == age)
                               .Select(s => s)
                               .Where(st => st.StandardID == standardID)
                               .Select(s => s);
                ControlDataResult(equal.ToList());
            }
            else
            {
                MessageBox.Show("Vui lòng nhập dữ liệu");
            }
        }
        #endregion
        #region Groupby and Orderby
        private void GroupAndSort_StandardID_Ascending()
        {
            /* Cũng có thể dùng Query Expression như comment
             * -> Cho record(1 con trỏ) chạy trong Properties StudentList (MockData)
             * -> Record này trả về một collections (type anonymous -> implicit type )
             * -> Gói vào 1 temp collection là sg
             * -> Gọi methods order by của Linq theo key là Sg.Key
             * -> Order trên tạo ra 1 collections mới sau đó
             * -> Dùng select để tạo ra 1 collection mới theo ta định nghĩa bên dưới
             * -> Select linq trả ra 1 anonymous collections ( implement interface IEnumerable )
             * -> Pass xuống Data Source của ResultDataGridView
             */

            // -> Query-expressions.
            //var groupByStandard = from record in StudentList
            //                      group record by record.StandardID into sg
            //                      orderby sg.Key
            //                      select new
            //                      {
            //                          StandardID = sg.Key,
            //                          StudentID = sg.First().StudentID,
            //                          StudentName = sg.First().StudentName,
            //                          Age = sg.First().Age
            //                      };

            ControlDataResult(null);
            var groupByStandardID_Ascending =
                StudentList
                .GroupBy(record => new
                {
                    standardID = record.StandardID,
                    studentID = record.StudentID,
                    age = record.Age,
                    name = record.StudentName
                })
                .Where(record => record.Key.standardID > 0)
                .Select(group => new
                {
                    StandardID = group.First().StandardID,
                    StudentID = group.Key.studentID,
                    Name = group.Key.name,
                    Age = group.Key.age,
                })
                .OrderBy(item => item.StandardID);
            ControlDataResult(groupByStandardID_Ascending.ToList());

        }    
        private void GroupAndSort_StandardID_Descending()
        {
            ControlDataResult(null);
            var groupByStandardID_Descending =
                StudentList
                .GroupBy(record => new
                {
                    standardID = record.StandardID,
                    studentID = record.StudentID,
                    age = record.Age,
                    name = record.StudentName
                })
                .Where(record => record.Key.standardID > 0)
                .Select(group => new
                {
                    StandardID = group.First().StandardID,
                    StudentID = group.Key.studentID,
                    Name = group.Key.name,
                    Age = group.Key.age,
                })
                .OrderByDescending(item => item.StandardID);
            ControlDataResult(groupByStandardID_Descending.ToList());
        }


        private void GroupAndSort_StudentID_Ascending()
        {
            ControlDataResult(null);
            var groupByStudentId_Ascending =
                StudentList
                .GroupBy(record => new
                {
                    studentID = record.StudentID,
                    standardID = record.StandardID,
                    name = record.StudentName,
                    age = record.Age,

                })
                .Select(group => new
                {
                    StudentID = group.First().StudentID,
                    StandardID = group.Key.standardID,
                    Name = group.Key.name,
                    Age = group.Key.age,
                })
                .OrderBy(item => item.StudentID);
            ControlDataResult(groupByStudentId_Ascending.ToList());
        }

        private void GroupAndSort_StudentID_Descending()
        {
            ControlDataResult(null);
            var groupByStudentId_Descending =
                StudentList
                .GroupBy(record => new
                {
                    studentID = record.StudentID,
                    standardID = record.StandardID,
                    name = record.StudentName,
                    age = record.Age,

                })
                .Select(group => new
                {
                    StudentID = group.First().StudentID,
                    StandardID = group.Key.standardID,
                    Name = group.Key.name,
                    Age = group.Key.age,
                })
                .OrderByDescending(item => item.StudentID);
            ControlDataResult(groupByStudentId_Descending.ToList());
        }
        private void GroupAndSort_StudentName_Ascending()
        {
            ControlDataResult(null);
            var groupByStudentName_Ascending =
                StudentList
                .GroupBy(record => new
                {
                    name = record.StudentName,
                    studentID = record.StudentID,
                    standardID = record.StandardID,
                    age = record.Age,

                })
                .Select(group => new
                {
                    Name = group.First().StudentName,
                    StudentID = group.Key.studentID,
                    StandardID = group.Key.standardID,
                    Age = group.Key.age,
                })
                .OrderBy(item => item.Name);
            ControlDataResult(groupByStudentName_Ascending.ToList());
        }
        private void GroupAndSort_StudentName_Descending()
        {
            ControlDataResult(null);
            var groupByStudentName_Descending =
                StudentList
                .GroupBy(record => new
                {
                    name = record.StudentName,
                    studentID = record.StudentID,
                    standardID = record.StandardID,
                    age = record.Age,

                })
                .Select(group => new
                {
                    Name = group.First().StudentName,
                    StudentID = group.Key.studentID,
                    StandardID = group.Key.standardID,
                    Age = group.Key.age,
                })
                .OrderByDescending(item => item.Name);
            ControlDataResult(groupByStudentName_Descending.ToList());           
        }
        private void GroupAndSort_StudentAge_Ascending()
        {
            ControlDataResult(null);
            var groupByStudentAge_Ascending =
                StudentList
                .GroupBy(record => new
                {
                    age = record.Age,
                    name = record.StudentName,
                    studentID = record.StudentID,
                    standardID = record.StandardID,                   
                })
                .Select(group => new
                {
                    Age = group.Key.age,
                    Name = group.First().StudentName,
                    StudentID = group.Key.studentID,
                    StandardID = group.Key.standardID,
                   
                })
                .OrderBy(item => item.Age);
            ControlDataResult(groupByStudentAge_Ascending.ToList());
        }

        private void GroupAndSort_StudentAge_Descending()
        {
            ControlDataResult(null);
            var groupByStudentAge_Ascending =
                StudentList
                .GroupBy(record => new
                {
                    age = record.Age,
                    name = record.StudentName,
                    studentID = record.StudentID,
                    standardID = record.StandardID,
                })
                .Select(group => new
                {
                    Age = group.Key.age,
                    Name = group.First().StudentName,
                    StudentID = group.Key.studentID,
                    StandardID = group.Key.standardID,

                })
                .OrderByDescending(item => item.Age);
            ControlDataResult(groupByStudentAge_Ascending.ToList());
        }
        #endregion
       


        #endregion


    }
}
