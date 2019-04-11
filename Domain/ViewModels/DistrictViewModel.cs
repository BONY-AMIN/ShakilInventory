using Domain.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.ViewModels
{
   public class DistrictViewModel
    {


        [Key]
        [Display(Name ="District Id")]
        public int DistrictId { get; set; }
        
        [Display(Name ="District Name")]
        [Required(ErrorMessage ="Enter District Name..")]
        public string DistrictName { get; set; }
        public virtual ICollection<Profile> Profile { get; set; }
        public virtual ICollection<PressentAddress> PressentAddress { get; set; }
        public virtual ICollection<PermanentAddress> PermanentAddress { get; set; }

    }
}
