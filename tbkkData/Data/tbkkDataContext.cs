using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using tbkkData.Models;

namespace tbkkData.Models
{
    public class tbkkDataContext : DbContext
    {
        public tbkkDataContext (DbContextOptions<tbkkDataContext> options)
            : base(options)
        {
        }
        public DbSet<tbkkData.Models.Company> Company { get; set; }
        public DbSet<tbkkData.Models.Customer> Customer { get; set; }
        public DbSet<tbkkData.Models.Department> Department { get; set; }
        public DbSet<tbkkData.Models.Employee> Employee { get; set; }
        public DbSet<tbkkData.Models.EmployeeType> EmployeeType { get; set; }
        public DbSet<tbkkData.Models.Login> Login { get; set; }
        
        public DbSet<tbkkData.Models.Order> Order { get; set; }
        public DbSet<tbkkData.Models.Order_Product> Order_Product { get; set; }
        public DbSet<tbkkData.Models.Partners> Partners { get; set; }
        public DbSet<tbkkData.Models.Position> Position { get; set; }
        public DbSet<tbkkData.Models.Product> Product { get; set; }
        public DbSet<tbkkData.Models.Project> Project { get; set; }
        public DbSet<tbkkData.Models.Project_Product> Project_Product { get; set; }
        public DbSet<tbkkData.Models.Rival> Rival { get; set; }
        public DbSet<tbkkData.Models.Rival_Product> Rival_Product { get; set; }
       // public DbSet<tbkkData.Models.AgeGroup> AgeGroup { get; set; }
       
        
        public DbSet<tbkkData.Models.Complain> Complain { get; set; }
        public DbSet<tbkkData.Models.Claim> Claim { get; set; }
        public DbSet<tbkkData.Models.Survey> Survey { get; set; }
        public DbSet<tbkkData.Models.Safety> Safety { get; set; }
        public DbSet<tbkkData.Models.Product_Loss_Reduction> Product_Loss_Reduction { get; set; }
        public DbSet<tbkkData.Models.Delivery_performance> Delivery_performance { get; set; }
        public DbSet<tbkkData.Models.SurveyOperators> SurveyOperators { get; set; }
       
        public DbSet<tbkkData.Models.Type_Survey> Type_Survey { get; set; }
        public DbSet<tbkkData.Models.type_productLooss> type_productLooss { get; set; }
        public DbSet<tbkkData.Models.Manufacture> Manufacture { get; set; }

        
    }
}
