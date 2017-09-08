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

namespace taskdemo.Controllers
{
    public class HomeController : Controller
    {
        #region----------------------------Declaration--------------------------
        private EFCustomer cust;
        #endregion

        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(Customer fc)
        {
            cust = new EFCustomer();
            cust.save(fc);
            return View();
        }

    }
}
