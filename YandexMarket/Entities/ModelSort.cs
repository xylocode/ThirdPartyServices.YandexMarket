using XyloCode.ThirdPartyServices.YandexMarket.Enum;

namespace XyloCode.ThirdPartyServices.YandexMarket.Entities
{
    /// <summary>
    /// Список доступных сортировок товарных предложений модели.
    /// </summary>
    public class ModelSort
    {
        /// <summary>
        /// Тип сортировки.
        /// </summary>
        public string Text { get; set; }

        /// <summary>
        /// Тип сортировки.
        /// </summary>
        public ModelSortOrder Field { get; set; }

        /// <summary>
        /// Доступные варианты для данного типа сортировки.
        /// </summary>
        public ModelSortOptions Options { get; set; }
    }

    /// <summary>
    /// Доступные варианты для данного типа сортировки.
    /// </summary>
    public class ModelSortOptions
    {
        /// <summary>
        /// Идентификатор варианта сортировки.
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Направление сортировки.
        /// </summary>
        public SortOrder How { get; set; }

        /// <summary>
        /// Вариант сортировки.
        /// </summary>
        public string Text { get; set; }
    }
}
