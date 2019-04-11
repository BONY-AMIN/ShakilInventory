using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
   public class ProcurementHeader
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PO_HD_ID { get; set; }
        public System.DateTime PurchaseDate { get; set; }
        public decimal PO_TOTAL_AMT { get; set; }
        public decimal PO_DIS_RATE { get; set; }
        public decimal PO_DIS_AMT { get; set; }
        public decimal PO_Tax_Rate { get; set; }
        public decimal PO_Tax_AMT { get; set; }
        public decimal PO_GRAND_TOTAL { get; set; }
        public int ProcurementTypeId { get; set; }
        public int SupplierCompanyId { get; set; }
        public int StoreId { get; set; }
        public Nullable<int> SubStoreId { get; set; }
        public Nullable<int> SubSubStoreId { get; set; }
        public Nullable<int> SubSubSubStoreId { get; set; }
        public Nullable<int> SubSubSubSubStoreId { get; set; }
        public int CreateBy { get; set; }
        public DateTime CreateDate { get; set; }
        public int UpdateBy { get; set; }
        public DateTime UpdateDate { get; set;}
        public virtual ProcurementType ProcurementType { get; set; }
        public virtual SupplierCompany SupplierCompany { get; set; }
        public virtual Store Store { get; set; }
        public virtual SubStore SubStore { get; set; }
        public virtual SubSubStore SubSubStore { get; set; }
        public virtual SubSubSubStore SubSubSubStore { get; set; }
        public virtual SubSubSubSubStore SubSubSubSubStore { get; set; }

        public virtual ICollection<ProcurementDetails> ProcurementDetails { get; set; }

    }
}
