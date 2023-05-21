using System;

namespace XyloCode.ThirdPartyServices.YandexMarket.Enum
{
    [Flags]
    public enum OfferFields
    {
        /// <summary>
        /// Активные фильтры.
        /// </summary>
        ACTIVE_FILTERS = 0x2,

        /// <summary>
        /// Информация о категории предложения.
        /// </summary>
        CATEGORY = 0x4,

        /// <summary>
        /// Информация о доставке.
        /// </summary>
        DELIVERY = 0x8,

        /// <summary>
        /// Скидка.
        /// </summary>
        DISCOUNT = 0x10,

        /// <summary>
        /// Информация о фильтрах, по которым можно найти товар.
        /// Для таких фильтров значение параметра found в выходных данных будет больше нуля.
        /// Для работы данного значения также нужно указать значение ACTIVE_FILTERS.
        /// </summary>
        FILTER_FOUND = 0x20,

        /// <summary>
        /// Ссылка на страницу с офферами для той же модели в том же магазине.
        /// </summary>
        OFFERS_LINK = 0x40,

        /// <summary>
        /// Информация о точке выдачи производетеля.
        /// </summary>
        OUTLET = 0x80,

        /// <summary>
        /// Количество точек выдачи предложения
        /// </summary>
        OUTLET_COUNT = 0x100,

        /// <summary>
        /// Фото предложения.
        /// </summary>
        PHOTO = 0x200,

        /// <summary>
        /// Магазин от которого поступило предложенение.
        /// </summary>
        SHOP = 0x400,

        /// <summary>
        /// Юридическая информация: юридический и фактический адрес, ОГРН, тип организации, ссылка на реквизиты.
        /// </summary>
        SHOP_ORGANIZATION = 0x800,

        /// <summary>
        /// Рейтинг магазина.
        /// </summary>
        SHOP_RATING = 0x1000,

        /// <summary>
        /// Информация о поставщике.
        /// </summary>
        VENDOR = 0x2000,

        SHOP_ALL = SHOP_ORGANIZATION | SHOP_RATING,
        STANDARD = CATEGORY | DELIVERY | OUTLET | OUTLET_COUNT | PHOTO | SHOP | SHOP_RATING,
        ALL = int.MaxValue,
    }
}
