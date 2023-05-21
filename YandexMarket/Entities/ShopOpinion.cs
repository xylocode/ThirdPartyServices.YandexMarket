using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using XyloCode.ThirdPartyServices.YandexMarket.Enum;

namespace XyloCode.ThirdPartyServices.YandexMarket.Entities
{
    /// <summary>
    /// <a href="https://yandex.ru/dev/market/content-data/doc/dg-v2/reference/shop-opinion-v2.html/">Отзыв на магазин</a>
    /// </summary>
    public class ShopOpinion
    {
        /// <summary>
        /// Идентификатор отзыва.
        /// </summary>
        public long Id { get; set; }

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
        /// Идентификатор заказа, который относится к отзыву.
        /// </summary>
        public string ShopOrderId { get; set; }

        /// <summary>
        /// Способ покупки.
        /// </summary>
        public DeliveryType Delivery { get; set; }

        /// <summary>
        /// Статус решения проблемы пользователя.
        /// </summary>
        public ProblemStatus Problem { get; set; }

        /// <summary>
        /// Текст отзыва.
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


        public long? ShopId { get; set; }
        /// <summary>
        /// Магазин.
        /// </summary>
        [ForeignKey(nameof(ShopId))]
        public virtual Shop Shop { get; set; }


        public long? ThisRowCreated { get; set; }

        public long? ThisRowUpdated { get; set; }
    }
}
