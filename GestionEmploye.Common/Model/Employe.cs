using GestionEmploye.Common.Model;
using System;
using System.ComponentModel.DataAnnotations.Schema;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace GestionEmploye.Common
{
    public class Employe
    {
        public bool estPiloteDeLigne;

        public int Id { get; set; }
        public string Prenom { get; set; }
        public string Nom { get; set; }
        public DateTimeOffset DateEmbauche { get; set; }
        public bool EstPiloteDeLigne { get; set; }
        public int RoleId { get; set; }

    }
}
