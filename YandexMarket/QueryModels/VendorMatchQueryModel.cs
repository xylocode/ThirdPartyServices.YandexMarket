using XyloCode.ThirdPartyServices.YandexMarket.Enum;

namespace XyloCode.ThirdPartyServices.YandexMarket.QueryModels
{
    /// <summary>
    /// <a href="https://yandex.ru/dev/market/content-data/doc/dg-v2/reference/vendor-controller-v2-match-vendor.html">Подбор производителя по названию</a>
    /// Возвращает производителя, наиболее подходящего под заданное во входных данных название
    /// </summary>
    public class VendorMatchQueryModel : BaseQueryModel
    {
        public override string GetPath() => $"/{version}/vendors/match";

        public VendorMatchQueryModel(string name)
        {
            this.name = name;
        }

        /// <summary>
        /// Название производителя, данные которого необходимо найти
        /// </summary>
        public string name { get; set; }

        /// <summary>
        /// Свойства производителя, которые необходимо показать в выходных данных.
        /// </summary>
        public VendorFields? fields { get; set; }

    }
}
