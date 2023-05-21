using System;

namespace XyloCode.ThirdPartyServices.YandexMarket.Enum
{
    [Flags]
    public enum OutletType
    {
        /// <summary>
        /// Доставка курьером/почтой
        /// </summary>
        DELIVERY = 2,

        /// <summary>
        /// Самовывоз
        /// </summary>
        PICKUP,

        /// <summary>
        /// Магазин
        /// </summary>
        STORE,

        ALL = int.MaxValue
    }
}
