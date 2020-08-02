using System;
using System.Collections.Generic;

#nullable disable

namespace QP_Comercio_Electronico.Models
{
    public partial class Categorium
    {
        public Categorium()
        {
            Detalletiendacategoria = new HashSet<Detalletiendacategorium>();
            Productos = new HashSet<Producto>();
        }

        public int CantId { get; set; }
        public string CatDescripcion { get; set; }
        public string CatIdestado { get; set; }
        public string CatFoto { get; set; }

        public virtual ICollection<Detalletiendacategorium> Detalletiendacategoria { get; set; }
        public virtual ICollection<Producto> Productos { get; set; }
    }
}
