using System;
using System.Collections.Generic;

#nullable disable

namespace QP_Comercio_Electronico.Models
{
    public partial class Ordene
    {
        public int OrdId { get; set; }
        public string OrdNumero { get; set; }
        public string OrdIdcliente { get; set; }
        public string OrdDireccion { get; set; }
        public string OrdFecha { get; set; }
        public string OrdLatitud { get; set; }
        public string OrdLongitud { get; set; }
        public string OrdAltura { get; set; }
        public string OrdFechaenvio { get; set; }
    }
}
