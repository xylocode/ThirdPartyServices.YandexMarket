using System.Collections.Generic;
using XyloCode.ThirdPartyServices.YandexMarket.Entities;

namespace XyloCode.ThirdPartyServices.YandexMarket.ResponseModels
{
    /// <summary>
    /// <a href="https://yandex.ru/dev/market/content-data/doc/dg-v2/reference/search-controller-v2-search.html/">Текстовый поиск</a>
    /// Возвращает список моделей и товарных предложений, удовлетворяющих заданным в запросе условиям поиска
    /// Ресурс является списочным и регионозависимым.
    /// </summary>
    public class TextSearchResponseModel:BaseResponseModel
    {
        /// <summary>
        /// Список моделей и/или товарных предложений
        /// Типы:
        /// Модель
        /// Предложение
        /// </summary>
        public ICollection<Offer> Items { get; set; }

        /// <summary>
        /// Список категорий.
        /// </summary>
        public ICollection<Category> Categories { get; set; }

        /// <summary>
        /// Список доступных сортировок
        /// </summary>
        public ICollection<ModelSort> Sorts { get; set; }
    }
}
