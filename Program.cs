using System;

namespace CSharp.LabExercise4
{
    interface IShape
    {
        string Name { get; set; }
        void ComputeArea();
        void DisplayArea();
    }
    abstract class Shape
    {
        public string Name { get; set; }
        public double Area { get; set; }
        public double Unit1 { get; set; }
        public double Unit2 { get; set; }
        public void DisplayArea()
        {
            Console.WriteLine($"The Area of {Name} is {Area} units squared");
        }
    }
    class Circle : Shape, IShape
    {
        public Circle(double radius)
        {
            this.Name = "Circle";
            this.Unit1 = radius;
        }
        public void ComputeArea()
        {
            this.Area = Convert.ToDouble(Math.PI) * Convert.ToDouble(this.Unit1 * this.Unit1);
        }
    }
    class Square : Shape, IShape
    {
        public Square(double side)
        {
            this.Name = "Square";
            this.Unit1 = side;
            
        }
        public void ComputeArea()
        {
            this.Area = this.Unit1 * this.Unit1;
        }
    }

    class Rectangle : Shape, IShape
    {
        public Rectangle(double length,  double width)
        {
            this.Name = "Rectangle";
            this.Unit1 = length;
            this.Unit2 = width;
        }
        public void ComputeArea()
        {
            this.Area = this.Unit1 * this.Unit2;
        }
    }

    interface IOperations
    {
        void Compute(decimal num1, decimal num2);
    }

    class Adder: IOperations
    {
        public void Compute(decimal num1, decimal num2)
        {
            decimal sum = num1 + num2;
            Console.WriteLine($"{num1} + {num2} is equals to {sum}");
        }
    }

    class Substracter : IOperations
    {
        public void Compute(decimal num1, decimal num2)
        {
            decimal difference = num1 - num2;
            Console.WriteLine($"{num1} - {num2} is equals to {difference}");
        }
    }

    class Multiplier : IOperations
    {
        public void Compute(decimal num1, decimal num2)
        {
            decimal product = num1 * num2;
            Console.WriteLine($"{num1} * {num2} is equals to {product}");
        }
    }

    class Divider : IOperations
    {
        public void Compute(decimal num1, decimal num2)
        {
            decimal quotient = num1 / num2;
            Console.WriteLine($"{num1} / {num2} is equals to {quotient}");
        }
    }



    internal class Program
    {
        static void Num1()
        {
            Console.WriteLine("*****MIKKO'S SHAPE'S AREA CALCULATOR*****");
            static void Circle()
            {
                Console.Write("Compute area of circle with radius of: ");
                double input = Convert.ToDouble(Console.ReadLine());

                IShape circle = new Circle(input);
                circle.ComputeArea();
                circle.DisplayArea();
                Main();
            }

            static void Square()
            {
                Console.WriteLine("Compute Area of Square");
                Console.Write("Side: ");
                double input = Convert.ToDouble(Console.ReadLine());
                IShape square = new Square(input);
                square.ComputeArea();
                square.DisplayArea();
                Main();
            }

            static void Rectangle()
            {
                Console.WriteLine("Compute Area of Rectangle");
                Console.Write("Length: ");
                double input1 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Width: ");
                double input2 = Convert.ToDouble(Console.ReadLine());
                IShape rectangle = new Rectangle(input1, input2);
                rectangle.ComputeArea();
                rectangle.DisplayArea();
                Main();
            }

            Console.WriteLine("1. Circle Area Calculator.");
            Console.WriteLine("2. Square Area Calculator.");
            Console.WriteLine("3. Rectangle Area Calculator.");
            Console.Write("Enter choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());
            if (choice == 1)
            {
                Circle();
            }
            else if (choice == 2)
            {
                Square();
            }
            else if (choice == 3)
            {
                Rectangle();
            }
        }

        static void Num2()
        {
            Console.WriteLine("*****MIKKO'S CALCULATOR*****");
            Console.WriteLine("Calculator");
            Console.WriteLine("1. Add");
            Console.WriteLine("2. Subtract");
            Console.WriteLine("3. Multiply");
            Console.WriteLine("4. Divide");
            Console.Write("Enter choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 1)
            {
                Add();
            }
            if (choice == 2)
            {
                Subtract();
            }
            if (choice == 3)
            {
                Multiply();
            }
            if (choice == 4)
            {
                Divide();
            }

            static void Add()
            {
                Console.Write("Enter Num1: ");
                decimal num1 = Convert.ToDecimal(Console.ReadLine());
                Console.Write("Enter Num2: ");
                decimal num2 = Convert.ToDecimal(Console.ReadLine());
                IOperations adder = new Adder();
                adder.Compute(num1, num2);
                Main();
            }

            static void Subtract()
            {
                Console.Write("Enter Num1: ");
                decimal num1 = Convert.ToDecimal(Console.ReadLine());
                Console.Write("Enter Num2: ");
                decimal num2 = Convert.ToDecimal(Console.ReadLine());
                IOperations substracter = new Substracter();
                substracter.Compute(num1, num2);
                Main();
            }

            static void Multiply()
            {
                Console.Write("Enter Num1: ");
                decimal num1 = Convert.ToDecimal(Console.ReadLine());
                Console.Write("Enter Num2: ");
                decimal num2 = Convert.ToDecimal(Console.ReadLine());
                IOperations multiplier = new Multiplier();
                multiplier.Compute(num1, num2);
                Main();
            }

            static void Divide()
            {
                Console.Write("Enter Num1: ");
                decimal num1 = Convert.ToDecimal(Console.ReadLine());
                Console.Write("Enter Num2: ");
                decimal num2 = Convert.ToDecimal(Console.ReadLine());
                IOperations divider = new Divider();
                divider.Compute(num1, num2);
                Main();
            }
        }
            static void Main()
        {
            //Num1();
            Num2();
        }
    }
}
