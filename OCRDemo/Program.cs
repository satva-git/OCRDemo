using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IronOcr;
namespace OCRDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = "F:\\Demo\\OCRDemo\\OCRDemo\\Images\\Hospital3.jpg";
           //var path= AppContext.BaseDirectory+ "Images\\Hospital3.jpg";
            var Ocr = new IronTesseract();
            using (var Input = new OcrInput(path))
            {
                // Input.Deskew();  // use if image not straight
                // Input.DeNoise(); // use if image contains digital noise
                var Result = Ocr.Read(Input);
                Console.WriteLine(Result.Text);
            }
        }
    }
}
