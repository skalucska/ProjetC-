using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GestionEmploye.Common.Model
{
    public class Role
    {
        [Key]
        public int IdRole { get; set; }
        public string Nom { get; set; }
        public ICollection<Employe> Employes { get; set; }
    }
}
