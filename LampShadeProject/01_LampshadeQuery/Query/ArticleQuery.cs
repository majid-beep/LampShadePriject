using _0_Framework.Application;
using _01_LampshadeQuery.Contracts.Article;
using BlogManagement.Infrastructure.EFCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;


namespace _01_LampshadeQuery.Query
{
    public class ArticleQuery : IArticleQuery

    {
        private readonly BlogContext _context;

        public ArticleQuery(BlogContext context)
        {
            _context = context;
        }

        public ArticleQueryModel GetArticleDetails(string slug)
        {
            var article= _context.Articles
                .Include(x => x.Category)
                .Where(x => x.PublishDate <= DateTime.Now)
                .Select(x => new ArticleQueryModel
                {
                    Title = x.Title,
                    CategoryName = x.Category.Name,
                    CategorySlug = x.Category.Slug,
                    Slug = x.Slug,
                    CanonicalAddress = x.CanonicalAddress,
                    Description = x.Description,
                    ShortDescription = x.ShortDescription,
                    MetaDescription = x.MetaDescription,
                    Keywords = x.Keywords,
                    Picture = x.Picture,
                    PictureAlt = x.PictureAlt,
                    PictureTitle = x.PictureTitle,
                    PublishDate = x.PublishDate.ToFarsi(),


                }).FirstOrDefault(x => x.Slug==slug);
            if(!string.IsNullOrWhiteSpace(article.Keywords))
            article.KeywordList = article.Keywords.Split(",").ToList();

            return article;
        }

        public List<ArticleQueryModel> GetLatestArticles()
        {
            return _context.Articles
               .Include(x => x.Category)
               .Where(x => x.PublishDate <= DateTime.Now)
               .Select(x => new ArticleQueryModel
               {
                   Id= x.Id,
                   Title = x.Title,
                   Slug = x.Slug,
                   ShortDescription = x.ShortDescription,
                   Picture = x.Picture,
                   PictureAlt = x.PictureAlt,
                   PictureTitle = x.PictureTitle,
                   PublishDate = x.PublishDate.ToFarsi(),


               }).OrderByDescending(x => x.Id).Take(6).ToList();
        }
    }

       
    
}
