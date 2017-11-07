using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace EFCodeFirst.Models
{
    public class BlogContext:DbContext
    {

        //Notice:DbContext is a class responsible for communicating with a database
        //here we calling the base class using the keyword :base and then passing
        //connection string to the base class
        //What is happing here is that we accessing DbContext and passing to it our
        //connection string
        public BlogContext():base("name=myConnection")
        {

        }
        //Keep in mind that dbcontext is a collection of DbSet
        //here we have two DbSet the first one is of type Blog and we called it BlogsTable
        public DbSet<Blog> BlogsTable { get; set; }
        public DbSet<Author> AuthorsTable { get; set; }
        public DbSet<Post> PostsTable { get; set; }
    }
}