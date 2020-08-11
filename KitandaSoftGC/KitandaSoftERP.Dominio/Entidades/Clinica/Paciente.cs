using KitandaSoftERP.Dominio.Entidades.Geral;
using System;
using System.Collections.Generic;
using System.Text;

namespace KitandaSoftERP.Dominio.Entidades.Clinica
{
    public class Paciente : Pessoa
    {
        public int Raca { get; set; }
        public int Religiao { get; set; }
        public string PacienteID { get; set; }
        public string Seguradora { get; set; }
        public string PlanoSeguro { get; set; }
        public string Apolice { get; set; }
        public string Alojamento { get; set; }
        public string Quarto { get; set; }
        public string Cargo { get; set; }
        public string DeficienciaFisica { get; set; }
        public string Area { get; set; }
        public string Contrato { get; set; }
        public string Matricula { get; set; }
       


        public Paciente()
        {

        }

        public Paciente(int pCodigo)
        {
            this.Codigo = pCodigo;

        }

        public Paciente(int pCodigo, string pNome)
        {
            this.Codigo = pCodigo;
            this.NomeCompleto = pNome;
            PacienteID = "";
            Identificacao = "";

        }

        public Paciente(int pCodigo, string pNome, DateTime pDataNascimento)
        {
            this.Codigo = pCodigo;
            this.NomeCompleto = pNome;
            this.DataNascimento = pDataNascimento;
        }

     
    }
}
