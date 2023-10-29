using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace OOP_Polymorphism
//Caroline Uthawong-Burr .NET23
{
    public class Circle : Geometry //ChildClass som ärver från ParentClass
    {
        private double CircleRadius { get; }  // Egenskaper
        private double Pi { get; }


        public Circle(string name) : base(name)
        {
            CircleRadius = 5;   // Konstruktorn med fasta värden
            Pi = Math.PI;

        }
        public override double Area()
        {
            Console.WriteLine($"\nArean av en {Name} räknas ut på detta sätt: radien * radien * pi; {CircleRadius} x {CircleRadius}  * {Pi}.");
            double answer = Math.Round((CircleRadius * CircleRadius) * Pi,1);
            Console.Write($"Arean på denna {Name} är: {answer}.\n");
            return answer;
        }
    }
}