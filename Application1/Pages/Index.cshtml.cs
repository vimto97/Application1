﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Application1.Models;

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
        public object Address { get; private set; }

        public void OnGet(IndexModel AddressModel)
        {
            City = AddressModel.City;
            Status = "Hello World!";
            Models.AddressModel.ReferenceEquals(City, Name);
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