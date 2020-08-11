using System;
using System.Collections.Generic;
using System.Text;

namespace KitandaSoftERP.Dominio.Entidades.Academica
{
    public class Curso : Retorno.Retorno
    {
        public int Codigo { get; set; }

        public string Nome { get; set; }
        public string Abreviatura { get; set; }

        public int Duracao { get; set; }
        public int Estado { get; set; }
        public string Especificacao { get; set; }


        public string Tempo { get; set; }

        public int Inicio { get; set; }

        public int Termino { get; set; }

        public string Formacao { get; set; }

        public Curso()
        {

        }

        public Curso(int pCodigo)
        {
            this.Codigo = pCodigo;
        }

        public Curso(int pCodigo, string pDesignacao)
        {
            this.Codigo = pCodigo;
            this.Nome = pDesignacao;
        }

        public Curso(int pCodigo, string pDesignacao, string pAbreviatura)
        {
            this.Codigo = pCodigo;
            this.Nome = pDesignacao;
            this.Abreviatura = pAbreviatura;
        }

        public Curso(int pCodigo, string pDesignacao, string pAbreviatura, int pEstado)
        {
            this.Codigo = pCodigo;
            this.Nome = pDesignacao;
            this.Abreviatura = pAbreviatura;
            this.Estado = pEstado;
        }

        public Curso(int pCodigo, string pDesignacao, string pAbreviatura, int pDuracao, string pEspecificacao, string pTempo, int pInicio, int pTermino, int pEstado, bool pSucesso, string pMensagem)
        {
            this.Codigo = pCodigo;
            this.Nome = pDesignacao;
            this.Abreviatura = pAbreviatura;
            this.Duracao = pDuracao;
            this.Especificacao = pEspecificacao;
            this.Estado = pEstado;
            this.MensagemErro = pMensagem;
            this.Sucesso = pSucesso;
            this.Tempo = pTempo;
            this.Inicio = pInicio;
            this.Termino = pTermino;
        }

        public string Ensino { get; set; }
        public string Ramo { get; set; }
        public bool isAutorizado { get; set; }
        public string Area { get; set; }
        public string Coordenador { get; set; }
        public string FormatoPauta { get; set; }
    }
}
