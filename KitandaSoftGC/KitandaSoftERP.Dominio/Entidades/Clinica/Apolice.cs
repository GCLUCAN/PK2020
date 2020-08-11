using System;
using System.Collections.Generic;
using System.Text;

namespace KitandaSoftERP.Dominio.Entidades.Clinica
{
    public class Apolice : Retorno.Retorno
    {
        public int Codigo { get; set; }
        public bool IsVitalicio { get; set; }
        public string NumeroBeneficiario { get; set; }
        public int Convenio { get; set; }
        public string NumPS { get; set; }
        public DateTime Emissao { get; set; }
        public DateTime Validade { get; set; }
        public int Beneficiario { get; set; }
        public Apolice()
        {
        }

        public Apolice(int pCodigo)
        {
            this.Codigo = pCodigo;
        }

        public Apolice(int pConvenio, int pBeneficiario)
        {
            this.Convenio = pConvenio;
            this.Beneficiario = pBeneficiario;
        }
    }
}
