using System.Collections.Generic;

namespace PierreSweetandSalty.Models
{
    public class Treat
    {
        public Treat ()
        {
            this.Flavors = new HashSet<FlavorTreat>();
        }

        public int TreatId {get; set; }
        public string Name {get; set; }
        public string Discription {get; set; }
        public virtual ApplicationUser User {get; set; }
        public ICollection<FlavorTreat> Flavors {get; set; } 
    }
}