using System;

namespace XyloCode.ThirdPartyServices.YandexMarket.Enum
{
    [Flags]
    public enum SearchResultType
    {
        /// <summary>
        /// Только модели
        /// </summary>
        MODELS = 2,

        /// <summary>
        /// Только офферы
        /// </summary>
        OFFERS = 4,

        /// <summary>
        /// Все результаты
        /// </summary>
        ALL = int.MaxValue,
    }
}
