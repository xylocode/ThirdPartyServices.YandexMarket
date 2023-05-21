using System.Collections.Generic;
using System.Runtime.Serialization;
using XyloCode.ThirdPartyServices.YandexMarket.Enum;

namespace XyloCode.ThirdPartyServices.YandexMarket.QueryModels
{
    /// <summary>
    /// <a href="https://yandex.ru/dev/market/content-data/doc/dg-v2/reference/models-controller-v2-get-model.html">Информация о модели</a>
    /// Возвращает информацию о модели.
    /// Ресурс является регионозависимым.
    /// </summary>
    public class ModelQueryModel : BaseQueryModel
    {
        public override string GetPath() => $"/{version}/models/{id}";

        public ModelQueryModel(long modelId, int geoId)
        {
            id = modelId;
            geo_id = geoId;
        }

        /// <summary>
        /// Идентификатор модели.
        /// </summary>
        [IgnoreDataMember]
        public long id { get; set; }

        /// <summary>
        /// Идентификатор региона, для которого нужно получить информацию о модели.
        /// </summary>
        public int geo_id { get; set; }

        /// <summary>
        /// Свойства модели, которые необходимо показать в выходных данных.
        /// </summary>
        public ModelFields? fields { get; set; }


        /// <summary>
        /// Параметры задают условия фильтрации моделей и предложений на модель.
        /// </summary>
        Dictionary<long, string> FILTERS { get; set; }
    }
}
