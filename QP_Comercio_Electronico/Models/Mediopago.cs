using System;
using System.Collections.Generic;

#nullable disable

namespace QP_Comercio_Electronico.Models
{
    public partial class Mediopago
    {
        public Mediopago()
        {
            Ordenes = new HashSet<Ordene>();
        }

        public int MepId { get; set; }
        public string MepDescripcion { get; set; }
        public string MepDetalle { get; set; }
        public string MepFoto { get; set; }

        public virtual ICollection<Ordene> Ordenes { get; set; }
    }
}
