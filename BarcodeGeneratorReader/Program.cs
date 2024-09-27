using System;

namespace BarcodeGeneratorReader
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Barkod Üretici ve Okuyucu Uygulamasına Hoş Geldiniz!");

            // Barkod üret
            var barcodeGenerator = new BarcodeGenerator();
            var barcodeText = "012345678"; // Üretilen barkod metni
            barcodeGenerator.GenerateBarcode(barcodeText, "Data/barcodes.png");
            Console.WriteLine("Barkod oluşturuldu ve kaydedildi: " + barcodeText);

            // Barkod oku
            var barcodeReader = new BarcodeReader();
            var readBarcode = barcodeReader.ReadBarcode("Data/barcodes.png");
            Console.WriteLine("Okunan Barkod: " + readBarcode);
        }
    }
}
