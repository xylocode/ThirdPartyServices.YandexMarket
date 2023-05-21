using System.Runtime.Serialization;
using XyloCode.ThirdPartyServices.YandexMarket.Enum;

namespace XyloCode.ThirdPartyServices.YandexMarket.QueryModels
{
    /// <summary>
    /// <a href="https://yandex.ru/dev/market/content-data/doc/dg-v2/reference/opinions-controller-v2-get-shop-opinions.html/">Отзывы о магазине</a>
    /// Возвращает отзывы пользователей о магазине. Оценки без отзывов не входят в ответ.
    /// Ресурс является списочным.
    /// </summary>
    public class ShopOpinionListQueryModel : BaseQueryModel
    {
        public override string GetPath() => IsChronologically ?
            $"/{version}/shops/{id}/opinions/chronological" :
            $"/{version}/shops/{id}/opinions";

        public bool IsChronologically { get; set; }

        public ShopOpinionListQueryModel(long shopId)
        {
            id = shopId;
        }

        /// <summary>
        /// Идентификатор магазина.
        /// </summary>
        [IgnoreDataMember]
        public long id { get; set; }


        /// <summary>
        /// Оценка, выставленная автором отзыва.
        /// </summary>
        public int? grade { get; set; }

        /// <summary>
        /// Максимальное количество комментариев, возвращаемых для каждого отзыва.
        /// </summary>
        public int? max_comments { get; set; }

        /// <summary>
        /// Признак показа отзывов на филиалы магазина.
        /// </summary>
        public bool? with_clones { get; set; }


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
        /// Значение по умолчанию: DATE.
        /// </summary>
        public OpinionSortOrder? sort { get; set; }
    }
}
