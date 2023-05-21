using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using XyloCode.ThirdPartyServices.YandexMarket.Enum;

namespace XyloCode.ThirdPartyServices.YandexMarket.Entities
{
    /// <summary>
    /// <a href="https://yandex.ru/dev/market/content-data/doc/dg-v2/reference/region-v2.html/">Регион</a>
    /// Краткая информация о регионе.
    /// </summary>
    public class Region
    {
        /// <summary>
        /// Идентификатор региона.
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Наименование региона.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Тип региона.
        /// </summary>
        public RegionType Type { get; set; }

        /// <summary>
        /// Количество дочерних регионов.
        /// </summary>
        public int ChildCount { get; set; }

        /// <summary>
        /// Гео-координаты.
        /// </summary>
        public GeoCoordinates Coordinates { get; set; }

        /// <summary>
        /// Наименование региона в винительном падеже.
        /// </summary>
        public string NameAccusative { get; set; }

        /// <summary>
        /// Наименование региона в родительном падеже.
        /// </summary>
        public string NameGenitive { get; set; }

        public int? CountryId { get; set; }
        /// <summary>
        /// Страна, к которой относится регион.
        /// </summary>
        [ForeignKey(nameof(CountryId))]
        public virtual Region Country { get; set; }

        public int? ParentId { get; set; }
        /// <summary>
        /// Родительский регион
        /// </summary>
        [ForeignKey(nameof(ParentId))]
        public virtual Region Parent { get; set; }

        public string Hierarchy { get; set; }

        public long? ThisRowCreated { get; set; }
        public long? ThisRowUpdated { get; set; } = 0;
        public long? ThisNodeUpdated { get; set; } = 0;

    }
}
