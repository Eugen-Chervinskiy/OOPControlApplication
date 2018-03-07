﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPControlApplication
{
    class TextFile : File
    {
        private readonly string fielDescription;
        public TextFile(string fileName, 
                           string fileExtension, 
                           string fileSize,
                           string fileDescription) :

                        base(fileName, 
                            fileExtension, 
                            fileSize)
        {
            this.fielDescription = fileDescription;
        }

        public override void PrintFileData()
        {
            base.PrintFileData();
            Console.WriteLine($"Description: {this.fielDescription}\r\n");
        }
    }
}
