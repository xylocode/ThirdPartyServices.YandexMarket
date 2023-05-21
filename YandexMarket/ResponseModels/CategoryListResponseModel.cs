using System.Collections.Generic;
using XyloCode.ThirdPartyServices.YandexMarket.Entities;

namespace XyloCode.ThirdPartyServices.YandexMarket.ResponseModels
{
    /// <summary>
    /// <a href="https://yandex.ru/dev/market/content-data/doc/dg-v2/reference/category-controller-v2-get-root-categories.html/">Список категорий</a>
    /// Возвращает список категорий первого уровня (корневых) товарного дерева.
    /// </summary>
    public class CategoryListResponseModel : BaseResponseModel
    {
        /// <summary>
        /// Список категорий.
        /// </summary>
        public ICollection<Category> Categories { get; set; }
    }
}
