using System;
using System.Drawing;
using System.IO;

namespace imageThumbnail
{
    class Program
    {
        static void Main(string[] args)
        {
            var filename = @"c:\deletekon\1.png";
            Image image = Image.FromFile(filename);
            Image thumb = image.GetThumbnailImage(image.Width, image.Height, () => false, IntPtr.Zero);
            thumb.Save(Path.ChangeExtension(filename, "thumb"));

        }
    }
}
