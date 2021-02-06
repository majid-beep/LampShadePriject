using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlogManagement.Application.Contracts.Article;
using BlogManagement.Application.Contracts.ArticleCategory;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace ServiceHost.Areas.Adminstration.Pages.Blog.Articles
{
    public class EditModel : PageModel
    {

        public EditArticle Command;
        public SelectList ArticleCategories;
        private readonly IArticleCategoryApplication _articleCategoryApplication;
        private readonly IArticleApplication _articleApplication;

        public EditModel(IArticleCategoryApplication articleCategoryApplication, IArticleApplication articleApplication)
        {
            _articleCategoryApplication = articleCategoryApplication;
            _articleApplication = articleApplication;
        }

        public void OnGet(long id)
        {
            Command = _articleApplication.GetDetails(id);
            ArticleCategories = new SelectList(_articleCategoryApplication.GetArticleCategories(), "Id", "Name");
        }

        //public IActionResult OnPost(EditArticle command)
        //{
        //    var result = _articleApplication.Edit(command);
        //    return RedirectToPage("./Index");

        //}
        //public IActionResult OnPost(EditArticle command, string slug)
        //{
        //    var result = _articleApplication.Edit(command);
        //    return RedirectToPage("./Index", new { Id = slug });

        //}


        public IActionResult OnPost(EditArticle command)
        {
            var result = _articleApplication.Edit(command);
            return RedirectToPage("./Index");

        }

        //public IActionResult OnPost(AddComment command, string productSlug)
        //{
        //    var result = _commentApplication.Add(command);
        //    return RedirectToPage("/Product", new { Id = productSlug });
        //}
    }
}
