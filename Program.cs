namespace OOP_Polymorphism
//Caroline Uthawong-Burr .NET23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Geometry Rectangle = new Rectangle("rektangel");
            Rectangle.Area();

            Geometry Square = new Square("fyrkant");
            Square.Area();

            Geometry Circle = new Circle("cirkel");
            Circle.Area();

            Geometry Parallellogram = new Parallellogram("parallellogram");
            Parallellogram.Area();

            Geometry Ellipse = new Ellipse("ellips");
            Ellipse.Area();
        }
    }
}