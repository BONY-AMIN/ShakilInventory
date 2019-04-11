using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
   public class ProcurementDetails
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PO_Details_ID { get; set; }
    
        public decimal PO_QTD { get; set; }
        public decimal PO_Price { get; set; }
        public decimal PO_SubTotal { get; set; }
        public int PO_HD_ID { get; set; }
        public int CategoryId { get; set; }
        public Nullable<int> SubCategoryId { get; set; }
        public Nullable<int> SubSubCategoryId { get; set; }
        public Nullable<int> SubSubSubCategoryId { get; set; }
        public Nullable<int> SubSubSubSubCategoryId { get; set; }
        public Nullable<int> BrandId { get; set; }
        public Nullable<int> ModelId { get; set; }
        public Nullable<int> UnitId { get; set; }
        public virtual ProcurementHeader ProcurementHeader { get; set; }
        public virtual Category Category { get; set; }
        public virtual SubCategory SubCategory { get; set; }
        public virtual SubSubCategory SubSubCategory { get; set; }
        public virtual SubSubSubCategory SubSubSubCategory { get; set; }
        public virtual SubSubSubSubCategory SubSubSubSubCategory { get; set; }
        public virtual Brand Brand { get; set; }
        public virtual Model Model { get; set; }
        public virtual Unit Unit { get; set; }


    }
}
