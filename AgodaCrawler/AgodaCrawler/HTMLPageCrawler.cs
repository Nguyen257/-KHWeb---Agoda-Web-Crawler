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
using Newtonsoft.Json;
namespace AgodaCrawler
{
    public class HTMLPageCrawler
    {
        #region KhaiBao
        List<string> Country;
        
        #endregion

        #region Ham
        public static async Task getAll()
        {
            /*
            string url = "http://www.agoda.com/pages/agoda/default/DestinationSearchResult.aspx?asq=R59JjboIpVfcDQ4ZOhOQF%2fXhuV7qgWrOGhAIRt9rCeZCOCRHGUSLUCaWZNmY%2f095%2fUweJaVLoDKSEIlINiGTn7yFvSKKT5yw0Na0K%2fOmIw7V%2fi0y0KRQ5wboBBIWaS5i1cjxyHhOIsGFMTDgt%2fniU8obKTbI2JDKMi1VjLNKe4w%3d&city=2758&cid=-221,-221&tick=636020451244&pagetypeid=103&origin=VN&cid=-221&htmlLanguage=en-us&checkIn=2016-6-21&checkOut=2016-6-22&los=1&rooms=1&adults=1&children=0&isFromSearchBox=true";
            HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
            HtmlWeb hw = new HtmlWeb();
            doc = hw.Load(url);

            string Content = doc.DocumentNode.InnerHtml;
            System.IO.Directory.CreateDirectory("Output");
            System.IO.File.WriteAllText(@".\Output\hotelpage.html", Content);
            */
            
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://www.agoda.com/");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpContent a ;
                
                string json = "{\"SearchMessageID\":\"e7e8366d-1ffc-4ed6-84c1-7eaf2f3e4abe\",\"SearchType\":1,\"ObjectID\":0,\"Filters\":{\"HotelName\":null,\"PriceRange\":{\"Min\":0,\"Max\":0},\"StarRating\":null,\"Facilities\":null,\"AccomodationType\":null,\"Areas\":null,\"ReviewScores\":null,\"ReviewScoreMin\":0,\"Size\":0},\"RateplanIDs\":[1,6],\"TotalHotels\":738,\"PlatformID\":1001,\"CurrentDate\":\"2016-06-21T09:47:19.0850761+07:00\",\"SearchID\":991110621094719085,\"CityId\":2758,\"Latitude\":0.0,\"Longitude\":0.0,\"Radius\":0.0,\"PageNumber\":1,\"PageSize\":30,\"SortType\":0,\"SortByASD\":false,\"ReviewTravelerType\":0,\"PointsMaxProgramId\":0,\"PollTimes\":0,\"CityName\":\"Hanoi\",\"ObjectName\":\"Hanoi\",\"CountryName\":\"Vietnam\",\"CountryId\":38,\"IsAllowYesterdaySearch\":true,\"CultureInfo\":\"en-US\",\"UnavailableHotelID\":0,\"IsEnableAPS\":false,\"AdditionalExperiments\":{\"PRIUS\":1008617},\"SeletedHotelId\":0,\"HasFilter\":false,\"LandingParameters\":{\"HeaderBannerUrl\":null,\"FooterBannerUrl\":null,\"SelectedHotelId\":0,\"LandingCityID\":2758},\"IsSave\":true,\"NewSSRSearchType\":0,\"MapType\":1,\"Adults\":1,\"Children\":0,\"Rooms\":1,\"CheckIn\":\"2016-06-21T00:00:00\",\"LengthOfStay\":1,\"Text\":\"Hanoi\"}";
                // HTTP POST
                HttpResponseMessage response ;

                response =await client.PostAsJsonAsync("api/en-us/Main/GetSearchResultList",json);

                if (response.IsSuccessStatusCode)
                {
                    string outputJson = response.Content.ReadAsStringAsync().Result;

                    string path = @".\Output\";
                    System.IO.File.WriteAllText(path+"11.txt", outputJson);
                
                }
            }
        }

        #endregion
    }
}
