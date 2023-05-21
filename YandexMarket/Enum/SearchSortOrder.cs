namespace XyloCode.ThirdPartyServices.YandexMarket.Enum
{
    public enum SearchSortOrder
    {
        /// <summary>
        /// Сначала новые
        /// </summary>
        DATE = 2,

        /// <summary>
        /// По времени доставки
        /// </summary>
        DELIVERY_TIME,

        /// <summary>
        /// По скидке (сортировка работает только по убыванию)
        /// </summary>
        DISCOUNT,

        /// <summary>
        /// По удаленности
        /// </summary>
        DISTANCE,

        /// <summary>
        /// По отзывам
        /// </summary>
        OPINIONS,

        /// <summary>
        /// По популярности
        /// </summary>
        POPULARITY,

        /// <summary>
        /// По цене
        /// </summary>
        PRICE,

        /// <summary>
        /// По рейтингу
        /// </summary>
        QUALITY,

        /// <summary>
        /// По рейтингу и цене
        /// </summary>
        RATING,

        /// <summary>
        /// По релевантности
        /// </summary>
        RELEVANCE,
    }
}
