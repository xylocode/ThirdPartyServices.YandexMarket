namespace XyloCode.ThirdPartyServices.YandexMarket.Enum
{
    // Тип сортировки
    public enum FilterSortBy
    {
        /// <summary>
        /// Сортировка по релевантности;
        /// </summary>
        RELEVANCY = 2,

        /// <summary>
        /// Сортировка по цене;
        /// </summary>
        PRICE,

        /// <summary>
        /// Сортировка по рейтингу;
        /// </summary>

        RATING,

        /// <summary>
        /// Сортировка по расстоянию до ближайшей точки продаж (значение доступно только при указании местоположения пользователя);
        /// </summary>
        DISTANCE,

        /// <summary>
        /// Сортировка по популярности;
        /// </summary>
        POPULARITY,

        /// <summary>
        /// Сортировка по размеру скидки;
        /// Ограничение. Для sort = DISCOUNT возможна только сортировка по убыванию (how = DESC).
        /// </summary>
        DISCOUNT,

        /// <summary>
        /// Сортировка по рейтингу;
        /// </summary>
        QUALITY,

        /// <summary>
        /// Сортировка по количеству отзывов;
        /// </summary>
        OPINIONS,

        /// <summary>
        /// Сортировка по дате;
        /// </summary>
        DATE,

        /// <summary>
        /// Сортировка по времени доставки;
        /// </summary>
        DELIVERY_TIME,

        /// <summary>
        /// Сортировка по количеству предложений.
        /// </summary>
        NOFFERS,
    }
}