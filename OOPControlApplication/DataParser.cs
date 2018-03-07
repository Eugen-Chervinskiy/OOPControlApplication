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

        public string GetFileName(string text)
        {
            string fileName = "";
            return fileName;
        }

        public string GetExtension(string text)
        {
            string extension = "";
            return extension;
        }

        public string GetSize(string text)
        {
            string size = "";
            return size;
        }

        public string GetResolution(string text)
        {
            string resolution = "";
            return resolution;
        }

        public string GetDuration(string text)
        {
            string duration = "";
            return duration;
        }
    }
}
