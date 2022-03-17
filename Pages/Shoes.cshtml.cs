using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace OnlineShop.Pages
{
    using OnlineShop.Models;
    using OnlineShop.Services;
    public class ShoesModel : PageModel
    {
        public void OnGet()
        {
            shoes = ShoesService.GetAll();
        }
        public List<Shoes> shoes = new();

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
            return Page();
            }
            ShoesService.Add(NewShoes);
            return RedirectToAction("Get");
        }
        [BindProperty]
        public Shoes NewShoes { get; set; } = new();

        public IActionResult OnPostDelete(int id)
        {
            ShoesService.Delete(id);
            return RedirectToAction("Get");
        }
    }
}