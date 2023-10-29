using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Polymorphism
//Caroline Uthawong-Burr .NET23
{
    public abstract class Geometry  //ParentClass
    {
        public string Name { get; set; }  

        public abstract double Area();  //return type är en double
        public Geometry(string name)
        {
            Name = name;
        }
    }
}