using System;
using System.Collections.Generic;
using System.Text;

namespace KitandaSoftERP.Dominio.Entidades.Comercial
{
    public class CondicaoPagamento: Retorno.TabelaGeral
    {
        public decimal DescontoFinaceiro { get; set; }

        public int Vencimento { get; set; }

        public int Periodicidade { get; set; }

        public string Pagamento { get; set; }

        public decimal NroPrestacoes { get; set; }

        public decimal EntradaInicial { get; set; }

        public CondicaoPagamento()
        {
        }
        public CondicaoPagamento(int pCodigo)
        {
            Codigo = pCodigo;
        }

        public CondicaoPagamento(int pCodigo, string pDescricao)
        {
            Codigo = pCodigo;
            Descricao = pDescricao;
        }

        public CondicaoPagamento(int pCodigo, string pDescricao, string pSigla)
        {
            Codigo = pCodigo;
            Descricao = pDescricao;
            Sigla = pSigla;
        }

        public CondicaoPagamento(int pCodigo, string pDescricao, string pSigla, int pEstado)
        {
            Codigo = pCodigo;
            Descricao = pDescricao;
            Sigla = pSigla;
            Estado = pEstado;
        }

        public CondicaoPagamento(int pCodigo, string pDescricao, string pSigla, int pEstado, bool pSucesso, string pMensagem)
        {
            Codigo = pCodigo;
            Descricao = pDescricao;
            Sigla = pSigla;
            Estado = pEstado;
            MensagemErro = pMensagem;
            Sucesso = pSucesso;
        }


        
    }
}
