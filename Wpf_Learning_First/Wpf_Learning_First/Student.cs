using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Wpf_Learning_First.Annotations;

namespace Wpf_Learning_First
{
    public class Student:INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void RaisePropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }


        private string _name { get; set; }
        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
                RaisePropertyChanged();
            }
        }

        private string _title { get; set; }
        public string Title
        {
            get { return _title; }
            set
            {
                _title = value;
                RaisePropertyChanged();
            }
        }

        private bool _wasReElected { get; set; }
        public bool WasReElected
        {
            get { return _wasReElected; }
            set
            {
                _wasReElected = value;
                RaisePropertyChanged();
            }
        }

        private Party _affiliation { get; set; }
        public Party Affiliation
        {
            get { return _affiliation; }
            set
            {
                _affiliation = value;
                RaisePropertyChanged();
            }
        }
        public static ObservableCollection<Student> GetStudents()
        {
            var students = new ObservableCollection<Student>
            {
                new Student() { Name = "Washington", Title = "President", WasReElected = true, Affiliation = Party.Independent },
                new Student() { Name = "Adams", Title = "President 2", WasReElected = false, Affiliation = Party.Federalist },
                new Student() { Name = "Jefferson", Title = "President 3", WasReElected = true, Affiliation = Party.DemocratRepublican },
                new Student() { Name = "Madison", Title = "President 4", WasReElected = true, Affiliation = Party.DemocratRepublican },
                new Student() { Name = "Monroe", Title = "President 5", WasReElected = true, Affiliation = Party.DemocratRepublican }
            };
            return students;
        }
    }

    

    public enum Party
    {
        Independent,
        Federalist,
        DemocratRepublican
    }
}
