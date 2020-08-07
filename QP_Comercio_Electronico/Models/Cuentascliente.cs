﻿using System;
using System.Collections.Generic;

#nullable disable

namespace QP_Comercio_Electronico.Models
{
    public partial class Cuentascliente
    {
        public int MiscId { get; set; }
        public int? MiscIdcliente { get; set; }
        public int? MiscIdbanco { get; set; }
        public int? MiscIdtipocuenta { get; set; }

        public virtual Banco MiscIdbancoNavigation { get; set; }
        public virtual Cliente MiscIdclienteNavigation { get; set; }
        public virtual Tipocuentum MiscIdtipocuentaNavigation { get; set; }
    }
}
