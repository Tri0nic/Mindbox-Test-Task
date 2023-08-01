using Mindbox_Library;

class Program
{
    public static void Main()
    {
        // Пример использования
        Circle circle2 = new Circle(6);
        List<Shape> shapes = new List<Shape>
        {
            new Circle(7.7),
            new Circle(0.3, "Маленький круг"),
            new Triangle(4.5, 6.1, 9.3),
            new Triangle(3, 5, 4)
        };

        foreach (var shape in shapes)
        {
            shape.Print();
        }
    }
}