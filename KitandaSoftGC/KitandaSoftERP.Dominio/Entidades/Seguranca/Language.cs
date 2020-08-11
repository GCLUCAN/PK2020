using System;
using System.Collections.Generic;
using System.Text;

namespace KitandaSoftERP.Dominio.Entidades.Seguranca
{
    public class Language
    {
        public Language()
        {

        }

        public Language(CultureInfo pCurrentCulture, ResourceManager pRm)
        {
            UserNameLabel = pRm.GetString("UserNameLabel", pCurrentCulture);
            PasswordLabel = pRm.GetString("PasswordLabel", pCurrentCulture);
            NotificacaoNovaSerieLabel = pRm.GetString("NotificacaoNovaSerieLabel", pCurrentCulture);
            NotificacaoLicencaoNotFoundLabel = pRm.GetString("NotificacaoLicencaoNotFoundLabel", pCurrentCulture);
            UserCredencialInfoLabel = pRm.GetString("UserCredencialInfoLabel", pCurrentCulture);
            UserNameEmptyLabel = pRm.GetString("UserNameEmptyLabel", pCurrentCulture);
            PasswordEmptyLabel = pRm.GetString("PasswordEmptyLabel", pCurrentCulture);
            EntrarLabel = pRm.GetString("EntrarLabel", pCurrentCulture);
        }
        public string WorkOrderLabel { get; set; }
        public string UserNameLabel { get; set; }
        public string PasswordLabel { get; }
        public string NotificacaoNovaSerieLabel { get; set; }
        public string NotificacaoLicencaoNotFoundLabel { get; set; }
        public string UserCredencialInfoLabel { get; set; }
        public string UserNameEmptyLabel { get; set; }
        public string PasswordEmptyLabel { get; set; }
        public string EntrarLabel { get; set; }
        public string NoRecordFoundsLabel { get; set; }
    }
}
