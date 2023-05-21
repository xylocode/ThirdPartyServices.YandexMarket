using System.Runtime.Serialization;
using XyloCode.ThirdPartyServices.YandexMarket.Enum;

namespace XyloCode.ThirdPartyServices.YandexMarket.QueryModels
{
    /// <summary>
    /// <a href="https://yandex.ru/dev/market/content-data/doc/dg-v2/reference/category-controller-v2-get-category.html">Информация о категории</a>
    /// Возвращает информацию об указанной категории по ее идентификатору.
    /// Ресурс является регионозависимым.
    /// </summary>
    public class CategoryQueryModel : BaseQueryModel
    {
        public override string GetPath() => $"/{version}/categories/{id}";

        public CategoryQueryModel(int categoryId, int geoId)
        {
            id = categoryId;
            geo_id = geoId;
        }

        /// <summary>
        /// Идентификатор категории.
        /// </summary>
        [IgnoreDataMember]
        public int id { get; set; }

        /// <summary>
        /// Идентификатор региона, для которого нужно получить информацию о категориях.
        /// </summary>
        public int geo_id { get; set; }

        /// <summary>
        /// Параметры категории, которые необходимо показать в выходных данных.
        /// </summary>
        public CategoryFields? fields { get; set; }
    }
}
