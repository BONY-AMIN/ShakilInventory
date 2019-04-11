using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace Domain.ViewModels
{
    [MetadataType(typeof(ProcurementViewModel))]
   public class ProcurementViewModel
    {
        public int PO_HD_ID { get; set; }
       [Display(Name ="Purchase Date")]
        public System.DateTime PurchaseDate { get; set; }

        [Display(Name = "Total Amount")]
        public decimal PO_TOTAL_AMT { get; set; }

        [Display(Name = "Discount Rate")]
        [Range(0, 100, ErrorMessage = "0 to 100")]
        public decimal PO_DIS_RATE { get; set; }

        [Display(Name = "Discount Amount")]
        public decimal PO_DIS_AMT { get; set; }

       
        [Display(Name = "Tax Rate")]
        [Required(ErrorMessage = "Pleasee enter you number")]
       [Range(1,100, ErrorMessage ="0 to 100")]
        public int PO_Tax_Rate { get; set; }

        [Display(Name = "Tax Amount")]
        public decimal PO_Tax_AMT { get; set; }

        [Display(Name = "Total")]
        public decimal PO_GRAND_TOTAL { get; set; }

        [Display(Name = "Procurement Name")]
        public int ProcurementTypeId { get; set; }

        [Display(Name = "Procurement Type")]
        public int ProcurementTypeName { get; set; }

        [Display(Name = "Supplier Company Id")]

        public int SupplierCompanyId { get; set; }
        [Display(Name = "Company Name")]

        public int SupplierCompanyName { get; set; }

        [Display(Name = "Supplier Name")]
        public string SupplierName { get; set; }

        [Display(Name = "Mobile Number")]
        public int MobileNumber { get; set; }

        [Display(Name = "Email")]
        public string Email { get; set; }

        [Display(Name = "Address")]
        //[DataType(DataType.MultilineText)]
        public string SupplierCompanyAddress { get; set; }

        [Display(Name = "Invoice No")]
        public int SupplierInvoiceNo { get; set; }

        [Display(Name = "Store Id")]
        public int StoreId { get; set; }


        [Display(Name = "Create By")]
        public int CreateBy { get; set; }

        [Display(Name = "Create Name")]
        public DateTime CreateDate { get; set; }

        [Display(Name = "Update By")]
        public int UpdateBy { get; set; }

        [Display(Name = "Update Name")]
        public DateTime UpdateDate { get; set; }

        [Display(Name = "Sub Store Id")]
        public Nullable<int> SubStoreId { get; set; }

        [Display(Name = "SubSubStore Id")]
        public Nullable<int> SubSubStoreId { get; set; }

        [Display(Name = "SubSubSubStore Id")]
        public Nullable<int> SubSubSubStoreId { get; set; }

        [Display(Name = "SubSubSubSubStore Id")]
        public Nullable<int> SubSubSubSubStoreId { get; set; }


  
        public int PO_Details_ID { get; set; }


        [Display(Name = "Item Id")]
        public int ItemId { get; set; }

        [Display(Name = "Item Name")]

        public string ItemName { get; set; }


        [Display(Name = "Quantity")]
        public decimal PO_QTD { get; set; }

        [Display(Name = "Price")]
        public decimal PO_Price { get; set; }

        [Display(Name = "Sub Total")]
        public decimal PO_SubTotal { get; set; }

        [Display(Name = "CategoryId")]
        public int CategoryId { get; set; }

        [Display(Name = "SubCategoryId")]
        public Nullable<int> SubCategoryId { get; set; }

        [Display(Name = "SubSubCategoryId")]
        public Nullable<int> SubSubCategoryId { get; set; }

        [Display(Name = "SubSubSubCategoryId")]
        public Nullable<int> SubSubSubCategoryId { get; set; }

        [Display(Name = "SubSubSubSubCategoryId")]
        public Nullable<int> SubSubSubSubCategoryId { get; set; }

        [Display(Name = "Brand Id")]
        public Nullable<int> BrandId { get; set; }
        [Display(Name = "Model Id")]
        public Nullable<int> ModelId { get; set; }

        [Display(Name = "Unit Id")]
        public Nullable<int> UnitId { get; set; }

      

        [Display(Name = "Item Id")]
        public int[] ArrayItemId { get; set; }

        [Display(Name = "Item Name")]

        public string[] ArrayItemName { get; set; }


        [Display(Name = "Quantity")]
        public decimal[] ArrayPO_QTD { get; set; }

        [Display(Name = "Price")]
        public decimal[] ArrayPO_Price { get; set; }

        [Display(Name = "Sub Total")]
        public decimal[] ArrayPO_SubTotal { get; set; }

        [Display(Name = "CategoryId")]
        public int[] ArrayCategoryId { get; set; }

        [Display(Name = "SubCategoryId")]
        public Nullable<int>[] ArraySubCategoryId { get; set; }

        [Display(Name = "SubSubCategoryId")]
        public Nullable<int>[] ArraySubSubCategoryId { get; set; }

        [Display(Name = "SubSubSubCategoryId")]
        public Nullable<int>[] ArraySubSubSubCategoryId { get; set; }

        [Display(Name = "SubSubSubSubCategoryId")]
        public Nullable<int>[] ArraySubSubSubSubCategoryId { get; set; }

        [Display(Name = "Brand Id")]
        public Nullable<int>[] ArrayBrandId { get; set; }
        [Display(Name = "Model Id")]
        public Nullable<int>[] ArrayModelId { get; set; }

        [Display(Name = "Unit Id")]
        public Nullable<int>[] ArrayUnitId { get; set; }







    }



  
}
