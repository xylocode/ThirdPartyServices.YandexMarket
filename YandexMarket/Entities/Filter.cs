using System.Collections.Generic;
using XyloCode.ThirdPartyServices.YandexMarket.Enum;

namespace XyloCode.ThirdPartyServices.YandexMarket.Entities
{
    /// <summary>
    /// <a href="https://yandex.ru/dev/market/content-data/doc/dg-v2/reference/category-controller-v2-get-category-filters.html">Фильтры категории</a>
    /// Фильтр для моделей и товарных предложений в указанной категории.
    /// Типы: Фильтр, Фильтр со значениями, Числовой фильтр
    /// </summary>
    public class Filter
    {
        /// <summary>
        /// Идентификатор фильтра.
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Наименование фильтра.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Тип фильтра.
        /// </summary>
        public FilterType Type { get; set; }

        /// <summary>
        /// Описание фильтра.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Единицы измерения значений фильтра.
        /// </summary>
        public string Unit { get; set; }

        /// <summary>
        /// Код единиц измерения значений фильтра, используемых по умолчанию.
        /// </summary>
        public string DefaultUnit { get; set; }

        /// <summary>
        /// Список значений фильтра
        /// Типы:
        /// значение фильтра;
        /// значение COLOR фильтра;
        /// значение SIZE фильтра;
        /// значение Filters.FilterType#PHOTO_PICKER фильтра.
        /// </summary>
        public virtual ICollection<Filter> Values { get; set; }

        /// <summary>
        /// Максимальное значение числового фильтра.
        /// </summary>
        public string Max { get; set; }

        /// <summary>
        /// Минимальное значение числового фильтра.
        /// </summary>
        public string Min { get; set; }

        /// <summary>
        /// Выбранное значение числового фильтра.
        /// </summary>
        public string Value { get; set; }

        /// <summary>
        /// Количество знаков поле запятой у значений фильтра.
        /// </summary>
        public int Precision { get; set; }

        public long? ThisRowCreated { get; set; }

        public long? ThisRowUpdated { get; set; }
    }

    /// <summary>
    /// <a href="https://yandex.ru/dev/market/content-data/doc/dg-v2/reference/category-controller-v2-get-category-filters.html">Фильтры категории</a>
    /// Фильтр для моделей и товарных предложений в указанной категории.
    ///  Типы:
    ///  Значение фильтра,
    ///  Значение COLOR фильтра,
    ///  Значение SIZE фильтра,
    ///  Значение Filters.FilterType#PHOTO_PICKER фильтра
    /// </summary>
    public class Filter2
    {
        /// <summary>
        /// Идентификатор значения фильтра, используется для установки значения фильтра.
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Текстовое описание значение фильтра.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Количество моделей/офферов в выдаче, попадающих под значение фильтра, при отсутствии других фильтров.
        /// </summary>
        public long InitialFound { get; set; }

        /// <summary>
        /// Количество моделей/офферов в выдаче, попадающих под значение фильтра, при текущих условиях фильтрации.
        /// </summary>
        public long Found { get; set; }

        /// <summary>
        /// Признак того, что значение выбрано в соответствии с текущими условиями фильтрации.
        /// </summary>
        public bool Checked { get; set; }

        /// <summary>
        /// Значение цвета.
        /// Внимание. Только для фильтров типов COLOR и Filters.FilterType#PHOTO_PICKER .
        /// </summary>
        public string Color { get; set; }

        /// <summary>
        /// Код единицы измерения размера значения фильтра.
        /// Внимание. Только для фильтра типа SIZE.
        /// </summary>
        public string UnitId { get; set; }

        /// <summary>
        /// Ссылка на картинку для выбора цвета.
        /// Внимание. Только для фильтра типа Filters.FilterType#PHOTO_PICKER .
        /// </summary>
        public string Photo { get; set; }

        public long? ThisRowCreated { get; set; }

        public long? ThisRowUpdated { get; set; }
    }
}
