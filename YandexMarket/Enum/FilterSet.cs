using System;

namespace XyloCode.ThirdPartyServices.YandexMarket.Enum
{
    /// <summary>
    /// Определяет набор фильтров в выходных данных.
    /// Значение по умолчанию: POPULAR.
    /// </summary>
    [Flags]
    public enum FilterSet
    {
        /// <summary>
        /// Базовый набор фильтров
        /// </summary>
        BASIC = 0x2,

        /// <summary>
        /// Только популярные фильтры.

        /// </summary>
        POPULAR = 0x4,

        /// <summary>
        /// Все фильтры
        /// </summary>
        ALL = int.MaxValue,
    }
}
