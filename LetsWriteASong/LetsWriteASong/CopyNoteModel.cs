using System.IO;

namespace LetsWriteASong
{
    public class CopyNoteModel
    {
        public CopyNoteModel(string note, string NewFolder)
        {
            //todo have the sourcefile path generated dinamicly
            var sourcefile = ($@"C:\Users\ASUS\source\repos\LetsWriteASong\LetsWriteASong\Models\{note}.stl");
            var destfile = ($@"{NewFolder}\{note}.stl");

            File.Copy(sourcefile, destfile, true);
        }
    }
}
