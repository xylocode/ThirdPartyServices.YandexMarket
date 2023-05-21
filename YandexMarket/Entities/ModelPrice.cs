namespace XyloCode.ThirdPartyServices.YandexMarket.Entities
{
    /// <summary>
    /// Информация о цене модели/модификации
    /// </summary>
    public class ModelPrice
    {
        /// <summary>
        /// Максимальная цена
        /// </summary>
        public string Max { get; set; }

        /// <summary>
        /// Минимальная цена
        /// </summary>
        public string Min { get; set; }

        /// <summary>
        /// Среднее значение цены
        /// </summary>
        public string Avg { get; set; }

        /// <summary>
        /// Скидка
        /// </summary>
        public string Discount { get; set; }

        /// <summary>
        /// Базовое значение цены
        /// </summary>
        public string Base { get; set; }
    }
}
