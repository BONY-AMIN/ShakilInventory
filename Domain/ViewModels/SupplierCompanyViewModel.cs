using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.ViewModels
{
    public class SupplierCompanyViewModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int SupplierCompanyId { get; set; }

        [Display(Name ="SC Name")]
        [Required(ErrorMessage ="Enter SC Name")]
        public string SupplierCompanyName { get; set; }
        [Display(Name = "Mobile Number")]
        public int MobileNumber { get; set; }
        [Display(Name = "Company Address")]
        public string SupplierCompanyAddress { get; set; }
        [Display(Name = "Email")]
        public string Email { get; set; }
        [Display(Name = "Supplier Id")]
        public int SupplierId { get; set; }
        [Display(Name = "Supplier Name")]
        public string SupplierName { get; set; }
    }
}
