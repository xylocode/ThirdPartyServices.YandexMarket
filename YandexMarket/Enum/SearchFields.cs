using System;

namespace XyloCode.ThirdPartyServices.YandexMarket.Enum
{
    [Flags]
    public enum SearchFields
    {
        /// <summary>
        /// Информация о фильтрах, по которым можно найти товар.
        /// Для таких фильтров значение параметра found в выходных данных будет больше нуля.
        /// Для работы данного значения также нужно указать значение OFFER_ACTIVE_FILTERS.
        /// </summary>
        FILTER_FOUND,

        /// <summary>
        /// Информация о категории, к которой относится модель
        /// </summary>
        MODEL_CATEGORY,

        /// <summary>
        /// Информация о товарном предложении по умолчанию для модели в указанном регионе.
        /// </summary>
        MODEL_DEFAULT_OFFER,

        /// <summary>
        /// Информация о скидках на модель.
        /// </summary>
        MODEL_DISCOUNTS,

        /// <summary>
        /// Список достоинств и недостатков модели
        /// </summary>
        MODEL_FACTS,

        /// <summary>
        /// Список фильтров по цвету, доступных для отбора модификаций модели.
        /// </summary>
        MODEL_FILTER_COLOR,

        /// <summary>
        /// Информация об отзывах и обзорах на модель.
        /// </summary>
        MODEL_MEDIA,

        /// <summary>
        /// Информация о навигационном узле дерева категорий Маркета, к которому относится модель.
        /// </summary>
        MODEL_NAVIGATION_NODE,

        /// <summary>
        /// Информация о товарных предложениях, соотнесенных с моделью, в указанном регионе.
        /// </summary>
        MODEL_OFFERS,

        /// <summary>
        /// Изображение модели, используемое как основное изображение на карточке модели
        /// </summary>
        MODEL_PHOTO,

        /// <summary>
        /// Все доступные изображения модели.
        /// </summary>
        MODEL_PHOTOS,

        /// <summary>
        /// Информация о ценах на модель.
        /// </summary>
        MODEL_PRICE,

        /// <summary>
        /// Информация о рейтинге и оценках модели.
        /// </summary>
        MODEL_RATING,

        /// <summary>
        /// Характеристики модели.
        /// </summary>
        MODEL_SPECIFICATION,

        /// <summary>
        /// Информация о производителе.
        /// </summary>
        MODEL_VENDOR,

        /// <summary>
        /// Активные фильтры.
        /// </summary>
        OFFER_ACTIVE_FILTERS,

        /// <summary>
        /// Информация о категории предложения.
        /// </summary>
        OFFER_CATEGORY,

        /// <summary>
        /// Информация о доставке.
        /// </summary>
        OFFER_DELIVERY,

        /// <summary>
        /// Скидка.
        /// </summary>
        OFFER_DISCOUNT,

        /// <summary>
        /// Ссылка на страницу с офферами для той же модели в том же магазине.
        /// </summary>
        OFFER_OFFERS_LINK,

        /// <summary>
        /// Информация о точке выдачи производетеля.
        /// </summary>
        OFFER_OUTLET,

        /// <summary>
        /// Количество точек выдачи предложения
        /// </summary>
        OFFER_OUTLET_COUNT,

        /// <summary>
        /// Фото предложения.
        /// </summary>
        OFFER_PHOTO,

        /// <summary>
        /// Магазин от которого поступило предложенение.
        /// </summary>
        OFFER_SHOP,

        /// <summary>
        /// Информация о поставщике.
        /// </summary>
        OFFER_VENDOR,

        /// <summary>
        /// Юридическая информация: юридический и фактический адрес, ОГРН, тип организации, ссылка на реквизиты.
        /// </summary>
        SHOP_ORGANIZATION,

        /// <summary>
        /// Рейтинг магазина.
        /// </summary>
        SHOP_RATING,

        MODEL_ACTIVE_FILTERS,
        MODEL_LINK,
        OFFER_BUNDLE_SETTINGS,
        OFFER_LINK,
        OFFER_SUPPLIER,

        /// <summary>
        /// Список фильтров в результатах запроса офферов
        /// </summary>
        FILTERS,

        /// <summary>
        /// Категории, в которых нашлись результаты по этому запросу
        /// </summary>
        FOUND_CATEGORIES,

        /// <summary>
        /// Доступные варианты сортировок для запроса
        /// </summary>
        SORTS,

        MODEL_ALL = MODEL_ACTIVE_FILTERS | MODEL_CATEGORY | MODEL_DEFAULT_OFFER | MODEL_DISCOUNTS | MODEL_FACTS | MODEL_FILTER_COLOR | MODEL_LINK | MODEL_MEDIA | MODEL_NAVIGATION_NODE | MODEL_OFFERS | MODEL_PHOTO | MODEL_PHOTOS | MODEL_PRICE | MODEL_RATING | MODEL_SPECIFICATION | MODEL_VENDOR,
        OFFER_ALL = OFFER_ACTIVE_FILTERS | OFFER_BUNDLE_SETTINGS | OFFER_CATEGORY | OFFER_DELIVERY | OFFER_DISCOUNT | OFFER_LINK | OFFER_OFFERS_LINK | OFFER_OUTLET | OFFER_OUTLET_COUNT | OFFER_PHOTO | OFFER_SHOP | OFFER_SUPPLIER | OFFER_VENDOR,
        SHOP_ALL = SHOP_ORGANIZATION | SHOP_RATING,
        STANDARD = MODEL_CATEGORY | MODEL_OFFERS | MODEL_PHOTO | MODEL_PRICE | MODEL_RATING | MODEL_VENDOR | OFFER_CATEGORY | OFFER_DELIVERY | OFFER_OUTLET | OFFER_OUTLET_COUNT | OFFER_PHOTO | OFFER_SHOP | SHOP_RATING,
        
        ALL = int.MaxValue,
    }
}
