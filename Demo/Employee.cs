using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal struct Employee
    {
        private int _id;
        private string _name;
        private double _salary;

        // Apply Encapsulation using Setter Getter Methods

        // Setter
        //private void SetId(int id)
        //{
        //    _id = id;
        //}
        //public void SetName(string name)
        //{
        //    if(name.Length >= 0 && name.Length <= 25)
        //        _name = name;
        //}
        //public void SetSalary(double salary)
        //{
        //    if (_salary >= 0)
        //        _salary = salary;
        //}


        //// Getter
        //public int GetId()
        //{
        //    return _id;
        //}
        //public string GetName()
        //{
        //    return _name;
        //}
        //public double GetSalary()
        //{
        //    return _salary;
        //}

        //public Employee(int id, string name, double salary)
        //{
        //    //SetId(id);
        //    SetName(name);
        //    SetSalary(salary);
        //}

        //public override string ToString()
        //{
        //    return $"ID: {_id}, Name: {_name}, Salary: {_salary}";
        //}
    }
}
