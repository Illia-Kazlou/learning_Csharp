using System;

namespace CourseHunter_73_Interfaces
{
    public abstract class Shape
    {
        protected Shape()
        {
            Console.WriteLine("Shape created");
        }

        public abstract void Draw(); // СИГНАТУРА

        public abstract double Area(); // СИГНАТУРА

        public abstract double Preimeter(); // СИГНАТУРА
    }

    public class Recanlge : Shape
    {
        private readonly double width;
        private readonly double height;

        public Recanlge(double width, double height)
        {
            this.width = width;
            this.height = height;

            Console.WriteLine("Rectangle created");
        }

        public override double Area() //ОБЯЗАНЫ ПЕРЕОПРЕДЕЛИТЬ МЕТОДЫ
        {
            return width * height;
        }

        public override void Draw() //ОБЯЗАНЫ ПЕРЕОПРЕДЕЛИТЬ МЕТОДЫ
        {
            Console.WriteLine("Drawing rectangle");
        }

        public override double Preimeter() //ОБЯЗАНЫ ПЕРЕОПРЕДЕЛИТЬ МЕТОДЫ
        {
            return 2 * (width + height);
        }
    }

    public class Triangle : Shape
    {
        private readonly double ab;
        private readonly double ca;
        private readonly double bc;

        public Triangle(double ab, double bc, double ca)
        {
            this.ab = ab;
            this.ca = ca;
            this.bc = bc;

            Console.WriteLine("Triengle created");
        }

        public override double Area()
        {
            double s = (ab + bc + ca) * 2;
            return Math.Sqrt(s * (s - ab) * (s - bc) * (s - ca));
        }

        public override void Draw()
        {
            Console.WriteLine("Drawing triengle");
        }

        public override double Preimeter()
        {
            return ab + bc + ca;
        }
    }
}
