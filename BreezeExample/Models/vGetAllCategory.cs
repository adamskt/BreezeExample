using System;
using System.Collections.Generic;

namespace BreezeExample.Models
{
    public partial class vGetAllCategory
    {
        public string ParentProductCategoryName { get; set; }
        public string ProductCategoryName { get; set; }
        public Nullable<int> ProductCategoryID { get; set; }
    }
}
