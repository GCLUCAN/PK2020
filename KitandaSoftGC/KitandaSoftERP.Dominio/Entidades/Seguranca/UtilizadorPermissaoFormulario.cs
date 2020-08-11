using System;
using System.Collections.Generic;
using System.Text;

namespace KitandaSoftERP.Dominio.Entidades.Seguranca
{
    public class UtilizadorPermissaoFormulario
    {
        public Formulario UserPermFormFormulario { get; set; }
        public Utilizador UserPermFormUtilizador { get; set; }
        public int UserPermFormInclusao { get; set; }
        public int UserPermFormAlteracao { get; set; }
        public int UserPermFormExclusao { get; set; }
        public int UserPermFormConsulta { get; set; }
        public int UserPermFormImpressao { get; set; }
        public int UserPermFormAcesso { get; set; }
        public string DsFormulario { get; set; }

    }
}
