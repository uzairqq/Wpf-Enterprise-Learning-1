using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace Wpf_Learning_First
{
    public class Student
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public int RollNo { get; set; }

        public static Student GetStudent()
        {
            var stu = new Student()
            {
                StudentId = 3378,
                StudentName = "Uzair",
                RollNo = 155
            };
            return stu;
        }
    }
}
