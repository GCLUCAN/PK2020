using System;
using System.Collections.Generic;
using System.Text;

namespace KitandaSoftERP.Dominio.Entidades.Tesouraria
{
    public class FaturaAutorizacao : Retorno.Retorno
    {
        public String AutoUtilizador { get; set; }
        public int AutoFaturac { get; set; }
        public DateTime AutoData { get; set; }
        public String AutoIP { get; set; }
        public String Accao { get; set; }
        public int Fatura { get; set; }

    }
}
