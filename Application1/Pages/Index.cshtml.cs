﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Application1.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public string Status { get; private set; }
        [BindProperty(SupportsGet = true)]
        public string Name { get; set; }
        [BindProperty]
        public string City { get; set; }
        public void OnGet()
        {
            Status = "Hello World!";

            if (string.IsNullOrWhiteSpace(Name))
            {
                Name = "Random User";
            }
            if (string.IsNullOrWhiteSpace(City))
            {
                City = "in the United Kingdom";
            }
        }
    }
}