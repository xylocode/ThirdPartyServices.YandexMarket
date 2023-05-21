using System;

namespace XyloCode.ThirdPartyServices.YandexMarket.Enum
{
    [Flags]
    public enum ModelFields : long
    {
        /// <summary>
        /// Информация о категории, к которой относится модель
        /// </summary>
        CATEGORY = 0x2,

        /// <summary>
        /// Информация о товарном предложении по умолчанию для модели в указанном регионе
        /// </summary>
        DEFAULT_OFFER = 0x4,

        /// <summary>
        /// Информация о скидках на модель
        /// </summary>
        DISCOUNTS = 0x8,

        /// <summary>
        /// Список достоинств и недостатков модели
        /// </summary>
        FACTS = 0x10,

        /// <summary>
        /// Список фильтров, доступных для отбора модификаций модели
        /// </summary>
        FILTERS = 0x20,

        /// <summary>
        /// Группа параметров для фильтра «Производитель»;
        /// По умолчанию выводится информация о первых 12 производителях.
        /// </summary>
        FILTER_ALLVENDORS = 0x40,

        /// <summary>
        /// Список фильтров по цвету, доступных для отбора модификаций модели
        /// </summary>
        FILTER_COLOR = 0x80,

        /// <summary>
        /// Описания фильтров
        /// </summary>
        FILTER_DESCRIPTION = 0x100,

        /// <summary>
        /// Количество моделей или товарных предложений
        /// </summary>
        FILTER_FOUND = 0x200,

        /// <summary>
        /// Если применить это значение фильтра с текущими условиями фильтрации
        /// </summary>
        found = 0x400,

        /// <summary>
        /// Если применить только это значение фильтра без других фильтров
        /// </summary>
        initialFound = 0x800,


        /// <summary>
        /// Включение в выдачу доступных фильтров
        /// </summary>
        FILTER_SORTS = 0x1000,

        /// <summary>
        /// Обогащение информацией статистикой по фильтрам
        /// </summary>
        FILTER_STATISTICS = 0x2000,

        /// <summary>
        /// Информация об отзывах и обзорах на модель
        /// </summary>
        MEDIA = 0x4000,

        /// <summary>
        /// Краткая информация о модификациях (для групповой модели)
        /// </summary>
        MODIFICATIONS = 0x8000,

        /// <summary>
        /// Информация о навигационном узле дерева категорий Маркета, к которому относится модель
        /// </summary>
        NAVIGATION_NODE = 0x10000,

        /// <summary>
        /// Источник данных узла навигационного дерева
        /// </summary>
        NAVIGATION_NODE_DATASOURCE = 0x20000,

        /// <summary>
        /// Иконки навигационного дерева
        /// </summary>
        NAVIGATION_NODE_ICONS = 0x40000,

        /// <summary>
        /// Статистика узла навигационного дерева
        /// </summary>
        NAVIGATION_NODE_STATISTICS = 0x80000,

        /// <summary>
        /// Информация о товарных предложениях, соотнесенных с моделью, в указанном регионе
        /// </summary>
        OFFERS = 0x100000,

        /// <summary>
        /// Активные фильтры
        /// </summary>
        OFFER_ACTIVE_FILTERS = 0x200000,

        /// <summary>
        /// Информация о категории предложения
        /// </summary>
        OFFER_CATEGORY = 0x400000,

        /// <summary>
        /// Информация о доставке
        /// </summary>
        OFFER_DELIVERY = 0x800000,

        /// <summary>
        /// Скидка
        /// </summary>
        OFFER_DISCOUNT = 0x1000000,

        /// <summary>
        /// Ссылка на страницу с офферами для той же модели в том же магазине
        /// </summary>
        OFFER_OFFERS_LINK = 0x2000000,

        /// <summary>
        /// Информация о точке выдачи производетеля
        /// </summary>
        OFFER_OUTLET = 0x4000000,

        /// <summary>
        /// Фото предложения
        /// </summary>
        OFFER_PHOTO = 0x8000000,

        /// <summary>
        /// Магазин от которого поступило предложенение
        /// </summary>
        OFFER_SHOP = 0x10000000,

        /// <summary>
        /// Информация о поставщике
        /// </summary>
        OFFER_VENDOR = 0x20000000,

        /// <summary>
        /// Изображение модели, используемое как основное изображение на карточке модели
        /// </summary>
        PHOTO = 0x40000000,

        /// <summary>
        /// Все доступные изображения модели
        /// </summary>
        PHOTOS = 0x80000000,

        /// <summary>
        /// Информация о ценах на модель
        /// </summary>
        PRICE = 0x100000000,

        /// <summary>
        /// Информация о рейтинге и оценках модели
        /// </summary>
        RATING = 0x200000000,

        /// <summary>
        /// Юридическая информация: юридический и фактический адрес, ОГРН, тип организации, ссылка на реквизиты
        /// </summary>
        SHOP_ORGANIZATION = 0x400000000,

        /// <summary>
        /// Рейтинг магазина
        /// </summary>
        SHOP_RATING = 0x800000000,

        /// <summary>
        /// Характеристики модели
        /// </summary>
        SPECIFICATION = 0x1000000000,

        /// <summary>
        /// Информация о производителе
        /// </summary>
        VENDOR = 0x2000000000,

        FILTER_PHOTO_PICKER = 0x4000000000,
        OFFER_BUNDLE_SETTINGS = 0x8000000000,
        OFFER_LINK = 0x10000000000,
        OFFER_SUPPLIER = 0x20000000000,
        VENDOR_LINK = 0x40000000000,


        FILTER_ALL = FILTER_ALLVENDORS | FILTER_DESCRIPTION | FILTER_FOUND | FILTER_PHOTO_PICKER | FILTER_SORTS | FILTER_STATISTICS,

        NAVIGATION_NODE_ALL = NAVIGATION_NODE_DATASOURCE | NAVIGATION_NODE_ICONS | NAVIGATION_NODE_STATISTICS,

        OFFER_ALL = OFFER_ACTIVE_FILTERS | OFFER_BUNDLE_SETTINGS | OFFER_CATEGORY | OFFER_DELIVERY | OFFER_DISCOUNT | OFFER_LINK | OFFER_OFFERS_LINK | OFFER_OUTLET | OFFER_PHOTO | OFFER_SHOP | OFFER_SUPPLIER | OFFER_VENDOR,

        SHOP_ALL = SHOP_ORGANIZATION | SHOP_RATING,

        STANDARD = CATEGORY | OFFERS | OFFER_CATEGORY | OFFER_DELIVERY | OFFER_OUTLET | OFFER_PHOTO | OFFER_SHOP | PHOTO | PRICE | RATING | SHOP_RATING | VENDOR,

        VENDOR_ALL = VENDOR_LINK,

        ALL = long.MaxValue,
    }
}
