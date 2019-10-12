using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using Newtonsoft.Json;

namespace GradeKeeper
{
    public class GradeBook : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        [JsonIgnore]
        public string FileName { get; set; }

        public List<Student> Students { get; set; }

        public List<Course> Courses { get; set; }

        public GradeBook()
        {
            Students = new List<Student>();
            Courses = new List<Course>();
        }
    }
}
