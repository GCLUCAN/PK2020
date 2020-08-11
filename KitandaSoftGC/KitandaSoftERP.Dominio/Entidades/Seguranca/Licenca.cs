using System;
using System.Collections.Generic;
using System.Text;

namespace KitandaSoftERP.Dominio.Entidades.Seguranca
{
    public class Licenca
    {
        public string LicencaID { get; set; }
        public string DataValidade{ get; set; }
        public string AnoFiscal { get; set; }
        public string DataGerada { get; set; }
        public string HostName { get; set; }
        public string HostMacAddress { get; set; }
        public string LicType { get; set; }
        public string LicDesignation { get; set; }
    }
}
