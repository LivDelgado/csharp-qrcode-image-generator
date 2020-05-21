using System;
using System.Text;

namespace QRCodeGeneratorTest
{
    class Program
    {
        static void Main(string[] args)
        {
            string qrtext = Console.ReadLine();
            int modules = 10;

            QRCodeUtil.GenerateFile_QRCoder(qrtext, modules, getFilePath());
            QRCodeUtil.GenerateQRCode(qrtext, modules, getFilePath());
        }

        private static string getFilePath()
        {
            StringBuilder filePath = new StringBuilder();
            filePath.Append(@"c:\users\dell\desktop\qrcodes\qrCodeGenerated-");
            filePath.Append(Guid.NewGuid().ToString());
            filePath.Append(".png");
            return filePath.ToString();
        }
    }
}
