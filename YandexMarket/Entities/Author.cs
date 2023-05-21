using XyloCode.ThirdPartyServices.YandexMarket.Enum;

namespace XyloCode.ThirdPartyServices.YandexMarket.Entities
{
    /// <summary>
    /// Информация об авторе отзыва.
    /// </summary>
    public class Author
    {
        /// <summary>
        /// Имя автора.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Ссылка на аватар.
        /// </summary>
        public string AvatarUrl { get; set; }

        /// <summary>
        /// Количество оценок.
        /// </summary>
        public int Grades { get; set; }

        /// <summary>
        /// Вариант отображения отзыва.
        /// </summary>
        public AuthorVisibility Visibility { get; set; }

        /// <summary>
        /// Информация о профилях автора в социальных сетях.
        /// </summary>
        public Social Social { get; set; }
    }


    /// <summary>
    /// Информация о профилях автора в социальных сетях.
    /// </summary>
    public class Social
    {
        /// <summary>
        /// Тип профиля.
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// Ссылка на профиль.
        /// </summary>
        public string Url { get; set; }
    }
}
