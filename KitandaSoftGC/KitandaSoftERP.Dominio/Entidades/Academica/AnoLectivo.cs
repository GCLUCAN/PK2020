using System;
using System.Collections.Generic;
using System.Text;

namespace KitandaSoftERP.Dominio.Entidades.Academica
{
    public class AnoLectivo : Retorno.Retorno
    {
        public AnoLectivo(int codigo, String ano, String descricao, DateTime inicio, DateTime termino,
            DateTime inicioMatricula, DateTime terminoMatricula, string status)
        {
            this.AnoAno = ano;
            this.AnoCodigo = codigo;
            this.AnoInicio = inicio;
            this.AnoInicioMatricula = inicioMatricula;
            this.AnoDescricao = descricao;
            this.AnoTermino = termino;
            this.AnoTerminoMatricula = terminoMatricula;
            AnoStatus = status;
        }


        public AnoLectivo(int pCodigo, String pDsAno, string pEnsino, string pFilial)
        {
            this.AnoAno = pDsAno;
            this.AnoCodigo = pCodigo;
            CompanyID = pFilial;
            NivelEnsino = pEnsino;
        }
        public AnoLectivo()
        {

        }

        public AnoLectivo(string pCodigo)
        {
            this.AnoCodigo = int.Parse(pCodigo);
        }

        public AnoLectivo(int pCodigo)
        {
            this.AnoCodigo = pCodigo;
        }

        public AnoLectivo(int pCodigo, string pNivelEnsino, string pFilial)
        {
            this.AnoCodigo = pCodigo;
            NivelEnsino = pNivelEnsino;
            CompanyID = pFilial;
        }

        public int AnoCodigo { get; set; }
        public String AnoAno { get; set; }
        public String AnoDescricao { get; set; }
        public DateTime AnoInicio { get; set; }
        public DateTime AnoTermino { get; set; }
        public DateTime AnoInicioMatricula { get; set; }
        public DateTime AnoTerminoMatricula { get; set; }
        public string AnoStatus { get; set; }

        public string TaxaInscricao { get; set; }

        public string MultaMatricula { get; set; }

        public List<PeriodoLectivo> PeriodosLectivosList { get; set; }
    }
}
