using System;
using System.Collections.Generic;
using System.Text;

namespace KitandaSoftERP.Dominio.Entidades.Lavandaria
{
    public class RoupaCor : Retorno.Retorno
    {
        public int Codigo { get; set; }
        public int Cor_Codigo { get; set; }
        public string Observacao { get; set; }
    }
}
