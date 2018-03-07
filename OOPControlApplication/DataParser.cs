using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPControlApplication
{
    class DataParser
    {
        private readonly string[] categories = { "Text","Image","Movie"};



        public string GetCategory(string text)
        {
            string category = "";
            return category;
        }

        public string GetFileName()
        {
            string fileName = "";
            return fileName;
        }

        public string GetExtension()
        {
            string extension = "";
            return extension;
        }

        public string GetSize()
        {
            string size = "";
            return size;
        }

        public string GetResolution()
        {
            string resolution = "";
            return resolution;
        }

        public string GetDuration()
        {
            string duration = "";
            return duration;
        }
    }
}
