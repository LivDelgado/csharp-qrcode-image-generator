using Gma.QrCodeNet.Encoding;
using Gma.QrCodeNet.Encoding.Windows.Render;
using QRCoder;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;

namespace QRCodeGeneratorTest
{
    public static class QRCodeUtil
    {
        public static void GenerateFile_QRCoder(string qrText, int moduleSize, string filePath)
        {
            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCodeData qrCodeData = qrGenerator.CreateQrCode(qrText, QRCodeGenerator.ECCLevel.Q);
            QRCode qrCode = new QRCode(qrCodeData);
            Bitmap qrCodeImage = qrCode.GetGraphic(moduleSize);
            qrCodeImage.Save(filePath, ImageFormat.Png);
        }

        public static void GenerateQRCode(string qrText, int moduleSize, string filePath)
        {
            QrEncoder qrEncoder = new QrEncoder(ErrorCorrectionLevel.Q);
            QrCode qrCode = qrEncoder.Encode(qrText);

            GraphicsRenderer renderer = new GraphicsRenderer(new FixedModuleSize(moduleSize, QuietZoneModules.Two));

            using (MemoryStream stream = new MemoryStream())
            {
                renderer.WriteToStream(qrCode.Matrix, ImageFormat.Png, stream);
                var bitmap = new Bitmap(stream);
                bitmap.Save(filePath, ImageFormat.Png);
            }
        }
    }
}
