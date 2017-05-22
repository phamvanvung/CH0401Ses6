using System;

namespace CH0401Ses6Shapes
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //Shape[] shapes = new Shape[] {
            //    new Circle("Circle 1"),
            //    new Hexagon("Hexagon 1"),
            //    new Circle("Circle 2")
            //};
            //foreach (Shape item in shapes)
            //{
            //    item.Draw();
            //}
            //         //Advanced from here down
            //         Shape s = new Circle("Circle 1");

            //         //Circle c = s;//Error;
            //         //But I do know that the shape is a circle
            //         Circle c = (Circle)s;//Type casting
            //         c.Draw();
            //         c.PrintRadius();
            //         s = new Hexagon("Hexagon 1");
            //         try{
            //             Circle c2 = (Circle)s;//Run-time error    
            //}catch(Exception ex){
            //             Console.WriteLine(ex.Message);
            //         }
            //         //Check
            //         if(s is Circle){
            //             c = (Circle)s;
            //             Console.WriteLine("Shape is a circle");
            //             c.Draw();
            //         }
            //         if(s is Hexagon){
            //             Hexagon h = (Hexagon)s;
            //             Console.WriteLine("Shape is a hexagon");
            //             h.Draw();
            //         }
            ////as operator
            ////returns the hexagon if s is a hexagon
            //         //returns null if the shape is not a hexagon
            //Hexagon h1 = s as Hexagon;
            ////if(h1!=null){
            ////    h1.Draw();
            ////}
            //h1?.Draw();//if h1 is not null, call to draw

            //Test the interface
            IPointy[] pointyShapes = new IPointy[] { 
                new Hexagon("Hexagon1"),
                new Triangle("Triangle1"),
                new Hexagon("Hexagon2")
            };
            foreach (IPointy item in pointyShapes)
            {
                item.PrintPoints();
                //item.Draw();//error => because it doesn't belong to IPointy
            }
        }
    }
}
