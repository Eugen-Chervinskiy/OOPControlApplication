﻿using System;
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
            string size = GetSize(text);
            string fileName = "";
            for (int i = text.IndexOf(':'); i < text.IndexOf(size); i++)
            {
                if (char.IsLetterOrDigit(text[i]) || char.IsPunctuation(text[i]))
                {
                    fileName += text[i];
                }
            }
            return fileName.Trim(new Char[] { ':','(',')'});
        }

        public string GetExtension(string text)
        {
            string fileName = GetFileName(text);
            string extension = "";
            for (int i = fileName.LastIndexOf('.'); i < fileName.Length; i++)
            {
                extension += fileName[i];
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
            string size = GetSize(text);
            string resolution = "";
            for (int i = text.IndexOf(size)+size.Length; i < text.Length; i++)
            {
                if (char.IsDigit(text[i]) || text[i].Equals('х'))
                {
                    if (text[i].Equals(';'))
                    {
                        break;
                    }
                    resolution += text[i];
                    
                }
            }
            return resolution;
        }

        public string GetDuration(string text)
        {
            string duration = "";
            for (int i = text.LastIndexOf(';'); i < text.Length; i++)
            {
                if (char.IsDigit(text[i]) || char.IsLetter(text[i]))
                {
                    duration += text[i];
                }
            }
            return duration;
        }
    }
}
