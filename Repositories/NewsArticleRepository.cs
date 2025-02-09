using BusinessObjects;
using DataAccessObjects;

namespace Repositories
{
    public class NewsArticleRepository : INewsArticleRepository
    {
        public List<NewsArticle> GetNewsArticles() => ArticlesDAO.GetNewsArticles();

        public NewsArticle GetNewsArticleById(String id) => ArticlesDAO.GetNewsArticleById(id);

        public void SaveNewsArticle(NewsArticle article) => ArticlesDAO.SaveNewsArticle(article);

        public void UpdateNewsArticle(NewsArticle article) => ArticlesDAO.UpdateNewsArticle(article);

        public void DeleteNewsArticle(NewsArticle article) => ArticlesDAO.DeleteNewsArticle(article);
    }

}
