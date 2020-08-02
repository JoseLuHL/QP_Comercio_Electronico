using System;
using System.Collections.Generic;

#nullable disable

namespace QP_Comercio_Electronico.Models
{
    public partial class Detalletiendacategorium
    {
        public int CanttienIdtienda { get; set; }
        public int CanttienIdcategoria { get; set; }

        public virtual Categorium CanttienIdcategoriaNavigation { get; set; }
        public virtual Tiendum CanttienIdtiendaNavigation { get; set; }
    }
}
