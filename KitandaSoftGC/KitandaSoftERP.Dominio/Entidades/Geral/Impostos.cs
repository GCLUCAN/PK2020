using System;
using System.Collections.Generic;
using System.Text;

namespace KitandaSoftERP.Dominio.Entidades.Geral
{
    public class Impostos : Retorno.TabelaGeral
    {
        public string Valorizacao { get; set; }
        public string Tipo { get; set; }
        public string Categoria { get; set; }
        public string SaftTaxLine { get; set; }
        public string ZonaFiscal { get; set; }
        public decimal Valor { get; set; }
        public string Notes { get; set; }
        public Impostos()
        {
        }
        public Impostos(int pCodigo)
        {
            Codigo = pCodigo;
        }
        public Impostos(int pCodigo, string pDescricao)
        {
            Codigo = pCodigo;
            Descricao = pDescricao;
        }
        public Impostos(int pCodigo, string pDescricao, string pSigla)
        {
            Codigo = pCodigo;
            Descricao = pDescricao;
            Sigla = pSigla;
        }

        public Impostos(int pCodigo, string pDescricao, string pSigla, int pEstado)
        {
            Codigo = pCodigo;
            Descricao = pDescricao;
            Sigla = pSigla;
            Estado = pEstado;
        }
        public Impostos(int pCodigo, string pDescricao, string pSigla, int pEstado, bool pSucesso, string pMensagem)
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

