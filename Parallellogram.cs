using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace OOP_Polymorphism
//Caroline Uthawong-Burr .NET23
{
    public class Parallellogram : Geometry  //ChildClass som ärver från ParentClass
    {
        private double ParallellogramBase { get; }  // Egenskaper
        private double ParallellogramHeight { get; }
        public Parallellogram(string name) : base(name)
        {
            ParallellogramBase = 12.2;   // Konstruktorn med fasta värden
            ParallellogramHeight = 4.3;
        }
        public override double Area()
        {
            Console.WriteLine($"\nArean av en {Name} räknas ut på detta sätt: basen * höjden; {ParallellogramBase} * {ParallellogramHeight}.");
            double answer = Math.Round(ParallellogramBase * ParallellogramHeight,1);
            Console.Write($"Arean på denna {Name} är: {answer}.\n");
            return answer;
        }
    }
}