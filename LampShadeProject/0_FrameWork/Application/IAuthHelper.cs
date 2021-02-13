using System;
using System.Collections.Generic;
using System.Text;

namespace _0_FrameWork.Application
{
    public interface IAuthHelper
    {
        void Signout();
        bool IsAuthenticated();
        void Signin(AuthViewModel account);
        string CurrentAccountRole();
        AuthViewModel CurrentAccountInfo();
    }

   
}
