//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EF_8.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class CabeceraFras
    {
        [Key]
        public int IDLINEAFRA { get; set; }
        public int IDPACIENTE { get; set; }
        public string NOMBRE_Y_APELLIDOS { get; set; }
        public string DNI { get; set; }
        public Nullable<System.DateTime> FECHA { get; set; }
        public string Nº_FACTURA { get; set; }
        public Nullable<decimal> TOTAL { get; set; }
    
        public virtual Pacientes Pacientes { get; set; }
        public string Calcula_Ultima_Fra(string factura)
        {
            int pos_slash = factura.IndexOf('/');
            int pos_guion = factura.IndexOf('-');
            int dif = pos_guion - pos_slash;


            string strdigito = factura.Substring(pos_slash + 1, dif - 1);
            int numero;
            numero = Convert.ToInt16(strdigito);
            numero++;
            strdigito = numero.ToString();
            string anio = factura.Substring(pos_guion + 1, 4);
            // ahora la serie
            string serie = factura.Substring(0, pos_slash + 1);

            factura = serie + strdigito + '-' + anio;
            return factura;
        }
        public static void CreaNuevaFra(CabeceraFras fra)
        {
            IVANNEntities db = new IVANNEntities();
            try
            {

                db.CabeceraFras.Add(fra);
                db.SaveChanges();
                
            }
            catch
            {
                
            }
        }
    }
}
