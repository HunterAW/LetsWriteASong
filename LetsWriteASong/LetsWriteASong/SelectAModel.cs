﻿using System;
using System.IO;
using System.Collections.Generic;
using System.Text;

namespace LetsWriteASong
{
    class SelectAModel
    {
         public void Write()
        {
            var song = Console.ReadLine();

            string[] notes = song.Split(' ');

            foreach(var note in notes)
            {
                CopyNoteModel cnm = new CopyNoteModel(note, "");
            }
        }
    }
}
