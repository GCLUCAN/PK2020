using System;
using System.Collections.Generic;
using System.Text;

namespace KitandaSoftERP.Dominio.Entidades.RecursosHumanos
{
    public class Funcionario : Geral.Pessoa
    {
        public string MotivoAdmissao { get; set; }

        public string Cargo { get; set; }

        public string RegimeLaboral { get; set; }

        public string Departamento { get; set; }

        public string Turno { get; set; }

        public string CategoriaSalarial { get; set; }

        public double Salario { get; set; }

        public string MotivoDemissao { get; set; }

        public string DataDemissao { get; set; }

        public DateTime DataObtencaoFormacao { get; set; }
        public int Unidade { get; set; }

        public string TipoSalario { get; set; }

        public string CargaHorariaSemanal { get; set; }

        public string CargaHorariaMensal { get; set; }

        public string Vinculo { get; set; }

        public DateTime DataInicioContrato { get; set; }

        public DateTime DataTerminoContrato { get; set; }

        public string VigenciaContrato { get; set; }

        public string PeriodoExperimental { get; set; }

        public DateTime DataAvisoPrevio { get; set; }

        public DateTime DataTermino { get; set; }

        public DateTime DataInicial { get; set; }

        public int Naturalidade { get; set; }
    }
}
