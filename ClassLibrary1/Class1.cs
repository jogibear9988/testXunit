using MimeKit;
using MimeKit.Cryptography;

namespace ClassLibrary1
{
    public class Class1
    {
        public void aa()
        {
            using (var ms = new MemoryStream())
            {
                var parser = new MimeParser(ms, MimeFormat.Mbox);
                while (!parser.IsEndOfStream && ms.Length>0)
                {
                    var message = parser.ParseMessage();
                }
                try
                {
                    BouncyCastleCertificateExtensions.GetKeyUsageFlags(new Org.BouncyCastle.X509.X509Certificate((byte[])null));
                }
                catch { }

                var a = Org.BouncyCastle.Crypto.AesUtilities.IsHardwareAccelerated;
            }
        }
    }
}
