using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Sinema
{
    class Group
    {
        public string Name { get; set; }
        public Student this[int i]
        {
            get
            {
                return students[i];
            }
            set
            {
                students[i] = value;
            }
        }


        private readonly Student[] students;

        public Group(string name, int countStudents)
        {
            Name = name;
            students = new Student[countStudents];

        }
        //public void AddStudent(Student st)
        //{
        //    for (int i = 0; i < students.Length; i++)
        //    {
        //        students[i] = st;
        //    }


        //}
    }
}
