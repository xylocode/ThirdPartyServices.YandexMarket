using System.Runtime.Serialization;
using XyloCode.ThirdPartyServices.YandexMarket.Enum;

namespace XyloCode.ThirdPartyServices.YandexMarket.QueryModels
{
    /// <summary>
    /// <a href="https://yandex.ru/dev/market/content-data/doc/dg-v2/reference/category-controller-v2-get-category-filters.html">Список фильтров</a>
    /// Возвращает список фильтров для моделей и товарных предложений в указанной категории.
    /// Во входных данных можно укзать идентификатор категории второго и более уровней вложенности.
    /// Чтобы получить статистику по количеству моделей и товарных предложений для определенного фильтра – укажите фильтр во входных данных.
    /// Ресурс является регионозависимым.
    /// </summary>
    public class FilterListQueryModel : BaseQueryModel
    {
        public override string GetPath() => $"/{version}/categories/{id}/filters";

        public FilterListQueryModel(int categoryId, int geoId)
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
        /// Идентификатор региона, для которого нужно получить информацию о фильтрах.
        /// </summary>
        public int geo_id { get; set; }

        /// <summary>
        /// Группы параметров, которые необходимо отобразить в выходных данных.
        /// </summary>
        public FilterFields? fields { get; set; }

        /// <summary>
        /// Определяет набор фильтров в выходных данных.
        /// </summary>
        public FilterSet? filter_set { get; set; }

        /// <summary>
        /// Нужно ли использовать для запроса модель вместо соответствующих ей товарных предложений.
        /// При значении 1 возвращаются те же фильтры и их значения, что и в результатах поиска Маркета.
        /// </summary>
        public bool? prefer_models { get; set; }

        /// <summary>
        /// Закодированная информацию о текстовом запросе после редиректа, на которую будет ориентироватся поиск.
        /// </summary>
        public string rs { get; set; }

        /// <summary>
        /// Тип сортировки значений в фильтрах.
        /// </summary>
        public FilterValueSortOrder? sort { get; set; }

        /// <summary>
        /// Параметры задают условия фильтрации моделей и предложений на модель.
        /// </summary>
        public long? filter_id { get; set; }
    }

}
