using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Core.Objects;
using System.Linq;
using backend.Models;

namespace backend
{
    public class EmployeeEntities : DbContext
    {
        public EmployeeEntities()
            : base("name=EmployeeEntities")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }

        public virtual DbSet<Department> Departments { get; set; }
        public virtual DbSet<Employeemaster> Employeemasters { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }

        public virtual ObjectResult<Usp_Login_Result> Usp_Login(string userName, string password)
        {
            var userNameParameter = userName != null ?
                new ObjectParameter("UserName", userName) :
                new ObjectParameter("UserName", typeof(string));

            var passwordParameter = password != null ?
                new ObjectParameter("Password", password) :
                new ObjectParameter("Password", typeof(string));

            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Usp_Login_Result>("Usp_Login", userNameParameter, passwordParameter);
        }
    }
}
