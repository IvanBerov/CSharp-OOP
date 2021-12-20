using System;
using System.Collections.Generic;
using System.Text;

namespace P03_StudentSystem
{
    public class StudentSystemData
    {
        public Dictionary<string, Student> repositoryStudents;

        public StudentSystemData()
        {
            this.repositoryStudents = new Dictionary<string, Student>();
        }

        public Student Find(string name)
        {
            if (this.repositoryStudents.ContainsKey(name))
            {
                var student = this.repositoryStudents[name];
            }

            return null;
        }

        public void Add(string name, int age, double grade)
        {
            if (!this.repositoryStudents.ContainsKey(name))
            {
                var student = new Student(name, age, grade);
                this.repositoryStudents[name] = student;
            }
        }
    }
}
