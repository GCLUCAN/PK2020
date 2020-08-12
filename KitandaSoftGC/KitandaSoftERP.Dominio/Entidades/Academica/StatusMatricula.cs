using System;
using System.Collections.Generic;
using System.Text;

namespace KitandaSoftERP.Dominio.Entidades.Academica
{
    public class StatusMatricula : Retorno.TabelaGeral
    {
        public int Movimento { get; set; }
        public string NomeMovimento { get; set; }
        public int Taxa { get; set; }
        public int Multa { get; set; }


        public StatusMatricula()
        {

        }

        public StatusMatricula(int pCodigo)
        {
            this.Codigo = pCodigo;
            this.Descricao = "";
        }

        public StatusMatricula(string pDescricao)
        {
            this.Codigo = 0;
            this.Descricao = pDescricao;
        }

        public StatusMatricula(int pCodigo, string pDescricao)
        {
            this.Codigo = pCodigo;
            this.Descricao = pDescricao;
        }

        public StatusMatricula(string pDescricao, int pmovimento)
        {
            this.Movimento = pmovimento;
            this.Descricao = pDescricao;
        }

        public StatusMatricula(int pCodigo, string pDescricao, int pmovimento, int pStatus)
        {
            this.Codigo = pCodigo;
            this.Descricao = pDescricao;
            this.Movimento = pmovimento;
            this.Estado = pStatus;
        }

        public StatusMatricula(string pDescricao, string pSigla)
        {
            // TODO: Complete member initialization
            Sigla = pSigla;
            Descricao = pDescricao;
        }
    }
 }
