using System;
using System.Collections.Generic;
using System.Text;

namespace KitandaSoftERP.Dominio.Entidades.Comercial
{
    public class GuiaItem : ItemFaturacao
    {
        public decimal Excesso { get; set; }
        public string Marca { get; set; }
        public string Substracto { get; set; }
        public string CustomerName { get; set; }
        public string ReceiverName { get; set; }
        public string DeliveredName { get; set; }
    }
}
