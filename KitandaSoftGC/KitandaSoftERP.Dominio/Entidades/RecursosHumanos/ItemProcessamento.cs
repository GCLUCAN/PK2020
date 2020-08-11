using System;
using System.Collections.Generic;
using System.Text;

namespace KitandaSoftERP.Dominio.Entidades.RecursosHumanos
{
    public class ItemProcessamento : Retorno.Retorno
    {
        public string Vencimento { get; set; }
        public string Cargo { get; set; }
        public string Beneficio { get; set; }
        public double Valor { get; set; }
        public string Incidencia { get; set; }
        public string Modo { get; set; }
    }
}
