﻿using System;
using System.Collections.Generic;

#nullable disable

namespace QP_Comercio_Electronico.Models
{
    public partial class Ordendetalle
    {
        public int? DetordId { get; set; }
        public string DetordIdproducto { get; set; }
        public string DetordOrdennumero { get; set; }
        public string DetordPrecio { get; set; }
        public string DetordCantidad { get; set; }
        public string DetordDescuento { get; set; }
        public string DetordTotal { get; set; }
        public string DetordTamano { get; set; }
        public string DetordColor { get; set; }
        public string DetordFechaenvio { get; set; }
    }
}
