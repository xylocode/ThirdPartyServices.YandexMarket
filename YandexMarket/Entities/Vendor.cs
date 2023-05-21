using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace XyloCode.ThirdPartyServices.YandexMarket.Entities
{
    /// <summary>
    /// <a href="https://yandex.ru/dev/market/content-data/doc/dg-v2/reference/vendor-v2.html">Производитель</a>
    /// </summary>
    public class Vendor
    {
        /// <summary>
        /// Идентификатор производителя
        /// </summary>
        [Key]
        public long Id { get; set; }

        /// <summary>
        /// Наименование производителя
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Ссылка на веб-сайт производителя
        /// </summary>
        public string Site { get; set; }

        /// <summary>
        /// Ссылка на изображение логотипа производителя
        /// </summary>
        public string Picture { get; set; }

        /// <summary>
        /// Ссылка на страницу производителя с рекомендованными магазинами
        /// </summary>
        public string RecommendedShops { get; set; }

        /// <summary>
        /// Ссылка на карточку производителя на большом маркете
        /// </summary>
        public string Link { get; set; }


        /// <summary>
        /// Список категорий, в которых представлен данный производитель
        /// </summary>
        //[NotMapped]
        //public virtual ICollection<VendorCategoryV2> Categories { get; set; }


        ///// <summary>
        ///// Список наиболее популярных категорий товаров производителя
        ///// </summary>
        //[NotMapped]
        //public virtual ICollection<VendorCategoryV2> TopCategories { get; set; }
        
        //[NotMapped]
        //public virtual ICollection<VendorCategory> AllCategories
        //{
        //    get
        //    {
        //        var list = new List<VendorCategory>();
        //        VendorCategory vc;
        //        if (Categories!=null)
        //        foreach (VendorCategoryV2 item in Categories)
        //        {
        //            vc = new VendorCategory
        //            {
        //                VendorId = Id,
        //                Vendor = this,
        //                CategoryId = item.Id,
        //                Category = item,
        //                Popularity = item.Popularity,
        //            };
        //            list.Add(vc);

        //        }

        //        if (TopCategories != null)
        //            foreach (VendorCategoryV2 item in TopCategories)
        //        {
        //            vc = new VendorCategory
        //            {
        //                VendorId = Id,
        //                Vendor = this,
        //                CategoryId = item.Id,
        //                Category = item,
        //                Popularity = item.Popularity,
        //                IsTop = true,
        //            };
        //            list.Add(vc);
        //        }
        //        return list;
        //    }
        //}

        public long? ThisRowCreated { get; set; }

        public long? ThisRowUpdated { get; set; }
    }
}
