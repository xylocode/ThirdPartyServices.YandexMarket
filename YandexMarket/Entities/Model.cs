using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using XyloCode.ThirdPartyServices.YandexMarket.Enum;


namespace XyloCode.ThirdPartyServices.YandexMarket.Entities
{
    /// <summary>
    /// <a href="https://yandex.ru/dev/market/content-data/doc/dg-v2/reference/model-v2.html/">Модель</a>
    /// Информация о модели
    /// </summary>
    public class ModelV2
    {
        /// <summary>
        /// Идентификатор модели.
        /// </summary>
        [Key]
        public long Id { get; set; }

        /// <summary>
        /// Наименование модели
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Тип товара
        /// </summary>
        public string Kind { get; set; }

        /// <summary>
        /// Тип модели
        /// </summary>
        public ModelType Type { get; set; }

        /// <summary>
        /// Признак новизны товара
        /// </summary>
        public bool IsNew { get; set; }

        /// <summary>
        /// Ссылка на карточку модели на большом маркете
        /// </summary>
        public string Link { get; set; }

        /// <summary>
        /// Кол-во товарных предложений модели в регионе запроса
        /// </summary>
        public long OfferCount { get; set; }

        /// <summary>
        /// Кол-во отзывов на модель
        /// </summary>
        public int OpinionCount { get; set; }

        /// <summary>
        /// Кол-во статей/обзоров на модель
        /// </summary>
        public int ReviewCount { get; set; }

        /// <summary>
        /// Кол-во модификаций групповой модели. Поле отсутствует в выдаче, если модель не групповая.
        /// </summary>
        public int ModificationCount { get; set; }

        /// <summary>
        /// Дата-время последнего обновления модели в спсике стравнения.
        /// Примечание. Только для списков сравнения
        /// </summary>
        public long LastUpdate { get; set; }

        public long ParentId { get; set; }

        /// <summary>
        /// Информация о групповой модели к которой относится модификация.
        /// Ограничение. Заполняется только у модифкаций.
        /// </summary>
        [ForeignKey(nameof(ParentId))]
        public virtual ModelV2 Parent { get; set; }

        public string Hierarchy { get; set; }

        /// <summary>
        /// Описание модели
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Основное изображение модели
        /// </summary>
        [NotMapped]
        public Photo Photo { get; set; }

        /// <summary>
        /// Остальные изображения модели
        /// </summary>
        public virtual ICollection<Photo> Photos { get; set; }

        public int? CategoryId { get; set; }

        /// <summary>
        /// Информация о категории, к которой относится модель
        /// </summary>
        [ForeignKey(nameof(CategoryId))]
        public virtual Category Category { get; set; }

        public int? NavigationNodeId { get; set; }

        /// <summary>
        /// Информация об узле навигационного дерева, к которому относится модель
        /// </summary>
        [ForeignKey(nameof(NavigationNodeId))]
        public virtual NavigationCategory NavigationNode { get; set; }

        /// <summary>
        /// Информация о цене модели в основной валюте запроса
        /// </summary>
        public ModelPrice Price { get; set; }

        /// <summary>
        /// Информация о цене модели в альтернативной валюте запроса
        /// </summary>
        public ModelPrice AlternatePrice { get; set; }

        public long? VendorId { get; set; }
        /// <summary>
        /// Информация о производителе модели
        /// </summary>
        [ForeignKey(nameof(VendorId))]
        public virtual Vendor Vendor { get; set; }


        /// <summary>
        /// Информация о рейтинге модели
        /// </summary>
        [NotMapped]
        public Rating Rating { get; set; }

        /// <summary>
        /// Факты о модели
        /// </summary>
        [NotMapped]
        public ModelFact Facts { get; set; }

        /// <summary>
        /// Дисклеймер, связанный с моделью.
        /// Только в версиях API: 2.1.0-2.1.1.
        /// </summary>
        //[Obsolete("Только в версиях API: 2.1.0-2.1.1."), NotMapped]
        //public string Warning { get; set; }

        /// <summary>
        /// Строковый код дисклеймера
        /// Только в версиях API: 2.1.1+.
        /// </summary>
        public virtual ICollection<Warning> Warnings { get; set; }


        /// <summary>
        /// Список фильтров, предназначенных для фильтрации моделей/модификаций
        /// Типы:
        /// Фильтр.
        /// Фильтр со значениями.
        /// Числовой фильтр
        /// </summary>
        public virtual ICollection<Filter> Filters { get; set; }

        /// <summary>
        /// Список модификаций групповой модели.Получаются с fields = MODIFICATIONS
        /// </summary>
        public virtual ICollection<Modification> Modifications { get; set; }

        /// <summary>
        /// Основные характеристики модели
        /// </summary>
        [NotMapped]
        public virtual ICollection<ModelSpecification> Specification { get; set; }

        /// <summary>
        /// Информация, касающаяся текущего пользователя
        /// </summary>
        public UserRelated UserRelated { get; set; }

        public long? ThisRowCreated { get; set; }

        public long? ThisRowUpdated { get; set; } = 0;

        public long? ThisNodeUpdated { get; set; } = 0;
    }

    /// <summary>
    /// Факты о модели
    /// </summary>
    public class ModelFact
    {
        /// <summary>
        /// Достоинства
        /// </summary>
        public ICollection<string> Pro { get; set; }

        /// <summary>
        /// Недостатки
        /// </summary>
        public ICollection<string> Contra { get; set; }
    }

    /// <summary>
    /// Основные характеристики модели
    /// </summary>
    public class ModelSpecification
    {
        /// <summary>
        /// Название группы характеристик
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Список характеристик
        /// </summary>
        public ICollection<ModelSpecificationFeatures> Features { get; set; }
    }

    /// <summary>
    /// Список характеристик
    /// </summary>
    public class ModelSpecificationFeatures
    {
        /// <summary>
        /// Наименование характеристики
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Значение характеристики
        /// </summary>
        public string Value { get; set; }
    }

    /// <summary>
    /// Информация, касающаяся текущего пользователя
    /// </summary>
    public class UserRelated
    {
        /// <summary>
        /// Модель находится в списках сравнений
        /// </summary>
        public bool InComparisonList { get; set; }

        /// <summary>
        /// Модель находится в отложеннных
        /// </summary>
        public bool InWishlist { get; set; }
    }
}
