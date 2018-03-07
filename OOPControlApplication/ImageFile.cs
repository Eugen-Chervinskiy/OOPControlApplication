using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPControlApplication
{
    class ImageFile : File
    {
        private readonly string fileResolution;
        protected ImageFile(string fileName, 
                            string fileExtension, 
                            string fileSize,
                            string fileResolution) :
            
                          base(fileName, 
                               fileExtension, 
                               fileSize)

        {
            this.fileResolution = fileResolution;
        }

        public override void PrintFileData()
        {
            base.PrintFileData();
        }
    }
}
