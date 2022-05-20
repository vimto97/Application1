using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

using Application1.Models;

namespace Application1.Pages
{
    public class IndexModel1 : PageModel
    {
        private DBCtx Context { get; }
        public IndexModel1(DBCtx _context1)
        {
            this.Context = _context1;
        }

        public List<Devices> Devices { get; set; }


        public void OnGet()
        {
            this.Devices = (from device in this.Context.Device.Take(10)
                            select device).ToList();
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
 