﻿using _0_Framework.Application;
using _0_FrameWork.Infrastructure;
using BlogManagement.Application.Contracts.ArticleCategory;
using BlogManagement.Domain.ArticleCategoryAgg;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlogManagement.Infrastructure.EFCore.Repository
{
    public class ArticleCategoryRepository : RepositoryBase<long, ArticleCategory>, IArticleCategoryRepository
    {
        private readonly BlogContext _context;

        public ArticleCategoryRepository(BlogContext context):base(context)
        {
            _context = context;
        }

        public EditArticleCategory GetDetails(long id)
        {
            return _context.ArticleCategories.Select(x => new EditArticleCategory
            {
                Id=x.Id,
                Name=x.Name,
                CanonicalAddress=x.CanonicalAddress,
                Description=x.Description,
                Keywords=x.Keywords,
                MetaDescription=x.MetaDescription,
                ShowOrder=x.ShowOrder,
                Slug=x.Slug,
                PictureAlt=x.PictureAlt,
                PictureTtile=x.PictureTitle


            }).FirstOrDefault(x => x.Id==id);
        }

        public string GetSlugBy(long id)
        {
            return _context.ArticleCategories.Select(x => new { x.Id, x.Slug }).FirstOrDefault(x => x.Id == id).Slug;
        }

        public List<ArticleCategoryViewModel> Search(ArticleCategorySearchModel searchModel)
        {
            var query = _context.ArticleCategories.Select(x => new ArticleCategoryViewModel
            {
                Id = x.Id,
                Name = x.Name,
                Description = x.Description,
                Picture = x.Picture,
                ShowOrder = x.ShowOrder,
                CreationDate=x.CreationDate.ToFarsi(),
                
            });
            if (!string.IsNullOrWhiteSpace(searchModel.Name))
                query = query.Where(x => x.Name.Contains(searchModel.Name));
            return query.OrderByDescending(x => x.ShowOrder).ToList();
        }
    }
}
