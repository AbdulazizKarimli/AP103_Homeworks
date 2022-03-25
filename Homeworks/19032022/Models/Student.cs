using System;
using System.Collections.Generic;
using System.Text;

namespace _19032022.Models
{
    internal class Student
    {
        private static int _id;
        public int Id { get; }
        public string Fullname { get; set; }
        public int Point { get; set; }

        public Student(string fullname, int point)
        {
            _id++;
            Id = _id;
            Fullname = fullname;
            Point = point;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Id: {Id} - Fullname: {Fullname} - Point: {Point}");
        }
    }
}
