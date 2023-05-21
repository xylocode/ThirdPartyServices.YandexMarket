using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace XyloCode.ThirdPartyServices.YandexMarket.Entities
{
    /// <summary>
    /// <a href="https://yandex.ru/dev/market/content-data/doc/dg-v2/reference/delivery-v2.html/">Доставка</a>
    /// </summary>
    public sealed class Delivery
    {
        /// <summary>
        /// Признак бесплатной доставки.
        /// </summary>
        public bool Free { get; set; }

        /// <summary>
        /// Признак, что цена доставки включена в стоимость товара.
        /// </summary>
        public bool DeliveryIncluded { get; set; }

        /// <summary>
        /// Признак наличия доставки.
        /// </summary>
        public bool Carried { get; set; }

        /// <summary>
        /// Признак возможности самовывоза заказа.
        /// </summary>
        public bool Pickup { get; set; }

        /// <summary>
        /// Признак, что товар можно скачать.
        /// </summary>
        public bool Downloadable { get; set; }

        /// <summary>
        /// Признак наличия торгового зала в регионе пользователя.
        /// </summary>
        public bool LocalStore { get; set; }

        /// <summary>
        /// Признак локальной доставки.
        /// Если у магазина есть точки продаж в регионе пользователя.
        /// Также применимо для товаров, которые можно скачать.
        /// </summary>
        public bool LocalDelivery { get; set; }

        /// <summary>
        /// Краткое описание условий доставки.
        /// </summary>
        public string Brief { get; set; }

        /// <summary>
        /// Признак наличия товара.
        /// </summary>
        public bool InStock { get; set; }

        /// <summary>
        /// Признак трансграничной доставки.
        /// </summary>
        public bool Global { get; set; }

        /// <summary>
        /// Стоимость доставки в валюте заказа.
        /// </summary>
        public OfferPrice Price { get; set; }

        /// <summary>
        /// Стоимость доставки в альтернативной или неденоминированной валюте.
        /// </summary>
        public OfferPrice AlternatePrice { get; set; }

        /// <summary>
        /// Свой регион магазина.
        /// </summary>
        public Region ShopRegion { get; set; }

        /// <summary>
        /// Регион пользователя.
        /// </summary>
        public Region UserRegion { get; set; }

        /// <summary>
        /// Описание условий доставки.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Информация о службах доставки, с которыми сотрудничает магазин.
        /// </summary>
        public ICollection<DeliveryOption> Options { get; set; }

        /// <summary>
        /// Информация об условиях самовывоза.
        /// </summary>
        public ICollection<DeliveryOption> PickupOptions { get; set; }
    }

    /// <summary>
    /// Информация о службах доставки, с которыми сотрудничает магазин или об условиях самовывоза.
    /// </summary>
    public class DeliveryOption
    {
        /// <summary>
        /// Краткое описание условий доставки.
        /// </summary>
        public string Brief { get; set; }

        /// <summary>
        /// Информация о службе доставки.
        /// </summary>
        public DeliveryService Service { get; set; }

        /// <summary>
        /// Информация об условиях доставки.
        /// </summary>
        public DeliveryCondition Conditions { get; set; }
    }

    /// <summary>
    /// Информация о службе доставки.
    /// </summary>
    public class DeliveryService
    {
        /// <summary>
        /// Идентификатор службы доставки
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Наименование службы доставки
        /// </summary>
        public string Name { get; set; }

        public long? ThisRowCreated { get; set; }

        public long? ThisRowUpdated { get; set; }
    }


    /// <summary>
    /// Информация об условиях доставки.
    /// </summary>
    public class DeliveryCondition
    {
        /// <summary>
        /// Стоимость доставки в основной валюте
        /// </summary>
        public decimal Price { get; set; }

        /// <summary>
        /// Стоимость доставки в альтернативной валюте
        /// </summary>
        public decimal AlternatePrice { get; set; }

        /// <summary>
        /// Определяет начало периода (день недели), в котором возможна доставка
        /// </summary>
        public int DaysFrom { get; set; }

        /// <summary>
        /// Определяет окончание периода(день недели), в котором возможна доставка
        /// </summary>
        public int DaysTo { get; set; }

        /// <summary>
        /// Время, до которого нужно сделать заказ в часовом поясе пользователя.
        /// Возможные значения - от 0 до 23.
        /// Отсутствие параметра - заказ можно делать в любое время
        /// </summary>
        public int OrderBefore { get; set; }

        /// <summary>
        /// Признак, что стоимость доставки включена в стоимость товарного предложения.
        /// Отсутствие свойства в ввыдаче равнозначно значению false.
        /// </summary>
        public bool DeliveryIncluded { get; set; }
    }
}
