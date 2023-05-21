namespace XyloCode.ThirdPartyServices.YandexMarket.Enum
{
    public enum FilterType
    {
        /// <summary>
        /// Логический тип
        /// </summary>
        BOOLEAN = 2,

        /// <summary>
        /// Числовой тип, задает диапазон допустимых значений
        /// </summary>
        NUMBER,

        /// <summary>
        /// Тип перечисление, задает список допустимых значений, множественный выбор
        /// </summary>
        ENUM,

        /// <summary>
        /// Фильтр по цвету, аналогичен ENUM, значения фильтра дополнительно содержат HEX-код соответствующего цвета
        /// </summary>
        COLOR,

        /// <summary>
        /// Фильтр по размеру, аналогичен ENUM, значения фильтра дополнительно содержат код единиц измерения
        /// </summary>
        SIZE,

        /// <summary>
        /// Аналогичен ENUM, но допускает выбор только одного значения
        /// </summary>
        RADIO,

        /// <summary>
        /// Тип фильтра для фильтрации по поисковой фразе.
        /// </summary>
        TEXT,
    }
}
