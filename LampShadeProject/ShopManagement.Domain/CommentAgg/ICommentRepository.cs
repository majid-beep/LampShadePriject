using _0_FrameWork.Domain;
using ShopManagement.Application.Contracts.Comment;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShopManagement.Domain.CommentAgg
{
    public interface ICommentRepository:IRepository<long,Comment>
    {
        List<CommentViewModel> Search(CommentSearchModel searchModel);
    }
}
