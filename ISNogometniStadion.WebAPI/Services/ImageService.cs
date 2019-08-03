using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Drawing;
using System.IO;

namespace ISNogometniStadion.WebAPI.Services
{
    public class ImageService : IImageService
    {
        public Image BytesToImage(byte[] arr)
        {
            MemoryStream ms = new MemoryStream(arr);
            return Image.FromStream(ms);
        }

        public Image GetNoImage()
        {
            var filename = "C:\\Users\\anton\\Desktop\\RSII\\slike\\noimage.jpg";
            return Image.FromFile(filename);
        }

        public byte[] ImageToBytes(Image img)
        {
            Image.GetThumbnailImageAbort myCallback = new Image.GetThumbnailImageAbort(ThumbnailCallback);

            Image mythumb = img.GetThumbnailImage(100, 100, myCallback, IntPtr.Zero);
            var ms = new MemoryStream();
            mythumb.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            return ms.ToArray();
        }

        public Image ImageToThumbnail(Image image)
        {
            Image.GetThumbnailImageAbort myCallback = new Image.GetThumbnailImageAbort(ThumbnailCallback);
            Image mythumb = image.GetThumbnailImage(100, 100, myCallback, IntPtr.Zero);
            return mythumb;
        }

        public bool ThumbnailCallback()
        {
            return false;
        }
    }
}
