using XyloCode.ThirdPartyServices.YandexMarket.Enum;

namespace XyloCode.ThirdPartyServices.YandexMarket.QueryModels
{
    /// <summary>
    /// <a href="https://yandex.ru/dev/market/content-data/doc/dg-v2/reference/geo-controller-v2-suggest.html/">Текстовый поиск региона</a>
    /// Возвращает список регионов, подходящих под заданные условия поиска.
    /// Можно задать поиск по полному или частичному названию региона.
    /// В случае указания частичного названия в выходных данных возвращается список регионов, название которых начинается с этого частичного названия.
    /// </summary>
    public class RegionTextSearchQueryModel : BaseQueryModel
    {
        public override string GetPath() => $"/{version}/geo/suggest";

        public RegionTextSearchQueryModel(string name_part)
        {
            this.name_part = name_part;
        }

        /// <summary>
        /// Полное или частичное название региона
        /// </summary>
        public string name_part { get; set; }

        /// <summary>
        /// Тип региона.
        /// </summary>
        public RegionType types { get; set; }



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
