using EF_8.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EF_8.Controllers
{
    public class CabeceraFrasController : Controller
    {
        // GET: CabeceraFras
        public ActionResult Index()
        {
            
            CabeceraFras fra = new CabeceraFras();
            IVANNEntities db = new IVANNEntities();
            
            var pu = db.spGetUltimaFraCD();
            var pe = db.View_CE.Max(p=>p.Nº_FACTURA);
            return View();
        }
    }
}