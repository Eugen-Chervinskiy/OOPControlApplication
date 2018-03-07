using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPControlApplication
{
    class DataParser
    {
        private readonly string[] categories = { "Text","Image", "Movie" };



        public string GetCategory(string text)
        {
            string category = "";
            for (int i = 0; i < categories.Length; i++)
            {
                if (text.Contains(categories[i]))
                {
                    category += categories[i];
                }
            }
            return category;
        }

        public string GetFileName(string text)
        {
            string fileName = "";
            for (int i = text.IndexOf(':'); i < text.Length; i++)
            {

            }
            return fileName;
        }

        public string GetExtension(string text)
        {
            string extension = "";
            for (int i = 0; i < text.Length; i++)
            {

            }
            return extension;
        }

        public string GetSize(string text)
        {
            string size = "";
            for (int i = text.IndexOf('('); i < text.IndexOf(')'); i++)
            {
                if (char.IsDigit(text[i]) || char.IsUpper(text[i]))
                {
                    size += text[i];
                }
                
            }
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
