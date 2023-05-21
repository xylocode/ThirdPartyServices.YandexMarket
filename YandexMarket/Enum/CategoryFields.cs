using System;

namespace XyloCode.ThirdPartyServices.YandexMarket.Enum
{
    /// <summary>
    /// Параметры категории, которые необходимо показать в выходных данных.
    /// </summary>
    [Flags]
    public enum CategoryFields
    {
        /// <summary>
        /// Информация о родительской категории.
        /// </summary>
        PARENT = 0x2,

        /// <summary>
        /// Статистика по категории. Например, количество моделей и товарных предложений в категории;
        /// </summary>
        STATISTICS = 0x4,

        /// <summary>
        /// Предупреждения, связанные с показом категории.
        /// </summary>
        WARNINGS = 0x8,

        /// <summary>
        /// Все значения.
        /// </summary>
        ALL = int.MaxValue,
    }
}
