using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
  public  class Brand
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int BrandId { get; set; }
        public string BrandName { get; set; }
        public Nullable<int> SubSubSubSubCategoryId { get; set; }
        public Nullable<int> SubSubSubCategoryId { get; set; }
        public Nullable<int> SubSubCategoryId { get; set; }
        public Nullable<int> SubCategoryId { get; set; }
        public Nullable<int> CategoryId { get; set; }


        public virtual Category Category { get; set; }
        public virtual SubCategory SubCategory { get; set; }
        public virtual SubSubCategory SubSubCategory { get; set; }
        public virtual SubSubSubCategory SubSubSubCategory { get; set; }
        public virtual SubSubSubSubCategory SubSubSubSubCategory { get; set; }
        public ICollection<Model> Models { get; set; }

        public virtual ICollection<ProcurementDetails> ProcurementDetails { get; set; }
        public virtual ICollection<Item> Items { get; set; }




    }
}
