using System;
using System.IO;
using System.Collections.Generic;
using System.Text;

namespace LetsWriteASong
{
    public class CopyNoteModel
    {
        public CopyNoteModel(string note, string NewFolder)
        {
            var sourcefile = (@"C:\Users\ASUS\source\repos\LetsWriteASong\LetsWriteASong\Models\" + note + ".stl");
            var destfile = (NewFolder + @"\" + note + ".stl");

            File.Copy(sourcefile, destfile, true);
            
        }
    }
}
