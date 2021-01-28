using _0_FrameWork.Domain;
using ShopManagement.Application.Contracts.ProductCategory;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace ShopManagement.Domain.ProductCategoryAgg
{
    public interface IProductCategoryRepository :IRepository <long,ProductCategory>
    {
        List<ProductCategoryViewModel> GetProductCategories();
        EditProductacategory GetDetails(long id);
        string GetSlugById(long id);
        List<ProductCategoryViewModel> Search(ProductCategorySearchModel searchModel);
    }
}
