using _0_FrameWork.Application;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShopManagement.Application.Contracts.Product
{
    public interface IProductApplication
    {
        OperationResult Create(CreateProduct command);
        OperationResult Edit(EditProduct command);
      
        EditProduct GetDetails(long id);
        List<ProductViewModel> GetProducts();
        List<ProductViewModel> Search(ProductSearchModel searchModel);
    }
}
