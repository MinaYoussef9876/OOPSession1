using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Demo
{
    internal struct Employee
    {
        private int _id;
        private string _name;
        private double _salary;


        // Automatic Propery
        public string Address { get; set; }

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





        // Apply Encapsualtion using Properties  [Recommended]
        // 1. Full Property

        // Id
        //public int Id
        //{
        //    // get
        //    // set

        //    get
        //    {
        //        return _id;
        //    }
        //    set
        //    {
        //        _id = value;
        //    }
        //}

        //// Name
        //public string Name
        //{
        //    get
        //    {
        //        return _name;
        //    }
        //    set
        //    {
        //        if (value.Length >= 0 && value.Length <= 25)
        //            _name = value;
        //    }
        //}

        //// Salary
        //public double Salary
        //{
        //    get
        //    {
        //        return _salary;
        //    }
        //    set
        //    {
        //        if (value >= 0)
        //            _salary = value;
        //    }
        //}




        // 2. Automatic Property
        // public string Address { get; set; }

        // 3. Specail Property


    }
}
