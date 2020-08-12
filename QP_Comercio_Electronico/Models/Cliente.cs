using System;
using System.Collections.Generic;

#nullable disable

namespace QP_Comercio_Electronico.Models
{
    public partial class Cliente
    {
        public Cliente()
        {
            Cuentasclientes = new HashSet<Cuentascliente>();
            Ordenes = new HashSet<Ordene>();
        }

        public int ClieId { get; set; }
        public string ClieIdtipoidentificacion { get; set; }
        public string ClieIdentificacion { get; set; }
        public string ClieNombre { get; set; }
        public string ClieApellidos { get; set; }
        public string ClieDireccion { get; set; }
        public string ClieIdsexo { get; set; }
        public string ClieTelefono { get; set; }
        public string ClieBarrio { get; set; }
        public string ClieLongitud { get; set; }
        public string ClieLatitud { get; set; }
        public string ClieAltura { get; set; }
        public string ClieClave { get; set; }

        public virtual ICollection<Cuentascliente> Cuentasclientes { get; set; }
        //public virtual ICollection<Ordene> Ordenes { get; set; }
        private ICollection<Ordene> ordenes { get; set; }
        public virtual ICollection<Ordene> Ordenes
        {
            get { return null; }
            set { ordenes = value; }
        }
    }
}
