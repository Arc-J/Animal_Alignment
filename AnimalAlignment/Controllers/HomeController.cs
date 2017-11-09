using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AnimalAlignment.Models;


namespace AnimalAlignment.Controllers
{
    public class HomeController : Controller
    {
        private readonly AlignmentContext _context;

        public HomeController(AlignmentContext context)
        {
            _context = context;
        }

        public ActionResult show(int id)
        {                 
            var res = _context.Table.FirstOrDefault(q => q.Id == id);

            return File(res.Image, "image/jpg");
        }

        //  private AlignmentContext db = new AlignmentContext();
        public IActionResult Index()
        {

            
                        
                          
            

            return View();
        }

    


        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
