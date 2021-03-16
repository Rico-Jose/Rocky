using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Rocky.Models
{
    public class Category
    {
        // Used DataAnnotations to tell the database or EF Core
        // that this column needs to be a primary key and an identity.
        // EF Core has default so if the property name is CategoryId,
        // or in this case, Id, it automatically adds it as a key
        // entity. So even if I don't add [Key], it will be added by
        // default. I think it is a good idea to explicitly include it.

        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        [DisplayName("Display Order")]
        public int DisplayOrder { get; set; }
    }
}
