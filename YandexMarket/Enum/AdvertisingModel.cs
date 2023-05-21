namespace XyloCode.ThirdPartyServices.YandexMarket.Enum
{
    /// <summary>
    /// Тип размещения товарных предложений в категории.
    /// </summary>
    public enum AdvertisingModel
    {
        /// <summary>
        /// Плата за заказы, оформленные прямо на Яндекс.Маркете.
        /// </summary>
        CPA = 2,

        /// <summary>
        /// Плата только за клики по предложению магазина.
        /// </summary>
        CPC,

        /// <summary>
        /// Возможны оба варианта размещения товарных предложений в категории.
        /// </summary>
        HYBRID,
    }
}
