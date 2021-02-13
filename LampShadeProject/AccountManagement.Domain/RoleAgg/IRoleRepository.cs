using _0_FrameWork.Domain;
using AccountManagement.Application.Contracts.Role;
using System;
using System.Collections.Generic;
using System.Text;

namespace AccountManagement.Domain.RoleAgg
{
    public interface IRoleRepository :IRepository<long, Role>
    {
        EditRole GetDetails(long id);
        List<RoleViewModel> List();
    }
}
