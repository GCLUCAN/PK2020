using System;
using System.Collections.Generic;
using System.Text;

namespace KitandaSoftERP.Dominio.Entidades.Tesouraria
{
    public class Titulo : Retorno.Retorno
    {
        public int Codigo
        {
            get;
            set;
        }


        public string NomeEntidade
        {
            get;
            set;
        }

        public DateTime Emissao
        {
            get;
            set;
        }

        public string Natureza
        {
            get;
            set;
        }

        public string Historico
        {
            get;
            set;
        }

        public int TotalParcela
        {
            get;
            set;
        }

        public string Documento
        {
            get;
            set;
        }

        public DateTime Cobranca
        {
            get;
            set;
        }

        public DateTime Liquidacao
        {
            get;
            set;
        }

        public string Parcela
        {
            get;
            set;
        }
        public Decimal Valor
        {
            get;
            set;
        }



        public int MeioPagamento { get; set; }

        public Titulo()
        {
            this.Codigo = -1;
            this.Cobranca = new DateTime();
            this.Documento = string.Empty;
            this.Emissao = new DateTime();
            this.Entidade = -1;
            this.Historico = string.Empty;
            this.Liquidacao = new DateTime();
            this.Natureza = string.Empty;
            this.NomeEntidade = string.Empty;
            this.Parcela = string.Empty;
            this.TotalParcela = 0;
            this.Utilizador = string.Empty;
            this.Valor = 0;
            this.MeioPagamento = -1;
            this.CompanyID = "-1";
            Situacao = string.Empty;
            Inicio = string.Empty;
            Ate = string.Empty;
            Rubrica = string.Empty;
            ContaBancaria = string.Empty;
        }

        public Titulo(int pCodigo)
        {
            Codigo = pCodigo;
        }

        public Titulo(string pNatureza, string pSituacao, string pDe, string pAte, string pDocumento, string pEntidade, string pHistorico)
        {
            this.Natureza = pNatureza;
            this.Situacao = pSituacao;
            this.Inicio = pDe;
            this.Ate = pAte;
            this.Documento = pDocumento;
            this.NomeEntidade = pEntidade;
            this.Historico = pHistorico;
        }

        public string Ate { get; set; }

        public string Inicio { get; set; }

        public string Rubrica { get; set; }

        public string ContaBancaria { get; set; }
    }
}
