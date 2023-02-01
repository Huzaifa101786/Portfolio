using Microsoft.AspNetCore.Mvc;
using Portfolio.Data;
using Portfolio.Models;

namespace Portfolio.Controllers
{
    public class PortfolioController : Controller
    {
        private PortfolioDbContext portfolioDbContext;
        private readonly string demostr = "abc";
        

        public PortfolioController(PortfolioDbContext portfolioDbContext)
        {
            this.portfolioDbContext = portfolioDbContext;
        }
        
        /*Add new Project*/
        public IActionResult Add_Proj()
        {
            return View();
        }
        public IActionResult CV()
        {
            return View();
        }
		public IActionResult Contact()
		{
			return View();
		}
        public IActionResult Proj_details()
        {
            return View();
        }
		
		[HttpPost]
        public IActionResult Add_Proj(Portfolio_Data model)
        {
            var Portfolio_Data = new Portfolio_Data()
            {
                Id = Guid.NewGuid(),
                Proj_Name= model.Proj_Name,
                Proj_Description = model.Proj_Description,
                Proj_Type = model.Proj_Type,
                Proj_Language = model.Proj_Language,
                Pic_1 = demostr /*model.Pic_1*/,
                Pic_2 = demostr /*model.Pic_2*/,
                Pic_3 = demostr /*model.Pic_3*/,
                video = demostr /*model.video*/,
                proj_code = demostr/*model.proj_code*/,
                
            };
            portfolioDbContext.Portfolio_Data.Add(Portfolio_Data);
            portfolioDbContext.SaveChanges();
            return RedirectToAction("Front_Page");
        }

        /*Add Experience*/
		[HttpPost]
		public IActionResult Add_Experience(Experience model)
		{
            var Experience = new Experience()
            {
                Experience_Id = Guid.NewGuid(),
                Domain_Name = model.Domain_Name,
                Description = model.Description,
                Level = model.Level,
                Company_Name = model.Company_Name,
                Image = demostr,
                Experience_type = model.Experience_type,
                position = model.position
	        };
			portfolioDbContext.Experience.Add(Experience);
			portfolioDbContext.SaveChanges();
			return RedirectToAction("Front_Page");
		}

		/*Show added Project*/

		[HttpGet]
        public IActionResult Front_Page()
        {
            /*ist<var> data = new List<var>();*/
            List<Portfolio_Data> p_data = portfolioDbContext.Portfolio_Data.ToList();
            List<Experience> exp_data = portfolioDbContext.Experience.ToList();
            /*var exp_data = portfolioDbContext.Experience.ToList();*/

            dynamic model = new System.Dynamic.ExpandoObject();
            model.portf = p_data;
            model.Exp = exp_data;

            return View(model);
        }




        /*Add Experience*/
        public IActionResult Add_Experience()
        {
            return View();
        }
        /*[HttpPost]
        public IActionResult Add_Experience(Portfolio_Data model)
        {
            var Portfolio_Data = new Portfolio_Data()
            {
                Id = Guid.NewGuid(),
                Proj_Name = model.Proj_Name,
                Proj_Description = model.Proj_Description,
                Proj_Type = model.Proj_Type,
                Proj_Language = model.Proj_Language,
                Pic_1 = demostr *//*model.Pic_1*//*,
                Pic_2 = demostr *//*model.Pic_2*//*,
                Pic_3 = demostr *//*model.Pic_3*//*,
                video = demostr *//*model.video*//*,
                proj_code = demostr*//*model.proj_code*//*,

            };
            portfolioDbContext.Portfolio_Data.Add(Portfolio_Data);
            portfolioDbContext.SaveChanges();
            return RedirectToAction("Front_Page");
        }*/
    }

    
}
