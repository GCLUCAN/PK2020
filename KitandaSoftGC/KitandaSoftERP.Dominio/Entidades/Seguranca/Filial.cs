using System;
using System.Collections.Generic;
using System.Text;

namespace KitandaSoftERP.Dominio.Entidades.Seguranca
{
    public class Filial : EmpresaLicenciada
    {
        private EmpresaLicenciada _sede = new EmpresaLicenciada();

        public EmpresaLicenciada Sede { get; set; }
        public List<Perfil> Perfis { get; set; }
        public int Estado { get; set; }
        public bool IsDefault { get; set; }

        public Filial()
        {
            Perfis = new List<Perfil>();
        }

        public Filial(int pCodigo)
        {
            Codigo = pCodigo;
        }
       
    }
}
