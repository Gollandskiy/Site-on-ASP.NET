using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DZ1_28._01._2024_.Pages
{
    public class RestaurantModel : PageModel
    {
        public string RestaurantName { get; set; } = "Итальянская кухня \"Cibo gourmet\"";

		public string Address { get; set; } = "Улица Тетерево 52";
        public int CountOfStars { get; set; } = 4;
        public void OnGet()
        {
        }
    }
}
