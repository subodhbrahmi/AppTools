using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace DemoWebapi.Models
{
    public class Person
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public DateTime DOB { get; set; }
    }
    public class PersonEntities : DbContext
    {
        public DbSet<Person> Persons { get; set; }

    }
}