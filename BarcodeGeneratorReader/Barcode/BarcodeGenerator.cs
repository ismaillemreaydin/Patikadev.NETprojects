using System.Drawing;
using ZXing;

namespace BarcodeGeneratorReader
{
    public class BarcodeGenerator
    {
        public void GenerateBarcode(string text, string filePath)
        {
            var writer = new BarcodeWriter
            {
                Format = BarcodeFormat.CODE_128,
                Options = new ZXing.Common.EncodingOptions
                {
                    Width = 300,
                    Height = 150
                }
            };

            using (var bitmap = writer.Write(text))
            {
                bitmap.Save(filePath); // Barkod resmi kaydediliyor
            }
        }
    }
}

