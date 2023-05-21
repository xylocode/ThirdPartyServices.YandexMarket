using System.ComponentModel.DataAnnotations.Schema;

namespace XyloCode.ThirdPartyServices.YandexMarket.Entities
{
    /// <summary>
    /// <a href="https://yandex.ru/dev/market/content-data/doc/dg-v2/reference/category-v2.html/">Предупреждения, связанные с категорией.</a>
    /// </summary>
    public class CategoryWarning
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }

        [ForeignKey(nameof(CategoryId))]
        public virtual Category Category { get; set; }

        /// <summary>
        /// Текст предупреждения.
        /// </summary>
        public string Text { get; set; }

        /// <summary>
        /// Краткий текст предупреждения.
        /// Предназначен для устройств с узким экраном.
        /// </summary>
        public string ShortText { get; set; }

        /// <summary>
        /// Возрастное ограничение для категории.
        /// </summary>
        public int Age { get; set; }
    }
}
