using System;
using System.Collections.Generic;
using System.Text;

namespace _25032022.Models
{
    internal class Group
    {
        private static int _no = 100;
        private Student[] _students;

        public string No { get; set; }

        public Group()
        {
            _no++;
            No = $"AP{_no}";
            _students = new Student[0];
        }

        public void AddStudent(Student student)
        {
            Array.Resize(ref _students, _students.Length + 1);
            _students[_students.Length - 1] = student;
        }
        public Student[] GetAllStudents()
        {
            Student[] students = new Student[_students.Length];
            _students.CopyTo(students, 0);
            return students;
        }
        public Student[] Sort()
        {
            Student[] students = new Student[_students.Length];
            _students.CopyTo(students, 0);

            Student temp;
            for (int i = 0; i < students.Length - 1; i++)
            {
                for (int j = i + 1; j < students.Length; j++)
                {
                    if (students[i] > students[j])
                    {
                        temp = students[i];
                        students[i] = students[j];
                        students[j] = temp;
                    }
                }
            }

            return students;
        }
    }
}
