using System;
using System.Collections.Generic;
using System.Text;

namespace KitandaSoftERP.Dominio.Entidades.Seguranca
{
    public class PermissaoModulo
    {
        public int Codigo { get; set; }
        public Modulo Modulo { get; set; }
        public Perfil Perfil { get; set; }
        public int Acesso { get; set; }
        public int Visibilidade { get; set; }
        public int Autorizar { get; set; }

    }
}
