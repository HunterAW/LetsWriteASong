using System;
using System.IO;
using System.Collections.Generic;
using System.Text;

namespace LetsWriteASong
{
    public class CopyNoteModel
    {
        public CopyNoteModel(string note, string destfolder)
        {
            var sourcefile = (@"C:\Users\ASUS\source\repos\LetsWriteASong\LetsWriteASong\Models" + note);
            var destfile = (destfolder + note);

            File.Copy(sourcefile, destfile, true);
            
        }
    }
}
