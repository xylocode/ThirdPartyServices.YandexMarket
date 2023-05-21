namespace XyloCode.ThirdPartyServices.YandexMarket.Enum
{
    /// <summary>
    /// Тип сортировки категорий.
    /// </summary>
    public enum CategoriesSortOrder
    {
        /// <summary>
        /// Сортировка по умолчанию.
        /// </summary>
        NONE = 0,

        /// <summary>
        /// Сортировка категорий в алфавитном порядке.
        /// </summary>
        BY_NAME,

        /// <summary>
        /// Сортировка по количеству товарных предложений в каждой категории.
        /// </summary>
        BY_OFFERS_NUM,
    }
}
