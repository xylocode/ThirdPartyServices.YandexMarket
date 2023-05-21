using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using XyloCode.ThirdPartyServices.YandexMarket.Enum;

namespace XyloCode.ThirdPartyServices.YandexMarket.Entities
{
    /// <summary>
    /// Изображение товара.
    /// </summary>
    public class Photo
    {
        /// <summary>
        /// Ширина изображения
        /// </summary>
        public int Width { get; set; }

        /// <summary>
        /// Высота изображения
        /// </summary>
        public int Height { get; set; }

        /// <summary>
        /// Ссылка на изображение
        /// </summary>
        public string Url { get; set; }

        /// <summary>
        /// Код значения фильтра по цвету.
        /// Примечание. Имеет значение только для моделей у которых есть фильтр по цвету
        /// </summary>
        public string ColorId { get; set; }

        /// <summary>
        /// Уменьшенные копии изображения
        /// Только в версиях API: 2.1.2+.
        /// </summary>
        [NotMapped]
        public virtual ICollection<Thumbnail> Thumbnails { get; set; }

        /// <summary>
        /// Типы:
        /// Критерий фильтрации
        /// Критерий фильтрации по поисковой фразе
        /// </summary>
        [NotMapped]
        public virtual ICollection<Criteria> Criteria { get; set; }
    }

    /// <summary>
    /// Уменьшенные копии изображения
    /// </summary>
    public class Thumbnail
    {
        /// <summary>
        /// Ширина изображения
        /// </summary>
        public int Width { get; set; }

        /// <summary>
        /// Высота изображения
        /// </summary>
        public int Height { get; set; }

        /// <summary>
        /// Ссылка на изображение
        /// </summary>
        public string Url { get; set; }

        /// <summary>
        /// Размер контейнера для которого подготовлена уменьшенная копия изображения
        /// </summary>
        public ThumbnailSize Container { get; set; }
    }
}
