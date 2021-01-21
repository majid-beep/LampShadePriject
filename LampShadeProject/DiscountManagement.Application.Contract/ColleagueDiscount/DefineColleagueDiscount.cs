using ShopManagement.Application.Contracts.Product;
using System;
using System.Collections.Generic;
using System.Text;

namespace DiscountManagement.Application.Contract.ColleagueDiscount
{
    public class DefineColleagueDiscount
    {
        public long ProductId { get; set; }
        public int DiscountRate { get; set; }
        public List<ProductViewModel>Products { get; set; }
    }
}
