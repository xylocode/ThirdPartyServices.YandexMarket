using XyloCode.ThirdPartyServices.YandexMarket.Entities;

namespace XyloCode.ThirdPartyServices.YandexMarket.ResponseModels
{
    /// <summary>
    /// <a href="https://yandex.ru/dev/market/content-data/doc/dg-v2/reference/category-controller-v2-get-category.html">Информация о категории</a>
    /// Возвращает информацию об указанной категории по ее идентификатору.
    /// Ресурс является регионозависимым.
    /// </summary>
    public class CategoryResponseModel : BaseResponseModel
    {
        /// <summary>
        /// Информация о категории.
        /// </summary>
        public Category Category { get; set; }
    }
}
