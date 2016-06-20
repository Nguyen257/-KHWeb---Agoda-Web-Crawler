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

namespace AgodaCrawler
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnCrawler_Click(object sender, EventArgs e)
        {

            string url;
            if (string.IsNullOrEmpty(txtUrl.Text))
            {
                url = "http://www.agoda.com/vi-vn/hotel-majestic-saigon/hotel/ho-chi-minh-city-vn.html";
            }
            else url = txtUrl.Text;

            Stopwatch st = new Stopwatch();
            st.Start();
            HTMLParser pa = new HTMLParser();
            pa.getHotelInfo(url);
            st.Stop();
            MessageBox.Show(st.Elapsed.ToString());
            string output = "";
            foreach (var v in pa.ht.comments)
            {
                try
                {
                    output += v.diem + "  " + v.tenUser + "\t" + v.quoctichUser + "\t" + v.thoigianNX + "\t" + v.titleNX + "\n" + v.noidungNX + "\n ______________________________________________________________________ \n";
                }
                catch(Exception ex)
                {
                    throw ex;
                }
            }
            rtxt1.Text = output;
            lbName.Text = pa.ht.Ten;
            lbDiaChi.Text = pa.ht.DiaChi;
            lbDiem.Text = pa.ht.diemNX;
        }

        private void btnOutput_Click(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
