using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Wpf_Learning_First.Annotations;

namespace Wpf_Learning_First
{
    public class Student :INotifyPropertyChanged
    {
        public int StudentId { get; set; }
        public int studentId
        {
            get { return studentId; }
            set
            {
                StudentId = value;
                OnPropertyChanged();
            }
        }
        public string StudentName { get; set; }
        public string studentName
        {
            get { return studentName; }
            set
            {
                StudentName =value ;
                OnPropertyChanged();
            }
        }
        public int RollNo { get; set; }

        public int rollNo
        {
            get { return rollNo; }
            set
            {
                RollNo = value;
                OnPropertyChanged();
            }
        }
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

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
