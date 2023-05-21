using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json;

namespace XyloCode.ThirdPartyServices.YandexMarket.Entities
{
    public class Rating
    {
        /// <summary>
        /// Средняя оценка рейтинга
        /// </summary>
        public float Value { get; set; }

        /// <summary>
        /// Кол-во оценок
        /// </summary>
        public int Count { get; set; }


        /// <summary>
        /// Информация о распределении оценок
        /// </summary>
        [NotMapped]
        public virtual ICollection<RatingDistribution> Distribution { get; set; }

        public string StatusId { get; set; }
        /// <summary>
        /// Статус рейтинга
        /// </summary>
        [ForeignKey(nameof(StatusId))]
        public virtual RatingStatus Status { get; set; }
    }

    /// <summary>
    /// Информация о распределении оценок
    /// </summary>
    public class RatingDistribution
    {
        /// <summary>
        /// Значение оценки
        /// </summary>
        public float Value { get; set; }

        /// <summary>
        /// Кол-во оценок с указанным значением
        /// </summary>
        public long Count { get; set; }

        /// <summary>
        /// Доля оценок с указанным значением среди всех оценок
        /// </summary>
        public int Percent { get; set; }
    }

    /// <summary>
    /// Статус рейтинга
    /// </summary>
    public class RatingStatus
    {
        /// <summary>
        /// Код статуса рейтинга
        /// </summary>
        [Key]
        public string Id { get; set; }

        /// <summary>
        /// Наименование статуса рейтинга
        /// </summary>
        public string Name { get; set; }


        public long? ThisRowCreated { get; set; }

        public long? ThisRowUpdated { get; set; } = 0;
    }

}
