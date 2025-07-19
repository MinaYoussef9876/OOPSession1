using Assignment.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Assignment
{
    internal class Employee
    {
        private int _id;
        private string _name;
        private SecurityLevel _securityLevel;
        private decimal _salary;
        private Gender _gender;
        private HiringDate _hiringDate;


        #region Getters And Setters Methods
        //public int GetId()
        //{
        //    return _id;
        //}
        //public void SetId(int id)
        //{
        //    _id = id;
        //}


        //public string GetName()
        //{
        //    return _name;
        //}
        //public void SetName(string name)
        //{
        //    if (name.Length >= 0)
        //        _name = name;
        //}


        //public SecurityLevel GetSecurityLevel()
        //{
        //    return _securityLevel;
        //}
        //public void SetSecurityLevel(string securityLevel)
        //{
        //    if(Enum.TryParse(typeof(SecurityLevel), securityLevel, true, out object parsedSecurityLevel ))
        //        _securityLevel = (SecurityLevel)parsedSecurityLevel;
        //}


        //public decimal GetSalary()
        //{
        //    return _salary;
        //}
        //public void SetSalary(decimal salary)
        //{
        //    if (salary > 0)
        //        _salary = salary;
        //}


        //public Gender GetGender()
        //{
        //    return _gender;
        //}
        //public void SetGender(string gender)
        //{
        //    if ((Enum.TryParse(typeof(Gender), gender, true, out object parsedGender)))
        //        _gender = (Gender)parsedGender;
        //}


        //public HiringDate GetHiringDate()
        //{
        //    return _hiringDate;
        //}
        //public void SetHiringDate(HiringDate hiringDate)
        //{
        //    if(hiringDate is not null)
        //        _hiringDate = hiringDate;
        //}
        #endregion


        // Constructor with Getter and Setter methods
        //public Employee(int id, string name, string securityLevel, decimal salary, string gender, HiringDate hiringDate)
        //{
        //    SetId(id); 
        //    SetName(name); 
        //    SetSecurityLevel(securityLevel); 
        //    SetSalary(salary); 
        //    SetGender(gender); 
        //    SetHiringDate(hiringDate);
        //}




        #region Properties
        public int Id
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
            }
        }

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                if (value.Length >= 0)
                    _name = value;
            }
        }

        public SecurityLevel SecurityLevel
        {
            get
            {
                return _securityLevel;
            }
            set
            {
                _securityLevel = value;
            }
        }

        public decimal Salary
        {
            get
            {
                return _salary;
            }
            set
            {
                if (value > 0)
                    _salary = value;
            }
        }

        public Gender Gender
        {
            get
            {
                return _gender;
            }
            set
            {
                _gender = value;
            }
        } 

        public HiringDate HiringDate
        {
            get
            {
                return _hiringDate;
            }
            set
            {
                _hiringDate= value;
            }
        }
        #endregion


        #region Ctors
        public Employee()
        {
            
        }

        // Constructors with Properties
        //public Employee(int id, string name, SecurityLevel securityLevel, decimal salary, Gender gender, HiringDate hiringDate)
        //{
        //    Id = id;
        //    Name = name;
        //    SecurityLevel = securityLevel;
        //    Salary = salary;
        //    Gender = gender;
        //    HiringDate = hiringDate;
        //}


        public Employee(int id, string name, SecurityLevel securityLevel, decimal salary, Gender gender, HiringDate hiringDate)
        : this(id, name, securityLevel, salary, gender)
        {
            HiringDate = hiringDate;
        }

        public Employee(int id, string name, SecurityLevel securityLevel, decimal salary, Gender gender)
            : this(id, name, securityLevel, salary)
        {
            Gender = gender;
        }

        public Employee(int id, string name, SecurityLevel securityLevel, decimal salary)
            : this(id, name, securityLevel)
        {
            Salary = salary;
        }

        public Employee(int id, string name, SecurityLevel securityLevel)
            : this(id, name)
        {
            SecurityLevel = securityLevel;
        }

        public Employee(int id, string name)
            : this(id)
        {
            Name = name;
        }

        public Employee(int id)
        {
            Id = id;
        } 
        #endregion


        public override string ToString()
        {
            return $"ID: {_id}," +
                $" Name: {_name}," +
                $" Security Level: {_securityLevel}," +
                $" Salary: {string.Format("{0:C}", _salary)}," +
                $" Gender: {_gender}," +
                $" Hiring Date: {_hiringDate}";
        }
    }
}
