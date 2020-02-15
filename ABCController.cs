using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;
using System.Data.SqlClient;

namespace WebApplication2.Controllers
{
    public class ABCController : Controller
    {
        [HttpPost]
        public ActionResult Index(string rn,string sk,DateTime sd,DateTime ed)
        {
            swapnilEntities ctx = new swapnilEntities();
            TRM tm = new TRM();
            tm.request_name = rn;
            tm.skill = sk;
            tm.startdate = sd;
            tm.enddate = ed;
            ctx.TRMs.Add(tm);
            ctx.SaveChanges();
               return View();
        }
        // GET: ABC
        public ActionResult Index()
        {
           
            return View();
        }
    }
}