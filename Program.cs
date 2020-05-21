using System;

namespace QRCodeGeneratorTest
{
    class Program
    {
        static void Main(string[] args)
        {
            string qrtext = Console.ReadLine();
            QRCodeUtil.GenerateFile(qrtext, "qrcodes/qrc.png");
        }
    }
}
