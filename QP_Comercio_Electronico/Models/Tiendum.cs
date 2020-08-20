using System;
using System.Collections.Generic;

#nullable disable

namespace QP_Comercio_Electronico.Models
{
    public partial class Tiendum
    {
        public Tiendum()
        {
            Detalletiendacategoria = new HashSet<Detalletiendacategorium>();
            Ordenes = new HashSet<Ordene>();
            Productos = new HashSet<Producto>();
        }

        public int TienId { get; set; }
        public string TienNit { get; set; }
        public string TienClave { get; set; }
        public string TienTipoidentificacion { get; set; }
        public string TienRazonsocial { get; set; }
        public string TienDireccion { get; set; }
        public string TienBarrio { get; set; }
        public string TienTelefono { get; set; }
        public string TienCorreo { get; set; }
        public string TienLatitud { get; set; }
        public string TienLongitud { get; set; }
        public string TienAltura { get; set; }
        public string TienFacebook { get; set; }
        public string TienInstagram { get; set; }
        public string TienWhatsapp { get; set; }
        public string TienTwitter { get; set; }
        public string TienYoutube { get; set; }
        public string TienFoto { get; set; }
        public bool? TienPremium { get; set; }
        public string TienKey { get; set; }
        public string TienPrivatekey { get; set; }
        public string TienPkey { get; set; }
        public string TienIdcliente { get; set; }

        public virtual ICollection<Detalletiendacategorium> Detalletiendacategoria { get; set; }
        private ICollection<Ordene> ordenes { get; set; }
        public virtual ICollection<Ordene> Ordenes
        {
            get { return null; }
            set { ordenes = value; }
        }
        //public virtual ICollection<Producto> Productos { get; set; }
        private ICollection<Producto> productos { get; set; }
        public virtual ICollection<Producto> Productos
        {
            get { return null; }
            set { productos = value; }
        }
    }
}
