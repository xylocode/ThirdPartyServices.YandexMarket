namespace XyloCode.ThirdPartyServices.YandexMarket.Enum
{
    public enum ModelSortOrder
    {
        /// <summary>
        /// Сортировка по дате
        /// </summary>
        DATE = 2,

        /// <summary>
        /// Сортировка по времени доставки
        /// </summary>
        DELIVERY_TIME,

        /// <summary>
        /// Сортировка по размеру скидки
        /// Для sort=DISCOUNT возможна только сортировка по убыванию (how=DESC).
        /// </summary>
        DISCOUNT,

        /// <summary>
        /// Сортировка по расстоянию до ближайшей точки продаж (значение доступно только при указании местоположения пользователя)
        /// </summary>
        DISTANCE,

        /// <summary>
        /// Сортировка по количеству предложений
        /// </summary>
        NOFFERS,

        /// <summary>
        /// Сортировка по количеству отзывов
        /// </summary>
        OPINIONS,

        /// <summary>
        /// Сортировка по популярности
        /// </summary>
        POPULARITY,

        /// <summary>
        /// Сортировка по цене
        /// </summary>
        PRICE,

        /// <summary>
        /// Сортировка по рейтингу
        /// </summary>
        QUALITY,

        /// <summary>
        /// Сортировка по рейтингу и цене
        /// </summary>
        RATING,

        /// <summary>
        /// Сортировка по релевантности
        /// </summary>
        RELEVANCY,
    }
}
