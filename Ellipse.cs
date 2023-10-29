using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace OOP_Polymorphism
//Caroline Uthawong-Burr .NET23
{
    public class Ellipse : Geometry  //ChildClass som ärver från ParentClass
    {
        private double EllipseRadiusA { get; }  // Egenskaper
        private double EllipseRadiusB { get; }
        private double Pi { get; }


        public Ellipse(string name) : base(name)
        {
            EllipseRadiusA = 15;     // Konstruktorn med fasta värden
            EllipseRadiusB = 15; 
            Pi = Math.PI;

        }
        public override double Area()
        {
            Console.WriteLine($"\nArean av en {Name} räknas ut på detta sätt :  storaxel * lillaxel * pi; {EllipseRadiusA} * {EllipseRadiusB} *  {Pi}.");
            double answer = Math.Round((Pi * EllipseRadiusA * EllipseRadiusB),1);
            Console.Write($"Arean på denna {Name} är: {answer}.\n");
            return answer;
        }
    }
}