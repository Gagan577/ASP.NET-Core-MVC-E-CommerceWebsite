using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Abc.MvcWebUI.Entity
{
    public class Category
    {
        public int Id { get; set; }

        [DisplayName("Category Name")]
        [StringLength(maximumLength:20,ErrorMessage = "Maximum 20 characters")]
        public string Name { get; set; }

        [DisplayName("Description")]
        public string Description { get; set; }

        public List<Product> Products { get; set; }
    }
}