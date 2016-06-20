using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;
using System.Windows.Forms;

namespace AgodaCrawler
{
    public class HTMLParser
    {
        #region KhaiBao
        public Hotel ht { get; set; }
        #endregion

        #region HotelInfo
        public void getHotelInfo(string url)
        {
            ht = new Hotel();

            //Lay Ten, Diachi va HotelID
            HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
            HtmlWeb hw = new HtmlWeb();
            doc = hw.Load(url);

            try
            {
                HtmlNode Ten = doc.DocumentNode.SelectSingleNode("//h1[@id=\"hotelname\"]");
                ht.Ten = Ten.InnerText.Trim();
                HtmlNode DiaChi = doc.DocumentNode.SelectSingleNode("//a[@class='hotel-map']");
                ht.DiaChi = DiaChi.InnerText.Trim();
                HtmlNode KhuVuc = doc.DocumentNode.SelectSingleNode("//span[@data-selenium='hotel-area-footer']");
                ht.KhuVuc = KhuVuc.InnerText.Trim();
                try
                {
                    HtmlNode SoPhong = doc.DocumentNode.SelectSingleNode("//span[@data-selenium='number-of-room-footer']");
                    ht.soPhong = Int32.Parse(SoPhong.InnerText.Trim());
                }
                catch
                {
                    ht.soPhong = -1;
                }
                try
                {
                    HtmlNode diem = doc.DocumentNode.SelectSingleNode("//a[@class='rating']");
                    ht.diemNX = diem.InnerText.Trim();
                }
                catch
                {
                    ht.diemNX = "";
                }

                #region getHotelID
                HtmlNode hotelid = doc.DocumentNode.SelectSingleNode("//a[@class='hotel-map']");
                string strID = hotelid.Attributes["data-url"].Value;
                string[] strsep = new string[] { "HotelId=", "&amp;CityId" };
                string[] strSps = strID.Split(strsep, StringSplitOptions.None);

                ht.HotelID = Int32.Parse(strSps[1]);
                getHotelComments();
                #endregion
            }
            catch (Exception ex)
            {
                
            }
        }
        #endregion

        #region HotelComments
        public void getHotelComments()
        {

            //https://www.agoda.com/NewSite/vi-vn/Review/ReviewComments?hotelId=10972&providerId=332&demographicId=0&page=1&pageSize=10&sorting=1&isReviewPage=false
            string urlNX = string.Format("https://www.agoda.com/NewSite/vi-vn/Review/ReviewComments?hotelId={0}&providerId=332&demographicId=0&page=1&pageSize=20000&sorting=1&isReviewPage=false", ht.HotelID);
            HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
            HtmlWeb hw = new HtmlWeb();
            doc = hw.Load(urlNX);

            try
            {
                HtmlNodeCollection lstNX = doc.DocumentNode.SelectNodes("//div[@class='sub-section review']");
                if (lstNX != null)
                {
                    foreach (var v in lstNX)
                    {
                        Comment cm = new Comment();
                        cm.HotelID = ht.HotelID;
                        try
                        {

                            cm.diem = float.Parse(v.SelectSingleNode(".//span[@class='review-score']").InnerText);
                            cm.tenUser = v.SelectSingleNode(".//span[@name='reviewer-name']").InnerText.Trim();
                            cm.quoctichUser = v.SelectSingleNode(".//span[@name='reviewer-country']").InnerText.Trim();
                            cm.thoigianNX = v.SelectSingleNode(".//span[@name='reviewdate']").InnerText.Trim();
                            if (v.SelectSingleNode(".//div[@name='review-title']") != null)
                            {
                                cm.titleNX = v.SelectSingleNode(".//div[@name='review-title']").InnerText.Trim();
                            }
                            if (v.SelectSingleNode(".//div[@class='comment-detail']") != null)
                            {
                                cm.noidungNX = v.SelectSingleNode(".//div[@class='comment-detail']").InnerText.Trim();
                            }

                        }
                        catch (Exception ex)
                        {
                            
                        }
                        ht.comments.Add(cm);
                    }
                }
            }
            catch(Exception ex)
            {
               
            }

        }
        #endregion
    }
}
