﻿using _0_FrameWork.Application;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlogManagement.Application.Contracts.ArticleCategory
{
   public interface IArticleCategoryApplication
    {
        OperationResult Create(CreateArticleCategory command);
        OperationResult Edit(EditArticleCategory command);
        List<ArticleCategoryViewModel> GetArticleCategories();
        EditArticleCategory GetDetails(long id);
        List<ArticleCategoryViewModel> Search(ArticleCategorySearchModel searchModel);

    }
}
