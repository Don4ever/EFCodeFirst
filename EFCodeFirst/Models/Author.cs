using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EFCodeFirst.Models
{
    public class Author
    {
        [Key]
        public int Auth_id { get; set; }
        public String auth_name { get; set; }

        public virtual IList<Post> posts { get; set; }
}
}