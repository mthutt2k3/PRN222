﻿using BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public interface INewsArticleService
    {
        List<NewsArticle> GetNewsArticles();
        NewsArticle GetNewsArticleById(String id);
        void SaveNewsArticle(NewsArticle article);
        void UpdateNewsArticle(NewsArticle article);
        void DeleteNewsArticle(NewsArticle article);
    }
}
