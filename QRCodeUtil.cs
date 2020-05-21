using QRCoder;
using System.Drawing;

namespace QRCodeGeneratorTest
{
    public static class QRCodeUtil
    {
        public static void GenerateFile(string qrText, string fileName)
        {
            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCodeData qrCodeData = qrGenerator.CreateQrCode(qrText, QRCodeGenerator.ECCLevel.Q);
            QRCode qrCode = new QRCode(qrCodeData);
            Bitmap qrCodeImage = qrCode.GetGraphic(20);
            qrCodeImage.Save(fileName, System.Drawing.Imaging.ImageFormat.Png);
        }
    }
}
