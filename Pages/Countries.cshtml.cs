using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DZ1_28._01._2024_.Pages
{
	public class CountriesModel : PageModel
	{
		public string[] Countries { get; set; }
		public string[] Status { get; set; }
		public string[] SizeCountry { get; set; }
		public string[] Budget { get; set; }

		public void OnGet()
        {
			Countries = new string[] { "Russia", "USA", "Ukraine","Japan","Canada" };
			Status = new string[] { "In war", "Not in war" };
			SizeCountry = new string[] { "Small", "Medium", "Big" };
			Budget = new string[] { "Poor Income", "Medium Income", "Rich Income" };

		}
	}
}
