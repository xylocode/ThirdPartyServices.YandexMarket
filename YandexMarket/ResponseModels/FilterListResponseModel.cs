using System.Collections.Generic;
using XyloCode.ThirdPartyServices.YandexMarket.Entities;

namespace XyloCode.ThirdPartyServices.YandexMarket.ResponseModels
{
    /// <summary>
    /// <a href="https://yandex.ru/dev/market/content-data/doc/dg-v2/reference/category-controller-v2-get-category-filters.html">Список фильтров</a>
    /// Возвращает список фильтров для моделей и товарных предложений в указанной категории.
    /// Во входных данных можно укзать идентификатор категории второго и более уровней вложенности.
    /// Чтобы получить статистику по количеству моделей и товарных предложений для определенного фильтра – укажите фильтр во входных данных.
    /// Ресурс является регионозависимым.
    /// </summary>
    public class FilterListResponseModel : BaseResponseModel
    {
        /// <summary>
        /// Список сортировок.
        /// </summary>
        public ICollection<ModelSort> Sorts { get; set; }

        /// <summary>
        /// Список фильтров.
        /// Типы:
        /// фильтр;
        /// фильтр со значениями;
        /// числовой фильтр.
        /// </summary>
        public ICollection<Filter> Filters { get; set; }
    }
}
