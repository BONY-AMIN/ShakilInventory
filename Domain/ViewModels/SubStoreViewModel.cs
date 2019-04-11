﻿using Domain.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.ViewModels
{
    public class SubStoreViewModel
    {


        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "SubStore Id")]
        public int SubStoreId { get; set; }

        [Display(Name = "SubStore Name")]
        [Required(ErrorMessage = "Please Enter SubStore Name")]
        public string SubStoreName { get; set; }

        public Nullable<int> StoreId { get; set; }
        public String StoreName { get; set; }


        public virtual Store Store { get; set; }
        public ICollection<SubSubStore> SubSubStores { get; set; }
        public ICollection<SubSubSubStore> SubSubSubStores { get; set; }
        public ICollection<SubSubSubSubStore> SubSubSubSubStores { get; set; }
    }
}
