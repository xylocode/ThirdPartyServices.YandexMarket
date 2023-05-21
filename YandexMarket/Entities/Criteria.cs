using System.ComponentModel.DataAnnotations;

namespace XyloCode.ThirdPartyServices.YandexMarket.Entities
{
    /// <summary>
    /// Критерий фильтрации
    /// </summary>
    public class Criteria
    {
        /// <summary>
        /// Идентификатор фильтра.
        /// </summary>
        [Key]
        public string Id { get; set; }

        /// <summary>
        /// Значение фильтра
        /// </summary>
        public string Value { get; set; }

        /// <summary>
        /// Текст поисковой фразы
        /// </summary>
        public string Text { get; set; }

        public long? ThisRowCreated { get; set; }

        public long? ThisRowUpdated { get; set; }
    }
}
