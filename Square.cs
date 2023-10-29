using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace OOP_Polymorphism
//Caroline Uthawong-Burr .NET23
{
    public class Square : Geometry //ChildClass som ärver från ParentClass
    {
        private double SquareSide { get; }  // Egenskaper
        
        public Square(string name) : base(name)
        {
            SquareSide = 16.3;   // Konstruktorn med fasta värden

        }
        public override double Area()
        {
            Console.WriteLine($"\nArean av en {Name} räknas ut på detta sätt: sida * sida; {SquareSide} * {SquareSide}.");
            double answer = Math.Round(SquareSide * SquareSide,1);
            Console.Write($"Arean på denna {Name} är: {answer}.\n");
            return answer;
        }
    }
}