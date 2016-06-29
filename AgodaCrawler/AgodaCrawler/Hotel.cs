using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgodaCrawler
{
    public class Hotel
    {
        public int HotelID { get; set; }
        public string Ten { get; set; }
        public string DiaChi { get; set; }
        public string KhuVuc { get; set; }
        public int soPhong { get; set; }
        public string diemNX { get; set; }
        public string hUrl { get; set; }
        public List<Comment> comments { get; set; }

        public Hotel()
        {
            HotelID = -1;
            Ten = "";
            DiaChi = "";
            KhuVuc = "";
            soPhong = -1;
            diemNX = "";
            hUrl = "";
            comments = new List<Comment>() ;
        }
    }
}
