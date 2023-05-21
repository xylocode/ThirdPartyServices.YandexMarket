using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace XyloCode.ThirdPartyServices.YandexMarket.Entities
{
    /// <summary>
    /// <a href="https://yandex.ru/dev/market/content-data/doc/dg-v2/reference/comment.html/">Комментарий</a>
    /// </summary>
    public class Comment
    {
        /// <summary>
        /// Идентификатор комментария
        /// </summary>
        [Key]
        public long Id { get; set; }

        /// <summary>
        /// Идентификатор корневого объекта, к которому относится комментарий
        /// </summary>
        public long? RootId { get; set; }

        [ForeignKey(nameof(RootId))]
        public virtual Comment RootComment { get; set; }


        /// <summary>
        /// Идентификатор родительского комментария или корневого объекта в дереве комментариев
        /// </summary>
        public long? ParentId { get; set; }

        [ForeignKey(nameof(ParentId))]
        public virtual Comment ParentComment { get; set; }

        public string Hierarchy { get; set; }


        /// <summary>
        /// Заголовок комментария
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Timestamp времени последнего обновления комментария
        /// </summary>
        public DateTime UpdateTimestamp { get; set; }

        /// <summary>
        /// Комментарий действителен
        /// </summary>
        public bool Valid { get; set; }

        /// <summary>
        /// Признак удаленного комментария
        /// </summary>
        public bool Deleted { get; set; }

        /// <summary>
        /// Комментарий заблокирован
        /// </summary>
        public bool Blocked { get; set; }

        /// <summary>
        /// Признак прикрепленного комментария
        /// </summary>
        public bool Sticky { get; set; }

        /// <summary>
        /// Текст комментария
        /// </summary>
        public string Body { get; set; }

        public long? UserId { get; set; }

        /// <summary>
        /// Информация об авторе комментария
        /// </summary>
        [ForeignKey(nameof(UserId))]
        public virtual CommentUser User { get; set; }

        /// <summary>
        /// Список дочерних комментариев к данному в дереве комментариев
        /// </summary>
        [NotMapped]
        public ICollection<Comment> Children { get; set; }

        public long? ModelOpinionId { get; set; }

        public long? ShopOpinionId { get; set; }

        public long? ThisRowCreated { get; set; }

        public long? ThisRowUpdated { get; set; } = 0;

        public long? ThisNodeUpdated { get; set; } = 0;
    }

    /// <summary>
    /// Информация об авторе комментария
    /// </summary>
    public class CommentUser
    {
        /// <summary>
        /// Идентификатор автора комментария
        /// </summary>
        [Key]
        public long Id { get; set; }

        /// <summary>
        /// Имя автора комментария
        /// </summary>
        public string Name { get; set; }

        public long? ThisRowCreated { get; set; }

        public long? ThisRowUpdated { get; set; }
    }
}
