﻿using ShopManagement.Application.Contracts.ProductCategory;
using ShopManagement.Domain.ProductCategoryAgg;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace ShopManagement.Infrastructure.EFCore.Repository
{
    public class ProductCategoryRepository : IProductCategoryRepository
    {
        private readonly ShopContext _context;

        public ProductCategoryRepository(ShopContext context)
        {
            _context = context;
        }

        public void Create(ProductCategory entity)
        {
            _context.ProductCategories.Add(entity);
        }

        public bool Exists(Expression<Func<ProductCategory, bool>> expression)
        {
            return _context.ProductCategories.Any(expression);
        }

        public ProductCategory Get(long id)
        {
            return _context.ProductCategories.Find(id);
        }

        public List<ProductCategory> GetAll()
        {
            return _context.ProductCategories.ToList();
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
                Picture = x.Picture,
                PictureAlt = x.PictureAlt,
                PictureTitle=x.PictureTitle,
                Slug=x.Slug,

            }).FirstOrDefault(x => x.Id == id);
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }

        public List<ProductCategoryViewModel> Search(ProductCategorySearchModel searchModel)
        {
            var query = _context.ProductCategories.Select(x => new ProductCategoryViewModel
            {
                Id=x.Id,
                Picture=x.Picture,
                Name=x.Name,
                CreationDate=x.CreationDate.ToString(CultureInfo.InvariantCulture),

            });
            if (!string.IsNullOrWhiteSpace(searchModel.Name))
                query = query.Where(x => x.Name == searchModel.Name);
            return query.OrderByDescending(x => x.Id).ToList();
        }
    }
}
