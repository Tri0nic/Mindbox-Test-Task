namespace Mindbox_Library
{
    public class Triangle : Shape
    {
        private double FirstSide { get; }
        private double SecondSide { get; }
        private double ThirdSide { get; }
        private bool IsRightTriangle { get; }
        public Triangle(double firstSide, double secondSide, double thirdSide, string name = "Треугольник") : base(name)
        {
            // TODO: проверки
            FirstSide = firstSide;
            SecondSide = secondSide;
            ThirdSide = thirdSide;

            // Проверка треугольника на прямоугольность
            double[] sides = { FirstSide, SecondSide, ThirdSide };
            Array.Sort(sides);
            // Проверяем прямоугольность по теореме Пифагора
            IsRightTriangle = Math.Pow(sides[2], 2) == Math.Pow(sides[0], 2) + Math.Pow(sides[1], 2);
        }
        public override double Area()
        {
            // Полупериметр
            double semiPerimeter = (FirstSide + SecondSide + ThirdSide) / 2;
            // Площадь по формуле Герона
            return Math.Sqrt(semiPerimeter * (semiPerimeter - FirstSide) * (semiPerimeter - SecondSide) * (semiPerimeter - ThirdSide));
        }

        public override void Print()
        {
            string rightTriangle;
            if (IsRightTriangle)
            { rightTriangle = "Прямоугольный"; }
            else
            { rightTriangle = "Непрямоугольный"; }
            Console.WriteLine($"{rightTriangle} {ShapeName} с площадью: {Area()}"); ;
        }
    }
}
