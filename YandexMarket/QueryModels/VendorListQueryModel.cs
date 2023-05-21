using XyloCode.ThirdPartyServices.YandexMarket.Enum;

namespace XyloCode.ThirdPartyServices.YandexMarket.QueryModels
{
    /// <summary>
    /// <a href="https://yandex.ru/dev/market/content-data/doc/dg-v2/reference/vendor-controller-v2-get-vendor-list.html">Список производителей</a>
    /// Возвращает список производителей, товары которых размещаются на Яндекс.Маркете
    /// Ресурс является списочным.
    /// </summary>
    public class VendorListQueryModel : BaseQueryModel
    {
        public override string GetPath() => $"/{version}/vendors";

        /// <summary>
        /// Свойства производителя, которые необходимо показать в выходных данных.
        /// </summary>
        public VendorFields? fields { get; set; }


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
