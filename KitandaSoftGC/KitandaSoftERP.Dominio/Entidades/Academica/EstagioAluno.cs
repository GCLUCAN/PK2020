using System;
using System.Collections.Generic;
using System.Text;

namespace KitandaSoftERP.Dominio.Entidades.Academica
{
    public class EstagioAluno : Retorno.Retorno
    {
        public int Ordem { get; set; }
        public int EstagioID { get; set; }
        public int MatriculaID { get; set; }
        public int AlunoID { get; set; }
        public string NroInscricao { get; set; }
        public string NroProcesso { get; set; }
        public string Curso { get; set; }
        public decimal Teoria { get; set; }
        public decimal Pratica { get; set; }
        public decimal NotaFinal { get; set; }
        public string Observacoes { get; set; }
        public int PaymentID { get; set; }
        public int TurmaID { get; set; }

        public EstagioAluno()
        {

        }

        public EstagioAluno(int pEstagioID)
        {
            EstagioID = pEstagioID;
        }

    }
}
