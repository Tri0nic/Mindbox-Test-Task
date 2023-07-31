using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mindbox_Library
{
    public class Circle : Shape
    {
        private double Radius { get; }
        public Circle(double radius, string name = "Круг") : base(name)
        {
            // TODO: проверки
            Radius = radius;
        }
        public override double Area()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
        public override void Print()
        {
            Console.WriteLine($"{ShapeName} с площадью: {Area()}");
        }
    }
}
