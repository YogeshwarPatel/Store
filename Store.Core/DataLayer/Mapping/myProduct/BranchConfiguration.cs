using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Store.Core.EntityLayer.myProduct;


namespace Store.Core.DataLayer.Mapping.myProduct
{
    class BranchConfiguration : IEntityTypeConfiguration<Branch>
    {
        public void Configure(EntityTypeBuilder<Branch> builder)
        {
            // Mapping for table
            builder.ToTable("Employee", "HumanResources");

            // Set key for entity
            builder.HasKey(b => b.branch_code);

            // Set mapping for columns
            builder.Property(b => b.branch_code).HasColumnType("varchar(25)").IsRequired();
            builder.Property(b => b.branch_desc).HasColumnType("varchar(150)").IsRequired();
            builder.Property(b => b.branch_name).HasColumnType("varchar(255)");
            builder.Property(b => b.area_code).HasColumnType("varchar(50)").IsRequired();
            builder.Property(b => b.area_desc).HasColumnType("varchar(255)").IsRequired();
            builder.Property(b => b.state).HasColumnType("varchar(50)").IsRequired();
            builder.Property(b => b.business_unit_code).HasColumnType("varchar(50)").IsRequired();
            builder.Property(b => b.business_unit_desc).HasColumnType("varchar(255)");
            builder.Property(b => b.business_unit_group).HasColumnType("varchar(16)");

            //following not needed
            // Set concurrency token for entity
            //builder.Property(b => b.Timestamp).ValueGeneratedOnAddOrUpdate().IsConcurrencyToken();

            // Set identity for entity (auto increment)
            //            builder.Property(b => b.EmployeeID).UseSqlServerIdentityColumn();
        }
    }
}

//using Microsoft.EntityFrameworkCore;
//using Microsoft.EntityFrameworkCore.Metadata.Builders;
//using Store.Core.EntityLayer.HumanResources;

//namespace Store.Core.DataLayer.Mapping.HumanResources
//{
//    public class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
//    {
//        public void Configure(EntityTypeBuilder<Employee> builder)
//        {
//            // Mapping for table
//            builder.ToTable("Employee", "HumanResources");

//            // Set key for entity
//            builder.HasKey(b => b.EmployeeID);

//            // Set identity for entity (auto increment)
//            builder.Property(b => b.EmployeeID).UseSqlServerIdentityColumn();

//            // Set mapping for columns
//            builder.Property(b => b.EmployeeID).HasColumnType("int").IsRequired();
//            builder.Property(b => b.FirstName).HasColumnType("varchar(25)").IsRequired();
//            builder.Property(b => b.MiddleName).HasColumnType("varchar(25)");
//            builder.Property(b => b.LastName).HasColumnType("varchar(25)").IsRequired();
//            builder.Property(b => b.BirthDate).HasColumnType("datetime").IsRequired();
//            builder.Property(b => b.CreationUser).HasColumnType("varchar(25)").IsRequired();
//            builder.Property(b => b.CreationDateTime).HasColumnType("datetime").IsRequired();
//            builder.Property(b => b.LastUpdateUser).HasColumnType("varchar(25)");
//            builder.Property(b => b.LastUpdateDateTime).HasColumnType("datetime");

//            // Set concurrency token for entity
//            builder.Property(b => b.Timestamp).ValueGeneratedOnAddOrUpdate().IsConcurrencyToken();
//        }
//    }
//}

