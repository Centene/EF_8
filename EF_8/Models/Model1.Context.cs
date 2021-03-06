﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class IVANNEntities : DbContext
    {
        public IVANNEntities()
            : base("name=IVANNEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<CabeceraFras> CabeceraFras { get; set; }
        public virtual DbSet<Pacientes> Pacientes { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<View_1_Pacientes_CE> View_1_Pacientes_CE { get; set; }
        public virtual DbSet<View_1_Pacientes_TEA> View_1_Pacientes_TEA { get; set; }
        public virtual DbSet<View_Caja> View_Caja { get; set; }
        public virtual DbSet<View_CE> View_CE { get; set; }
        public virtual DbSet<View_FRAS_ALFA> View_FRAS_ALFA { get; set; }
        public virtual DbSet<View_Pacientes_ALFA> View_Pacientes_ALFA { get; set; }
        public virtual DbSet<View_Pacientes_Alfabetico> View_Pacientes_Alfabetico { get; set; }
        public virtual DbSet<View_Remesa> View_Remesa { get; set; }
        public virtual DbSet<View_TEA> View_TEA { get; set; }
    
        public virtual int sp_alterdiagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_alterdiagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int sp_creatediagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_creatediagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int sp_dropdiagram(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_dropdiagram", diagramnameParameter, owner_idParameter);
        }
    
        public virtual ObjectResult<sp_helpdiagramdefinition_Result> sp_helpdiagramdefinition(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_helpdiagramdefinition_Result>("sp_helpdiagramdefinition", diagramnameParameter, owner_idParameter);
        }
    
        public virtual ObjectResult<sp_helpdiagrams_Result> sp_helpdiagrams(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_helpdiagrams_Result>("sp_helpdiagrams", diagramnameParameter, owner_idParameter);
        }
    
        public virtual int sp_renamediagram(string diagramname, Nullable<int> owner_id, string new_diagramname)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var new_diagramnameParameter = new_diagramname != null ?
                new ObjectParameter("new_diagramname", new_diagramname) :
                new ObjectParameter("new_diagramname", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_renamediagram", diagramnameParameter, owner_idParameter, new_diagramnameParameter);
        }
    
        public virtual int sp_upgraddiagrams()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_upgraddiagrams");
        }
    
        public virtual ObjectResult<spCaja_Result> spCaja()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spCaja_Result>("spCaja");
        }
    
        public virtual ObjectResult<spGet_All_Pacientes_Result> spGet_All_Pacientes()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spGet_All_Pacientes_Result>("spGet_All_Pacientes");
        }
    
        public virtual ObjectResult<spGet_Fras_By_Nombre_Result> spGet_Fras_By_Nombre()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spGet_Fras_By_Nombre_Result>("spGet_Fras_By_Nombre");
        }
    
        public virtual ObjectResult<spGetAllFrasCD_Result> spGetAllFrasCD()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spGetAllFrasCD_Result>("spGetAllFrasCD");
        }
    
        public virtual ObjectResult<spGetAllFrasOrderFecha_Result> spGetAllFrasOrderFecha()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spGetAllFrasOrderFecha_Result>("spGetAllFrasOrderFecha");
        }
    
        public virtual ObjectResult<spGetAllFrasTEA_Result> spGetAllFrasTEA()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spGetAllFrasTEA_Result>("spGetAllFrasTEA");
        }
    
        public virtual ObjectResult<spGetFrasByDates_Result> spGetFrasByDates(Nullable<System.DateTime> fechainicial, Nullable<System.DateTime> fechafinal)
        {
            var fechainicialParameter = fechainicial.HasValue ?
                new ObjectParameter("fechainicial", fechainicial) :
                new ObjectParameter("fechainicial", typeof(System.DateTime));
    
            var fechafinalParameter = fechafinal.HasValue ?
                new ObjectParameter("fechafinal", fechafinal) :
                new ObjectParameter("fechafinal", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spGetFrasByDates_Result>("spGetFrasByDates", fechainicialParameter, fechafinalParameter);
        }
    
        public virtual ObjectResult<spGetFrasIDPaciente_Result> spGetFrasIDPaciente(Nullable<int> idpaciente)
        {
            var idpacienteParameter = idpaciente.HasValue ?
                new ObjectParameter("idpaciente", idpaciente) :
                new ObjectParameter("idpaciente", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spGetFrasIDPaciente_Result>("spGetFrasIDPaciente", idpacienteParameter);
        }
    
        public virtual ObjectResult<string> spGetUltimaFraCD()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("spGetUltimaFraCD");
        }
    
        public virtual ObjectResult<string> spGetUltimaFraTEA()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("spGetUltimaFraTEA");
        }
    
        public virtual ObjectResult<Nullable<int>> spGetUltimoIDPACIENTE()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("spGetUltimoIDPACIENTE");
        }
    
        public virtual ObjectResult<spRemesa_Result> spRemesa()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spRemesa_Result>("spRemesa");
        }
    
        public virtual ObjectResult<string> UltimaFra()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("UltimaFra");
        }
    }
}
