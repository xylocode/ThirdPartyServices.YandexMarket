using System.Collections.Generic;
using System.Runtime.Serialization;
using XyloCode.ThirdPartyServices.YandexMarket.Enum;

namespace XyloCode.ThirdPartyServices.YandexMarket.QueryModels
{
    /// <summary>
    /// <a href="https://yandex.ru/dev/market/content-data/doc/dg-v2/reference/search-controller-v2-filter-on-category.html">Подбор по параметрам в категории</a>
    /// Возвращает список моделей категории и предложений на модели, удовлетворяющих заданным в запросе параметра
    /// Ресурс является списочным.
    /// </summary>
    public class ModelSearchQueryModel : BaseQueryModel
    {
        public override string GetPath() => $"/{version}/categories/{id}/search";

        public ModelSearchQueryModel(int categoryId)
        {
            id = categoryId;
        }

        /// <summary>
        /// Идентифкатор категории
        /// </summary>
        [IgnoreDataMember]
        public int id { get; set; }

        /// <summary>
        /// Поля, которые необходимо показать в выходных данных.
        /// </summary>
        public SearchFields? fields { get; set; }


        /// <summary>
        /// Нужно ли возвращать модель ("__type": "model") вместо соответствующих ей товарных предложений ("__type": "offer"):
        /// При значении 1 возвращаются те же модели и предложения, что и в результатах поиска Маркета.
        /// Значение по умолчанию: 0.
        /// </summary>
        public bool? prefer_models { get; set; }

        /// <summary>
        /// Тип выдачи: все результаты, только модели, только офферы.
        /// </summary>
        public SearchResultType? result_type { get; set; }


        /// <summary>
        /// Поле содержащее закодированную информацию о текстовом запросе после редиректа, на которую будет ориентироватся поиск.
        /// </summary>
        public string rs { get; set; }

        /// <summary>
        /// Идентификаторы регионов магазинов.
        /// </summary>
        public ICollection<int> shop_regions { get; set; }

        /// <summary>
        /// Параметры задают условия фильтрации моделей и предложений на модель.
        /// </summary>
        object filter_id { get; set; }

        /// <summary>
        /// Признак фильтрации предложений с доставкой в регион, указанный в параметре geo_id.
        /// </summary>
        public bool? local_delivery { get; set; }

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

        /// <summary>
        /// Направление сортировки.
        /// Значение по умолчанию: Зависит от поля, по которому сортируем (так по цене сортировка по возрастанию, а по популярности по убыванию).
        /// </summary>
        public SortOrder? how { get; set; }

        /// <summary>
        /// Определяет, по какому параметру осуществляется сортировка.
        /// </summary>
        public SearchSortOrder? sort { get; set; }

        /// <summary>
        /// Идентификатор региона, для которого нужно получить информацию о моделях и предложениях.
        /// </summary>
        public int? geo_id { get; set; }
    }
}
