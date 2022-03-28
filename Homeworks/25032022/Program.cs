using _25032022.Models;
using System;

namespace _25032022
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student("test1", "testov", 89);
            Student student1 = new Student("test2", "testov", 20);
            Student student2 = new Student("test3", "testov", 0);
            Student student3 = new Student("test4", "testov", 35);

            Group group = new Group();
            group.AddStudent(student);
            group.AddStudent(student1);
            group.AddStudent(student2);
            group.AddStudent(student3);

            foreach (var item in group.GetAllStudents())
            {
                Console.WriteLine(item.ShowInfo());
            }
            Console.WriteLine("---------");
            foreach (var item in group.Sort())
            {
                Console.WriteLine(item.ShowInfo());
            }

            Console.WriteLine("---------");
            Group group1 = new Group();
            Console.WriteLine(group.No);
            Console.WriteLine(group1.No);

            #region CapacityOfList
            //List<int> numbers = new List<int>();
            //numbers.Add(1);
            //numbers.Add(2);
            //numbers.Add(3);
            //numbers.Add(4);
            //numbers.Add(5);
            //numbers.Add(6);
            //numbers.Add(7);
            //numbers.Add(8);
            //numbers.Add(9);
            //numbers.Add(10);
            //numbers.Add(11);
            //Console.WriteLine("Capacity:" + numbers.Capacity);
            //Console.WriteLine("Count:" + numbers.Count);
            #endregion
        }
    }
}
