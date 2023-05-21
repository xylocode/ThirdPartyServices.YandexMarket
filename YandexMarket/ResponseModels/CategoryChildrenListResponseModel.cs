using System.Collections.Generic;
using XyloCode.ThirdPartyServices.YandexMarket.Entities;

namespace XyloCode.ThirdPartyServices.YandexMarket.ResponseModels
{
    /// <summary>
    /// <a href="https://yandex.ru/dev/market/content-data/doc/dg-v2/reference/category-controller-v2-get-children-categories.html/">Список подкатегорий</a>
    /// Возвращает список категорий товарного дерева, вложенных в категорию с указанным в запросе идентификатором.
    /// </summary>
    public class CategoryChildrenListResponseModel : BaseResponseModel
    {
        /// <summary>
        /// Список категорий.
        /// </summary>
        public ICollection<Category> Categories { get; set; }
    }
}
