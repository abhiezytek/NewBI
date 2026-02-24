using Microsoft.EntityFrameworkCore;  
using System.Collections.Generic;  

namespace Backend.Infrastructure.Data  
{  
    public class InsuranceDbContext : DbContext  
    {  
        public InsuranceDbContext(DbContextOptions<InsuranceDbContext> options) : base(options) { }  
        
        public DbSet<Product> Products { get; set; }  
        public DbSet<Policy> Policies { get; set; }  
        public DbSet<FactorTable> FactorTables { get; set; }  
        public DbSet<Claim> Claims { get; set; }  
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)  
        {  
            // Define relationships and constraints here  
            modelBuilder.Entity<Product>()  
                .HasKey(p => p.ProductId);  
            
            modelBuilder.Entity<Policy>()  
                .HasKey(p => p.PolicyId);  
            
            modelBuilder.Entity<FactorTable>()  
                .HasKey(f => f.FactorId);  
            
            modelBuilder.Entity<Claim>()  
                .HasKey(c => c.ClaimId);  
        }  
    }  
    
    public class Product  
    {  
        public int ProductId { get; set; }  
        public string Name { get; set; }  
        public decimal Price { get; set; }  
        public ICollection<Policy> Policies { get; set; }  
    }  
    
    public class Policy  
    {  
        public int PolicyId { get; set; }  
        public string PolicyNumber { get; set; }  
        public int ProductId { get; set; }  
        public Product Product { get; set; }  
    }  
    
    public class FactorTable  
    {  
        public int FactorId { get; set; }  
        public string Description { get; set; }  
    }  
    
    public class Claim  
    {  
        public int ClaimId { get; set; }  
        public string ClaimNumber { get; set; }  
        public int PolicyId { get; set; }  
        public Policy Policy { get; set; }  
    }  
}