using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming_Languages.Entities
{
    public class ProgrammingLanguage
    {
        public int ProgrammingLanguageId { get; set; }
        public int Year { get; set; }

        public string Name { get; set; }

        [NotMapped]
        public ICollection<string> ChiefDeveloper { get; set; }

        public string ListChiefDeveloper
        {
            get => string.Join(",", ChiefDeveloper);
            set => ChiefDeveloper = value.Split(',').ToList(); 
        }

        [NotMapped]
        public ICollection<string> Predecessors { get; set; }

        public string ListPredecessors
        {
            get => string.Join(",", Predecessors);
            set => Predecessors = value.Split(',').ToList();
        }
    }
}
