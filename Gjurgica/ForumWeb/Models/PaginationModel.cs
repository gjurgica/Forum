using ForumDataAccess.Interfaces;
using ForumDomain;
using ForumServices.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ForumViewModels.ViewModels
{
    public class PaginationModel : PageModel
    {
        private readonly IPostService _postService;

        public PaginationModel(IPostService postService)
        {
            _postService = postService;
        }
        public PaginationModel() { }
        [BindProperty(SupportsGet = true)]
        public int CurrentPage { get; set; } = 1;
        public int Count { get; set; }
        public int PageSize { get; set; } = 3;

        public int TotalPages => (int)Math.Ceiling(decimal.Divide(Count, PageSize));

        public List<PostViewModel> Data { get; set; }

    }
}
