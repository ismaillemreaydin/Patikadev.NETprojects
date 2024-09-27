using System.Drawing;
using ZXing;

namespace BarcodeGeneratorReader
{
    public class BarcodeReader
    {
        public string ReadBarcode(string filePath)
        {
            var reader = new BarcodeReader();
            using (var bitmap = (Bitmap)Bitmap.FromFile(filePath))
            {
                var result = reader.Decode(bitmap);
                return result?.Text ?? "Barkod okunamadı!";
            }
        }
    }
}
