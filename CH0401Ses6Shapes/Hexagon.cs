using System;
namespace CH0401Ses6Shapes
{
    public class Hexagon: Shape, IPointy
    {
        public Hexagon()
        {
        }
        public Hexagon(string name): base(name)
        {
        }

        public override void Draw()
        {
            Console.WriteLine("Drawing {0} Hexagon", PetName);
        }
        //IPointy implementation
		public int Points
		{
			get
			{
				return 6;
			}
		}
        public void PrintPoints()
        {
            Console.WriteLine("Hexagon has 6 points");
        }
    }
}
