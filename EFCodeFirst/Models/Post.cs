using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EFCodeFirst.Models
{
    public class Post
    {
        [Key]
        public int PostId { get; set; }
        public string Title { get; set; }
        public string PostDate { get; set; }

        //this means each post belongs to only one blog
        public int BlogId { get; set; }
        public int AuhtId { get; set; }
        // here am going to create a property called blog and it is of the taype Blog
        //this means that what every primary key we used in table Blog it will used as
        // as forign key in blog table, because the blog is now of type Blog and Blog is a table
        //so blog will be aslo a tble, which will have a forign key of table Blog
        public virtual Blog blog { get; set; }
        public virtual Post post { get; set; }
    }
}