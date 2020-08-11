using System;
using System.Collections.Generic;
using System.Text;

namespace KitandaSoftERP.Dominio.Entidades.Geral
{
    public class Sala
    {
        public int Codigo{ get; set;}
        public string Descricao{get;set;}
        public int Lotacao{get;set;}
        public string Estado{get;set;}
        public string MensagemErro { get; set; }
        public Sala(int pCodigo)
        {
            Codigo = pCodigo;
        }
        public Sala()
        {
            Codigo = -1;
            Descricao = string.Empty;
            Lotacao = 0;
            Estado = "A";
        }

        public Sala(int pCodigo, string pDescricao, int pLotacao, string pEstado)
        {
            Codigo = pCodigo;
            Descricao = pDescricao;
            Lotacao = pLotacao;
            Estado = pEstado;
        }

       
    }
}
