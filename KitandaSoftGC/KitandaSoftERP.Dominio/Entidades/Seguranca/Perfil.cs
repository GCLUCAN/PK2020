using System;
using System.Collections.Generic;
using System.Text;

namespace KitandaSoftERP.Dominio.Entidades.Seguranca
{
    public class Perfil : Retorno.Retorno
    {
      
        public int PerCodigo { get; set; }
        public string PerNome { get; set; }
        public string PerDescricao { get; set; }
        public string PerStatus { get; set; }
        public string PerEmail { get; set; }

        public Perfil(int pCodigo)
        {
            PerCodigo = pCodigo;
        }

        public Perfil(string pNome)
        {
            PerDescricao = pNome;
        }

        public Perfil()
        {
            
        }

        
    }
}
