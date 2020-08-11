using System;
using System.Collections.Generic;
using System.Text;

namespace KitandaSoftERP.Dominio.Entidades.Seguranca
{
    public class EmpresaLicenciada : Geral.Entidade
    {
        public string Responsavel { get; set; }
        public int ProvinciaMorada { get; set; }
        public string NomeLocalNascimento { get; set; }
        public bool IsColectiveCompany { get; set; }
        public int EmpresaSede { get; set; }
        public EmpresaLicenciada()
        {
        }
        public EmpresaLicenciada(string pCodigo)
        {
            Codigo = Convert.ToInt32(pCodigo);
        }
        public EmpresaLicenciada(int pCodigo, string pDescricao)
        {
            Codigo = Convert.ToInt32(pCodigo);
            NomeCompleto = pDescricao;
        }
        public EmpresaLicenciada(int pEmpresa)
        {
            EmpresaSede = pEmpresa;
        }
    }
}
