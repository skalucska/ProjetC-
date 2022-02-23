using GestionEmploye.Common.Model;
using GestionEmploye.Common.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestionEmploye.Common;
using System.Diagnostics;
using GestionEmploye.EFcoreDemo;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace GestionEmploye.DataAccess
{
    public class EmployeDataProvider : IEmployeDataProvider
    {

        EmployeContext context = new EmployeContext();

       

        public IEnumerable<Employe> ChargerEmployes()
        {

            return context.Employes.ToList();

        }

        public IEnumerable<Role> ChargerRoles()
        {
            Console.WriteLine("test");
            return context.Roles.ToList();

        }

        public void SauvegarderEmploye(Employe employe)
        {

            context.Update<Employe>(employe);
            context.SaveChanges();

        }

        public void AddEmploye(Employe employe)
        {
           
            context.Employes.Add(employe);
            context.SaveChanges();

        }

    }
}
