using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace XyloCode.ThirdPartyServices.YandexMarket.Entities
{
    /// <summary>
    /// <a href="https://yandex.ru/dev/market/content-data/doc/dg-v2/reference/outlet-v2.html/">Пункт выдачи</a>
    /// </summary>
    public class Outlet
    {
        /// <summary>
        /// Идентификатор торговой точки / пункта выдачи товара.
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Наименование торговой точки / пункта выдачи товара.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Тип торговой точки / пункта выдачи товара.
        /// </summary>
        public string Type { get; set; }

        public long? ShopId { get; set; }
        /// <summary>
        /// Информация о магазине, который выдает товар в данной торговой точке.
        /// </summary>
        [ForeignKey(nameof(ShopId))]
        public virtual Shop Shop { get; set; }

        /// <summary>
        /// Список телефонов торговой точки / пункта выдачи товара.
        /// </summary>
        public virtual ICollection<Phone> Phones { get; set; }

        /// <summary>
        /// Адрес торговой точки / пункта выдачи товара.
        /// </summary>
        public Address Address { get; set; }

        /// <summary>
        /// Расписание работы торговой точки / пункта выдачи товара.
        /// </summary>
        public OutletSchedule Schedule { get; set; }


        /// <summary>
        /// Гео-информация о торговой точке / пункте выдачи товара.
        /// </summary>
        public GeoPoint GeoPoint { get; set; }

        public string OfferId { get; set; }
        /// <summary>
        /// Товарное предложение в контексте запроса.
        /// </summary>
        [ForeignKey(nameof(OfferId))]
        public virtual Offer Offer { get; set; }


        public long? ThisRowCreated { get; set; }

        public long? ThisRowUpdated { get; set; }
    }

    /// <summary>
    /// Расписание работы торговой точки / пункта выдачи товара.
    /// </summary>
    public class OutletSchedule
    {
        /// <summary>
        /// Первый рабочий день в неделе.
        /// </summary>
        public string DaysFrom { get; set; }

        /// <summary>
        /// Последний рабочий день в неделе.
        /// </summary>
        public string DaysTill { get; set; }

        /// <summary>
        /// Время начала рабочего дня.
        /// </summary>
        public string From { get; set; }

        /// <summary>
        /// Время окончания рабочего дня.
        /// </summary>
        public string Till { get; set; }
    }
}
