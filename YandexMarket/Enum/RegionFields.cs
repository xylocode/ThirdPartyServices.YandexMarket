using System;

namespace XyloCode.ThirdPartyServices.YandexMarket.Enum
{
    /// <summary>
    /// Параметры региона, которые необходимо включить в выдачу
    /// </summary>
    [Flags]
    public enum RegionFields
    {
        /// <summary>
        /// Название региона в разных падежах
        /// </summary>
        DECLENSIONS = 0x2,

        /// <summary>
        /// Родительский регион.
        /// </summary>
        PARENT = 0x4,

        /// <summary>
        /// Все значения
        /// </summary>
        ALL = int.MaxValue,
    }
}
