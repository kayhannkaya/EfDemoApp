using EfDataAccesslibrary.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EfDataAccesslibrary.DataAccess
{
    //Conrol + . for comes features C#
  public class PeopleContext:DbContext
    {
        public PeopleContext(DbContextOptions options):base(options)
        {

        }
        //These are Set the data
        public DbSet<Person> People { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Email> EmailAddresses { get; set; }
    }
}
