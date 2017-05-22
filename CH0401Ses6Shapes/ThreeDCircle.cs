using System;
namespace CH0401Ses6Shapes
{
    public class ThreeDCircle : Circle
    {
        public ThreeDCircle()
        {
        }
        public ThreeDCircle(string name) : base(name)
        {
        }
        public new void Draw()
        {
            Console.WriteLine("Drawing {0} three dimensional circle", PetName);
        }
    }
}
