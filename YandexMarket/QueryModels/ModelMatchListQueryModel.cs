using System.Collections.Generic;
using XyloCode.ThirdPartyServices.YandexMarket.Entities;
using XyloCode.ThirdPartyServices.YandexMarket.Enum;
using MatchType = XyloCode.ThirdPartyServices.YandexMarket.Enum.MatchType;

namespace XyloCode.ThirdPartyServices.YandexMarket.QueryModels
{
    /// <summary>
    /// <a href="https://yandex.ru/dev/market/content-data/doc/dg-v2/reference/models-controller-v2-get-matched-models.html">Поиск модели по названию и параметрам</a>
    /// Возвращает модель из гуризованной категории по названию и параметрам, удовлетворяющим заданным во входных данных условиям поиска.
    /// </summary>
    public class ModelMatchListQueryModel : BaseQueryModel
    {
        public override string GetPath() => $"/{version}/models/match";

        public ModelMatchListQueryModel(string name)
        {
            this.name = name;
        }

        /// <summary>
        /// Количество категорий
        /// Значение по умолчанию: 1.
        /// </summary>
        public int? category_count { get; set; }

        /// <summary>
        /// Свойства модели, которые необходимо показать в выходных данных.
        /// </summary>
        public ModelFields? fields { get; set; }

        /// <summary>
        /// Тип поиска.
        /// </summary>
        public MatchType? match_types { get; set; }

        /// <summary>
        /// Название модели.
        /// </summary>
        public string name { get; set; }

        /// <summary>
        /// Название категории.
        /// </summary>
        public string category_name { get; set; }

        /// <summary>
        /// Описание модели.
        /// </summary>
        public string description { get; set; }

        /// <summary>
        /// Локаль поиска.
        /// Значение по умолчанию: RU_ru.
        /// </summary>
        public string locale { get; set; }

        /// <summary>
        /// Цена модели.
        /// </summary>
        public string price { get; set; }

        /// <summary>
        /// Название магазина.
        /// </summary>
        public string shop_name { get; set; }

        /// <summary>
        /// Идентификаторы категорий.
        /// </summary>
        public ICollection<Category> category_id { get; set; }

        /// <summary>
        /// Идентификаторы категорий.
        /// </summary>
        public ICollection<Category> hid { get; set; }
    }
}
