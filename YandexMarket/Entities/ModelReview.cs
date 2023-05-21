namespace XyloCode.ThirdPartyServices.YandexMarket.Entities
{
    /// <summary>
    /// <a href="https://yandex.ru/dev/market/content-data/doc/dg-v2/reference/models-controller-v2-get-reviews.html/">Обзоров на модель</a>
    /// </summary>
    public class ModelReview
    {
        /// <summary>
        /// URL обзорной статьи на модель.
        /// </summary>
        public string Url { get; set; }

        /// <summary>
        /// Заголовок обзора на модель.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// URL значка веб-сайта с обзором на модель.
        /// </summary>
        public string FavIcon { get; set; }
    }
}
