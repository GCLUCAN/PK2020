using System;
using System.Collections.Generic;
using System.Text;

namespace KitandaSoftERP.Dominio.Entidades.Comercial
{
    public class MetodoPagamento : Retorno.TabelaGeral
    {
        public MetodoPagamento()
        {
        }
        public decimal TotalLinha { get; set; }

        public DateTime Periodo { get; set; }

        public MetodoPagamento(int pCodigo)
        {
            Codigo = pCodigo;
        }

        public MetodoPagamento(int pCodigo, string pDescricao)
        {
            Codigo = pCodigo;
            Descricao = pDescricao;
        }

        public MetodoPagamento(int pCodigo, string pDescricao, string pSigla)
        {
            Codigo = pCodigo;
            Descricao = pDescricao;
            Sigla = pSigla;
        }

        public MetodoPagamento(int pCodigo, string pDescricao, string pSigla, int pEstado)
        {
            Codigo = pCodigo;
            Descricao = pDescricao;
            Sigla = pSigla;
            Estado = pEstado;
        }

        public MetodoPagamento(int pCodigo, string pDescricao, string pSigla, int pEstado, bool pSucesso, string pMensagem)
        {
            Codigo = pCodigo;
            Descricao = pDescricao;
            Sigla = pSigla;
            Estado = pEstado;
            MensagemErro = pMensagem;
            Sucesso = pSucesso;
        }

        public int POSVisible { get; set; }
        public string DescricaoPagamento { get; set; }
        public string Icon { get; set; }
    }
}

