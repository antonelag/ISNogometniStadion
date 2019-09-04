using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using ISNogometniStadion.Model;
using ISNogometniStadion.Model.Requests;
using ISNogometniStadion.WebAPI.Database;
using System.Drawing.Imaging;
using QRCoder;

namespace ISNogometniStadion.WebAPI.Services
{
    public class UlazniceService : BaseCRUDService<Model.Ulaznica, Model.UlazniceSearchRequest, Database.Ulaznice,UlazniceInsertRequest,UlazniceInsertRequest>
    {
        private readonly ISNogometniStadionContext _context;
        private readonly IMapper _mapper;
        private readonly ImageService imageService = new ImageService();
        public UlazniceService(IMapper mapper, ISNogometniStadionContext context) : base(mapper, context)
        {
            _context = context;
            _mapper = mapper;

        }
        public override List<Ulaznica> Get(UlazniceSearchRequest search)
        {
            var q = _context.Set<Database.Ulaznice>().AsQueryable();

            if (search?.KorisnikID.HasValue==true)
            {
                q = q.Where(s => s.Korisnik.KorisnikID == search.KorisnikID);
            }
            var list = q.ToList();
            return _mapper.Map<List<Ulaznica>>(list);
            
        }
        public override Ulaznica Insert(UlazniceInsertRequest req)
        {
            string number = req.SjedaloID.ToString()+req.UtakmicaID.ToString() + GetVoucherNumber(8);

            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCodeData qrCodeData = qrGenerator.CreateQrCode(number, QRCodeGenerator.ECCLevel.Q);
            QRCode qrCode = new QRCode(qrCodeData);
            Bitmap qrCodeImage = qrCode.GetGraphic(20);
            var bitmapBytes = BitmapToBytes(qrCodeImage);


            //Zen.Barcode.Code128BarcodeDraw barcode = Zen.Barcode.BarcodeDrawFactory.Code128WithChecksum;
            //Image img = barcode.Draw(number, 50);
            
            //byte[] barcodeimg = imageService.ImageToBytes(img);
            req.barcodeimg = bitmapBytes;
            
            return base.Insert(req);
        }
        private static byte[] BitmapToBytes(Bitmap img)
        {
            using (MemoryStream stream = new MemoryStream())
            {
                img.Save(stream, System.Drawing.Imaging.ImageFormat.Png);
                return stream.ToArray();
            }
        }
        private static Random random = new Random();

        public static string GetVoucherNumber(int length)
        {
            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            var result = new string(
                Enumerable.Repeat(chars, length)
                          .Select(s => s[random.Next(s.Length)])
                          .ToArray());

            return result;
        }
    }
}
