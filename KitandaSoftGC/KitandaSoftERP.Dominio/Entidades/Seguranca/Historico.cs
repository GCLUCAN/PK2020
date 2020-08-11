using System;
using System.Collections.Generic;
using System.Text;

namespace KitandaSoftERP.Dominio.Entidades.Seguranca
{
    public class Historico
    {
      
        public int HistCodigo { get; set; }
        public string HistAccao { get; set; }
        public string HistFormulario { get; set; }
        public string HistDescricao { get; set; }
        public string HistUtilizador { get; set; }
        public DateTime HistData { get; set; }
        public DateTime HistHora { get; set; }
        public DateTime HistDtInicial { get; set; }
        public DateTime HistDtFim { get; set; }


    }

    public class ListaDeHistoricos : List<Historico>
    {

    }
}

