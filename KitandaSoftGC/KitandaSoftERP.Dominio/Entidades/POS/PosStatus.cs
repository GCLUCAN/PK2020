using KitandaSoftERP.Dominio.Entidades.Tesouraria;
using System;
using System.Collections.Generic;
using System.Text;

namespace KitandaSoftERP.Dominio.Entidades.POS
{
    public class PosStatus : Retorno.Retorno
    {
        public int Codigo { get; set; }
        public int POS { get; set; }
        public string DescricaoPos { get; set; }
        public DateTime Data { get; set; }
        public decimal SaldoInicial { get; set; }
        public int Turno { get; set; }
        public DateTime Abertura { get; set; }
        public decimal SaldoFinal { get; set; }
        public DateTime Fecho { get; set; }
        public string IP { get; set; }
        public int DocumentID { get; set; }
        public object DefaultAccount { get; set; }
        public Movimento PosTransaction { get; set; }
        public decimal ValorSessao { get; set; }
        public DateTime TurnoBegin { get; set; }
        public DateTime TurnoEnd { get; set; }

        public PosStatus()
        {

        }

        public PosStatus(int pCodigo)
        {
            Codigo = pCodigo;
        }

    }
}
