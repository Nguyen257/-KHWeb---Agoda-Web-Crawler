using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;
using System.Windows.Forms;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web;
using System.Web.Script.Serialization;
using Newtonsoft.Json;
using System.Net;
using System.IO;
using System.Collections.Specialized;
namespace AgodaCrawler
{
    public class HTMLPageCrawler
    {
        #region KhaiBao
        string strJson { get; set; }
        public int check { get; set; }
        public int numberHotel { get; set; }
        public List<string> listCityID { get; set; }
        #endregion
        public HTMLPageCrawler()
        {
            check = 0;
            strJson = "";
            numberHotel = 0;
            listCityID = null;
        }
        #region Ham
        public async Task getHotelID(int CityID)
        {

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://www.agoda.com/");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                string json = "{\"SearchType\":1,\"PlatformID\":1001,\"PageNumber\":0,\"PageSize\":10000,\"CityId\":"+CityID.ToString() + ",\"Adults\":2,\"Children\":0,\"Rooms\":1,\"CheckIn\":\"2016-06-23T00:00:00\",\"LengthOfStay\":2}";
                 var jObj = JsonConvert.DeserializeObject(json) as Object;
               
                var  response = await client.PostAsJsonAsync("api/en-us/Main/GetSearchResultList",jObj);

                if (response.IsSuccessStatusCode)
                {
                    string outputJson = response.Content.ReadAsStringAsync().Result;
                    strJson = outputJson;
                    tachHotelURL();
                }
                else { getHotelID(CityID); }
            }

            
        }

        #endregion


        public void tachHotelURL ()
        {

            List<string> temp = strJson.Split(new string[] { "\"TotalFilteredHotels\":", ",\"FilteredHotelIDs",
                "HotelID\":", ",\"EnglishHotelName\":\"","\",\"TranslatedHotelName",
                "\"HotelUrl\":\"","\",\"Distance" }, StringSplitOptions.None).ToList();
            numberHotel = Int32.Parse(temp[1]);

            //string strURL = "";
            
            for (int i = 3; i < 5*(numberHotel+1); i=i+5)
            {
                string strout = temp[i] + ":Name:" + temp[i + 1] + ":Url:" + temp[i + 3] + ";\n";
                //strURL+="http://www.agoda.com" + temp[i] +"\n";
                System.IO.File.AppendAllText("./Input/HotelID.txt", strout);

            }
            
            /*
            var json = JsonConvert.DeserializeObject<JsonAgodaHotel>(strJson) as JsonAgodaHotel;
            foreach (var v in json.ResultList)
            {
                System.IO.File.AppendAllText("./Input/HotelID.txt", v.HotelID.ToString());
            }*/
        }


       

        public void getCountrySearch()
        {
            string strWorld = "https://www.agoda.com/world.html";
            HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
            HtmlWeb hw = new HtmlWeb();
            doc = hw.Load(strWorld);

            try
            {
                HtmlNodeCollection nodes = doc.DocumentNode.SelectNodes("//a[@data-selenium='country-link']");
                if(nodes!=null)
                {
                    //listcountry = new List<string>();
                    foreach (var v in nodes)
                    {
                        //listcountry.Add("https://www.agoda.com" + v.Attributes["href"].Value);
                        System.IO.File.AppendAllText("./Input/CountryLink.txt", "https://www.agoda.com" + v.Attributes["href"].Value + "\n");
                    }
                        
                }
                
            }
            catch
            { }
        }

        public void getRegionLink(RichTextBox output)
        {
            string pathCountry = @"./Input/CountryLink.txt";
            if (File.Exists(pathCountry))
            {
                List<string> lCountryLink = File.ReadLines(pathCountry).ToList<string>();
                foreach (var strURL in lCountryLink)
                {
                    
                    HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
                    HtmlWeb hw = new HtmlWeb();
                    doc = hw.Load(strURL);

                    try
                    {
                        HtmlNodeCollection nodes = doc.DocumentNode.SelectNodes("//li[@class='sprite']");
                        if (nodes != null)
                        {
                            //listregion = new List<string>();
                            foreach (var v in nodes)
                            {
                                try
                                {
                                    string str = v.ChildNodes[0].Attributes["href"].Value;
                                    //listregion.Add("https://www.agoda.com" + str);
                                    System.IO.File.AppendAllText("./Input/RegionLink.txt", "https://www.agoda.com" + str + "\n");
                                }
                                catch { }
                            }

                        }
                    }
                    catch
                    {
                       // output.Text = "Lay link Region that bai  \n";
                    }
                   
                }
                output.Text = "Lay link Region thanh cong  \n";
            }
            else
                output.Text = "Lay link Region that bai  \n";
            
        }

        public void getCityLink(RichTextBox output)
        {
            string pathRegion = @"./Input/RegionLink.txt";
            if(File.Exists(pathRegion))
            {
                List<string> lRegionLink = File.ReadLines(pathRegion).ToList<string>();
                foreach(var strURL in lRegionLink )
                //string strURL = "https://www.agoda.com/region/lam-dong-province-vn.html";
                {
                    HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
                    HtmlWeb hw = new HtmlWeb();
                    doc = hw.Load(strURL);

                    try
                    {
                        HtmlNodeCollection nodes = doc.DocumentNode.SelectNodes("//li[@class='sprite']");
                        if (nodes != null)
                        {
                            //listcity = new List<string>();
                            foreach (var v in nodes)
                            {
                                try
                                {
                                    string str = v.ChildNodes[0].Attributes["href"].Value;
                                    //listcity.Add("https://www.agoda.com" + str);
                                    System.IO.File.AppendAllText("./Input/Citylink.txt", "https://www.agoda.com" + str + "\n");
                                    
                                    
                                }
                                catch { 
                                }
                            }
                            //output.Text += "Get thanh cong city link trong : " + strURL + "\n";
                        }
                    }
                    catch
                    {
                        //output.Text += "Load Page that bai \n";
                    }
                }
                output.Text += "Load CityLink thành công   \n";
            }
            else {
                output.Text += "Khong doc duoc File \n";
            }
            
        }

        public void getCityID(RichTextBox output)
        {
            string pathCity = @"./Input/Citylink.txt";
            if (File.Exists(pathCity))
            {
                List<string> lCityLink = File.ReadLines(pathCity).ToList<string>();
                int i = 0;
                listCityID = new List<string>();
                foreach(var strURL in lCityLink)
                {
                    //string strURL = "https://www.agoda.com/city/hoi-an-vn.html";
                    HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
                    HtmlWeb hw = new HtmlWeb();
                    doc = hw.Load(strURL);
                    try
                    {
                        HtmlNode nodes = doc.DocumentNode.SelectSingleNode("//input[@name='CityId']");
                        if (nodes != null)
                        {
                            
                            try
                            {
                                string str = nodes.Attributes["value"].Value;
                                
                                System.IO.File.AppendAllText("./Input/CityID.txt", str + "\n");
                                i++;
                            }
                            catch { }
                            
                            
                        }
                    }
                    catch
                    { }
                    output.Text = "Số CityID thu được : " + i.ToString();
                }
            }
            
            
        }

        public void getAllHotelID(RichTextBox output)
        {
            string pathCityID = @"./Input/CityID.txt";
            if (File.Exists(pathCityID))
            {
                List<string> lCityID_string = File.ReadLines(pathCityID).ToList<string>();

                foreach (var strID in lCityID_string)
                {
                    int cityID = Int32.Parse(strID);
                    
                    getHotelID(cityID);
                }
                output.Text += "Get HotelID thanh cong ";
            }
            else
                output.Text += "Get HotelID that bai "; 
        }
    }
}
