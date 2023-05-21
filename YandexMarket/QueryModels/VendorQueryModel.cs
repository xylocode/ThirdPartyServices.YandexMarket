using System.Runtime.Serialization;
using XyloCode.ThirdPartyServices.YandexMarket.Enum;

namespace XyloCode.ThirdPartyServices.YandexMarket.QueryModels
{
    /// <summary>
    /// <a href="https://yandex.ru/dev/market/content-data/doc/dg-v2/reference/vendor-controller-v2-get-vendor.html/">Информация о производителе</a>
    /// Возвращает информацию об указанном производителе
    /// </summary>
    public class VendorQueryModel : BaseQueryModel
    {
        public override string GetPath() => $"/{version}/vendors/{id}";

        public VendorQueryModel(long vendorId)
        {
            id = vendorId;
        }

        /// <summary>
        /// Идентификатор производителя
        /// </summary>
        [IgnoreDataMember]
        public long id { get; set; }

        /// <summary>
        /// Свойства производителя, которые необходимо показать в выходных данных.
        /// </summary>
        public VendorFields? fields { get; set; }
    }
}
