using XyloCode.ThirdPartyServices.YandexMarket.Enum;

namespace XyloCode.ThirdPartyServices.YandexMarket.QueryModels
{
    /// <summary>
    /// <a href="https://yandex.ru/dev/market/content-data/doc/dg-v2/reference/category-controller-v2-get-root-categories.html/">Список категорий</a>
    /// Возвращает список категорий первого уровня (корневых) товарного дерева.
    /// Ресурс является списочным и регионозависимым.
    /// </summary>
    public class CategoryListQueryModel : BaseQueryModel
    {
        public override string GetPath() => $"/{version}/categories";

        public CategoryListQueryModel(int geoId)
        {
            geo_id = geoId;
        }


        /// <summary>
        /// Идентификатор региона, для которого нужно получить информацию о категориях.
        /// </summary>
        public int geo_id { get; set; }

        /// <summary>
        /// Параметры категории, которые необходимо показать в выходных данных.
        /// </summary>
        public CategoryFields? fields { get; set; }

        /// <summary>
        /// Тип сортировки категорий.
        /// </summary>
        public CategoriesSortOrder? sort { get; set; }
    }
}
