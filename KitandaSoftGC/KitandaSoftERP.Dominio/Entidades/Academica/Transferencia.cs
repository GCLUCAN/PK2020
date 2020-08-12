using System;
using System.Collections.Generic;
using System.Text;

namespace KitandaSoftERP.Dominio.Entidades.Academica
{
    public class Transferencia
    {
        public int TransCodigo { get; set; }
        public int TransAluno { get; set; }
        public int TransInstituicao { get; set; }
        public string TransDsInstituicao { get; set; }
        public string TransMotivo { get; set; }

    }
    public class ListaTranferenciasDTO : List<Transferencia>
    {

    }
}
