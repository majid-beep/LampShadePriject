using _0_FrameWork.Application;
using System;
using System.Collections.Generic;
using System.Text;

namespace AccountManagement.Application.Contracts.Role
{
    public interface IRoleApplication
    {
        OperationResult Create(CreateRole command);
        OperationResult Edit(EditRole command);
        EditRole GetDetails(long id);
        List<RoleViewModel> List();


    }
}
