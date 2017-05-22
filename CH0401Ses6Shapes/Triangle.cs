using System;
namespace CH0401Ses6Shapes
{
    public class Triangle: Shape, IPointy
    {
        public Triangle(){}
        public Triangle(string name):base(name){}
        //Implementing Draw abstract method from abstract class Shape
        public override void Draw()
        {
            Console.WriteLine("Drawing {0} Triangle", PetName);
        }
        //Implementing the IPointy interface
        public int Points{
            get{
                return 3;
            }
        }
        public void PrintPoints()
        {
            Console.WriteLine("Triangle has 3 points");
        }
    }
}
