using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPControlApplication
{
    class MovieFile : ImageFile
    {
        private readonly string fileDuration;

        public MovieFile(string fileName, 
                            string fileExtension, 
                            string fileSize, 
                            string fileResolution,
                            string fileDuration) : 

                        base(fileName, 
                             fileExtension, 
                             fileSize, 
                             fileResolution)

        {
            this.fileDuration = fileDuration;
        }

        public override void PrintFileData()
        {
            base.PrintFileData();
            Console.WriteLine($"Duration: {this.fileDuration}");
        }
    }
}
