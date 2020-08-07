﻿using System;
using System.Collections.Generic;

#nullable disable

namespace QP_Comercio_Electronico.Models
{
    public partial class Tipocuentum
    {
        public Tipocuentum()
        {
            Cuentasclientes = new HashSet<Cuentascliente>();
        }

        public int TipcuId { get; set; }
        public string TipcuDescripcion { get; set; }

        public virtual ICollection<Cuentascliente> Cuentasclientes { get; set; }
    }
}
