using System;
using System.Collections.Generic;
using System.Text;

namespace KitandaSoftERP.Dominio.Entidades.Tesouraria
{
    public class Desconto
    {
        public int DesCodigo { get; set; }
        public String DesDescricao { get; set; }
        public String DesCategoria { get; set; }
        public int DesDiasAdiantado { get; set; }
        public int DesEncarregandos { get; set; }
        public String DesStatus { get; set; }
        public Decimal DesPercentual { get; set; }
        public Decimal DesValor { get; set; }
        public String DesTipo { get; set; }
        public int DesMeses { get; set; }

        public Desconto()
        {

        }

        public Desconto(int pCodigo)
        {
            DesCodigo = pCodigo;
        }

        public string DesExcepcao { get; set; }
    }
}
