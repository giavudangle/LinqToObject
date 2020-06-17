using System;
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
        new Standard(){ StandardID = 1, StandardName="Go to school by Ducati"},
        new Standard(){ StandardID = 2, StandardName="Sleep in hotel"},
        new Standard(){ StandardID = 3, StandardName="Eat in Restauntrant"},
        new Standard(){ StandardID = 4, StandardName="Can talk with Ronaldo"},
        new Standard(){ StandardID = 5, StandardName="Nice drink everyday"},
        new Standard(){ StandardID = 99, StandardName="Best soccer student"},
        new Standard(){ StandardID = 77, StandardName="1 bottle milk"},
        new Standard(){ StandardID = 66, StandardName="1 milktea"}
        };

        List<Student> studentList = new List<Student>()
        {
                new Student() { StudentID = 1, StudentName = "Wukong", Age = 18, StandardID = 1 } ,
                new Student() { StudentID = 2, StudentName = "Bat",  Age = 21, StandardID = 1 } ,
                new Student() { StudentID = 3, StudentName = "Bill",  Age = 18, StandardID = 2 } ,
                new Student() { StudentID = 3, StudentName = "Blitz",  Age = 18, StandardID = 3 } ,
                new Student() { StudentID = 4, StudentName = "Ram" , Age = 20, StandardID = 2 } ,
                new Student() { StudentID = 4, StudentName = "Gaga" , Age = 20, StandardID = 4 },
                new Student() { StudentID = 3, StudentName = "Kayn" , Age = 20, StandardID = 4 },
                new Student() { StudentID = 3, StudentName = "Lee" , Age = 25, StandardID = 10 },
                new Student() { StudentID = 3, StudentName = "Xuka" , Age = 17, StandardID = 5 },
                new Student() { StudentID = 3, StudentName = "Lux" , Age = 17, StandardID = 5 },
                new Student() { StudentID = 3, StudentName = "Ezreal" , Age = 25, StandardID = 10 },
                new Student() { StudentID = 3, StudentName = "Kelvin" , Age = 29, StandardID = 88 },
                new Student() { StudentID = 5, StudentName = "Gath" , Age = 21 ,StandardID=44},
                new Student() { StudentID = 5, StudentName = "Moon" , Age = 21 ,StandardID=12},
                new Student() { StudentID = 5, StudentName = "Laza" , Age = 21 ,StandardID=20}
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
        private void btnGroupStuID_CheckedChanged(object sender, EventArgs e)
        {
            GroupByStudentID();
        }

        private void btnGroupName_CheckedChanged(object sender, EventArgs e)
        {
            GroupByStudentName();
        }

        private void btnGroupStanID_CheckedChanged(object sender, EventArgs e)
        {
            GroupByStandardID();
        }

        private void btnGroupAge_CheckedChanged(object sender, EventArgs e)
        {
            GroupByStudentAge();
        }

        private void btnLeftJoin_Click(object sender, EventArgs e)
        {
            LeftJoin();
        }

        private void btnRightJoin_Click(object sender, EventArgs e)
        {
            RightJoin();
        }

        private void btnInnerJoin_Click(object sender, EventArgs e)
        {
            InnerJoin();
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
        #region Single Select - Where Operator
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
                MessageBox.Show("You must fill StudentID");
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
        #region Multi Select - Compare

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
                MessageBox.Show("Vui lòng nhập đủ dữ liệu");
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
        #region Order by - Sort
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


            /*Tôi k muốn lấy những Standard ID <=0*/
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
                    StandardID = group.First().StandardID,
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
        #region Group by
        private void GroupByStudentID()
        {
            ControlDataResult(null);
            if (btnGroupStuID.Checked) {
                var rawData =
                    from s in StudentList
                    group s by s.StudentID;


                var result =
                    from r in rawData
                    select new
                    {
                        StudentID = r.Key,
                        Amount = r.Count()
                    };
                ControlDataResult(result.ToList());
            }
        }

        private void GroupByStudentName()
        {
            ControlDataResult(null);
            if (btnGroupName.Checked)
            {
                var rawData =
                    from s in StudentList
                    group s by s.StudentName;


                var result =
                    from r in rawData
                    select new
                    {
                        StudentName = r.Key,
                        Amount = r.Count()
                    };
                ControlDataResult(result.ToList());
            }
        }

        private void GroupByStandardID()
        {
            ControlDataResult(null);
            if (btnGroupStanID.Checked)
            {
                var rawData = StudentList.GroupBy(s => s.StandardID);
                var res = rawData.Select(s => new
                {
                    StandardID = s.Key,
                    Amount = s.Count()
                });
                ControlDataResult(res.ToList());
            }           
        }

        private void GroupByStudentAge()
        {
            ControlDataResult(null);
            if (btnGroupAge.Checked)
            {
                var rawData = StudentList.GroupBy(s => s.Age);
                var res = rawData.Select(s => new
                {
                    StudentAge = s.Key,
                    Amount = s.Count()
                });
                ControlDataResult(res.ToList());
            }
        }




        #endregion
        #region Left-Right(Outer Join) - Inner Join

        private void LeftJoin()
        {

            // Left Outer Join
            /* Cho sta chạy trong StandardList,s trong StudentList
             * join sta.StandList match với s.StandardID
             * thành 1 collections mới nhét vào record
             * cho s chạy trong record (để mặc định nếu record empty)
             * select new collections pass về res
             *  Left join bảng StandardList với StudentList
             * Dù không match thì StandardList vẫn sẽ lấy hết ( bảng trái )
             * StudentList không match sẽ ra <NOT MATCHING>
             */


            /*Query expression */
            //var res = from sta in StandardList
            //          join s in StudentList
            //          on sta.StandardID equals s.StandardID
            //          into record
            //          from s in record.DefaultIfEmpty()
            //          select new
            //          {
            //              StandardName = sta.StandardName,
            //              StudentName = (s == null)
            //              ? "<NOT MATCHING>"
            //              : s.StudentName
            //          };
            ControlDataResult(null);
            /* Lambada expression*/
            var res = StandardList
                    .GroupJoin(
                        StudentList,
                        sta => sta.StandardID,
                        stu => stu.StandardID,
                        (sta, stuGroup) => new
                        {
                            sta,
                            stuGroup
                        })
                        .SelectMany(
                            tempSta => tempSta.stuGroup.DefaultIfEmpty(),
                            (tempSta, stu) => new
                            {
                                StandardName = tempSta.sta.StandardName,
                                StudentName = (stu == null) ? "<NOT MATCHING>" : stu.StudentName,

                            });
            ControlDataResult(res.ToList());
        }

        private void RightJoin()
        {
            ControlDataResult(null);
            var res = StudentList
                .GroupJoin(
                StandardList,
                stu => stu.StandardID,
                sta => sta.StandardID,
                (stu, staGroup) => new
                {
                    stu = stu,
                    staGroup = staGroup
                })                
                .SelectMany(
                    temp => temp.staGroup.DefaultIfEmpty(),
                    (temp, sta) => new
                    {
                        StandardName = (sta == null) ? "<NOT MATCHING>" : sta.StandardName,
                        StudentName = temp.stu.StudentName,
                        
                    }
                );                              
            ControlDataResult(res.ToList());
        }

        private void InnerJoin()
        {
            var result = from stu in StudentList
                         join sta in StandardList
                         on stu.StandardID equals sta.StandardID
                         select new
                         {
                             StudentName = stu.StudentName,
                             StandardName = sta.StandardName
                         };
            ControlDataResult(result.ToList());
        }

        #endregion

        #endregion


    }
}
