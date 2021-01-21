﻿using _0_FrameWork.Domain;
using DiscountManagement.Application.Contract.ColleagueDiscount;
using System;
using System.Collections.Generic;
using System.Text;

namespace DiscountManagement.Domain.ColleagueDiscountAgg
{
   public interface IColleagueDiscountRepository:IRepository<long,ColleagueDiscount>
    {
        EditColleagueDiscount GetDetails(long id);
        List<ColleagueDiscountViewModel> Search(ColleagueDiscountSearchModel searchModel);

    }
}
