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
        static string FECHAFRA;
        static string SERIE;

        CabeceraFras factura = new CabeceraFras();
        // GET: CabeceraFras
        public ActionResult Index(string Serie, string fechafra)
        {
            
            CabeceraFras fra = new CabeceraFras();
            IVANNEntities db = new IVANNEntities();
            SERIE = Serie;
            ViewBag.Serie = Serie;
            Pacientes paciente = new Pacientes();
            CabFrasGlobal PACI_FRA = new CabFrasGlobal();
            PACI_FRA.PacientesGlob = paciente.GetALLPacientes().ToList();
            Pacientes pacien = new Pacientes();
            var pu = db.spGetUltimaFraCD();
            var pe = db.View_CE.Max(p=>p.Nº_FACTURA);
            return View(PACI_FRA);
        }
        [HttpPost]
        public ActionResult Index(CabFrasGlobal model)
        {
            string serie = SERIE;
            ViewBag.Serie = SERIE.ToString();
            IVANNEntities db = new IVANNEntities();
            CabFrasGlobal PACI_FRA = new CabFrasGlobal();
            Pacientes paciente = new Pacientes();
            PACI_FRA.PacientesGlob = paciente.GetALLPacientes().ToList();
            Pacientes pacien = new Pacientes();
            pacien = db.Pacientes.Find(model.IDPACIENTE);
            CabeceraFras nuevafra = new CabeceraFras();
            nuevafra.IDPACIENTE = model.IDPACIENTE;
            nuevafra.FECHA = Convert.ToDateTime(FECHAFRA);
            nuevafra.TOTAL = model.TOTAL;
            nuevafra.NOMBRE_Y_APELLIDOS = pacien.NOMBRE_Y_APELLIDOS;
            nuevafra.DNI = pacien.DNI;
            nuevafra.Nº_FACTURA = "";
            //PACI_FRA.factura.IDPACIENTE = Convert.ToInt32(model.IDPACIENTE);


            return View(PACI_FRA);

        }
    }
}