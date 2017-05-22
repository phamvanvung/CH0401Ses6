using System;
namespace CH0401Ses6Shapes
{
    public class Circle : Shape
    {
        public Circle()
        {
        }
        public Circle(string name) : base(name)
        {
        }
        public override void Draw()
        {
            Console.WriteLine("Drawing {0} circle.", PetName);
        }
        public void PrintRadius(){
            Console.WriteLine("My radius is 3");
        }

    }
}
