using System.Collections.Generic;
using System.Runtime.Serialization;
using XyloCode.ThirdPartyServices.YandexMarket.Enum;

namespace XyloCode.ThirdPartyServices.YandexMarket.QueryModels
{
    public abstract class BaseQueryModel
    {
        public abstract string GetPath();

        public virtual List<KeyValuePair<string, string>> GetDynamicAttributeValuePairs() => null;

        //public string api_key { get; set; }

        /// <summary>
        /// Версия API.
        /// v[мажорная_версия].[минорная_версия].[версия_патча]
        /// </summary>
        [IgnoreDataMember]
        public string version { get; protected set; } = "v2.1.3";

        /// <summary>
        /// Формат выходных данных.
        /// </summary>
        public ResponseFormat? format { get; set; }

        /// <summary>
        /// Признак отображения описания моделей и товарных предложений в формате HTML.
        /// </summary>
        public bool? html_content { get; set; }

        /// <summary>
        /// Размер уменьшенных копий изображений
        /// </summary>
        public ThumbnailSize? thumbnails { get; set; }

        /// <summary>
        /// Требуемая высота изображения.
        /// Высота изображений будет изменена на требуемую с сохранением пропорций.Возможно только уменьшение высоты изображений.
        /// Минимальное значение: 0.
        /// Значение по умолчанию: 0.
        /// </summary>
        public int? height { get; set; }

        /// <summary>
        /// Требуемая ширина изображения.
        /// Ширина изображения будет изменена на требуемую с сохранением пропорций.Возможно только уменьшение ширины изображений.
        /// Минимальное значение: 0.
        /// Значение по умолчанию: 0.
        /// </summary>
        public int? width { get; set; }


        /// <summary>
        /// Размер страницы (количество элементов на странице).
        /// Ограничения: минимальное значение: 1; максимальное значение: 30.
        /// Значение по умолчанию: 10.
        /// </summary>
        public int? count { get; set; }

        /// <summary>
        /// Номер страницы.
        /// Ограничения: минимальное значение: 1.
        /// Значение по умолчанию: 1.
        /// </summary>
        public int? page { get; set; }
    }
}
