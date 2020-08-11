using System;
using System.Collections.Generic;
using System.Text;

namespace KitandaSoftERP.Dominio.Entidades.Academica
{
    public class Ramo : Retorno.Retorno
    {
        public Ramo(int pCodigo, string pDescricao, Curso pCurso, string pDesignacao, int pInicio, int pTermino, int pEstado, string pAreaFormacao)
        {
            this.RamCodigo = pCodigo;
            this.RamCurso = pCurso;
            this.RamDescricao = pDescricao;
            RamDesignacao = pDesignacao;
            this.RamInicio = pInicio;
            this.RamTermino = pTermino;
            RamStatus = 1;
            AreaFormacao = pAreaFormacao;

        }

        public Ramo()
        {

        }

        public Ramo(string pCodigo)
        {
            this.RamCodigo = Convert.ToInt32(pCodigo);
        }

        public Ramo(Curso pCurso)
        {
            RamCurso = pCurso;
        }

        public Ramo(int pID, string pDesignation)
        {
            RamCodigo = pID;
            RamDescricao = pDesignation;
        }

        public Ramo(int pCodigo)
        {
            this.RamCodigo = pCodigo;
        }
        public int RamCodigo { get; set; }
        public string RamDescricao { get; set; }
        public Curso RamCurso { get; set; }
        public string RamDesignacao { get; set; }
        public int RamInicio { get; set; }
        public int RamTermino { get; set; }
        public int RamStatus { get; set; }
        public string Erro { get; set; }
        public string DsInicio { get; set; }
        public string DsTermino { get; set; }

        public string AreaFormacao { get; set; }
    }
}
