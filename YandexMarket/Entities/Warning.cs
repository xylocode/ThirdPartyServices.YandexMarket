namespace XyloCode.ThirdPartyServices.YandexMarket.Entities
{
    /// <summary>
    /// Список предупреждений, возникших при обработке запроса.
    /// </summary>
    public class Warning
    {
        /// <summary>
        /// Тип предупрежедния.
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// Код предупреждения.
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// Сообщение с описанием предупреждения.
        /// </summary>
        public string Message { get; set; }
    }
}
