using System;
using System.ComponentModel;
using System.Drawing;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Reflection.Emit;
using System.Security.Claims;
using System.Security.Cryptography;
using static System.Net.Mime.MediaTypeNames;
using System.Diagnostics.Metrics;
using System.Threading;
using Assignment.Enums;

namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part01


            #region Q01
            // 1.Create a struct called "Point" to represent a 2D point with properties "X" and "Y". 
            // Write a C# program that takes two points as input from the user and calculates the distance between them.
            //Console.WriteLine("Enter 2 Points");

            //Console.WriteLine("Enter the First Point");
            //Point p01 = AssignPoint();

            //Console.WriteLine("Enter the second Point");
            //Point p02 = AssignPoint();

            //double distance = CalculateDistance(p01, p02);
            //Console.WriteLine($"Distance between the 2 points = {distance}");




            //static Point AssignPoint()
            //{
            //    Point p = new Point();
            //    p.X = ReadPointCoordinate('x');
            //    p.Y = ReadPointCoordinate('y');
            //    return p;
            //}

            //static double ReadPointCoordinate(char c)
            //{
            //    double coordinateValue;
            //    bool flag = false;
            //    do
            //    {
            //        Console.Write($"Enter {c} of point:  ");
            //        flag = double.TryParse(Console.ReadLine(), out double value);
            //        coordinateValue = value;
            //    } while (!flag);
            //    return coordinateValue;
            //}

            //static double CalculateDistance(Point p1, Point p2)
            //{
            //    double dx = p2.X - p1.X;
            //    double dy = p2.Y - p1.Y;
            //    double result = Math.Sqrt(dx * dx + dy * dy);
            //    return result;
            //}
            #endregion

            #region Q02
            //2.Create a struct called "Person" with properties "Name" and "Age".
            //Write a C# program that takes details of 3 persons as input from the user and displays the name and age of the oldest person.

            //Person[] people = new Person[3];

            //Console.WriteLine("Enter 3 Persons");

            //for(int i = 0; i < people.Length; i++)
            //{
            //    Console.WriteLine($"Enter Person {i+1}: ");
            //    people[i].Name = ReadName();
            //    people[i].Age = ReadAge();
            //}

            //Console.WriteLine($"The Oldest Person is: {GetTheOldestPerson(people)}");

            //static string ReadName()
            //{
            //    string name;
            //    bool flag = false;
            //    do
            //    {
            //        Console.Write("Enter valid Name: ");
            //        name = Console.ReadLine();
            //        if (name.Length > 0)
            //            flag = true;
            //    } while (!flag);
            //    return name;
            //}

            //static int ReadAge()
            //{
            //    int age;
            //    bool flag = false;
            //    do
            //    {
            //        Console.Write("Enter valid Age: ");
            //        flag = int.TryParse(Console.ReadLine(), out int value);
            //        age = value;
            //    } while (!flag);
            //    return age;
            //}

            //static Person GetTheOldestPerson(Person[] people)
            //{
            //    Person oldestPerson = people[0];

            //    for(int i = 1; i < people.Length; i++)
            //    {
            //        if (people[i].Age > oldestPerson.Age)
            //            oldestPerson = people[i];
            //    }
            //   return oldestPerson;
            //}
            #endregion


            #endregion

            #region Part02
            // 1. Design and implement a Class for the employees in a company:
            //Notes:
            //  ● Employee is identified by an ID, Name, security level, salary, hire date and Gender.
            //  ● We need to restrict the Gender field to be only M or F[Male or Female]
            //  ● Assign the following security privileges to the employee(guest, Developer, secretary and DBA) in a form of Enum.
            //  ● We want to provide the Employee Class to represent Employee data in a string Form(override ToString()),
            //    display employee salary in a currency format. [Use String.Format() Function].


            //0.Develop a Class to represent the Hiring Date Data:
            //    ● Consisting of fields to hold the day, month and Years.

            //0.Create an array of Employees with size three a DBA,
            //    Guest and the third one is security officer who have full permissions. (Employee[] EmpArr;)
            //Notes:
            //    ● Implement All the Necessary Member Functions on the Class (Getters, Setters)
            //    ● Define all the Necessary Constructors for the Class
            //    ● Allow NO RUNTIME errors if the user inputs any data
            //    ● Write down all the necessary Properties(Instead of setters and getters)


            Employee[] employees = new Employee[3];

            Console.WriteLine("Enter 3 Employees");

            for (int i = 0; i < employees.Length; i++)
            {
                employees[i] = new Employee();

                Console.WriteLine($"Enter Employee {i+1}: ");
                employees[i].Id = ReadIntInput("Id");
                employees[i].Name = ReadName();
                employees[i].Gender = ReadGender();
                employees[i].Salary = ReadSalary();
                employees[i].HiringDate = ReadHiringDate();
            }
            employees[0].SecurityLevel = SecurityLevel.DBA;
            employees[1].SecurityLevel = SecurityLevel.Guest;
            employees[2].SecurityLevel = SecurityLevel.DBA | SecurityLevel.Guest | SecurityLevel.Developer | SecurityLevel.Secretary;


            DisplayEmployees(employees);

            static int ReadIntInput(string input)
            {
                int digit;
                bool flag = false;
                do
                {
                    Console.Write($"Enter valid {input}: ");
                    flag = int.TryParse(Console.ReadLine(), out int value);
                    digit = value;
                } while (!flag);
                return digit;
            }
            static string ReadName()
            {
                Console.Write($"Enter Name: ");
                return Console.ReadLine();
            }
            static decimal ReadSalary()
            {
                decimal salary;
                bool flag = false;
                do
                {
                    Console.Write("Enter valid Salary: ");
                    flag = decimal.TryParse(Console.ReadLine(), out decimal value);
                    salary = value;
                } while (!flag);
                return salary;
            }
            static Gender ReadGender()
            {
                Gender gender = Gender.M;
                bool flag = false;
                do
                {
                    Console.Write("Enter valid Gender [M (or Male), F (or Female)]: ");
                    flag = Enum.TryParse(typeof(Gender), Console.ReadLine(), true, out object value);
                    if(flag)
                        gender = (Gender)value;
                } while (!flag);
                return gender;
            }
            static HiringDate ReadHiringDate()
            {
                Console.WriteLine("Enter Hiring Date");
                int day = ReadIntInput("day");
                int month = ReadIntInput("month");
                int year = ReadIntInput("year");

                return new HiringDate(day, month, year);
            }
            static void DisplayEmployees(Employee[] employees)
            {
                foreach (Employee e in employees)
                {
                    Console.WriteLine(e);
                }
            }
            #endregion
        }
    }
}
