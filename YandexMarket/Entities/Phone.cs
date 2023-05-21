using System.ComponentModel.DataAnnotations.Schema;

namespace XyloCode.ThirdPartyServices.YandexMarket.Entities
{
    /// <summary>
    /// Для списка телефонов торговой точки / пункта выдачи товара.
    /// </summary>
    public class Phone
    {
        /// <summary>
        /// Начение номера телефона в произвольном формате.
        /// </summary>
        public string Number { get; set; }

        /// <summary>
        /// Значение номера телефона в числовом формате.
        /// </summary>
        public string Sanitized { get; set; }

        /// <summary>
        /// Ссылка для получения номера телефона.
        /// </summary>
        public string Call { get; set; }
    }
}
