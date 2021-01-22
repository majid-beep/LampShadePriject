using _0_FrameWork.Domain;
using InventoryManagement.Application.Contract.Inventory;
using System;
using System.Collections.Generic;
using System.Text;

namespace InventoryManagement.Domain.InventoryAgg
{
    public interface IInventoryRepository:IRepository<long,Inventory>
    {
        EditInventory GetDetails(long id);
        Inventory GetBy(long ProductId);
        List<InventoryViewModel> Search(InventorySearchModel searchModel);
    }
}
