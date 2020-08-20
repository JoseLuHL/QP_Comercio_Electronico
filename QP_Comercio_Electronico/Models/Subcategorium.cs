using System;
using System.Collections.Generic;

#nullable disable

namespace QP_Comercio_Electronico.Models
{
    public partial class Subcategorium
    {
        public Subcategorium()
        {
            Productos = new HashSet<Producto>();
        }

        public int SubcatId { get; set; }
        public string SubcatDescripcion { get; set; }
        public string SubcatFoto { get; set; }
        public int? SubcatIdcategoria { get; set; }

        public virtual Categorium SubcatIdcategoriaNavigation { get; set; }
        //public virtual ICollection<Producto> Productos { get; set; }

        private ICollection<Producto> productos { get; set; }
        public virtual ICollection<Producto> Productos
        {
            get { return null; }
            set { productos = value; }
        }

    }
}
