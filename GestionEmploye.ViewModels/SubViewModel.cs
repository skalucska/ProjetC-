using GestionEmploye.Common;
using GestionEmploye.Common.Interface;
using GestionEmploye.Common.Model;
using GestionEmploye.ViewModels.Command;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionEmploye.ViewModels
{
    public class SubViewModel
    {

        private IEmployeDataProvider _employeDataProvider;

        public SubViewModel(IEmployeDataProvider employeDP)
        {
            _employeDataProvider = employeDP;
            AddCmd = new DelegateCommand(AddNewEmploye);
        }

        public DelegateCommand AddCmd { get; }
        public ObservableCollection<Role> Roles { get; } = new();

        public string nom { get; set; }
        public string prenom { get; set; }
        public DateTime date { get; set; }

        public bool pilote { get; set; }

        public void AddNewEmploye()
        {


            var NewEmploye = new Employe
            {
                
                Nom = nom,
                Prenom = prenom,
                DateEmbauche = new DateTime(2021, 10, 15),
                EstPiloteDeLigne = pilote,
                RoleId = 1
            };

            _employeDataProvider.AddEmploye(NewEmploye);
        }

        public void Charger()
        {
            var roles = _employeDataProvider.ChargerRoles();

            Roles.Clear();
            foreach (var jobRole in roles)
            {
                Roles.Add(jobRole);
            }
        }

    }
}
