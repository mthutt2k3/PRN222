using BusinessObjects;
using Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class NewsArticleService : INewsArticleService
    {
        private readonly INewsArticleRepository newsArticleRepository;

        public NewsArticleService()
        {
            newsArticleRepository = new NewsArticleRepository();
        }

        public List<NewsArticle> GetNewsArticles() => newsArticleRepository.GetNewsArticles();

        public NewsArticle GetNewsArticleById(String id) => newsArticleRepository.GetNewsArticleById(id);

        public void SaveNewsArticle(NewsArticle article) => newsArticleRepository.SaveNewsArticle(article);

        public void UpdateNewsArticle(NewsArticle article) => newsArticleRepository.UpdateNewsArticle(article);

        public void DeleteNewsArticle(NewsArticle article) => newsArticleRepository.DeleteNewsArticle(article);
    }

}
