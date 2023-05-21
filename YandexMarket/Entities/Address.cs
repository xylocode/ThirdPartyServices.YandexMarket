using XyloCode.ThirdPartyServices.YandexMarket.Enum;

namespace XyloCode.ThirdPartyServices.YandexMarket.Entities
{
    /// <summary>
    /// <a href="https://yandex.ru/dev/market/content-data/doc/dg-v2/reference/address-v2.html/">Адрес</a>
    /// </summary>

    public class Address
    {
        /// <summary>
        /// Идентификатор региона, к которому относится данный адрес.
        /// </summary>
        public int RegionId { get; set; }

        /// <summary>
        /// Тип региона, к которому относится данный адрес.
        /// </summary>
        public RegionType Type { get; set; }

        /// <summary>
        /// Наименование страны.
        /// </summary>
        public string Country { get; set; }

        /// <summary>
        /// Наименование региона.
        /// </summary>
        public string Region { get; set; }

        /// <summary>
        /// Район внутри области.
        /// </summary>
        public string SubRegion { get; set; }

        /// <summary>
        /// Наименование города, поселка, деревни.
        /// </summary>
        public string Locality { get; set; }

        /// <summary>
        /// Наименование района.
        /// </summary>
        public string SubLocality { get; set; }

        /// <summary>
        /// Улица, проспект, километр шоссе.
        /// </summary>
        public string Thoroughfare { get; set; }

        /// <summary>
        /// Номер дома, строение, участка.
        /// </summary>
        public string PremiseNumber { get; set; }

        /// <summary>
        /// Полный адрес.
        /// </summary>
        public string FullAddress { get; set; }


        /// <summary>
        /// Корпус.
        /// </summary>
        public string Block { get; set; }

        /// <summary>
        /// Строение.
        /// </summary>
        public string Wing { get; set; }

        /// <summary>
        /// Владение.
        /// </summary>
        public string Estate { get; set; }

        /// <summary>
        /// Подъезд.
        /// </summary>
        public string Entrance { get; set; }

        /// <summary>
        /// Этаж.
        /// </summary>
        public string Floor { get; set; }

        /// <summary>
        /// Комната, офис.
        /// </summary>
        public string Room { get; set; }

        /// <summary>
        /// Примечание.
        /// </summary>
        public string Note { get; set; }

        /// <summary>
        /// Гео-координаты.
        /// </summary>
        public GeoPoint GeoPoint { get; set; }

        /// <summary>
        /// Почтовый индекс.
        /// </summary>
        public string Postcode { get; set; }
    }

    /// <summary>
    /// Гео-координаты для Адреса
    /// </summary>
    public class GeoPoint
    {
        /// <summary>
        /// Расстояние.
        /// </summary>
        public double Distance { get; set; }

        /// <summary>
        /// Гео-координаты.
        /// </summary>
        public GeoCoordinates Coordinates { get; set; }
    }

    /// <summary>
    /// Гео-координаты для Адреса
    /// </summary>
    public class GeoCoordinates
    {
        /// <summary>
        /// Широта.
        /// </summary>
        public double Latitude { get; set; }

        /// <summary>
        /// Долгота.
        /// </summary>
        public double Longitude { get; set; }
    }
}
