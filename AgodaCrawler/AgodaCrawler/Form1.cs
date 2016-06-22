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

        private void btnCrawler_Click(object sender, EventArgs e)
        {
            if (lURL.Count==0)
            {
                lURL.Add("http://www.agoda.com/vi-vn/hotel-majestic-saigon/hotel/ho-chi-minh-city-vn.html");
            }
            foreach (var url in lURL)
            {
                
                HTMLParser pa = new HTMLParser();
                pa.getHotelInfo(url);
                string output = "Hotel-Name: " + pa.ht.Ten + "            Hotel-Address: " + pa.ht.DiaChi + "\n";
                foreach (var v in pa.ht.comments)
                {
                    try
                    {
                        output += v.diem + "  " + v.tenUser + "\t" + v.quoctichUser + "\t" + v.thoigianNX + "\t" + v.titleNX + "\n" + v.noidungNX + "\n ______________________________________________________________________ \n";
                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }
                }
                if(!Directory.Exists(@"./Output")) Directory.CreateDirectory("Output");

                string outpath = @"./Output/" + GetSafeFilename(pa.ht.HotelID.ToString()).Trim() + ".txt";

                File.WriteAllText(outpath,output);
               
            }
            System.Diagnostics.Process.Start(@".\Output\");
            /*
            rtxt1.Text = output;
            lbName.Text = pa.ht.Ten;
            lbDiaChi.Text = pa.ht.DiaChi;
            lbDiem.Text = pa.ht.diemNX;*/
        }
        public string GetSafeFilename(string filename)
        {

            return Path.GetInvalidFileNameChars().Aggregate(filename, (current, c) => current.Replace(c.ToString(), string.Empty));

        }
        private void btnOutput_Click(object sender, EventArgs e)
        {
            HTMLPageCrawler cr = new HTMLPageCrawler();
            cr.getAll();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            HTMLPageCrawler cr = new HTMLPageCrawler();
            cr.getLinkSearch();
        }
    }
}
