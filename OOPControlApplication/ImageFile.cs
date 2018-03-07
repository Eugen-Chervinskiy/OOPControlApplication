using System;


namespace OOPControlApplication
{
    class ImageFile : File
    {
        private readonly string fileResolution;
        public ImageFile(string fileName, 
                            string fileExtension, 
                            string fileSize,
                            string fileResolution) :
            
                          base(fileName, 
                               fileExtension, 
                               fileSize)

        {
            this.fileResolution = fileResolution;
        }

        public override string FileCategory
        {
            get
            {
                return "ImageFile";
            }
        }

        public override void PrintFileData()
        {
            base.PrintFileData();
            Console.WriteLine($"Resolution: {this.fileResolution}");
        }
    }
}
