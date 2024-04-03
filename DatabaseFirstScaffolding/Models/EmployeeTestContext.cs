﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace DatabaseFirstScaffolding.Models;

public partial class EmployeeTestContext : DbContext
{
    public EmployeeTestContext()
    {
    }

    public EmployeeTestContext(DbContextOptions<EmployeeTestContext> options)
        : base(options)
    {
        
    }

    public virtual DbSet<Address> Addresses { get; set; }

    public virtual DbSet<City> Cities { get; set; }

    public virtual DbSet<Company> Companies { get; set; }

    public virtual DbSet<Department> Departments { get; set; }

    public virtual DbSet<Email> Emails { get; set; }

    public virtual DbSet<EmpDepartment> EmpDepartments { get; set; }

    public virtual DbSet<Employee> Employees { get; set; }

    public virtual DbSet<PhoneNumber> PhoneNumbers { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.UseCollation("Danish_Norwegian_CI_AS");

        modelBuilder.Entity<Address>(entity =>
        {
            entity.HasKey(e => e.AddressId).HasName("PK__Address__091C2A1B53CCD576");

            entity.ToTable("Address");

            entity.Property(e => e.AddressId).HasColumnName("AddressID");
            entity.Property(e => e.AddressLine)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

            entity.HasOne(d => d.Employee).WithMany(p => p.Addresses)
                .HasForeignKey(d => d.EmployeeId)
                .HasConstraintName("FK__Address__Employe__4316F928");

            entity.HasOne(d => d.PostalCodeNavigation).WithMany(p => p.Addresses)
                .HasForeignKey(d => d.PostalCode)
                .HasConstraintName("FK__Address__PostalC__4222D4EF");
        });

        modelBuilder.Entity<City>(entity =>
        {
            entity.HasKey(e => e.PostalCode).HasName("PK__City__12D1DBD3299359D4");

            entity.ToTable("City");

            entity.Property(e => e.PostalCode).ValueGeneratedNever();
            entity.Property(e => e.City1)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("City");
        });

        modelBuilder.Entity<Company>(entity =>
        {
            entity.HasKey(e => e.CompanyId).HasName("PK__Company__2D971C4C612B64C6");

            entity.ToTable("Company");

            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.CompanyName)
                .HasMaxLength(255)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Department>(entity =>
        {
            entity.HasKey(e => e.DepartmentId).HasName("PK__Departme__B2079BCDE9155F50");

            entity.ToTable("Department");

            entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.DepartmentName)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.HasOne(d => d.Company).WithMany(p => p.Departments)
                .HasForeignKey(d => d.CompanyId)
                .HasConstraintName("FK__Departmen__Compa__47DBAE45");
        });

        modelBuilder.Entity<Email>(entity =>
        {
            entity.HasKey(e => e.EmailId).HasName("PK__Email__7ED91AEF1341C54D");

            entity.ToTable("Email");

            entity.Property(e => e.EmailId).HasColumnName("EmailID");
            entity.Property(e => e.Email1)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("Email");
            entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

            entity.HasOne(d => d.Employee).WithMany(p => p.Emails)
                .HasForeignKey(d => d.EmployeeId)
                .HasConstraintName("FK__Email__EmployeeI__3D5E1FD2");
        });

        modelBuilder.Entity<EmpDepartment>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("EmpDepartment");

            entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");
            entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

            entity.HasOne(d => d.Department).WithMany()
                .HasForeignKey(d => d.DepartmentId)
                .HasConstraintName("FK__EmpDepart__Depar__4AB81AF0");

            entity.HasOne(d => d.Employee).WithMany()
                .HasForeignKey(d => d.EmployeeId)
                .HasConstraintName("FK__EmpDepart__Emplo__49C3F6B7");
        });

        modelBuilder.Entity<Employee>(entity =>
        {
            entity.HasKey(e => e.EmployeeId).HasName("PK__Employee__7AD04FF1C5779956");

            entity.ToTable("Employee");

            entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");
            entity.Property(e => e.FirstName)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.LastName)
                .HasMaxLength(255)
                .IsUnicode(false);
        });

        modelBuilder.Entity<PhoneNumber>(entity =>
        {
            entity.HasKey(e => e.PhoneNumberId).HasName("PK__PhoneNum__D2D34FB121D74C96");

            entity.ToTable("PhoneNumber");

            entity.Property(e => e.PhoneNumberId).HasColumnName("PhoneNumberID");
            entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");
            entity.Property(e => e.PhoneNumber1).HasColumnName("PhoneNumber");

            entity.HasOne(d => d.Employee).WithMany(p => p.PhoneNumbers)
                .HasForeignKey(d => d.EmployeeId)
                .HasConstraintName("FK__PhoneNumb__Emplo__398D8EEE");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}