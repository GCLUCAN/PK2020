using System;
using System.Collections.Generic;
using System.Text;

namespace KitandaSoftERP.Dominio.Entidades.Geral
{
    public class Veiculo : Imobilizado
    {
        public Veiculo()
        {

        }

        public Veiculo(int pCodigo)
        {
            VeiculoID = pCodigo;
        }

        public Veiculo(string pMatricula)
        {
            MatriculaID = pMatricula;
        }
        public int VeiculoID { get; set; }
        public string MatriculaID { get; set; }
        public string ChassiNumber { get; set; }
        public string Designation { get; set; }
        public object MarcaID { get; set; }
        public int OwnerID { get; set; }
        public int MyProperty { get; set; }
        public string MotorNumber { get; set; }
        public object FluelID { get; set; }
        public object CategoryID { get; set; }
        public decimal Cilindrada { get; set; }
        public object ColorID { get; set; }
        public string PathImage { get; set; }
        public string CaixaVelocidade { get; set; }
        public DateTime LastRevision { get; set; }
        public DateTime LastIntervencao { get; set; }
        public DateTime NextRevision { get; set; }
        public int ModeloID { get; set; }
        public int NroValvulas { get; set; }
        public string Classe { get; set; }
        public int AnoFabrico { get; set; }
        public int Portas { get; set; }
        public decimal Eixos { get; set; }
        public decimal Tara { get; set; }
        public decimal Peso { get; set; }
        public object Pnematicos { get; set; }
        public int NroCilindros { get; set; }
        public string Matricula { get; set; }
        public string Concessionaria { get; set; }
        public string Estado { get; set; }
    }
}
