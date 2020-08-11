using System;
using System.Collections.Generic;
using System.Text;

namespace KitandaSoftERP.Dominio.Entidades.Oficina
{
    public class Marcacao : OrdemServico
    {
        public int Codigo { get; set; }
        public string CancelNotes { get; set; }
    }
}
