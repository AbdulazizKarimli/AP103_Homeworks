using System;
using System.Collections.Generic;
using System.Text;

namespace _19032022.Models
{
    internal class Group
    {
        private int _studentLimit;
        private string _groupNo;
        public string GroupNo
        {
            get => _groupNo; 
            set
            {
                if(CheckGroupNo(value))
                    _groupNo = value;
            }
        }
        public int StudentLimit
        {
            get => _studentLimit;
            set
            {
                if (value >= 2 && value <= 18)
                    _studentLimit = value;
            }
        }
        private Student[] students;

        public Group(string groupNo, int studentLimit)
        {
            GroupNo = groupNo;
            StudentLimit = studentLimit;
            students = new Student[0];
        }

        public bool CheckGroupNo(string groupNo)
        {
            if (!string.IsNullOrWhiteSpace(groupNo) && groupNo.Length == 5 && char.IsUpper(groupNo[0]) && char.IsUpper(groupNo[1]))
            {
                //AP103
                for (int i = 2; i < 5; i++)
                {
                    if (char.IsDigit(groupNo[i]) == false)
                        return false;
                }

                return true;
            }

            return false;
        }

        public void AddStudent(Student student)
        {

            if (students.Length < StudentLimit)
            {
                Array.Resize(ref students, students.Length + 1);
                students[students.Length - 1] = student;
                return;
            }

            Console.WriteLine("limit doldu");
        }

        public Student GetStudent(int? id)
        {
            if (id != null && students.Length > 0)
            {
                foreach (var student in students)
                {
                    if (student.Id == id)
                        return student;
                }
            }

            return null;
        }

        public Student[] GetAllStudents()
        {
            return students;
        }
    }
}
