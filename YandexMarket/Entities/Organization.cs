using XyloCode.ThirdPartyServices.YandexMarket.Enum;

namespace XyloCode.ThirdPartyServices.YandexMarket.Entities
{
    /// <summary>
    /// <a href="https://yandex.ru/dev/market/content-data/doc/dg-v2/reference/organization.html">Организация</a>
    /// </summary>
    public class Organization
    {
        /// <summary>
        /// Юридическое название
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Основной государственный номер регистрации
        /// </summary>
        public string Ogrn { get; set; }

        /// <summary>
        /// Юридический адрес
        /// </summary>
        public string Address { get; set; }


        /// <summary>
        /// Фактический адрес
        /// </summary>
        public string PostalAddress { get; set; }

        /// <summary>
        /// Тип организации
        /// </summary>
        public OrganizationType Type { get; set; }

        /// <summary>
        /// Ссылка на страницу с контактной информацией
        /// </summary>
        public string ContactUrl { get; set; }
    }
}
