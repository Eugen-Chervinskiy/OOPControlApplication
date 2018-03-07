using System;


namespace OOPControlApplication
{
    public abstract class File
    {
        
        protected readonly string fileName;
        protected readonly string fileExtension;
        protected readonly string fileSize;
        public abstract string FileCategory { get; }
        
        protected File(string fileName,string fileExtension,string fileSize)
        {
            this.fileName = fileName;
            this.fileExtension = fileExtension;
            this.fileSize = fileSize;
        }

        public virtual void PrintFileData()
        {
            Console.WriteLine($"\r\nFile Name: {this.fileName}\r\n" +
                $"Extension: {this.fileExtension}\r\n" +
                $"Size:{this.fileSize}");
            
        }

    }
}
