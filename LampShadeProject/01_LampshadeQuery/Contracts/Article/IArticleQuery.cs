using System;
using System.Collections.Generic;
using System.Text;

namespace _01_LampshadeQuery.Contracts.Article
{
    public interface IArticleQuery
    {
        ArticleQueryModel GetArticleDetails(string slug);
        List<ArticleQueryModel> GetLatestArticles();
    }
}
