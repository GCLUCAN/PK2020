using System;
using System.Collections.Generic;
using System.Text;

namespace KitandaSoftERP.Dominio.Entidades.Geral
{
    public class Moeda : Retorno.TabelaGeral
    {
        public DateTime Data { get; set; }
        public decimal Valor { get; set; }
        public Moeda()
        {
            Codigo = int.MinValue;
            Descricao = string.Empty;
            Sigla = string.Empty;
            Estado = 1;
            Valor = 0;
            Data = DateTime.Today;
        }

        public Moeda(int pCodigo)
        {
            Codigo = pCodigo;
        }

        public Moeda(int pCodigo, string pDescricao)
        {
            Codigo = pCodigo;
            Descricao = pDescricao;
        }

        public Moeda(int pCodigo, string pDescricao, string pSigla)
        {
            Codigo = pCodigo;
            Descricao = pDescricao;
            Sigla = pSigla;
        }

        public Moeda(int pCodigo, string pDescricao, string pSigla, int pEstado)
        {
            Codigo = pCodigo;
            Descricao = pDescricao;
            Sigla = pSigla;
            Estado = pEstado;
        }

        public Moeda(int pCodigo, string pDescricao, string pSigla, int pEstado, bool pSucesso, string pMensagem)
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
