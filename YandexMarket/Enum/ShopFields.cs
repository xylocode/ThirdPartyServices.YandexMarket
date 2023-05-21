using System;

namespace XyloCode.ThirdPartyServices.YandexMarket.Enum
{
    [Flags]
    public enum ShopFields
    {
        /// <summary>
        /// Юридическая информация: юридический и фактический адрес, ОГРН, тип организации, ссылка на реквизиты.
        /// </summary>
        ORGANIZATION = 2,

        /// <summary>
        /// Рейтинг магазина.
        /// </summary>
        RATING = 4,


        ALL = int.MaxValue,
    }
}
