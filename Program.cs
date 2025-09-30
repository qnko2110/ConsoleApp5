using System;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle firstRect = new Rectangle();
            firstRect.Input();
            Console.WriteLine("The area is " + firstRect);
            Rectangle secondRect = new Rectangle();
            secondRect.Input();
            Console.WriteLine("The area is" + secondRect);
            Rectangle thirdRect = new Rectangle();
            thirdRect.Input();
            Console.WriteLine("The area is" + thirdRect);
            Triangle firstTria = new Triangle();
            firstTria.Input();
            Console.WriteLine("The area is" + firstTria);
            Triangle secondTria = new Triangle();
            secondTria.Input();
            Console.WriteLine("The area is" + secondTria);
            Triangle thirdTria = new Triangle();
            thirdTria.Input();
            Console.WriteLine("The area is" + thirdTria);
            Circle firstCirc = new Circle();
            firstCirc.Input();
            Console.WriteLine("The area is" + firstCirc);
            Circle secondCirc = new Circle();
            secondCirc.Input();
            Console.WriteLine("The area is" + secondCirc);
            Circle thirdCirc = new Circle();
            thirdCirc.Input();
            Console.WriteLine("The area is" + thirdCirc);
        }
    }
}
class Rectangle
{
    private double height;
    private double width;
   public double Area()
{
    return height* width;
}
    public void Input()
    {
        height = Convert.ToDouble(Console.ReadLine());
        width = Convert.ToDouble(Console.ReadLine());
    }

}
class Triangle
{
    private double side;
    private double height;
   
    public double Area()
    {
        return side * height / 2;
    }
    public void Input()
    {
        side = Convert.ToDouble(Console.ReadLine());
        height = Convert.ToDouble(Console.ReadLine());
    }
}
class Circle
{
    private double radius;
    public double Area()
    {
        return Math.PI * (radius * radius);
    }
    public void Input()
    {
        radius = Convert.ToDouble(Console.ReadLine());
    }
}
