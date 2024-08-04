using Microsoft.AspNetCore.Mvc;
using Products.DataPath;
using Products.Models;
namespace Products.Controllers
{
    public class ProductsController : Controller
    {
        Application application =new Application();

        public IActionResult Mobils()
        {
            var result = application.products.Where(e => e.catogeryId == 1);

            return View(result);
        }


        public IActionResult Details(int id)
        {
              var result=application.products.Find(id);

            return View(result);


        }



        public IActionResult CreateFormWithProduct()
        {




            return View();
        }



        public IActionResult SaveProduct(Product products)
        {

            application.products.Add(products);

            application.SaveChanges();

            return RedirectToAction("CreateFormWithProduct");
        
        }



    }
}
