using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

using Application1.Models;

namespace Application1.Pages
{
    public class IndexModel1 : PageModel
    {
        private IndexModel1 Context { get; }
        public IndexModel1(IndexModel1 _context)
        {
            this.Context = _context;
        }

        public List<Devices> Devices { get; set; }


        public void OnGet()
        {
            this.Devices = (from devices in this.Context.Devices.Take(10)
                              select devices).ToList();
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
 