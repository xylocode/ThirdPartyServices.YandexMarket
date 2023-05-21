using System.Collections.Generic;
using XyloCode.ThirdPartyServices.YandexMarket.Enum;

namespace XyloCode.ThirdPartyServices.YandexMarket.QueryModels
{
    /// <summary>
    /// <a href="https://yandex.ru/dev/market/content-data/doc/dg-v2/reference/search-controller-v2-search.html/">Текстовый поиск</a>
    /// Возвращает список моделей и товарных предложений, удовлетворяющих заданным в запросе условиям поиска
    /// Ресурс является списочным и регионозависимым.
    /// </summary>
    public class TextSearchQueryModel : BaseQueryModel
    {
        public override string GetPath() => $"/{version}/search";

        public TextSearchQueryModel(int geoId, string text)
        {
            geo_id = geoId;
            this.text = text;
        }

        /// <summary>
        /// Идентификатор региона, в котором необходимо найти модели и предложения.
        /// </summary>
        public int geo_id { get; set; }

        /// <summary>
        /// Признак включения цены доставки в цену товарного предложения.
        /// Значение по умолчанию: ЛОЖЬ.
        /// </summary>
        public bool? delivery_included { get; set; }

        /// <summary>
        /// Праметры модели/товарного предложения, которые необходимо показать в выходных данных.
        /// </summary>
        public ModelFields? fields { get; set; }

        /// <summary>
        /// Нужно ли возвращать модель ("__type": "model") вместо соответствующих ей товарных предложений ("__type": "offer"):
        /// При значении 1 возвращаются те же модели и предложения, что и в результатах поиска Маркета.
        /// Значение по умолчанию: 0.
        /// </summary>
        public bool? prefer_models { get; set; }

        /// <summary>
        /// Признак  наличия товара в магазине.
        /// </summary>
        public bool? onstock { get; set; }

        /// <summary>
        /// Типы точек продажи
        /// </summary>
        public OutletType? outlet_types { get; set; }

        /// <summary>
        /// Максимальная цена
        /// </summary>
        public long? price_max { get; set; }

        /// <summary>
        /// Минимальная цена
        /// </summary>
        public long? price_min { get; set; }


        /// <summary>
        ///  Результат: всё, только модели, только офферы.
        ///  Значение по умолчанию: ALL.
        /// </summary>
        public SearchResultType result_type { get; set; }

        /// <summary>
        /// Идентификаторы магазинов
        /// </summary>
        public ICollection<long> shop_id { get; set; }

        /// <summary>
        /// Признак "Гарантия производителя"
        /// </summary>
        public bool? warranty { get; set; }

        /// <summary>
        /// Параметры задают условия фильтрации моделей и предложений на модель.
        /// </summary>
        Dictionary<int, string> FILTERS { get; set; }

        /// <summary>
        /// Текст запроса
        /// Ограничение. Параметр действует только, если не указан search_type
        /// </summary>
        public string text { get; set; }

        /// <summary>
        /// Признак поиска по штрихкоду
        /// </summary>
        public bool? barcode { get; set; }

        /// <summary>
        /// Тип поискового запроса
        /// </summary>
        public SearchType? search_type { get; set; }

        /// <summary>
        /// Идентификаторы категорий
        /// </summary>
        public ICollection<int> category_id { get; set;}

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
        /// Тип сортировки отзывов.
        /// </summary>
        public SearchSortOrder? sort { get; set; }

        /// <summary>
        /// Широта.
        /// Минимальное значение: -90.0.
        /// Mаксимальное значение: 90.0.
        /// </summary>
        public double? latitude { get; set; }

        /// <summary>
        /// Долгота.
        /// Минимальное значение: -180.0.
        /// Mаксимальное значение: 180.0.
        /// </summary>
        public double? longitude { get; set; }
    }
}
