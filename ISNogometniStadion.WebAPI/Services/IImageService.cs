using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Drawing.Imaging;
using System.Drawing;

namespace ISNogometniStadion.WebAPI.Services
{
    public interface IImageService
    {
        byte[] ImageToBytes(Image img);
        Image BytesToImage(byte[] arr);
        Image GetNoImage();
        Image ImageToThumbnail(Image image);
        bool ThumbnailCallback();
    }
}
