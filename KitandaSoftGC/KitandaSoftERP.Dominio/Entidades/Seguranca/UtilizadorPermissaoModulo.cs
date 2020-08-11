using System;
using System.Collections.Generic;
using System.Text;

namespace KitandaSoftERP.Dominio.Entidades.Seguranca
{
    public class UtilizadorPermissaoModulo : Retorno.Retorno
    {
        public Modulo Modulo { get; set; }
        public Utilizador User { get; set; }
        public int UtilizadorPermModAcesso { get; set; }
        public int UtilizadorPermModVisibilidade { get; set; }

        public UtilizadorPermissaoModulo(Modulo pModulo, Utilizador pUtilizador)
        {
            this.Modulo = pModulo;
            this.User = pUtilizador;
        }

        public UtilizadorPermissaoModulo()
        {
          
        }

        
    }
}
