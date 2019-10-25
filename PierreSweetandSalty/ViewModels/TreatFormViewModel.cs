using System.ComponentModel.DataAnnotations;
using PierreSweetandSalty.Models;
using System.Collections.Generic;

namespace RecipeBook.ViewModels
{
    public class RecipeFormViewModel
    {
        [Required]
        [Display (Name = "Treat Name")]
        public string TreatName {get;set;}

        [Display (Name = "Flavor")]
        public List<Flavor> Flavors {get;set;}

        
    }
}