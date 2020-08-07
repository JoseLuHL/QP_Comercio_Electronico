using System;
using System.Collections.Generic;

#nullable disable

namespace QP_Comercio_Electronico.Models
{
    public partial class Banco
    {
        public Banco()
        {
            Cuentasclientes = new HashSet<Cuentascliente>();
        }

        public int BanId { get; set; }
        public string BanDescripcion { get; set; }

        public virtual ICollection<Cuentascliente> Cuentasclientes { get; set; }
    }
}
