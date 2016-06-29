using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgodaCrawler
{

    public class MainPhoto
    {
        public int TypeId { get; set; }
        public string Location { get; set; }
        public string Title { get; set; }
        public int RowNum { get; set; }
        public int HasHDImage { get; set; }
        public bool IsDefault { get; set; }
        public int Height { get; set; }
        public int Width { get; set; }
        public int ImageType { get; set; }
        public bool IsMainImage { get; set; }
    }

    public class Tax
    {
        public int id { get; set; }
        public string t { get; set; }
        public double v { get; set; }
        public int o { get; set; }
    }

    public class PriceSummary
    {
        public double SellInclusive { get; set; }
        public double SellExclusive { get; set; }
        public double NetInclusive { get; set; }
        public List<Tax> Taxes { get; set; }
        public int RatePlanID { get; set; }
        public int PromotionValue { get; set; }
        public string CancellationCode { get; set; }
        public int LastRooms { get; set; }
        public int RoomTypeID { get; set; }
        public bool IsBreakfastIncluded { get; set; }
    }

    public class ResultList
    {
        public int HotelID { get; set; }
        public string EnglishHotelName { get; set; }
        public string TranslatedHotelName { get; set; }
        public object ImgPath { get; set; }
        public int SearchType { get; set; }
        public string AreaName { get; set; }
        public string CityName { get; set; }
        public object LandmarkName { get; set; }
        public string ObjectName { get; set; }
        public int AreaId { get; set; }
        public int CityId { get; set; }
        public object CountryName { get; set; }
        public int CountryId { get; set; }
        public int DmcId { get; set; }
        public int RoomDmcId { get; set; }
        public double StarRating { get; set; }
        public string StarRatingCss { get; set; }
        public double ReviewScore { get; set; }
        public string ReviewScoreFormatted { get; set; }
        public int ReviewScoreASD { get; set; }
        public int NumberOfReview { get; set; }
        public object NumberOfReviewASD { get; set; }
        public int NumberOfLanguageReview { get; set; }
        public bool FreeWifi { get; set; }
        public int LastBooking { get; set; }
        public string LastBookingText { get; set; }
        public int PeopleLooking { get; set; }
        public bool IsCloggy { get; set; }
        public bool IsASD { get; set; }
        public bool IsHd { get; set; }
        public bool IsSoldOut { get; set; }
        public bool IsThumbnail { get; set; }
        public double DisplayPrice { get; set; }
        public string DisplayCurrency { get; set; }
        public double CrossOutPrice { get; set; }
        public bool HasCrossOutRate { get; set; }
        public string FormattedDisplayPrice { get; set; }
        public string FormattedCrossedOutPrice { get; set; }
        public string Currency { get; set; }
        public int CurrencyId { get; set; }
        public string CurrencyCode { get; set; }
        public string OptionDisplay { get; set; }
        public double ExchangeRate { get; set; }
        public bool IsCurrencyOnBackPosition { get; set; }
        public object CancellationPolicyCode { get; set; }
        public bool IsBNPL { get; set; }
        public bool IsBNPLDuringYourStay { get; set; }
        public bool IsFreeCancellation { get; set; }
        public bool IsBreakfastIncluded { get; set; }
        public bool IsBenefitsIncluded { get; set; }
        public string BenefitText { get; set; }
        public int BookingCondition { get; set; }
        public MainPhoto MainPhoto { get; set; }
        public string MainPhotoUrl { get; set; }
        public int hotelIndex { get; set; }
        public bool IsMobileDeal { get; set; }
        public bool Discount { get; set; }
        public int HotelRoomTypeId { get; set; }
        public string HotelRoomTypeName { get; set; }
        public string HotelRoomTypeNameASD { get; set; }
        public int RoomOfferCmsId { get; set; }
        public object DefaultRoomOfferName { get; set; }
        public int DisplayRackRate { get; set; }
        public int MaxOccupancy { get; set; }
        public int RoomSize { get; set; }
        public string ReviewText { get; set; }
        public int ReviewTextCmsId { get; set; }
        public bool IsInsiderDeals { get; set; }
        public bool IsGiftCard { get; set; }
        public int ImgWidth { get; set; }
        public int ImgHeight { get; set; }
        public bool IsReady { get; set; }
        public string PromotionText { get; set; }
        public string HotelUrl { get; set; }
        public double Distance { get; set; }
        public string MobileDistanceMessage { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public bool IsUnavailableHotel { get; set; }
        public bool IsMSE { get; set; }
        public bool IsPPC { get; set; }
        public bool IsPromotionEligible { get; set; }
        public object UnavailableDateText { get; set; }
        public int RemainingRooms { get; set; }
        public object SaveUpTo { get; set; }
        public List<int> PromotionTypes { get; set; }
        public object PointsMaxPromoText { get; set; }
        public object PointsMaxProgramName { get; set; }
        public bool IsPointsMaxEligible { get; set; }
        public bool IsPointsMaxOpportunityEligible { get; set; }
        public List<object> PointsMaxShortcutProgramList { get; set; }
        public bool IsPointsMaxShortcutProgramListExist { get; set; }
        public string CancellationCode { get; set; }
        public int PromotionID { get; set; }
        public int RatePlanID { get; set; }
        public double PriceInclusive { get; set; }
        public int PromotionValue { get; set; }
        public string PromotionDiscount { get; set; }
        public bool HasLocalTaxReceipt { get; set; }
        public int CmsDiscountTypeID { get; set; }
        public bool IsNoCreditCardRequired { get; set; }
        public PriceSummary PriceSummary { get; set; }
        public bool IsDisplayReviewScore { get; set; }
        public bool HasNHATag { get; set; }
        public bool IsShowMobileAppPriceOnSearch { get; set; }
    }

    public class PriceFilterRange
    {
        public string Name { get; set; }
        public int Min { get; set; }
        public int Max { get; set; }
        public string MinText { get; set; }
        public string MaxText { get; set; }
        public string CurrencyFormat { get; set; }
        public int SliderIntervalSize { get; set; }
        public string CurrencyCode { get; set; }
        public string PriceSeparator { get; set; }
    }

    public class ItemList
    {
        public int Id { get; set; }
        public int SecondId { get; set; }
        public string Name { get; set; }
        public int Count { get; set; }
    }

    public class Facilities
    {
        public List<ItemList> ItemList { get; set; }
        public string FilterId { get; set; }
        public string Name { get; set; }
    }

    public class ItemList2
    {
        public int Id { get; set; }
        public int SecondId { get; set; }
        public string Name { get; set; }
        public int Count { get; set; }
    }

    public class ReviewScores
    {
        public List<ItemList2> ItemList { get; set; }
        public string FilterId { get; set; }
        public string Name { get; set; }
    }

    public class ItemList3
    {
        public int Id { get; set; }
        public int SecondId { get; set; }
        public string Name { get; set; }
        public int Count { get; set; }
    }

    public class StarRating
    {
        public List<ItemList3> ItemList { get; set; }
        public string FilterId { get; set; }
        public string Name { get; set; }
    }

    public class ItemList4
    {
        public int Id { get; set; }
        public int SecondId { get; set; }
        public string Name { get; set; }
        public int Count { get; set; }
    }

    public class Area
    {
        public List<ItemList4> ItemList { get; set; }
        public string FilterId { get; set; }
        public string Name { get; set; }
    }

    public class ItemList5
    {
        public int Id { get; set; }
        public int SecondId { get; set; }
        public string Name { get; set; }
        public int Count { get; set; }
    }

    public class AccomdType
    {
        public List<ItemList5> ItemList { get; set; }
        public string FilterId { get; set; }
        public string Name { get; set; }
    }

    public class FilterList
    {
        public int ReviewScoreMin { get; set; }
        public PriceFilterRange PriceFilterRange { get; set; }
        public Facilities Facilities { get; set; }
        public ReviewScores ReviewScores { get; set; }
        public StarRating StarRating { get; set; }
        public Area Area { get; set; }
        public AccomdType AccomdType { get; set; }
    }

    public class PriceRange
    {
        public int Min { get; set; }
        public int Max { get; set; }
    }

    public class Filters
    {
        public object HotelName { get; set; }
        public PriceRange PriceRange { get; set; }
        public object StarRating { get; set; }
        public object Facilities { get; set; }
        public object AccomodationType { get; set; }
        public object Areas { get; set; }
        public object ReviewScores { get; set; }
        public int ReviewScoreMin { get; set; }
        public int Size { get; set; }
    }

    public class AdditionalExperiments
    {
        public int PRIUS { get; set; }
    }

    public class LandingParameters
    {
        public object HeaderBannerUrl { get; set; }
        public object FooterBannerUrl { get; set; }
        public int SelectedHotelId { get; set; }
        public int LandingCityID { get; set; }
    }

    public class SearchCriteria
    {
        public string SearchMessageID { get; set; }
        public int SearchType { get; set; }
        public int ObjectID { get; set; }
        public Filters Filters { get; set; }
        public List<int> RateplanIDs { get; set; }
        public int TotalHotels { get; set; }
        public int PlatformID { get; set; }
        public string CurrentDate { get; set; }
        public long SearchID { get; set; }
        public int CityId { get; set; }
        public int Latitude { get; set; }
        public int Longitude { get; set; }
        public int Radius { get; set; }
        public int PageNumber { get; set; }
        public int PageSize { get; set; }
        public int SortType { get; set; }
        public bool SortByASD { get; set; }
        public int ReviewTravelerType { get; set; }
        public int PointsMaxProgramId { get; set; }
        public int PollTimes { get; set; }
        public string CityName { get; set; }
        public string ObjectName { get; set; }
        public string CountryName { get; set; }
        public int CountryId { get; set; }
        public bool IsAllowYesterdaySearch { get; set; }
        public string CultureInfo { get; set; }
        public int UnavailableHotelID { get; set; }
        public bool IsEnableAPS { get; set; }
        public AdditionalExperiments AdditionalExperiments { get; set; }
        public int SeletedHotelId { get; set; }
        public bool HasFilter { get; set; }
        public LandingParameters LandingParameters { get; set; }
        public bool IsSave { get; set; }
        public int NewSSRSearchType { get; set; }
        public int MapType { get; set; }
        public bool IsShowMobileAppPrice { get; set; }
        public int Adults { get; set; }
        public int Children { get; set; }
        public int Rooms { get; set; }
        public string CheckIn { get; set; }
        public int LengthOfStay { get; set; }
        public string Text { get; set; }
    }

    public class JsonAgodaHotel
    {
        public bool IsDFError { get; set; }
        public bool IsComplete { get; set; }
        public bool IsLogin { get; set; }
        public bool IsReady { get; set; }
        public string SearchId { get; set; }
        public string CurrencyCode { get; set; }
        public object UnavailableHotels { get; set; }
        public int TotalFilteredHotels { get; set; }
        public object FilteredHotelIDs { get; set; }
        public List<ResultList> ResultList { get; set; }
        public object SelectedHotel { get; set; }
        public object UnavailableHotelResult { get; set; }
        public FilterList FilterList { get; set; }
        public object SortList { get; set; }
        public object TravelerSortList { get; set; }
        public SearchCriteria SearchCriteria { get; set; }
        public int PageNumber { get; set; }
        public int PageSize { get; set; }
        public int FirstRowInPage { get; set; }
        public int LastRowInPage { get; set; }
        public int TotalPage { get; set; }
        public string CityName { get; set; }
        public string CountryName { get; set; }
        public string ObjectName { get; set; }
        public List<object> NotReadyHotelIds { get; set; }
        public bool HasInsiderDeal { get; set; }
        public int Defaultradius { get; set; }
        public int TotalActiveHotel { get; set; }
        public int GMTOffset { get; set; }
        public double CenterLatitude { get; set; }
        public double CenterLongitude { get; set; }
        public double MapLatitude { get; set; }
        public double MapLongitude { get; set; }
        public string TitleBar { get; set; }
        public object MobileMapHeaderText { get; set; }
        public string CheckInDate { get; set; }
        public string CheckOutDate { get; set; }
        public string ShortCheckInDate { get; set; }
        public string ShortCheckOutDate { get; set; }
        public int StartPageIndex { get; set; }
        public int EndPageIndex { get; set; }
        public bool HasSecretDeal { get; set; }
        public bool HasDeals { get; set; }
        public int InsiderDealBannerRow { get; set; }
        public object priceConfigItem { get; set; }
    }
}
