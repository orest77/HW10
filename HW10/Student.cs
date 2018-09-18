using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW10
{
    class Student
    {
        private string name;
        private List<int> marks = new List<int>();

        public string Name { get { return name; } set { name = value; } }
        public List<int> Marks { get { return marks; } set { marks = value; } }

        public Student() { }
        public Student(string _name, List<int> _marks)
        {
            this.name = _name;
            this.marks = _marks;
        }
        public event Program.MyDel MarkChange;

        public void AddMark(int m)
        {
            marks.Add(m);
            if (MarkChange != null)
            {
                MarkChange(m);
            }
        }     
    }
}
