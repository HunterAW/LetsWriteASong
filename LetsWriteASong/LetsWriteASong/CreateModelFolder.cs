using System;
using System.Collections.Generic;
using System.Text;

namespace LetsWriteASong
{
    public class CreateModelFolder
    {
        public CreateModelFolder(string folder)
        {
            System.IO.Directory.CreateDirectory(@"C:\Users\ASUS\desktop\" + folder);
            Console.WriteLine(folder + "has been created on your desktop");
        }
    }
}
