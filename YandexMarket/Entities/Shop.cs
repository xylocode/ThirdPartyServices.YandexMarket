using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;


namespace XyloCode.ThirdPartyServices.YandexMarket.Entities
{
    /// <summary>
    /// <a href="https://yandex.ru/dev/market/content-data/doc/dg-v2/reference/shop-info-v2.html/">Магазин</a>
    /// Информация о магазине
    /// </summary>
    public class Shop
    {
        /// <summary>
        /// Идентификатор магазина
        /// </summary>
        public long Id { get; set; }

        /// <summary>
        /// Наименование магазина.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// URL, содержащий контактную информацию магазина
        /// Примечание. Параметр может быть пустым, если магазин не добавил контактную информацию
        /// </summary>
        public string Domain { get; set; }

        /// <summary>
        /// Дата регистрации на Маркете
        /// </summary>
        public DateTime Registered { get; set; }

        /// <summary>
        /// Ссылка на отзывы о магазине
        /// </summary>
        public string OpinionUrl { get; set; }

        public int? RegionId { get; set; }

        /// <summary>
        /// Домашний регион
        /// </summary>
        [ForeignKey(nameof(RegionId))]
        public virtual Region Region { get; set; }

        /// <summary>
        /// Информация о рейтинге магазина
        /// </summary>
        public Rating Rating { get; set; }

        /// <summary>
        /// Информация об организации
        /// </summary>
        [NotMapped]
        public virtual ICollection<Organization> Organizations { get; set; }

        public long? ThisRowCreated { get; set; }

        public long? ThisRowUpdated { get; set; }
    }
}
