using System;

namespace XyloCode.ThirdPartyServices.YandexMarket.Enum
{
    /// <summary>
    /// Тип региона.
    /// </summary>
    [Flags]
    public enum RegionType
    {
        /// <summary>
        /// Другой тип населенного пункта
        /// </summary>
        OTHER = 1,

        /// <summary>
        /// Аэропорт
        /// </summary>
        AIRPORT = 0x2,

        /// <summary>
        /// Город
        /// </summary>
        CITY = 0x4,

        /// <summary>
        /// Район города
        /// </summary>
        CITY_DISTRICT = 0x8,

        /// <summary>
        /// Континент
        /// </summary>
        CONTINENT = 0x10,

        /// <summary>
        /// Страна
        /// </summary>
        COUNTRY = 0x20,

        /// <summary>
        /// Федеральный округ
        /// </summary>
        COUNTRY_DISTRICT = 0x40,

        /// <summary>
        /// Станция метро
        /// </summary>
        METRO_STATION = 0x80,

        /// <summary>
        /// Станция монорельса
        /// </summary>
        MONORAIL_STATION = 0x100,

        /// <summary>
        /// Отдельная территория какого-либо государства, расположенная в другой части света (например, Ангилья, Гренландия, Бермудские острова и т.д.).
        /// </summary>
        OVERSEAS_TERRITORY = 0x200,

        /// <summary>
        /// Регион
        /// </summary>
        REGION = 0x400,

        /// <summary>
        /// Сельское поселение
        /// </summary>
        RURAL_SETTLEMENT = 0x800,

        /// <summary>
        /// Район города второго уровня (например, для ВАО Москвы районами второго уровня являются Измайлово, Новокосино, Перово и т. д.).
        /// </summary>
        SECONDARY_DISTRICT = 0x1000,

        /// <summary>
        /// Субъект федерации
        /// </summary>
        SUBJECT_FEDERATION = 0x2000,

        /// <summary>
        /// Район субъекта федерации
        /// </summary>
        SUBJECT_FEDERATION_DISTRICT = 0x4000,

        /// <summary>
        /// Село
        /// </summary>
        VILLAGE = 0x8000,


        HIDDEN = 0x4000_0000,

        /// <summary>
        /// Все значения
        /// </summary>
        ALL = int.MaxValue,
    }
}
