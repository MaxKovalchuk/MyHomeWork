using System;

class Shapes
{
    static void Main()
    {
        int key;
        Console.WriteLine("1 - Circle; 2 - Rectangle; 3 - Rectangle; 0 - Exit");
        do
        {
            key = Convert.ToInt32(Console.ReadLine());

            switch (key)
            {
                case 1:
                    Console.WriteLine("Info about the circe :");
                    Circle circle = new Circle(7);
                    circle.getInfo(); 
                    break;
                case 2:
                    Console.WriteLine("Info about the rectangle :");
                    Rectangle rectangle = new Rectangle(8, 8);
                    rectangle.getInfo();
                    break;
                case 3:
                    Console.WriteLine("Info about the triangle :");
                    Triangle triangle = new Triangle(10, 6, 6);
                    triangle.getInfo();
                    break;
            }

        } while (key != 0);

        Console.ReadKey();
    }
}

class Shape
{
    Random rnd = new Random();
    private string[] colors = new string[] {"green", "gray", "pink", "black", "purple",
        "white", "red", "yellow", "brown", "blue", };
    private string name;
    private int perimeter;
    private double area;
    private string color;

    public void setColor()
    {
        color = colors[rnd.Next(0, 10)];
    }
    public string getColor()
    {
        return color;
    }
    public void setName(string name)
    {
        this.name = name;
    }

    public void setPerimeter(int perimeter)
    {
        this.perimeter = perimeter;
    }
    public string getName()
    {
        return name;
    }
    public int getPerimeter()
    {
        return perimeter;
    }
    public void setArea(double area)
    {
        this.area = area;
    }
    public double getArea()
    {
        return area;
    }
    public void getInfo()
    {
        Console.WriteLine("Perimeter = " + getPerimeter() + "; Area = " + getArea() + "; Name = " +
            getName() + "; Color = " + getColor());
    }
}
class Circle : Shape
{
    private int radius;
    private const double PI = 3.14159265358979;
    //private double circuit;

    public Circle(int radius)
    {
        setArea(2 * PI * Math.Pow(radius, 2));
        setName("circle");
        setColor();
    }
}
class Triangle : Shape
{
    private int side1;
    private int side2;
    private int side3;

    public Triangle(int side1, int side2, int side3)
    {
        setPerimeter(side1 + side2 + side3);
        setColor();
        setArea(Math.Sqrt(getPerimeter() / 2 * (getPerimeter() - side1) * (getPerimeter() - side2) * (getPerimeter() - side3)));
        if (side1 == side2 & side2 == side3)
        {
            setName("equilateral");
        }
        else if (side1 == side2 & side3 != (side1 & side2) | side1 == side3 & side2 != (side1 & side3) | side2 == side3 & side1 != (side2 & side3))
        {
            setName("isosceles");
        }
        else
        {
            setName("versatile");
        }
    }

}
class Rectangle : Shape
{
    private int width;
    private int lenght;

    public Rectangle(int width, int lenght)
    {
        setPerimeter(2 * (width + lenght));
        setArea(width * lenght);
        setName(width == lenght ? "square" : "rectangle");
        setColor();
    }
}
