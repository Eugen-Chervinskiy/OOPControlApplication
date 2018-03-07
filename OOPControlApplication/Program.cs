using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPControlApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            string dataInput = @"Text:file.txt(6B);Some string content
                                 Image: img.bmp(19MB); 1920х1080
                                 Text:data.txt(12B); Another string
                                 Movie:logan.2017.mkv(19GB); 1920х1080;3h12m
                                 Text:data1.txt(7B); Yet another string
                                 Movie:logan.2017.mkv(19GB); 1920х1080; 2h12m";


            string[] fileData = dataInput.Split('\n');

            DataParser parser = new DataParser();

           
            Console.WriteLine("-------Parser Results--------");

            for (int i = 0; i < fileData.Length; i++)
            {
                parser.CreateData(fileData[i]);
            }
            parser.PrintDataInfo();

            Console.ReadKey();
        }

        
    }
}
