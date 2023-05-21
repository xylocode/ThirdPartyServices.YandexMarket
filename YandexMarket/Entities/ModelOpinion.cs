using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using XyloCode.ThirdPartyServices.YandexMarket.Enum;

namespace XyloCode.ThirdPartyServices.YandexMarket.Entities
{
    /// <summary>
    /// <a href="https://yandex.ru/dev/market/content-data/doc/dg-v2/reference/model-opinion-v2.html/">Отзыв о модели</a>
    /// </summary>
    public class ModelOpinion
    {
        /// <summary>
        /// Идентификатор отзыва.
        /// </summary>
        public long Id { get; set; }

        public long? ModelId { get; set; }
        /// <summary>
        /// Модель.
        /// </summary>
        [ForeignKey(nameof(ModelId))]
        public virtual ModelV2 Model { get; set; }


        /// <summary>
        /// Дата написания отзыва.
        /// </summary>
        public DateTime Date { get; set; }

        /// <summary>
        /// Мнение текущего пользователя об отзыве.
        /// </summary>
        public OpinionVote Vote { get; set; }

        /// <summary>
        /// Оценка отзыва.
        /// </summary>
        public int Grade { get; set; }

        /// <summary>
        /// Причина отклонения отзыва.
        /// </summary>
        public string RejectReason { get; set; }

        /// <summary>
        /// Статус отзыва.
        /// </summary>
        public string State { get; set; }

        /// <summary>
        /// Количество согласных с оценкой.
        /// </summary>
        public int AgreeCount { get; set; }

        /// <summary>
        /// Количество несоглаcных с оценкой.
        /// </summary>
        public int DisagreeCount { get; set; }

        /// <summary>
        /// Время использования модели
        /// </summary>
        public UsageTime UsageTime { get; set; }

        /// <summary>
        /// Признак проверенного покупателя
        /// </summary>
        public bool VerifiedBuyer { get; set; }

        /// <summary>
        /// Текст отзыва.
        /// Чтобы URL страницы отображался корректно, ваш сайт должен разрешить использование HTML-тега A в текстах.
        /// </summary>
        public string Text { get; set; }

        /// <summary>
        /// Описание достоинств.
        /// </summary>
        public string Pros { get; set; }

        /// <summary>
        /// Описание недостатков.
        /// </summary>
        public string Cons { get; set; }

        /// <summary>
        /// Информация об авторе отзыва.
        /// </summary>
        public Author Author { get; set; }

        /// <summary>
        /// Комментарии.
        /// </summary>
        public virtual ICollection<Comment> Comments { get; set; }

        public int? RegionId { get; set; }
        /// <summary>
        /// Регион.
        /// </summary>
        [ForeignKey(nameof(RegionId))]
        public virtual Region Region { get; set; }


        public long? ThisRowCreated { get; set; }

        public long? ThisRowUpdated { get; set; }
    }
}
