using System;
using System.Collections.Generic;
using System.Text;

namespace KitandaSoftERP.Dominio.Entidades
{
    public class Turma : Retorno.Retorno
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public string Sigla { get; set; }
        public int Curso { get; set; }
        public int Lotacao { get; set; }
        public int Classe { get; set; }
        public int Ano { get; set; }
        public string Sala { get; set; }
        public string Turno { get; set; }
        public string AnosFrom { get; set; }
        public string MesesFrom { get; set; }
        public string DiasFrom { get; set; }
        public string AnosUntil { get; set; }
        public string MesesUntil { get; set; }
        public string DiasUntil { get; set; }

        public Turma()
        {

        }

        public Turma(int pCodigo)
        {
            this.Codigo = pCodigo;
        }

        public Turma(int pCodigo, int pClasse)
        {
            this.Codigo = pCodigo;
            Curso = pClasse;
        }

        public Turma(int codigo, int plano, string nome, string sigla, int lotacao, int status, string sala, string turno, string pFilial, int pCurso)
        {
            this.Codigo = codigo;
            this.Lotacao = lotacao;
            this.Nome = nome;
            this.Sigla = sigla;
            this.Status = status;
            this.Classe = plano;
            this.Sala = sala;
            this.Turno = turno;
            this.CompanyID = pFilial;
            Curso = pCurso;
        }

        public Turma(int pCodigo, string pNome)
        {
            // TODO: Complete member initialization
            Codigo = pCodigo;
            Nome = pNome;
            Sigla = pNome;
        }



        public Turma(int pCodigo, int pClasse, int pFilial)
        {
            // TODO: Complete member initialization
            Codigo = pCodigo;
            Classe = pClasse;
            CompanyID = pFilial.ToString();
        }


        public string strClasse { get; set; }

        public string Localizacao { get; set; }

        public string Director { get; set; }

        public int Matriculados { get; set; }

        public int Regulares { get; set; }

        public int Irregulares { get; set; }

        public decimal Arrecadado { get; set; }

        public decimal Pendente { get; set; }

        public decimal PercentagemArrecadado { get; set; }

        public decimal PercentagemDivida { get; set; }
        public int Masculinos { get; set; }
        public int Femininos { get; set; }

    }
}
