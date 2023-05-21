using System.ComponentModel.DataAnnotations.Schema;

namespace XyloCode.ThirdPartyServices.YandexMarket.Entities
{
    /// <summary>
    /// <a href="https://yandex.ru/dev/market/content-data/doc/dg-v2/reference/modification.html">Модификация</a>
    /// Модификация групповой модели (краткая информация)
    /// </summary>
    public class Modification
    {
        /// <summary>
        /// Идентификатор модели-модификации
        /// </summary>
        public long Id { get; set; }

        public long? ModelId { get; set; }
        /// <summary>
        /// Базовая модель.
        /// </summary>
        [ForeignKey(nameof(ModelId))]
        public virtual ModelV2 Model { get; set; }


        /// <summary>
        /// Наименование модели-модификации
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Описание модели-модификации
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Оценка популярности модели-модификации
        /// </summary>
        public string Popularity { get; set; }

        /// <summary>
        /// Кол-во товарных предложений для данной модификации
        /// </summary>
        public long OfferCount { get; set; }

        /// <summary>
        /// Кол-во магазинов, имеющих товарные предложения данной модификации
        /// </summary>
        public int ShopCount { get; set; }

        /// <summary>
        /// Информация о цене модификации
        /// </summary>
        public ModelPrice Price { get; set; }

        /// <summary>
        /// Информация о ценах на модификацию в альтернативной валюте запроса
        /// </summary>
        public ModelPrice AlternatePrices { get; set; }


        public long? ThisRowCreated { get; set; }

        public long? ThisRowUpdated { get; set; } = 0;
    }
}
