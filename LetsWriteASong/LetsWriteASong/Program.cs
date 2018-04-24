using System;

namespace LetsWriteASong
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Name the folder where you would like to save your music box cylinder model");
            var newFolder = Console.ReadLine();
            CreateModelFolder cmf = new CreateModelFolder(newFolder);

            Console.WriteLine("Select models to add to your 3dprint");
            Console.WriteLine("Dragon, Duck, Robot.");

            Console.ReadLine();
        }
    }
}
