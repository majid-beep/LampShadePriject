﻿using _0_FrameWork.Domain;
using AccountManagement.Domain.AccountAgg;
using System;
using System.Collections.Generic;
using System.Text;

namespace AccountManagement.Domain.RoleAgg
{
   public class Role:EntityBase
    {
        public string Name { get; private set; }
        public List<Account>Accounts { get; private set; }

        public Role(string name)
        {
            Name = name;
            Accounts = new List<Account>();
        }
        public void Edit(string name)
        {
            Name = name;
        }
    }
}
