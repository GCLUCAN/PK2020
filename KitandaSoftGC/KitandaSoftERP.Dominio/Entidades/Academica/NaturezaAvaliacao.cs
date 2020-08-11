using System;
using System.Collections.Generic;
using System.Text;

namespace KitandaSoftERP.Dominio.Entidades.Academica
{
    public class NaturezaAvaliacao : Retorno.TabelaGeral
    {
        public NaturezaAvaliacao()
        {

        }


        public NaturezaAvaliacao(int pCodigo)
        {
            Codigo = pCodigo;
        }

        public NaturezaAvaliacao(int pCodigo, string pDescricao)
        {
            Codigo = pCodigo;
            Descricao = pDescricao;
        }

        public NaturezaAvaliacao(int pCodigo, string pDescricao, string pSigla)
        {
            Codigo = pCodigo;
            Descricao = pDescricao;
            Sigla = pSigla;
        }

        public NaturezaAvaliacao(int pCodigo, string pDescricao, string pSigla, int pEstado)
        {
            Codigo = pCodigo;
            Descricao = pDescricao;
            Sigla = pSigla;
            Estado = pEstado;
        }

        public NaturezaAvaliacao(int pCodigo, string pDescricao, string pSigla, string pEstado)
        {
            Codigo = pCodigo;
            Descricao = pDescricao;
            Sigla = pSigla;
        }

        public string Tipo { get; set; }
    }
}
