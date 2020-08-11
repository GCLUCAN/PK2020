using System;
using System.Collections.Generic;
using System.Text;

namespace KitandaSoftERP.Dominio.Entidades.Tesouraria
{
    public class Bolseiro : Retorno.Retorno
    {
        public string Aluno { get; set; }
        public string Bolsa { get; set; }
        public DateTime Inicio { get; set; }
        public string Adesao { get; set; }
        public string Estado { get; set; }
        public Bolseiro()
        {
            // TODO: Complete member initialization

        }
        public Bolseiro(int pAluno)
        {
            // TODO: Complete member initialization
            Aluno = pAluno.ToString();
        }

        public Bolseiro(int pAluno, int pAno)
        {
            // TODO: Complete member initialization
            Aluno = pAluno.ToString();
            AnoLectivo = pAno;
        }

       
    }
}
