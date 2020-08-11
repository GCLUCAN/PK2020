using System;
using System.Collections.Generic;
using System.Text;

namespace KitandaSoftERP.Dominio.Entidades.Geral
{
    public class RetencaoFonte : Retorno.TabelaGeral
    {
        public string Valorizacao { get; set; }
        public string Tipo { get; set; }
        public string Categoria { get; set; }
        public string SaftTaxLine { get; set; }
        public string ZonaFiscal { get; set; }
        public decimal Valor { get; set; }
        public string Notes { get; set; }

        public RetencaoFonte()
        {
        }
        public RetencaoFonte(int pCodigo)
        {
            Codigo = pCodigo;
        }
        public RetencaoFonte(int pCodigo, string pDescricao)
        {
            Codigo = pCodigo;
            Descricao = pDescricao;
        }

        public RetencaoFonte(int pCodigo, string pDescricao, string pSigla)
        {
            Codigo = pCodigo;
            Descricao = pDescricao;
            Sigla = pSigla;
        }

        public RetencaoFonte(int pCodigo, string pDescricao, string pSigla, int pEstado)
        {
            Codigo = pCodigo;
            Descricao = pDescricao;
            Sigla = pSigla;
            Estado = pEstado;
        }
        public RetencaoFonte(int pCodigo, string pDescricao, string pSigla, int pEstado, bool pSucesso, string pMensagem)
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
