using System;

namespace LetsWriteASong
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Name the folder where you would like to save your music box cylinder model");

            //todo seperate the folder name into its own value.
            var NewFolder = (@"C:\Users\ASUS\desktop\" + Console.ReadLine());
            CreateModelFolder cmf = new CreateModelFolder(NewFolder);

            Console.WriteLine("Select models to add to your 3dprint");
            Console.WriteLine("Dragon, Duck, Robot.");

            SelectAModel sm = new SelectAModel(NewFolder);

            Console.WriteLine("Your music box is now ready.");
            Console.WriteLine("Drag and drop drop all files inside your newly created folder and drop them into the slicer of your choice");

            Console.ReadLine();
        }
    }
}
