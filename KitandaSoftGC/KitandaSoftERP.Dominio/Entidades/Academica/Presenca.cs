using System;
using System.Collections.Generic;
using System.Text;

namespace KitandaSoftERP.Dominio.Entidades.Academica
{
    public class Presenca : Retorno.Retorno
    {
        public Presenca()
        {

        }

        public Presenca(int pAula, int pMatricula, string pPresenca, string pUtilizador)
        {
            AulaID = pAula;
            MatriculaID = pMatricula;
            Status = pPresenca;
            Utilizador = pUtilizador;
        }

        public Presenca(int pOrdem, int pAulaID, int pMatricula, string pPresenca, string pInscricao, string pNome, int pAlunoID, AulaDTO pAula)
        {
            AulaID = pAulaID;
            MatriculaID = pMatricula;
            Status = pPresenca;
            OrderNumber = pOrdem;
            AlunoID = pAlunoID;
            NroInscricao = pInscricao;
            SocialName = pNome;
            Aula = pAula;
        }


        public int AulaID { get; set; }
        public int MatriculaID { get; set; }
       
        public decimal NotaAvaliacao { get; set; } // Avaliação Contínua

        public int AlunoID { get; set; }
        public string NroInscricao { get; set; }
        public Aula Aula { get; set; }
        public DateTime DataIni { get; set; }
        public DateTime DataTerm { get; set; }
    }
}
