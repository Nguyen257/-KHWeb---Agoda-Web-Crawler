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
        public List<string> listcity { get; set; }
        public List<string> listcountry { get; set; }
        #endregion
        public HTMLPageCrawler()
        {
            check = 0;
            strJson = "";
            numberHotel = 0;
            listcity = null;
            listcountry = null;
        }
        #region Ham
        public async Task getAll()
        {

            #region aa
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://www.agoda.com/");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                
                string json = "{\"SearchMessageID\":\"4785f6d6-d0ea-4108-bc19-c60c21b6b847\",\"SearchType\":1,\"ObjectID\":0,\"Filters\":{\"HotelName\":null,\"PriceRange\":{\"Min\":0,\"Max\":0},\"StarRating\":null,\"Facilities\":null,\"AccomodationType\":null,\"Areas\":null,\"ReviewScores\":null,\"ReviewScoreMin\":0,\"Size\":0},\"RateplanIDs\":[1,2,6],\"TotalHotels\":343,\"PlatformID\":1001,\"CurrentDate\":\"2016-06-22T20:01:49.547716+07:00\",\"SearchID\":991110622200149547,\"CityId\":16552,\"Latitude\":0.0,\"Longitude\":0.0,\"Radius\":0.0,\"PageNumber\":0,\"PageSize\":10000,\"SortType\":0,\"SortByASD\":false,\"ReviewTravelerType\":0,\"PointsMaxProgramId\":0,\"PollTimes\":0,\"CityName\":\"Hội An\",\"ObjectName\":\"Hội An\",\"CountryName\":\"Việt Nam\",\"CountryId\":38,\"IsAllowYesterdaySearch\":true,\"CultureInfo\":\"vi-VN\",\"UnavailableHotelID\":0,\"IsEnableAPS\":false,\"AdditionalExperiments\":{\"PRIUS\":1008617},\"SeletedHotelId\":0,\"HasFilter\":false,\"LandingParameters\":{\"HeaderBannerUrl\":null,\"FooterBannerUrl\":null,\"SelectedHotelId\":0,\"LandingCityID\":16552},\"IsSave\":true,\"NewSSRSearchType\":0,\"MapType\":1,\"IsShowMobileAppPrice\":false,\"Adults\":2,\"Children\":0,\"Rooms\":1,\"CheckIn\":\"2016-06-23T00:00:00\",\"LengthOfStay\":2,\"Text\":\"Hội An\"}";
                string[] temp = json.Split(new string[] { "TotalHotels\":", ",\"PlatformID\"" }, StringSplitOptions.None);
                numberHotel = Int32.Parse(temp[1]);
                var jObj = JsonConvert.DeserializeObject(json) as Object;
                // HTTP POST
                //HttpResponseMessage response ;

                var  response = await client.PostAsJsonAsync("api/en-us/Main/GetSearchResultList",jObj);

                if (response.IsSuccessStatusCode)
                {
                    string outputJson = response.Content.ReadAsStringAsync().Result;
                    strJson = outputJson;
                    tachHotelURL();
                }
                else { getAll(); }
            }
            #endregion 

            
        }

        #endregion


        public void tachHotelURL ()
        {
            string[] temp = strJson.Split(new string[] {"HotelUrl\":\"","?checkin"},StringSplitOptions.None);
            string strURL = "";
            for (int i = 1; i < 2*numberHotel; i=i+2)
            {
                strURL+="http://www.agoda.com" + temp[i] +"\n";
            }
           // System.IO.File.WriteAllText("./Input/Input.txt", strURL);
            
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
                    listcountry = new List<string>();
                    foreach (var v in nodes)
                    {
                        listcountry.Add("https://www.agoda.com" + v.Attributes["href"].Value);
                    }
                }          
            }
            catch
            { }
        }

        public void getCitySearch()
        {
            string strURL = "https://www.agoda.com/country/vietnam.html";
            HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
            HtmlWeb hw = new HtmlWeb();
            doc = hw.Load(strURL);

            try
            {
                HtmlNodeCollection nodes = doc.DocumentNode.SelectNodes("//li[@class='sprite']");
                if (nodes != null)
                {
                    listcity = new List<string>();
                    foreach (var v in nodes)
                    {
                        try
                        {
                            string str = v.ChildNodes[0].Attributes["href"].Value;
                            listcity.Add("https://www.agoda.com" + str);
                        }
                        catch { }
                    }

                }
            }
            catch
            { }
        }

        public async Task getLinkSearch()
        {
            /*
            string strURL = "https://www.agoda.com/region/lam-dong-province-vn.html";
            using (WebClient client = new WebClient())
            {
                client.Headers.Add("Content-Type", "application/x-www-form-urlencoded");

                byte[] result = client.up(strURL, "POST", new NameValueCollection() 
                { 
                    {}
                });
                string ResultAuthTicket = Encoding.UTF8.GetString(result);
            }*/
        }
    }
}
