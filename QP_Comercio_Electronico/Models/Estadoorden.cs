using System;
using System.Collections.Generic;

#nullable disable

namespace QP_Comercio_Electronico.Models
{
    public partial class Estadoorden
    {
        public Estadoorden()
        {
            Ordenes = new HashSet<Ordene>();
        }

        public int EsorId { get; set; }
        public string EsorIdDescripcion { get; set; }

        public virtual ICollection<Ordene> Ordenes { get; set; }
    }
}
