using Microsoft.AspNetCore.Mvc;

using Products.DataPath;
using Products.Models;
namespace Products.Controllers
{
    public class CatogeryController : Controller
    {
        Application application =new Application();


        public IActionResult Index()
        {

             var result=application.catogeries.ToList();


            return View(result);


        }

        public IActionResult CreateFormWithCatogery()
        {

            return View();
        }

        public IActionResult SaveData(Catogery catogery)
        {

            application.catogeries.Add(catogery);
            application.SaveChanges();

            return RedirectToAction("Index");



        }



        public IActionResult Edit(int id) {


           var result=application.catogeries.Find(id);

            return result !=null? View(result):RedirectToAction("NotFound","Home");
        
 
        }


        public IActionResult SaveEdit(Catogery catogery) {

            application.catogeries.Update(catogery);
            application.SaveChanges();  

            return RedirectToAction("Index");
        
        }


        public ActionResult Delete(int id) {

             var result=application.catogeries.Find(id);

            if (result != null) {

                application.catogeries.Remove(result);
                application.SaveChanges();
                return RedirectToAction("Index");


            }
            else
            {
                return RedirectToAction("NotFound","Home");
            }




        }
       



    }
}
