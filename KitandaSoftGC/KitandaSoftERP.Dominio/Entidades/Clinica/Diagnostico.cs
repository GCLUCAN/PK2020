using System;
using System.Collections.Generic;
using System.Text;

namespace KitandaSoftERP.Dominio.Entidades.Clinica
{
    public class Diagnostico : Retorno.TabelaGeral
    {
        public string Doenca { get; set; }

        public string Atendimento { get; set; }

        public Diagnostico()
        {

        }

        public Diagnostico(int pCodigo)
        {
            this.Codigo = pCodigo;
        }

        public Diagnostico(int pCodigo, string pDescricao)
        {
            this.Codigo = pCodigo;
            this.Descricao = pDescricao;
        }

        public Diagnostico(int pCodigo, string pDescricao, string pSigla)
        {
            this.Codigo = pCodigo;
            this.Descricao = pDescricao;
            this.Sigla = pSigla;
        }

        public Diagnostico(int pCodigo, string pDescricao, string pSigla, int pEstado)
        {
            this.Codigo = pCodigo;
            this.Descricao = pDescricao;
            this.Sigla = pSigla;
            this.Estado = pEstado;
        }

        public Diagnostico(int pCodigo, string pDescricao, string pSigla, int pEstado, bool pSucesso, string pMensagem)
        {
            this.Codigo = pCodigo;
            this.Descricao = pDescricao;
            this.Sigla = pSigla;
            this.Estado = pEstado;
            this.MensagemErro = pMensagem;
            this.Sucesso = pSucesso;
        }


        public string Problema { get; set; }

        public string Inicio { get; set; }

        public string IdadeInicio { get; set; }

        public string MesesInicio { get; set; }


        public object Paciente { get; set; }

        public string Termino { get; set; }

        public string IdadeTermino { get; set; }

        public string MesesTermino { get; set; }
    }
}
