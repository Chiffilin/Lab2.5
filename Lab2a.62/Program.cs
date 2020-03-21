using System;
using System.Globalization;
namespace AbstractFigure
{
    

    internal abstract class Figure
    {
        public abstract string Area();
        public abstract string Perimeter();
        public abstract string ShapeName();

        public void ShowInfo()
        {
            Console.WriteLine(
                $"Название фигуры: {ShapeName()}\n" +
                $"Площадь: {Area()}\n" +
                $"Периметр: {Perimeter()}"
            );
            Console.WriteLine();
        }
    }

    internal class Rectangle : Figure
    {
        private double width;   // Ширина прямоугольника
        private double height;   // Высота прямоугольника

        // Конструктор
        public Rectangle(double rectangleWidth, double rectangleHeight)
        {
            Width = rectangleWidth;
            Height = rectangleHeight;
        }

        // Свойство, проверяем значение на отрицательность.
        public double Width
        {
            get => width;
            set => width = value < 0 ? -value : value;
        }

        public double Height
        {
            get => height;
            set => height = value < 0 ? -value : value;
        }

        // Метод для вычисления площади прямоугольника
        public override string Area()
        {
            return (width * height).ToString(CultureInfo.InvariantCulture);
        }

        // Метод для вычисления периметра прямоугольника
        public override string Perimeter()
        {
            return (width * 2 + height * 2).ToString(CultureInfo.InvariantCulture);
        }

        // Метод возвращающий наименование фигуры
        public override string ShapeName()
        {
            return "Прямоугольник";
        }
    }


    internal class Triangle : Figure
    {
        private double sideA, sideB, sideC;   // Стороны треугольника

        // Конструктор
        public Triangle(double triangleSideA, double triangleSideB, double triangleSideC)
        {
            SideA = triangleSideA;
            SideB = triangleSideB;
            SideC = triangleSideC;
        }

        // Свойство, проверяем значение на отрицательность.
        // Если значение отрицательное меняем его на аналогичное положительное.
        public double SideA
        {
            get => sideA;
            set => sideA = value < 0 ? -value : value;
        }

        public double SideB
        {
            get => sideB;
            set => sideB = value < 0 ? -value : value;
        }

        public double SideC
        {
            get => sideC;
            set => sideC = value < 0 ? -value : value;
        }

        // Метод для вычисления площади треугольника
        public override string Area()
        {
            double semPer = (sideA + sideB + sideC) / 2;
            return Math.Sqrt(semPer * (semPer - sideA) * (semPer - sideB) * (semPer - sideC)).ToString(CultureInfo.InvariantCulture);
        }

        // Метод для вычисления периметра треугольника
        public override string Perimeter()
        {
            return (sideA + sideB + sideC).ToString(CultureInfo.InvariantCulture);
        }

        // Метод возвращающий наименование фигуры
        public override string ShapeName()
        {
            return "Треугольник";
        }
    }
    internal class Circle : Figure
    {
        private double radius;   // Радиус прямоугольника
       

        // Конструктор
        public Circle(double circleWidth)
        {
            Width = circleWidth;
            
        }

        // Свойство, проверяем значение на отрицательность.
        public double Width
        {
            get => radius;
            set => radius = value < 0 ? -value : value;
        }
        public override string Area()
        {
            return (Math.PI * Math.Pow(radius,2)).ToString(CultureInfo.InvariantCulture);
        }

        // Метод для вычисления периметра прямоугольника
        public override string Perimeter()
        {
            return (2*Math.PI*radius).ToString(CultureInfo.InvariantCulture);
        }

        // Метод возвращающий наименование фигуры
        public override string ShapeName()
        {
            return "Круг";
        }
    }

    internal class Program
    {
        private static void Main()
        {
            
            Figure figure1 = new Triangle(4, 5, 6);
            figure1.ShowInfo();

            Figure figure2 = new Rectangle(5, 6);
            figure2.ShowInfo();
            
            Figure figure3 = new Circle(2);
            figure3.ShowInfo();
            Console.ReadLine();
            Figure[] figure = { new Triangle(4, 5, 6), new Rectangle(5, 6), new Circle(6) };
        }
        // Создать массив совместных с Figure объектов.
        Figure[] myFigure = { new Triangle(4, 5, 6), new Rectangle(5, 6), new Circle(6) };


    }
}
