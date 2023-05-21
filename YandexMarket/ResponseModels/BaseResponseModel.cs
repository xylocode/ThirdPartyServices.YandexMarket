using System;
using System.Collections.Generic;
using XyloCode.ThirdPartyServices.YandexMarket.Entities;
using XyloCode.ThirdPartyServices.YandexMarket.Enum;

namespace XyloCode.ThirdPartyServices.YandexMarket.ResponseModels
{
    public abstract class BaseResponseModel
    {
        /// <summary>
        /// Статус обработки запроса.
        /// </summary>
        public ResponseStatus Status { get; set; }

        /// <summary>
        /// Контекст обработки запроса.
        /// </summary>
        public ResultContext Context { get; set; }
    }

    public class ResultContext
    {
        /// <summary>
        /// Уникальный идентификатор запроса.
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Дата и время выполнения запроса в формате ISO 8601.
        /// </summary>
        public DateTime Time { get; set; }

        /// <summary>
        /// Ссылка на текущий запрос.
        /// </summary>
        public string Link { get; set; }

        /// <summary>
        /// Ссылка на Яндекс.Маркет.
        /// </summary>
        public string MarketUrl { get; set; }

        /// <summary>
        /// Информация о регионе запроса.
        /// </summary>
        public ContextRegion Region { get; set; }

        /// <summary>
        /// Валюта запроса.
        /// </summary>
        public ContextCurrency Currency { get; set; }

        /// <summary>
        /// Альтернативная валюта запроса.
        /// </summary>
        public ContextCurrency AlternateCurrency { get; set; }

        /// <summary>
        /// Информация о параметрах страницы запроса.
        /// </summary>
        public PageInfo Page { get; set; }

        /// <summary>
        /// Список предупреждений, возникших при обработке запроса.
        /// Предупреждение может быть связано с некритичной ошибкой, позволяющей продолжить обработку запроса.При этом результат может частично не соответствовать параметрам запроса.
        /// </summary>
        public ICollection<Warning> Warnings { get; set; }
    }

    /// <summary>
    /// Информация о регионе запроса.
    /// </summary>
    public class ContextRegion
    {

        /// <summary>
        /// Идентификатор региона.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Наименование региона.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Тип региона.
        /// </summary>
        public RegionType Type { get; set; }

        /// <summary>
        /// Количество дочерних регионов.
        /// </summary>
        public int ChildCount { get; set; }

        /// <summary>
        /// Страна, к которой относится регион.
        /// </summary>
        public Region Country { get; set; }
    }

    /// <summary>
    /// Валюта запроса.
    /// </summary>
    public class ContextCurrency
    {
        /// <summary>
        /// Код валюты.
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Название валюты.
        /// </summary>
        public string Name { get; set; }
    }


    /// <summary>
    /// Информация о параметрах страницы запроса.
    /// </summary>
    public class PageInfo
    {
        /// <summary>
        /// Номер страницы.
        /// </summary>
        public int Number { get; set; }

        /// <summary>
        /// Размер страницы.
        /// </summary>
        public int Count { get; set; }

        /// <summary>
        /// Количество страниц в результате.
        /// </summary>
        public int Total { get; set; }
    }
}
