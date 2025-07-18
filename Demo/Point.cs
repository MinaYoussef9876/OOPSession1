using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Demo
{
    internal struct Point
    {
        //public int x;
        //public int y;

        // Constructor is special method
        // 1. Same name as struct
        // 2. No return type

        // CLR will generate paramterless constructor.
        // This constructor will initialize the attributes with default values

        // Constructor
        //public Point()
        //{

        //}



        // .NET 6.0   C# 10.0    // paramaterless ctor can be created but it must initialize attributes
        //public Point()
        //{
        //    x = 8;
        //    y = 8;
        //}

        // in .NET 7.0 a parameterless ctor can be created without initializing attributes

        //public Point(int x, int y)
        //{
        //    this.x = x; 
        //    this.y = y;
        //}

        //public void PrintPoint()
        //{
        //    Console.WriteLine($"({x}, {y})");
        //}

        //public override string ToString()
        //{
        //    return $"({x}, {y})";
        //}
    }
}
