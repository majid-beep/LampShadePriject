using _0_FrameWork.Application;
using System;
using System.Collections.Generic;
using System.Text;

namespace AccountManagement.Application.Contracts.Account
{
    public interface IAccountApplication
    {
        OperationResult Register(RegisterAccount command);
        OperationResult Edit(EditAccount command);
        OperationResult ChangePassword(ChangePassword command);
        EditAccount GetDetails(long id);
        List<AccountViewModel> Search(AccountSearchModel searchModel);
        OperationResult Login(Login command);
        void Logout();
    }
}
