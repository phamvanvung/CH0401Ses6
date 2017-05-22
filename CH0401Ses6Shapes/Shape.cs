using System;
namespace CH0401Ses6Shapes
{
    public abstract class Shape
    {
        public string PetName
        {
            get;
            set;
        }

        public Shape(string name = "PetName")
        {
            PetName = name;
        }

        public abstract void Draw();//{
        //    Console.WriteLine("Draw() in the Shape method");
        //}
    }
}
