using EF_8.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EF_8.Controllers
{
    public class HomeController : Controller
    {
        Pacientes paciente = new Pacientes();
        CabeceraFras factura = new CabeceraFras();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Facturacion()
        {
            IVANNEntities db = new IVANNEntities();
            CabFrasGlobal PACI_FRA = new CabFrasGlobal();
            PACI_FRA.PacientesGlob = paciente.GetALLPacientes().ToList();
            Pacientes pacien = new Pacientes();
            return View(PACI_FRA);
        }
        public ActionResult EdicionFras()
        {
            IVANNEntities db = new IVANNEntities();
            CabFrasGlobal PACI_FRA = new CabFrasGlobal();
            PACI_FRA.PacientesGlob = paciente.GetALLPacientes().ToList();

            return View(PACI_FRA);
        }
            
        [HttpPost]
        public ActionResult Facturacion(string Serie, DateTime fecha)
        {
            //EFacturaController otrafra = new EFacturaController();

            string fechita;
            CabeceraFras factura = new CabeceraFras();

            fechita = fecha.ToShortDateString();
            string serie = Serie;

            return RedirectToAction("Index", "CabeceraFras", new { Serie, fechafra = fechita });
        }
        [HttpPost]
        public ActionResult EdicionFras(Pacientes info)
        {
            CabFrasGlobal PACI_FRA = new CabFrasGlobal();
            CabeceraFras fra = new CabeceraFras();
            Pacientes paci = new Pacientes();
            var id = info.IDPACIENTE;
            int idpaciente = Convert.ToInt32(id);
            PACI_FRA.PacientesGlob = paci.GetALLPacientes().ToList();
            PACI_FRA.FacturasGlob = fra.GetFrasByIDPACIENTE(idpaciente);
            return View(PACI_FRA);
            

        }

    }
}