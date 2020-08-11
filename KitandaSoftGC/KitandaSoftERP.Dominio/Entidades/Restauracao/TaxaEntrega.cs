using System;
using System.Collections.Generic;
using System.Text;

namespace KitandaSoftERP.Dominio.Entidades.Restauracao
{
    public class TaxaEntrega : Retorno.TabelaGeral
    {
        public TaxaEntrega()
        {
        }

        public TaxaEntrega(int pCodigo)
        {
            Codigo = pCodigo;
        }

        public TaxaEntrega(int pCodigo, string pDescricao)
        {
            Codigo = pCodigo;
            Descricao = pDescricao;
        }

        public TaxaEntrega(int pCodigo, string pDescricao, decimal pValor)
        {
            Codigo = pCodigo;
            Descricao = pDescricao;
            Valor = pValor;
        }

        public TaxaEntrega(int pCodigo, string pDescricao, decimal pValor, int pEstado)
        {
            Codigo = pCodigo;
            Descricao = pDescricao;
            Valor = pValor;
            Estado = pEstado;
        }

        public TaxaEntrega(int pCodigo, string pDescricao, decimal pValor, int pEstado, bool pSucesso, string pMensagem)
        {
            Codigo = pCodigo;
            Descricao = pDescricao;
            Valor = pValor;
            Estado = pEstado;
            MensagemErro = pMensagem;
            Sucesso = pSucesso;
        }

        public decimal Valor { get; set; }
    }
}
