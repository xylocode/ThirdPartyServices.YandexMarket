using System.Collections.Generic;
using XyloCode.ThirdPartyServices.YandexMarket.Entities;

namespace XyloCode.ThirdPartyServices.YandexMarket.ResponseModels
{
    /// <summary>
    /// <a href="https://yandex.ru/dev/market/content-data/doc/dg-v2/reference/opinions-controller-v2-get-shop-opinions.html/">Отзывы о магазине</a>
    /// Возвращает отзывы пользователей о магазине. Оценки без отзывов не входят в ответ.
    /// Ресурс является списочным.
    /// </summary>
    public class ShopOpinionListResponseModel : BaseResponseModel
    {
        /// <summary>
        /// Отзывы на магазин
        /// </summary>
        public ICollection<ShopOpinion> Opinions { get; set; }
    }
}
