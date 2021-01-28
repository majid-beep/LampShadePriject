﻿using _0_Framework.Application;
using _0_FrameWork.Infrastructure;
using ShopManagement.Application.Contracts.ProductCategory;
using ShopManagement.Domain.ProductCategoryAgg;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace ShopManagement.Infrastructure.EFCore.Repository
{
    public class ProductCategoryRepository : RepositoryBase <long,ProductCategory>, IProductCategoryRepository
    {
        private readonly ShopContext _context;

        public ProductCategoryRepository(ShopContext context) : base(context)
        {
            _context = context;
        }

     
        public EditProductacategory GetDetails(long id)
        {
            return _context.ProductCategories.Select(x => new EditProductacategory()
            {
                Id = x.Id,
                Name = x.Name,
                Description = x.Description,
                Keywords = x.Keywords,
                MetaDescription = x.MetaDescription,
                //Picture = x.Picture,
                PictureAlt = x.PictureAlt,
                PictureTitle=x.PictureTitle,
                Slug=x.Slug,

            }).FirstOrDefault(x => x.Id == id);
        }

        public List<ProductCategoryViewModel> GetProductCategories()
        {
            return _context.ProductCategories.Select(x => new ProductCategoryViewModel
            {
                Id=x.Id,
                Name=x.Name 

            }).ToList();
        }

        public string GetSlugById(long id)
        {
            return _context.ProductCategories.Select(x => new { x.Id,x.Slug}).FirstOrDefault(x => x.Id == id).Slug;
        }

        public List<ProductCategoryViewModel> Search(ProductCategorySearchModel searchModel)
        {
            var query = _context.ProductCategories.Select(x => new ProductCategoryViewModel
            {
                Id=x.Id,
                Picture=x.Picture,
                Name=x.Name,
                CreationDate=x.CreationDate.ToFarsi()

            });
            if (!string.IsNullOrWhiteSpace(searchModel.Name))
                query = query.Where(x => x.Name == searchModel.Name);
            return query.OrderByDescending(x => x.Id).ToList();
        }
    }
}
