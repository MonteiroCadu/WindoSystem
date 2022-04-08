﻿using System;
using System.Collections.Generic;

namespace Windo.Persistence.Dominio
{
    public partial class HistoricoLicenca
    {
        public int Id { get; set; }
        public int? Tipo { get; set; }
        public decimal Valor { get; set; }
        public int LicencaClienteId { get; set; }
        public DateTime Data { get; set; } = DateTime.Now;  
        public virtual LicencaCliente LicencaClienteNavigation { get; set; } = null!;
        public virtual TipoHistoricoLicenca? TipoNavigation { get; set; }
    }
}
