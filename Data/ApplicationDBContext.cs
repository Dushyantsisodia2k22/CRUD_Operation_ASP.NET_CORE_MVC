using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using MNJ_CRUD_OPERATION_FINAL.Models;

namespace MNJ_CRUD_OPERATION_FINAL.Data
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {
        }

        public DbSet<EmployeeModel> EmployeeTable { get; set; }
        public DbSet<AddressModel> AddressTable { get; set; }
    }
}
