using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Application1.Pages
{
    public class Index1Model : PageModel
    {


        private Microsoft.AspNetCore.Hosting.IHostingEnvironment _environment;
        public Index1Model(Microsoft.Extensions.Hosting.IHostingEnvironment environment)
        {
            _environment = (Microsoft.AspNetCore.Hosting.IHostingEnvironment?)environment;
        }
        [BindProperty]
        public IFormFile Upload { get; set; }
        public async Task OnPostAsync()
        {
            var file = Path.Combine(_environment.ContentRootPath, "uploads", Upload.FileName);
            using (var fileStream = new FileStream(file, FileMode.Create))
            {
                await Upload.CopyToAsync(fileStream);
            }
        }
        public void OnGet()
        {

        }
    }
}
