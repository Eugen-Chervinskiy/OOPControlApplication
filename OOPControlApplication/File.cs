using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPControlApplication
{
    public class File
    {
        protected readonly string fileCategory;
        protected readonly string fileName;
        protected readonly string fileExtension;
        protected readonly string fileSize;
        
        protected File(string fileName,string fileExtension,string fileSize)
        {
            this.fileName = fileName;
            this.fileExtension = fileExtension;
            this.fileSize = fileSize;
        }

        public virtual void PrintFileData()
        {
            Console.WriteLine();
        }

    }
}
