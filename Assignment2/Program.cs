using System.ComponentModel.Design;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Xml.Serialization;


namespace Assignment2
{
    class program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle();
            Console.WriteLine("enter the radius");
            circle.radius =Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(circle.GetCircumference);

            
        }
    }

}