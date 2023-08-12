using EduHome.Areas.Admin.ViewModels.SliderViewModel;
using EduHome.Contexts;
using EduHome.Models;
using Microsoft.AspNetCore.Mvc;

namespace EduHome.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class SliderController : Controller
    {
        
        private readonly AppDbContext _context;

        public SliderController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            
            var sliders = _context.Sliders;
         
            return View(sliders);
        }

        public IActionResult Create()
        {
            return View();
        }
		[HttpPost]
		public async Task<IActionResult> Create(CreateSliderViewModel createSliderViewModel)
		{
			if (!ModelState.IsValid)
			{
				return View();
			}
            Slider slider = new Slider
            {
                Title = createSliderViewModel.Title,
                Description = createSliderViewModel.Description,
                //Img = createSliderViewModel.Img,
            };
			await _context.Sliders.AddAsync(slider);
			await _context.SaveChangesAsync();
			return RedirectToAction(nameof(Index));
		}
	}
}
