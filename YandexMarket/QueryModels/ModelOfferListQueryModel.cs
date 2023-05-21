using System.Collections.Generic;
using System.Runtime.Serialization;
using XyloCode.ThirdPartyServices.YandexMarket.Enum;

namespace XyloCode.ThirdPartyServices.YandexMarket.QueryModels
{
    /// <summary>
    /// <a href="https://yandex.ru/dev/market/content-data/doc/dg-v2/reference/models-controller-v2-get-offers.html/">Список предложений на модель</a>
    /// Возвращает список товарных предложений, соотнесенных с указанной моделью.
    /// Ресурс является списочным.
    /// </summary>
    public class ModelOfferListQueryModel : BaseQueryModel
    {
        public override string GetPath() => $"/{version}/models/{id}/offers";

        public ModelOfferListQueryModel(long modelId)
        {
            id = modelId;
        }

        /// <summary>
        /// Идентификатор модели.
        /// </summary>
        [IgnoreDataMember]
        public long id { get; set; }

        /// <summary>
        /// Признак включения цены доставки в цену товарного предложения.
        /// </summary>
        public bool? delivery_included { get; set; }

        /// <summary>
        /// Свойства модели, которые необходимо показать в выходных данных.
        /// </summary>
        public ModelFields? fields { get; set; }

        /// <summary>
        /// Вариант группировки товарных предложений
        /// </summary>
        public ModelGroupBy? groupBy { get; set; }

        /// <summary>
        /// Идентификаторы регионов магазинов.
        /// </summary>
        public ICollection<int> shop_regions { get; set; }

        /// <summary>
        /// Параметры задают условия фильтрации моделей и предложений на модель
        /// </summary>
        Dictionary<long,string> FILTERS { get; set; }

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
        /// Значение по умолчанию зависит от поля, по которому сортируем. По цене сортировка по возрастанию, а по популярности – по убыванию.
        /// </summary>
        public SortOrder? how { get; set; }

        /// <summary>
        /// Идентификатор региона, для которого нужно получить информацию о предложениях.
        /// </summary>
        public int? geo_id { get; set; }

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


