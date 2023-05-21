using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using XyloCode.ThirdPartyServices.YandexMarket.Enum;

namespace XyloCode.ThirdPartyServices.YandexMarket.Entities
{
    /// <summary>
    /// <a href="https://yandex.ru/dev/market/content-data/doc/dg-v2/reference/vendor-category-v2.html/">Категория производителя</a>
    /// </summary>
    public class VendorCategoryV2
    {

        #region Category
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
        #endregion

        /// <summary>
        /// Оценка популярности
        /// </summary>
        public double Popularity { get; set; }

        /// <summary>
        /// Список дочерних категорий
        /// </summary>
        public virtual ICollection<VendorCategoryV2> Children { get; set; }


        public static implicit operator Category(VendorCategoryV2 category)
        {
            return new Category
            {
                Id = category.Id,
                Name = category.Name,
                FullName=category.FullName,
                Parent = category.Parent,
                Hierarchy = category.Hierarchy,
                Adult = category.Adult,
                Link = category.Link,
                ChildCount = category.ChildCount,
                ModelCount = category.ModelCount,
                OfferCount = category.OfferCount,
                AdvertisingModel = category.AdvertisingModel,
                ViewType = category.ViewType,
                FindCount = category.FindCount,
                Warnings = category.Warnings,
            };
        }

    }

    public class VendorCategory
    {
        public int Id { get; set; }

        public long VendorId { get; set; }
        
        [ForeignKey(nameof(VendorId))]
        public virtual Vendor Vendor { get; set; }
        
        public int CategoryId { get; set; }

        [ForeignKey(nameof(CategoryId))]
        public virtual Category Category { get; set; }

        /// <summary>
        /// Оценка популярности
        /// </summary>
        public double Popularity { get; set; }

        /// <summary>
        /// Является наиболее популярной категорией товаров производителя
        /// </summary>
        public bool IsTop { get; set; }
    }
}
