using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Polymorphism
//Caroline Uthawong-Burr .NET23
{
    public class Rectangle : Geometry //ChildClass som ärver från ParentClass
    {
        private double RectangleBase { get; }  // Egenskaper
        private double RectangleHeight { get; }


        public Rectangle(string name) : base(name)
        {
            RectangleBase = 5.4;   // Konstruktorn med fasta värden
            RectangleHeight = 9;

        }
        public override double Area()
        {
            Console.WriteLine($"\nArean av en {Name} räknas ut på detta sätt: basen * höjden; {RectangleBase} * {RectangleHeight}.");
            double answer = Math.Round(RectangleBase * RectangleHeight,1);

            Console.Write($"Arean på denna {Name} är: {answer}.\n");
            return answer;
        }
    }
}