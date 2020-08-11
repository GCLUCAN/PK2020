using System;
using System.Collections.Generic;
using System.Text;

namespace KitandaSoftERP.Dominio.Entidades.Tesouraria
{
    public class MeioPagamento : Retorno.TabelaGeral
    {
        public string Modo { get; set; }
        public string IconPath { get; set; }


        public MeioPagamento()
        {

        }
        public MeioPagamento(int pCodigo)
        {
            this.Codigo = pCodigo;
        }
        public MeioPagamento(int pCodigo, string pDescricao, string pModo)
        {
            this.Codigo = pCodigo;
            this.Descricao = pDescricao;
            this.Modo = pModo;
        }

        public MeioPagamento(int pCodigo, string pDescricao)
        {
            this.Codigo = pCodigo;
            this.Descricao = pDescricao;
        }

        public MeioPagamento(int pCodigo, string pDescricao, int pStatus, string pModo)
        {
            this.Codigo = pCodigo;
            this.Descricao = pDescricao;
            this.Modo = pModo;

        }
    }
}
