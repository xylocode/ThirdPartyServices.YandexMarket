using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace XyloCode.ThirdPartyServices.YandexMarket.Entities
{
    /// <summary>
    /// <a href="https://yandex.ru/dev/market/content-data/doc/dg-v2/reference/offer-v2.html/">Предложение</a>
    /// Оффер
    /// </summary>
    public class Offer
    {
        /// <summary>
        /// Идентификатор предложения.
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// MD5 хеш-код предложения.
        /// </summary>
        public string WareMd5 { get; set; }

        /// <summary>
        /// Название предложения.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Признак, что товар можно купить с промокодом.
        /// </summary>
        public bool Promocode { get; set; }

        /// <summary>
        /// URL товара на сайте магазина.
        /// </summary>
        public string Url { get; set; }

        /// <summary>
        /// URL карточки модели на Яндекс.Маркете.
        /// </summary>
        public string CpaUrl { get; set; }

        /// <summary>
        /// URL карты со списком точек выдачи товара.
        /// </summary>
        public string OutletUrl { get; set; }

        /// <summary>
        /// Признак, что предложение относится к интим-категории (18+).
        /// </summary>
        public bool Adult { get; set; }

        /// <summary>
        /// Возрастные ограничения для предложения.
        /// </summary>
        public string Age { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public bool OnStock { get; set; }

        /// <summary>
        /// Признак наличия товара.
        /// Возможно только значение TRUE — товар есть в наличии.
        /// </summary>
        public int OutletCount { get; set; }

        /// <summary>
        /// Количество точек выдачи.
        /// </summary>
        public int PickupCount { get; set; }

        /// <summary>
        /// Количество точек самовывоза.
        /// </summary>
        public int LocalStoreCount { get; set; }

        /// <summary>
        /// Признак наличия гарантии производителя.
        /// </summary>
        public bool Warranty { get; set; }

        /// <summary>
        /// Признак наличия рекомендации производителя.
        /// </summary>
        public bool Recommended { get; set; }

        /// <summary>
        /// URL предложения на Яндекс.Маркете.
        /// </summary>
        public string Link { get; set; }

        /// <summary>
        /// URL для добавления предложения в корзину на Яндекс.Маркете.
        /// </summary>
        public string CartLink { get; set; }

        /// <summary>
        /// URL предложений на модификации модели в указанном магазине.
        /// Например, для модели «Apple iPhone 8 64 ГБ золотой» будут URL предложений на эту модель в других цветах, если указанный магазин разместил соответствующие предложения на Яндекс.Маркете.
        /// </summary>
        public string OffersLink { get; set; }

        /// <summary>
        /// Количество других предложений на указанный товар в магазине.
        /// Например, магазин разместил на Яндекс.Маркете два предложения с разными ценами на одну и ту же модель из разных партий.
        /// Аналог поля ru.yandex.market.api.offer.Offer#variations
        /// </summary>
        public int VariationCount { get; set; }

        /// <summary>
        /// Описание предложения.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Информация о цене.
        /// </summary>
        public OfferPrice Price { get; set; }

        /// <summary>
        /// Информация о цене в альтернативной валюте.
        /// </summary>
        public OfferPrice AlternatePrice { get; set; }


        public long? ShopId { get; set; }
        /// <summary>
        /// Информация о магазине, который разместил предложение.
        /// </summary>
        [ForeignKey(nameof(ShopId))]
        public virtual Shop Shop { get; set; }


        public long? ModelId { get; set; }
        /// <summary>
        /// Идентификатор модели.
        /// </summary>
        [ForeignKey(nameof(ModelId))]
        public virtual ModelV2 Model { get; set; }


        /// <summary>
        /// Номер телефона магазина.
        /// </summary>
        public Phone Phone { get; set; }

        /// <summary>
        /// Изображения товара.
        /// </summary>
        [NotMapped]
        public virtual ICollection<Photo> Photos { get; set; }

        /// <summary>
        /// Основное изображение товара.
        /// </summary>
        [NotMapped]
        public Photo Photo { get; set; }


        /// <summary>
        /// Уменьшенные изображения товара.
        /// Только в версиях API: 2.1.0-2.1.2.
        /// </summary>
        //[Obsolete("Только в версиях API: 2.1.0-2.1.2."), NotMapped]
        //public virtual ICollection<Photo> PreviewPhotos { get; set; }

        /// <summary>
        /// Параметры модели, по которым можно отфильтровать предложения на нее в поиске Яндекс.Маркета.
        /// Типы:
        /// Фильтр.
        /// Фильтр со значениями.
        /// Числовой фильтр
        /// </summary>
        public virtual ICollection<Filter> ActiveFilters { get; set; }

        /// <summary>
        /// Информация о доставке.
        /// </summary>
        [NotMapped]
        public Delivery Delivery { get; set; }

        public int? CategoryId { get; set; }
        /// <summary>
        /// Информация о категории предложения.
        /// </summary>
        [ForeignKey(nameof(CategoryId))]
        public virtual Category Category { get; set; }


        public long? VendorId { get; set; }
        /// <summary>
        /// Информация о производителе.
        /// </summary>
        [ForeignKey(nameof(VendorId))]
        public virtual Vendor Vendor { get; set; }


        /// <summary>
        /// Предупреждение, связанное с предложением.
        /// Только в версиях API: 2.1.0-2.1.1.
        /// </summary>
        //[Obsolete("Только в версиях API: 2.1.0-2.1.1.")]
        //public string Warning { get; set; }

        /// <summary>
        /// Код предупреждения, связанного с предложением.
        /// Только в версиях API: 2.1.1+.
        /// </summary>
        public virtual ICollection<Warning> Warnings { get; set; }


        /// <summary>
        /// Способы оплаты товара.
        /// </summary>
        public PaymentOptions PaymentOptions { get; set; }

        public long? ThisRowCreated { get; set; }

        public long? ThisRowUpdated { get; set; }
    }


    /// <summary>
    /// Стоимость доставки в валюте заказа.
    /// Стоимость доставки в альтернативной или неденоминированной валюте.
    /// </summary>
    public class OfferPrice
    {
        /// <summary>
        /// Значение цены
        /// </summary>
        public string Value { get; set; }

        /// <summary>
        /// Скидка
        /// </summary>
        public string Discount { get; set; }

        /// <summary>
        /// Базовая цена
        /// </summary>
        public string Base { get; set; }

        /// <summary>
        /// Минимальная цена из всех склеенных офферов в данном магазине
        /// </summary>
        public string ShopMin { get; set; }

        /// <summary>
        /// Максимальная цена из всех склеенных офферов в данном магазине
        /// </summary>
        public string ShopMax { get; set; }
    }


    /// <summary>
    /// Способы оплаты товара.
    /// </summary>
    public class PaymentOptions
    {
        /// <summary>
        /// Оплата картой на Маркете
        /// </summary>
        public bool CanPayByCard { get; set; }
    }
}
