using System;

namespace XyloCode.ThirdPartyServices.YandexMarket.Enum
{
    /// <summary>
    /// Группы параметров, которые необходимо отобразить в выходных данных.
    /// </summary>
    [Flags]
    public enum FilterFields
    {

        /// <summary>
        /// Группа параметров для фильтра «Производитель».
        /// По умолчанию выводится информация о первых 12 производителях.
        /// </summary>
        ALLVENDORS = 0x2,

        /// <summary>
        /// Описания фильтров.
        /// </summary>
        DESCRIPTION = 0x4,

        /// <summary>
        /// Количество моделей или товарных предложений, если применить это значение фильтра с текущими условиями фильтрации
        /// </summary>
        FOUND = 0x8,

        /// <summary>
        /// Количество моделей или товарных предложений, если применить это значение фильтра без других фильтров
        /// </summary>
        initialFound = 0x10,

        /// <summary>
        /// Включение в выдачу доступных фильтров
        /// </summary>
        SORTS = 0x20,

        /// <summary>
        /// Обогащение информацией статистикой по фильтрам.
        /// </summary>
        STATISTICS = 0x40,

        /// <summary>
        /// Все значения.
        /// </summary>
        ALL = int.MaxValue,
    }
}
