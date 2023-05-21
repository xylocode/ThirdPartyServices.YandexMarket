using System.Runtime.Serialization;
using XyloCode.ThirdPartyServices.YandexMarket.Enum;

namespace XyloCode.ThirdPartyServices.YandexMarket.QueryModels
{
    /// <summary>
    /// <a href="https://yandex.ru/dev/market/content-data/doc/dg-v2/reference/geo-controller-v2-get-region.html">Информация о регионе</a>
    /// </summary>
    public class RegionQueryModel : BaseQueryModel
    {
        public override string GetPath() => $"/{version}/geo/regions/{id}";

        public RegionQueryModel(int id)
        {
            this.id = id;
        }

        /// <summary>
        /// Идентификатор региона.
        /// </summary>
        [IgnoreDataMember]
        public int id { get; set; }

        /// <summary>
        /// Параметры региона, которые необходимо включить в выдачу
        /// </summary>
        public RegionFields? fields { get; set; }
    }
}
