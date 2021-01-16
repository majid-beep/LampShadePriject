﻿using _0_FrameWork.Domain;
using ShopManagement.Application.Contracts.Product;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShopManagement.Domain.ProductAgg
{
    public interface IProductRepository:IRepository<long, Product>
    {
        EditProduct GetDetails(long id);
        List<ProductViewModel> Search(ProductSearchModel serachModel);
    }
}