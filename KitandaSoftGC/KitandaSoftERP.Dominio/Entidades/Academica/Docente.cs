using System;
using System.Collections.Generic;
using System.Text;

namespace KitandaSoftERP.Dominio.Entidades.Academica
{
    public class Docente:RecursosHumanos.Funcionario
    {
        public bool Estado { get; set; }
        public string DescricaoEstado { get; set; }

        public Docente()
        {

        }

        public Docente(string pCodigo, string pNome)
        {
            this.Codigo = Convert.ToInt32(pCodigo);
            this.NomeCompleto = pNome == null ? string.Empty : pNome;
        }

        public Docente(int pCodigo)
        {
            // TODO: Complete member initialization
            Codigo = pCodigo;
        }


        public int AnoCurricular { get; set; }

        public int Turma { get; set; }

        public int Disciplina { get; set; }
        public int ProvinciaMorada { get; set; }
    }
}
