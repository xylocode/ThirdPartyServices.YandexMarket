using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using XyloCode.ThirdPartyServices.YandexMarket.Enum;

namespace XyloCode.ThirdPartyServices.YandexMarket.Entities
{
    /// <summary>
    /// <a href="https://yandex.ru/dev/market/content-data/doc/dg-v2/reference/navigation-category-v1.html/">Навигационная категория</a>
    /// Элемент навигационного дерева
    /// </summary>
    public class NavigationCategory
    {
        /// <summary>
        /// Идентификатор навигационного узла (nid)
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Идентификатор товарной категории(hid)
        /// </summary>
        public int Hid { get; set; }

        [ForeignKey(nameof(Hid))]
        public virtual Category Category { get; set; }


        /// <summary>
        /// Краткое наименование навигационного узла
        /// </summary>
        public string ShortName { get; set; }

        /// <summary>
        /// Тип узла навигационного дерева
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// Количество товарных предложений в категории узла
        /// </summary>
        public int OfferCount { get; set; }

        /// <summary>
        /// Количество моделей в категории узла
        /// </summary>
        public int ModelCount { get; set; }

        /// <summary>
        /// Признак визуальной категории
        /// </summary>
        public bool Visual { get; set; }

        /// <summary>
        /// Максимальная скидка в категории.
        /// Отдается только для некоторых ручек.
        /// </summary>
        public string MaxDiscount { get; set; }

        /// <summary>
        /// Полное наименование навигационного узла
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Информация о источнике данных для узла навигационного дерева
        /// </summary>
        [NotMapped]
        public DatasourceNavigationCategory Datasource { get; set; }


        /// <summary>
        /// Список изображений, относящихся к данному узлу навигационного дерева
        /// </summary>
        public virtual ICollection<Icon> Icons { get; set; }


        /// <summary>
        /// Иерархический список всех родителей узла, начиная с корня
        /// </summary>
        public virtual ICollection<NavigationCategory> Parents { get; set; }

        /// <summary>
        /// Список дочерних узлов
        /// </summary>
        public virtual ICollection<NavigationCategory> Categories { get; set; }

        public long? ThisRowCreated { get; set; }

        public long? ThisRowUpdated { get; set; }
    }

    /// <summary>
    /// Информация о источнике данных для узла навигационного дерева
    /// </summary>
    public class DatasourceNavigationCategory
    {
        /// <summary>
        /// Тип источника данных
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// Идентификатор категории.
        /// </summary>
        public int Hid { get; set; }

        /// <summary>
        /// Идентификатор узла навигационного дерева
        /// </summary>
        public int Nid { get; set;}

        /// <summary>
        /// Параметры сортировки моделей и товарных предложений источника
        /// </summary>
        public UniversalModelSort Order { get; set; }

        /// <summary>
        /// Список условий фильтрации моделей и товарных предложений источника
        /// Типы:
        /// Критерий фильтрации
        /// Критерий фильтрации по поисковой фразе
        /// </summary>
        public virtual ICollection<Criteria> Criteria { get; set; }
    }


    /// <summary>
    /// Для списка изображений, относящихся к данному узлу навигационного дерева
    /// </summary>
    public class Icon
    {
        /// <summary>
        /// Ссылка на изображение
        /// </summary>
        public string Url { get; set; }
    }

    /// <summary>
    /// Параметры сортировки моделей и товарных предложений источника
    /// </summary>
    public class UniversalModelSort
    {
        /// <summary>
        /// Вариант/параметр, по которому осуществляется сортировка
        /// </summary>
        public ModelSortOrder Sort { get; set; }

        /// <summary>
        /// Направление сортировки
        /// </summary>
        public SortOrder How { get; set; }
    }
}
