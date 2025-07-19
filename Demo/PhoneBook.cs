using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal struct PhoneBook
    {
        //public string[] _names;
        //public long[] _numbers;

        //public PhoneBook(int size)
        //{
        //    _names = new string[size];
        //    _numbers = new long[size];
        //}


        //// Indexer
        //public long this[string name]
        //{
        //    get
        //    {
        //        for (int i = 0; i < _names.Length; i++)
        //        {
        //            if (_names[i] == name)
        //                return _numbers[i];
        //        }
        //        return -1;
        //    }
        //    set
        //    {
        //        for (int i = 0; i < _names.Length; i++)
        //        {
        //            if (_names[i] == name)
        //                _numbers[i] = value;
        //        }
        //    }
        //}

        //public string this[long number]
        //{
        //    get
        //    {
        //        for (int i = 0; i < _numbers.Length; i++)
        //        {
        //            if (_numbers[i] == number)
        //                return _names[i];
        //        }
        //        return "";
        //    }
        //    set
        //    {
        //        for (int i = 0; i < _numbers.Length; i++)
        //        {
        //            if (_numbers[i] == number)
        //                _names[i] = value;
        //        }
        //    }
        //}



        //public void AddPerson(string name, long number, int index)
        //{
        //    _names[index] = name;
        //    _numbers[index] = number;
        //}

        //public long GetNumberByName (string name)
        //{
        //    for (int i = 0; i < _names.Length;  i++)
        //    {
        //        if(_names[i] == name)
        //            return _numbers[i];
        //    }
        //    return -1;
        //}

        //public void UpdateNumber(string name, long newNumber)
        //{
        //    for (int i = 0; i < _names.Length; i++)
        //    {
        //        if (_names[i] == name)
        //            _numbers[i] = newNumber;
        //    }
        //}

        //public string GetNameByNumber(long number)
        //{
        //    for (int i = 0; i < _numbers.Length; i++)
        //    {
        //        if (_numbers[i] == number)
        //            return _names[i];
        //    }
        //    return "";
        //}

        //public void UpdateName(string name, long newNumber)
        //{
        //    for (int i = 0; i < _names.Length; i++)
        //    {
        //        if (_names[i] == name)
        //            _numbers[i] = newNumber;
        //    }
        //}
    }
}
