using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgodaCrawler
{
    public class Comment
    {
        public int HotelID { get; set; }
        public float diem { get; set; }
        public string tenUser {get;set;}
        public string quoctichUser { get; set; }
        public string thoigianNX { get; set; }
        public string titleNX { get; set; }
        public string noidungNX { get; set; }

        public Comment ()
        {
            HotelID = -1;
            diem = -1;
            tenUser = "Anymous";
            quoctichUser = "None";
            thoigianNX = "1/1/1900";
            titleNX = "";
            noidungNX = "";
        }
    }
}
