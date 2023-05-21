using System.Runtime.Serialization;
using XyloCode.ThirdPartyServices.YandexMarket.Enum;

namespace XyloCode.ThirdPartyServices.YandexMarket.QueryModels
{
    /// <summary>
    /// <a href="https://yandex.ru/dev/market/content-data/doc/dg-v2/reference/category-controller-v2-get-children-categories.html/">Список подкатегорий</a>
    /// Возвращает список категорий товарного дерева, вложенных в категорию с указанным в запросе идентификатором.
    /// </summary>
    public class CategoryChildrenListQueryModel : BaseQueryModel
    {
        public override string GetPath() => $"/{version}/categories/{id}/children";

        public CategoryChildrenListQueryModel(int categoryId)
        {
            id = categoryId;
        }

        /// <summary>
        /// Идентификатор категории.
        /// </summary>
        [IgnoreDataMember]
        public int id { get; set; }

        /// <summary>
        /// Параметры категории, которые необходимо показать в выходных данных.
        /// </summary>
        public CategoryFields? fields { get; set; }

        /// <summary>
        /// Тип сортировки категорий.
        /// </summary>
        public CategoriesSortOrder? sort { get; set; }

        ///// <summary>
        ///// Размер страницы (количество элементов на странице).
        ///// Ограничения: минимальное значение: 1; максимальное значение: 30.
        ///// Значение по умолчанию: 10.
        ///// </summary>
        //public int? count { get; set; }

        ///// <summary>
        ///// Номер страницы.
        ///// Ограничения: минимальное значение: 1.
        ///// Значение по умолчанию: 1.
        ///// </summary>
        //public int? page { get; set; }
    }
}
