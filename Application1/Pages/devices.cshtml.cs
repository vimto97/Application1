using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Application1.Pages
{
    public class devicesModel : PageModel
    {
        public List<string> Devices = new List<string>();
        public void OnGet()
        {
            Devices.AddRange(new[] { "Laptop", "Phone", "Desktop", "Dog" });
        }

        public string Message { get; set; } = "Initial Request";
        public void OnPost()
        {
            Message = "Form Posted";
        }
        public void OnPostDelete()
        {
            Message = "Delete handler fired";
        }
        public void OnPostEdit(int id)
        {
            Message = "Edit handler fired";
        }
        public void OnPostView(int id)
        {
            Message = "View handler fired";
        }
    }
}
 