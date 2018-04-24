using System;
using System.Collections.Generic;
using System.Text;

namespace LetsWriteASong
{
    public class CreateModelFolder
    {
        public CreateModelFolder(string NewFolder)
        {
            //todo: check to make sure the file does not currently excist.
            //todo: add relevent try catches.
            System.IO.Directory.CreateDirectory(NewFolder);
            Console.WriteLine(NewFolder + "has been created on your desktop");
        }
    }
}
