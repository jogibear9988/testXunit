using MimeKit;
using System.IO;

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
            }
        }
    }
}
