using _19032022.Models;
using System;

namespace _19032022
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Fullname:");
            string fullname = Console.ReadLine();
            Console.WriteLine("Email:");
            string email = Console.ReadLine();
            string password;
            do
            {
                Console.WriteLine("Password:");
                password = Console.ReadLine();
            } while (PasswordChecker(password) == false);

            User user = new User(email, password)
            {
                Fullname = fullname
            };

            Console.WriteLine("====== User Menu ======");
            Console.WriteLine("1. Show info");
            Console.WriteLine("2. Create new group");

            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    user.ShowInfo();
                    break;
                case "2":
                    string groupNo;
                    do
                    {
                        Console.WriteLine("Group no:");
                        groupNo = Console.ReadLine();
                    } while (CheckGroupNo(groupNo) == false);
                    int studentLimit;
                    bool isNum;
                    do
                    {
                        Console.WriteLine("Student limit:");
                        string studentLimitStr = Console.ReadLine();
                        isNum = int.TryParse(studentLimitStr, out studentLimit);
                    } while (isNum == false || studentLimit < 2 || studentLimit > 18);

                    Group group = new Group(groupNo, studentLimit);

                    bool check = true;
                    while (check)
                    {
                        Console.WriteLine("====== Group menu ======");
                        Console.WriteLine("1. Show all students");
                        Console.WriteLine("2. Get student by id");
                        Console.WriteLine("3. Add student");
                        Console.WriteLine("0. Quit");

                        string groupChoice = Console.ReadLine();

                        switch (groupChoice)
                        {
                            case "1":
                                foreach (var item in group.GetAllStudents())
                                {
                                    Console.WriteLine("------");
                                    item.ShowInfo();
                                }
                                break;
                            case "2":
                                int studentId;
                                bool isNumId;
                                do
                                {
                                    Console.WriteLine("Student id:");
                                    string studentIdStr = Console.ReadLine();
                                    isNumId = int.TryParse(studentIdStr, out studentId);
                                } while (isNum == false);

                                group.GetStudent(studentId).ShowInfo();
                                break;
                            case "3":
                                Console.WriteLine("Student fullname:");
                                string studentFullname = Console.ReadLine();
                                int point;
                                bool isNumPoint;
                                do
                                {
                                    Console.WriteLine("Point:");
                                    string pointStr = Console.ReadLine();
                                    isNumPoint = int.TryParse(pointStr, out point);
                                } while (isNumPoint == false);

                                Student student = new Student(studentFullname, point);

                                group.AddStudent(student);
                                break;
                            case "0":
                                check = false;
                                break;
                            default:
                                Console.WriteLine("wrong input!!!");
                                break;
                        }
                    }

                    break;
                default:
                    break;
            }
        }

        static bool PasswordChecker(string password)
        {
            bool hasDigit = false;
            bool hasLower = false;
            bool hasUpper = false;
            if (string.IsNullOrWhiteSpace(password) == false && password.Length >= 8)
            {
                foreach (var item in password)
                {
                    if (char.IsDigit(item))
                        hasDigit = true;

                    if (char.IsLower(item))
                        hasLower = true;

                    if (char.IsUpper(item))
                        hasUpper = true;

                    if (hasDigit && hasUpper && hasLower)
                        return true;
                }
            }

            return false;
        }

        static bool CheckGroupNo(string groupNo)
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
    }
}
