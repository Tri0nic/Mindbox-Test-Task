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
            if (radius <= 0)
            {
                throw new ArgumentNullException("Радиус не может быть меньше или равен нулю!", nameof(radius));
            }
            Radius = radius;
        }
        /// <summary>
        /// Вычисление площади
        /// </summary>
        /// <returns>Площадь</returns>
        public override double Area()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
        /// <summary>
        /// Вывод информации о фигуре
        /// </summary>
        public override void Print()
        {
            Console.WriteLine($"{ShapeName} с площадью: {Area()}");
        }
    }
}
