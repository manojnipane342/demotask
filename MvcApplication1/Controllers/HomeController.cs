using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using logictast.Abstract;
using logictast.Concreate;
using logictast.Entities;
using System.IO;
using System.Text;
using System.Data.Entity.Validation;

namespace MvcApplication1.Controllers
{
    public class HomeController : Controller
    {
        #region---------------------Declaration----------------
        private EFCustomer _Customer;
        #endregion

        #region-------------------Constructor------------------
        public HomeController(EFCustomer customer)
        {
            _Customer = customer;
        }
        #endregion

        #region-------------------Method-----------------------

        private Random random = new Random((int)DateTime.Now.Ticks);
        private string RandomString(int Size)
        {
            string input = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            StringBuilder builder = new StringBuilder();
            char ch;
            for (int i = 0; i < Size; i++)
            {
                ch = input[random.Next(0, input.Length)];
                builder.Append(ch);
            }
            return builder.ToString();
        }



        #endregion
        public ActionResult Index(int? id)
        {
           
           if (id != null)
           {
               var custdetails = _Customer.customer.FirstOrDefault(c => c.c_id == id);
               return View(custdetails);
           }

            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";
            return View();

        }


        [HttpPost]
        public JsonResult GetCust(int cid)
        {
            var p =( from n in _Customer.customer where n.c_id==cid select n).ToList();
            return Json(p,JsonRequestBehavior.AllowGet);
        
        }
        [HttpPost]
        public JsonResult UpdateCust(int cid,string nm,string mb,string em,string gn,string ag)
        {
            var p = from n in _Customer.customer where n.c_id == cid select n;
            return Json("please check database records updated", JsonRequestBehavior.AllowGet);
        }
        [HttpPost]
        public ActionResult Index(Customer fc)
        {
            // _Customer = new EFCustomer();
            _Customer.save(fc);
            return RedirectToAction("Display", "Home");
        }
        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Display()
        {
            
            List<Customer> custlist = new List<Customer>();
            custlist = _Customer.customer.ToList();
            return PartialView("Display", custlist);
        }
        public ActionResult Delete(int id)
        {
            try
            {
                var d = _Customer.DeleteA(id);
                //return Json(d.c_name + "Has Been Deleted", JsonRequestBehavior.AllowGet);
                return RedirectToAction("Display", "Home");
            }
            catch (Exception e)
            {
                return Json(e.Message, JsonRequestBehavior.AllowGet);
            }
        }

        //******************************demo*****************************

    }
}
