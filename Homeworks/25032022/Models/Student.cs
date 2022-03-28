using System;
using System.Collections.Generic;
using System.Text;

namespace _25032022.Models
{
    internal class Student
    {
        private static int _id;

        public int Id { get; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public byte Age { get; set; }
        public double Point { get; set; }

        public Student(string name, string surname, double point)
        {
            _id++;
            Id = _id;
            Name = name;
            Surname = surname;
            Point = point;
        }

        public string ShowInfo()
        {
            return $"Id: {Id} - Name: {Name} - Surname: {Surname} - Age: {Age} - Point: {Point}";
        }
        public static bool operator >(Student student1, Student student2)
        {
            return student1.Point > student2.Point;
        }
        public static bool operator <(Student student1, Student student2)
        {
            return student1.Point < student2.Point;
        }
    }
}
