using BusinessObjects;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObjects;
using Microsoft.EntityFrameworkCore;

namespace DataAccessObjects
{
    public class ArticlesDAO
    {
        public static List<NewsArticle> GetNewsArticles()
        {
            var list = new List<NewsArticle>();
            try
            {
                using var db = new FunewsManagementContext();
                list = db.NewsArticles.Include(x => x.Category).ToList();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message); // Log lỗi
            }
            return list;
        }

        public static NewsArticle GetNewsArticleById(String id)
        {
            try
            {
                using var db = new FunewsManagementContext();
                return db.NewsArticles.FirstOrDefault(a => a.NewsArticleId.Equals(id));
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                return null;
            }
        }

        public static void SaveNewsArticle(NewsArticle article)
        {
            try
            {
                using var db = new FunewsManagementContext();
                db.NewsArticles.Add(article);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        public static void UpdateNewsArticle(NewsArticle article)
        {
            try
            {
                using var db = new FunewsManagementContext();
                db.NewsArticles.Update(article);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        public static void DeleteNewsArticle(NewsArticle newsArticle)
        {
            try
            {
                using var db = new FunewsManagementContext();
                var article = db.NewsArticles.SingleOrDefault(c => c.NewsArticleId == newsArticle.NewsArticleId);
                if (article != null)
                {
                    db.NewsArticles.Remove(article);
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }
}
