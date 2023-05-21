using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using XyloCode.ThirdPartyServices.YandexMarket.Enum;

namespace XyloCode.ThirdPartyServices.YandexMarket.Entities
{
    /// <summary>
    /// <a href="https://yandex.ru/dev/market/content-data/doc/dg-v2/reference/category-v2.html/">Категория</a>
    /// </summary>
    public class Category
    {
        /// <summary>
        /// Идентификатор категории.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Наименование категории.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Полное наименование категории.
        /// </summary>
        public string FullName { get; set; }

        /// <summary>
        /// Идентификатор родительской категории.
        /// </summary>
        public int? Parent { get; set; }


        [ForeignKey(nameof(Parent))]
        public virtual Category ParentCategory { get; set; }

        public string Hierarchy { get; set; }


        /// <summary>
        /// Признак категории, имеющей возрастное ограничение (18+).
        /// </summary>
        public bool Adult { get; set; }

        /// <summary>
        /// Ссылка на карточку категории на Яндекс.Маркете.
        /// </summary>
        public string Link { get; set; }

        /// <summary>
        /// Количество дочерних категорий.
        /// </summary>
        public int ChildCount { get; set; }


        /// <summary>
        /// Количество моделей в категории.
        /// </summary>
        public int ModelCount { get; set; }

        /// <summary>
        /// Количество товарных предложений в категории.
        /// </summary>
        public int OfferCount { get; set; }

        /// <summary>
        /// Тип размещения товарных предложений в категории.
        /// </summary>
        public AdvertisingModel AdvertisingModel { get; set; }

        /// <summary>
        /// Тип отображения товаров в категории.
        /// </summary>
        public ViewType ViewType { get; set; }

        /// <summary>
        /// Количество категорий в результатах поиска.
        /// </summary>
        public int FindCount { get; set; }

        /// <summary>
        /// Предупреждения, связанные с категорией.
        /// </summary>
        public virtual ICollection<CategoryWarning> Warnings { get; set; }

        public virtual ICollection<VendorCategory> Vendors { get; set; }

        public long? ThisRowCreated { get; set; }
        public long? ThisRowUpdated { get; set; } = 0;
        public long? ThisNodeUpdated { get; set; } = 0;
    }
}
