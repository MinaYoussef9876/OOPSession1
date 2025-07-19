using System;
using System.ComponentModel;
using System.Drawing;

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

            Person[] people = new Person[3];

            Console.WriteLine("Enter 3 Persons");

            for(int i = 0; i < people.Length; i++)
            {
                Console.WriteLine($"Enter Person {i+1}: ");
                people[i].Name = ReadName();
                people[i].Age = ReadAge();
            }

            Console.WriteLine($"The Oldest Person is: {GetTheOldestPerson(people)}");

            static string ReadName()
            {
                string name;
                bool flag = false;
                do
                {
                    Console.Write("Enter valid Name: ");
                    name = Console.ReadLine();
                    if (name.Length > 0)
                        flag = true;
                } while (!flag);
                return name;
            }

            static int ReadAge()
            {
                int age;
                bool flag = false;
                do
                {
                    Console.Write("Enter valid Age: ");
                    flag = int.TryParse(Console.ReadLine(), out int value);
                    age = value;
                } while (!flag);
                return age;
            }

            static Person GetTheOldestPerson(Person[] people)
            {
                Person oldestPerson = people[0];

                for(int i = 1; i < people.Length; i++)
                {
                    if (people[i].Age > oldestPerson.Age)
                        oldestPerson = people[i];
                }
               return oldestPerson;
            }
            #endregion


        #endregion
        }
    }
}
