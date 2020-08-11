using System;
using System.Collections.Generic;
using System.Text;

namespace KitandaSoftERP.Dominio.Entidades.Geral
{
    public class Categoria : Retorno.TabelaGeral
    {
        public string Categoria { get; set; }
        public int TablePriceID { get; set; }
        public int PaymentTermsID { get; set; }
        public decimal LimiteCredito { get; set; }
        public int PromocaoID { get; set; }
        public decimal ValorDesconto { get; set; }

        public Categoria()
        {

        }

        public Categoria(int pCodigo)
        {
            Codigo = pCodigo;
        }

        public Categoria(int pCodigo, string pDescricao)
        {
            Codigo = pCodigo;
            Descricao = pDescricao;
        }

        public Categoria(int pCodigo, string pDescricao, string pSigla, string pCategoria)
        {
            Codigo = pCodigo;
            Descricao = pDescricao;
            Sigla = pSigla;
            Categoria = pCategoria;
        }

        public Categoria(int pCodigo, string pDescricao, string pSigla, int pEstado, string pCategoria)
        {
            Codigo = pCodigo;
            Descricao = pDescricao;
            Sigla = pSigla;
            Estado = pEstado;
            Categoria = pCategoria;
        }

        public Categoria(int pCodigo, string pDescricao, string pSigla, int pEstado, string pCategoria, bool pSucesso, string pMensagem)
        {
            Codigo = pCodigo;
            Descricao = pDescricao;
            Sigla = pSigla;
            Estado = pEstado;
            MensagemErro = pMensagem;
            Sucesso = pSucesso;
            Categoria = pCategoria;
        }


    }
}
