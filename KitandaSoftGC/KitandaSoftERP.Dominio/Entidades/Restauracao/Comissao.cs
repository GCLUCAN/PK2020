using System;
using System.Collections.Generic;
using System.Text;

namespace KitandaSoftERP.Dominio.Entidades.Restauracao
{
    public class Comissao : Retorno.TabelaGeral
    {
        public decimal Valor { get; set; }
        public Comissao()
        {
        }

        public Comissao(int pCodigo)
        {
            Codigo = pCodigo;
        }

        public Comissao(int pCodigo, string pDescricao)
        {
            Codigo = pCodigo;
            Descricao = pDescricao;
        }

        public Comissao(int pCodigo, string pDescricao, decimal pValor)
        {
            Codigo = pCodigo;
            Descricao = pDescricao;
            Valor = pValor;
        }

        public Comissao(int pCodigo, string pDescricao, decimal pValor, int pEstado)
        {
            Codigo = pCodigo;
            Descricao = pDescricao;
            Valor = pValor;
            Estado = pEstado;
        }

        public Comissao(int pCodigo, string pDescricao, decimal pValor, int pEstado, bool pSucesso, string pMensagem)
        {
            Codigo = pCodigo;
            Descricao = pDescricao;
            Valor = pValor;
            Estado = pEstado;
            MensagemErro = pMensagem;
            Sucesso = pSucesso;
        }

       
    }
}
