using System;
using System.Collections.Generic;
using System.Text;

namespace KitandaSoftERP.Dominio.Entidades.Tesouraria
{
    public class ParcelaMensalidade
    {
        public ParcelaMensalidade()
        {

        }

        public int Codigo { get; set; }
        public Mensalidade Mensalidade { get; set; }
        public string Descricao { get; set; }
        public string Data { get; set; }

        public int Mes { get; set; }
        public decimal ValorUnitario { get; set; }
        public bool CobraMulta { get; set; }

        public ParcelaMensalidade(int pCodigo)
        {
            Codigo = pCodigo;
        }

        public ParcelaMensalidade(int pCodigo, Mensalidade pMensalidade, string pDescricao, string pData, int pMes)
        {
            Codigo = pCodigo;
            Descricao = pDescricao;
            Mensalidade = pMensalidade;
            Data = pData;
            Mes = pMes;
        }
    }
}
