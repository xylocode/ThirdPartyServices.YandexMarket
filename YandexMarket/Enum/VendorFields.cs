using System;

namespace XyloCode.ThirdPartyServices.YandexMarket.Enum
{
    [Flags]
    public enum VendorFields
    {
        /// <summary>
        /// Описание категорий, в которых представлен данный производитель
        /// </summary>
        CATEGORIES = 0x2,

        CATEGORY_LINK = 0x4,

        /// <summary>
        /// Информация о родительской категории.
        /// </summary>
        CATEGORY_PARENT = 0x8,

        /// <summary>
        /// Статистика по категории. Например, количество моделей и товарных предложений в категории.
        /// </summary>
        CATEGORY_STATISTICS = 0x10,

        /// <summary>
        /// Предупреждения, связанные с показом категории.
        /// </summary>
        CATEGORY_WARNINGS = 0x20,

        /// <summary>
        /// Список наиболее популярных категорий товаров производителя
        /// </summary>
        TOP_CATEGORIES = 0x40,

        CATEGORY_ALL = CATEGORY_LINK | CATEGORY_PARENT | CATEGORY_STATISTICS | CATEGORY_WARNINGS,
        ALL = int.MaxValue
    }
}
