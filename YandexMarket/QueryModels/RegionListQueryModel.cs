using XyloCode.ThirdPartyServices.YandexMarket.Enum;

namespace XyloCode.ThirdPartyServices.YandexMarket.QueryModels
{
    /// <summary>
    /// <a href="https://yandex.ru/dev/market/content-data/doc/dg-v2/reference/geo-controller-v2-get-region-root.html/">Список регионов</a>
    /// </summary>
    public class RegionListQueryModel : BaseQueryModel
    {
        public override string GetPath() => $"/{version}/geo/regions";

        /// <summary>
        /// Параметры региона, которые необходимо включить в выдачу
        /// </summary>
        public RegionFields? fields { get; set; }


        ///// <summary>
        ///// Размер страницы (количество элементов на странице).
        ///// Ограничения: минимальное значение: 1; максимальное значение: 30.
        ///// Значение по умолчанию: 10.
        ///// </summary>
        //public int? count { get; set; }

        ///// <summary>
        ///// Номер страницы.
        ///// Ограничения: минимальное значение: 1.
        ///// Значение по умолчанию: 1.
        ///// </summary>
        //public int? page { get; set; }
    }
}
