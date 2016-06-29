using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace AgodaCrawler
{
    public partial class MainForm : Form
    {
        public List<string> lURL { get; set; }
        public MainForm()
        {
            InitializeComponent();
            if(File.Exists(@"./Input.link.txt"))
            {
                string[] url = File.ReadAllLines(@"./Input/link.txt");
                lURL = new List<string>(url);
            }
        }

        
        public string GetSafeFilename(string filename)
        {

            return Path.GetInvalidFileNameChars().Aggregate(filename, (current, c) => current.Replace(c.ToString(), string.Empty));

        }
        private void btnOutput_Click(object sender, EventArgs e)
        {
            string path = @".\Output\";
            if (Directory.Exists(path))
            {
                System.Diagnostics.Process.Start(path);
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        
        private void button2_Click(object sender, EventArgs e)
        {
            string path = @".\Input\";
            if(Directory.Exists(path))
            {
                System.Diagnostics.Process.Start(path);
                
            }
        }

        
        private void btnCountry_Click(object sender, EventArgs e)
        {
            HTMLPageCrawler cr = new HTMLPageCrawler();
            cr.getCountrySearch();
        }

        private void btnRegion_Click(object sender, EventArgs e)
        {
            HTMLPageCrawler cr = new HTMLPageCrawler();
            cr.getRegionLink(rtxt1);
        }

        private void btnCityL_Click(object sender, EventArgs e)
        {
            HTMLPageCrawler cr = new HTMLPageCrawler();
            cr.getCityLink(rtxt1);
            
        }

        private void btnCityID_Click(object sender, EventArgs e)
        {
            HTMLPageCrawler cr = new HTMLPageCrawler();
            cr.getCityID(rtxt1);
        }

        private void btnHotelID_Click(object sender, EventArgs e)
        {
            HTMLPageCrawler cr = new HTMLPageCrawler();
            cr.getAllHotelID(rtxt1);
        }

        private void btnCrawlerComment_Click(object sender, EventArgs e)
        {
            HTMLParser paCrawler = new HTMLParser();
            paCrawler.getHotelComments();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                
                HTMLParser paCrawler = new HTMLParser();
                Hotel ht = new Hotel();
                ht = paCrawler.PaserHotel(ofd.FileName);
                string strOutput = "";
                strOutput += " Tên Khách sạn : " + ht.Ten + "\n ID của Khách sạn : " + ht.HotelID.ToString() + "\n Đường dẫn của Khách sạn : " + ht.hUrl 
                    +"\n ______________________________________\n";
                foreach(var v in ht.comments)
                {
                    strOutput += " Số Điểm đánh giá : " + v.diem.ToString() + "\t - Tên Người đánh giá : " + v.tenUser
                        + "\n Quốc tịch của User : " + v.quoctichUser + "\t Thời gian đánh giá : " + v.thoigianNX
                        + "\n Title của Nhận xét : " + v.titleNX
                        + "\n Comment-Positive : " + v.commentText
                        + "\n Nội dung comment " + v.noidungNX + "\n ______________________________________\n";
                }
                rtxt1.Text = strOutput ;
            }
        }


        
    }
}
