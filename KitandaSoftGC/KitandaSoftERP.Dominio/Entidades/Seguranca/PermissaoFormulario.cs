using System;
using System.Collections.Generic;
using System.Text;

namespace KitandaSoftERP.Dominio.Entidades.Seguranca
{
    public class PermissaoFormulario : Retorno.Retorno
    {
        
        public int Codigo { get; set; }
        public Formulario Formulario { get; set; }
        public Perfil Perfil { get; set; }
        public int AllowInsert { get; set; }
        public int AllowUpdate { get; set; }
        public int AllowDelete { get; set; }
        public int AllowSelect { get; set; }
        public int AllowPrint { get; set; }
        public int AllowAccess { get; set; }

        public PermissaoFormulario()
        {
        }
        public PermissaoFormulario(Perfil pPerfil)
        {
            Perfil = pPerfil;
        }

    }
}
