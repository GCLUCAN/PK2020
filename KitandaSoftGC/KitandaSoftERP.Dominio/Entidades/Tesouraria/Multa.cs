using System;
using System.Collections.Generic;
using System.Text;

namespace KitandaSoftERP.Dominio.Entidades.Tesouraria
{
    public class Multa
    {
        public int MulCodigo { get; set; }
        public string MulDescricao { get; set; }
        public Decimal MulValor { get; set; }
        public int MulDe { get; set; }
        public int MulAte { get; set; }
        public DateTime MulInicio { get; set; }
        public DateTime MulTermino { get; set; }
        public Decimal MulPercentual { get; set; }
        public String MulTipo { get; set; }
        public int Estado { get; set; }

        public object Categoria { get; set; }

        public Multa()
        {

        }

        public Multa(int pCodigo)
        {
            MulCodigo = pCodigo;
        }

        public Multa(string pMulta)
        {
            MulDescricao = pMulta;
        }

    }
    public class ListaMultasDTO : List<Multa>
    {

    }
}
