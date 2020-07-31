using System;
using System.Collections.Generic;

#nullable disable

namespace QP_Comercio_Electronico.Models
{
    public partial class Ordene
    {
        public Ordene()
        {
            Ordendetalles = new HashSet<Ordendetalle>();
        }

        public int OrdId { get; set; }
        public string OrdNumero { get; set; }
        public int? OrdIdcliente { get; set; }
        public int? OrdIdtienda { get; set; }
        public string OrdDireccion { get; set; }
        public string OrdFecha { get; set; }
        public string OrdLatitud { get; set; }
        public string OrdLongitud { get; set; }
        public string OrdAltura { get; set; }
        public string OrdFechaenvio { get; set; }
        public int? OrdIdestado { get; set; }
        public double? OrdTotalcompra { get; set; }
        public string OrdDescripcion { get; set; }
        public int? OrdIdformapago { get; set; }

        public virtual Cliente OrdIdclienteNavigation { get; set; }
        public virtual Estadoorden OrdIdestadoNavigation { get; set; }
        public virtual Mediopago OrdIdformapagoNavigation { get; set; }
        public virtual Tiendum OrdIdtiendaNavigation { get; set; }
        public virtual ICollection<Ordendetalle> Ordendetalles { get; set; }
    }
}
