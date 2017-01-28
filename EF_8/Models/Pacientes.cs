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
    
    public partial class Pacientes
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Pacientes()
        {
            this.CabeceraFras = new HashSet<CabeceraFras>();
        }
    
        public int IDPACIENTE { get; set; }
        public Nullable<int> ORDEN { get; set; }
        public string NOMBRE_Y_APELLIDOS { get; set; }
        public string DNI { get; set; }
        public string CUENTA_BANCO { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CabeceraFras> CabeceraFras { get; set; }
        public List<Pacientes> GetALLPacientes()
        {
            Pacientes paciente = new Pacientes();
            List<Pacientes> pacientes = new List<Pacientes>();
            IVANNEntities db = new IVANNEntities();
            var res = db.spGet_All_Pacientes();
            foreach (var item in res)
            {
                paciente.IDPACIENTE = item.IDPACIENTE;
                paciente.ORDEN = item.ORDEN;
                paciente.NOMBRE_Y_APELLIDOS = item.NOMBRE_Y_APELLIDOS;
                paciente.DNI = item.DNI;
                paciente.CUENTA_BANCO = item.CUENTA_BANCO;
                pacientes.Add(paciente);
                paciente = new Pacientes();
            }

            return pacientes;
        }
    }
}
