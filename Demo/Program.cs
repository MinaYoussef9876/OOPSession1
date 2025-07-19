namespace Demo
{
    // 1. Class
    // 2. Struct
    // 3. Interface
    // 4. Enum

    internal class Program
    {
        static void Main(string[] args)
        {
            #region V01 Struct
            // Struct: Value type - STACK

            // Employee
            // Id, Name, Salary


            // Point
            //Point p01;
            // Declare of object of type Point
            // Allocate uninialized 8 bytes at stack

            //Console.WriteLine(p01.x);      // error: Unassigned variable
            //Console.WriteLine(p01.y);      // error: Unassigned variable

            //p01.x = 12;
            //p01.y = 12;

            //Console.WriteLine(p01.x);
            //Console.WriteLine(p01.y);


            //Point p02 = new Point();
            //// new: used for selection of constructor

            //Console.WriteLine(p02.x);       // 0
            //Console.WriteLine(p02.y);       // 0


            //Point p03 = new Point(1, 2);

            //Console.WriteLine(p03.x);        // 1
            //Console.WriteLine(p03.y);        // 2

            //Console.WriteLine(p03);       

            //p03.PrintPoint();

            //Console.WriteLine(p03.ToString());

            //Console.WriteLine(p03.ToString());
            //Console.WriteLine(p03);
            #endregion

            #region V02 OOP overview
            // OOP: Object Oriented Programming
            // Programming paradigm
            // OOP: Paradigm used for building any business

            // Class: Blueprint of the object
            // Object: Specific instance of the class

            // 4 Pillars
            // 1. Encapsulation
            // 2. Inheritance
            // 3. Polymorphism
            // 4. Abstraction
            #endregion

            #region V03 Encapsulation using setter and getter methods
            // 1. Encapsulation
            // Class or Struct
            // Seperate the data (attributes) definition from its use
            // [Setter Getter methods - Properties]

            // Employee
            // Id, Name, Salary

            // 1. End user access data itself
            // 2. No data validation
            // 3. No readonly fields

            // Apply Encapsulation
            // 1. make all attributes private
            // 2. Access data through: 
            //      2.1 Setter Getter methods
            //      2.2 Properites

            //Employee e01 = new Employee();
            //Employee e01 = new Employee(1, "Ahmed", 12000);
            //Console.WriteLine(e01);

            // Id is readonly attribute
            //e01.GetId();

            //e01._id = 1;
            //e01._name = "Ahmed";
            //e01._salary = 12000;

            //Console.WriteLine(e01._id);
            //Console.WriteLine(e01._name);
            //Console.WriteLine(e01._salary);

            //e01.SetId(1);
            //e01.SetName("Ahmed");
            //e01.SetSalary(12000);

            //Console.WriteLine(e01.GetId());
            //Console.WriteLine(e01.GetName());
            //Console.WriteLine(e01.GetSalary());
            #endregion

            #region V04 Encapsulation using Properties

            //Employee employee = new Employee();
            //employee.Id = 12;
            //employee.Name = "Ahmed";
            //employee.Salary = 12000;

            //Console.WriteLine(employee.Id);
            //Console.WriteLine(employee.Name);
            //Console.WriteLine(employee.Salary);
            #endregion
        }
    }
}
