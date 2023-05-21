namespace XyloCode.ThirdPartyServices.YandexMarket.Enum
{
    public enum ModelGroupBy
    {
        /// <summary>
        /// Группировка предложений отключена. В выдаче присутствуют все предложения;
        /// </summary>
        NONE,

        /// <summary>
        /// Группировка по предложениям;
        /// </summary>
        OFFER,

        /// <summary>
        /// Группировка предложений осуществляется по магазину.
        /// В выдаче присутствует по одному предложению магазина.
        /// </summary>
        SHOP,
    }
}
