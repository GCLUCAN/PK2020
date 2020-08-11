using System;
using System.Collections.Generic;
using System.Text;

namespace KitandaSoftERP.Dominio.Entidades.Geral
{
    public class Feriados : Retorno.TabelaGeral
    {
        public string Dia { get; set; }
        public Feriados()
        {
        }
        public Feriados(int pCodigo)
        {
            Codigo = pCodigo;
        }
        public Feriados(int pCodigo, string pDescricao)
        {
            Codigo = pCodigo;
            Descricao = pDescricao;
        }
        public Feriados(int pCodigo, string pDescricao, string pSigla, string pDia)
        {
            Codigo = pCodigo;
            Descricao = pDescricao;
            Sigla = pSigla;
            Dia = pDia;
        }
        public Feriados(int pCodigo, string pDescricao, string pSigla, int pEstado, string pDia)
        {
            Codigo = pCodigo;
            Descricao = pDescricao;
            Sigla = pSigla;
            Estado = pEstado;
            Dia = pDia;
        }
        public Feriados(int pCodigo, string pDescricao, string pSigla, int pEstado, string pDia, bool pSucesso, string pMensagem)
        {
            Codigo = pCodigo;
            Descricao = pDescricao;
            Sigla = pSigla;
            Dia = pDia;
            Estado = pEstado;
            MensagemErro = pMensagem;
            Sucesso = pSucesso;
        }
    }
}
