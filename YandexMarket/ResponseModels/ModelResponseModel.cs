using XyloCode.ThirdPartyServices.YandexMarket.Entities;

namespace XyloCode.ThirdPartyServices.YandexMarket.ResponseModels
{
    /// <summary>
    /// <a href="https://yandex.ru/dev/market/content-data/doc/dg-v2/reference/models-controller-v2-get-model.html">Информация о модели</a>
    /// Возвращает информацию о модели.
    /// Ресурс является регионозависимым.
    /// </summary>
    public class ModelResponseModel : BaseResponseModel
    {
        /// <summary>
        /// Информация о модели.
        /// </summary>
        public ModelV2 Model { get; set; }
    }
}
