using System;
using System.Collections.Generic;
using System.Text;

namespace KitandaSoftERP.Dominio.Entidades.Clinica
{
    public class AtendimentoQueixas : Retorno.Retorno
    {
        public int Codigo { get; set; }

        public int Atendimento { get; set; }

        public string Queixa { get; set; }

        public string Tempo { get; set; }

        public AtendimentoQueixas()
        {

        }

        public AtendimentoQueixas(int pCodigo)
        {
            this.Codigo = pCodigo;
        }

        public AtendimentoQueixas(int pAtendimento, string pQueixa)
        {
            this.Atendimento = pAtendimento;
            this.Queixa = pQueixa;
        }

        public AtendimentoQueixas(int pAtendimento, string pDescricao, string pQueixa)
        {
            this.Atendimento = pAtendimento;
            this.Descricao = pDescricao;
            this.Queixa = pQueixa;
        }

        public AtendimentoQueixas(string pDescricao, string pQueixa)
        {

            this.Descricao = pDescricao;
            this.Queixa = pQueixa;
        }

        public AtendimentoQueixas(int pCodigo, int pAtendimento, string pQueixa, string pDescricao)
        {
            this.Codigo = pCodigo;
            this.Descricao = pDescricao;
            this.Queixa = pQueixa;
            Atendimento = pAtendimento;

        }

    }
}
