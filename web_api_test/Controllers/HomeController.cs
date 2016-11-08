using web_api_test.Models;
using System.Web.Mvc;

namespace web_api_test.Controllers
{
    public class HomeController : Controller
    {
        //IReservationRespository repository = ReservationRespository.Current;
        public ViewResult Index()
        {
            return View(/*repository.GetAll()*/);
        }

        //public ActionResult Add(Reservation item)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        repository.Add(item);
        //        return RedirectToAction("Index");
        //    }
        //    else return View("Index");
        //}

        //public ActionResult Update(IReservation item)
        //{
        //    if (ModelState.IsValid && repository.Update(item))
        //        return RedirectToAction("Index");
        //    else return View("Index");
        //}

        //public ActionResult Remove(int id)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        repository.Remove(id);
        //        return RedirectToAction("Index");
        //    }
        //    else return View("Index");
        //}
    }
}