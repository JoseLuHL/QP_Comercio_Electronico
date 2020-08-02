using System;
using System.Collections.Generic;

#nullable disable

namespace QP_Comercio_Electronico.Models
{
    public partial class Categorium
    {
        public Categorium()
        {
            Productos = new HashSet<Producto>();
        }

        public int CantId { get; set; }
        public string CatDescripcion { get; set; }
        public string CatIdestado { get; set; }

        public virtual ICollection<Producto> Productos { get; set; }
    }
}
