using DeviceId;
using DeviceId.Encoders;
using DeviceId.Formatters;
using System;
using System.Security.Cryptography;

namespace DeviceFingerprint
{
    class Program
    {
        static void Main(string[] args)
        {
            string deviceId = new DeviceIdBuilder()
                .AddProcessorId()
                .AddMotherboardSerialNumber()
                .UseFormatter(new HashDeviceIdFormatter(() => SHA256.Create(), new Base64UrlByteArrayEncoder()))
                .ToString().ToUpper();
            deviceId = StringUtils.FormatLikeGUID(deviceId.Replace("-",""), 3);

            Console.WriteLine("DeviceID: " + deviceId);

            var fingerprintUtilsID = FingerprintUtils.Value();

            Console.WriteLine("Fingerprint Utils ID: " + fingerprintUtilsID);

            Console.WriteLine(string.Empty);
            Console.WriteLine(string.Empty);
            Console.WriteLine(string.Empty);
            Console.WriteLine("===================================================================================");
            Console.WriteLine("==========================To be used in production !!==============================");
            Console.WriteLine("Program and client unique ID: " + deviceId + "-" +fingerprintUtilsID);
            Console.WriteLine("===================================================================================");

            Console.ReadLine();
        }
    }
}
