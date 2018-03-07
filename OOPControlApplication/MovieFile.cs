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

        protected MovieFile(string fileName, 
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
    }
}
