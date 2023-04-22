using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace EmployeesManagement.Models
{
    public partial class employeeDBContext : DbContext
    {
        public employeeDBContext()
        {
        }

        public employeeDBContext(DbContextOptions<employeeDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Account> Accounts { get; set; } = null!;
        public virtual DbSet<Department> Departments { get; set; } = null!;
        public virtual DbSet<Employee> Employees { get; set; } = null!;
        public virtual DbSet<EmployeeProject> EmployeeProjects { get; set; } = null!;
        public virtual DbSet<Position> Positions { get; set; } = null!;
        public virtual DbSet<Project> Projects { get; set; } = null!;
        public virtual DbSet<levelSalary> LevelSalaries { get; set; } = null!;
        public virtual DbSet<allowanceSalary> AllowanceSalaries { get; set; } = null!;
        public virtual DbSet<Salary> Salaries { get; set; } = null!;
        public virtual DbSet<Timekeeping> Timekeepings { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=.\\;Database=employeeDB;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Account>(entity =>
            {
                entity.ToTable("account");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .HasColumnName("email");

                entity.Property(e => e.EmployeeId).HasColumnName("employee_id");

                entity.Property(e => e.FullName)
                    .HasMaxLength(50)
                    .HasColumnName("full_name");

                entity.Property(e => e.Password)
                    .HasMaxLength(50)
                    .HasColumnName("password");

                entity.Property(e => e.Type)
                    .HasMaxLength(50)
                    .HasColumnName("type");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .HasColumnName("user_name");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.Accounts)
                    .HasForeignKey(d => d.EmployeeId)
                    .HasConstraintName("fk_a_employee");
            });

            modelBuilder.Entity<Department>(entity =>
            {
                entity.ToTable("department");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Address)
                    .HasMaxLength(50)
                    .HasColumnName("address");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .HasColumnName("name");

                entity.Property(e => e.Phone)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("phone")
                    .IsFixedLength();
            });

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.ToTable("employee");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.DepartmentId).HasColumnName("department_id");

                entity.Property(e => e.Gender).HasColumnName("gender");

                entity.Property(e => e.HomeTown)
                    .HasMaxLength(50)
                    .HasColumnName("home_town");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .HasColumnName("name");

                entity.Property(e => e.Phone)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("phone")
                    .IsFixedLength();

                entity.Property(e => e.PositionId).HasColumnName("position_id");

                entity.Property(e => e.SalaryId).HasColumnName("salary_id");

                entity.HasOne(d => d.Department)
                    .WithMany(p => p.Employees)
                    .HasForeignKey(d => d.DepartmentId)
                    .HasConstraintName("fk_e_department");

                entity.HasOne(d => d.Position)
                    .WithMany(p => p.Employees)
                    .HasForeignKey(d => d.PositionId)
                    .HasConstraintName("fk_e_position");

                entity.HasOne(d => d.Salary)
                    .WithMany(p => p.Employees)
                    .HasForeignKey(d => d.SalaryId)
                    .HasConstraintName("fk_e_salary");
            });

            modelBuilder.Entity<EmployeeProject>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("employee_project");

                entity.Property(e => e.Description)
                    .HasMaxLength(50)
                    .HasColumnName("description");

                entity.Property(e => e.EmployeeId).HasColumnName("employee_id");

                entity.Property(e => e.EndDate)
                    .HasMaxLength(50)
                    .HasColumnName("end_date");

                entity.Property(e => e.ProjectId).HasColumnName("project_id");

                entity.Property(e => e.Role)
                    .HasMaxLength(50)
                    .HasColumnName("role");

                entity.Property(e => e.StartDate)
                    .HasMaxLength(50)
                    .HasColumnName("start_date");

                entity.HasOne(d => d.Employee)
                    .WithMany()
                    .HasForeignKey(d => d.EmployeeId)
                    .HasConstraintName("fk_ep_employee");

                entity.HasOne(d => d.Project)
                    .WithMany()
                    .HasForeignKey(d => d.ProjectId)
                    .HasConstraintName("fk_ep_project");
            });

            modelBuilder.Entity<Position>(entity =>
            {
                entity.ToTable("position");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Description)
                    .HasMaxLength(50)
                    .HasColumnName("description");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<Project>(entity =>
            {
                entity.ToTable("project");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Description)
                    .HasMaxLength(50)
                    .HasColumnName("description");

                entity.Property(e => e.EndDate)
                    .HasMaxLength(50)
                    .HasColumnName("end_date");

                entity.Property(e => e.IsActive)
                    .HasColumnName("is_active")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .HasColumnName("name");

                entity.Property(e => e.StartDate)
                    .HasMaxLength(50)
                    .HasColumnName("start_date");
            });
            modelBuilder.Entity<levelSalary>(entity =>
            {
                entity.ToTable("levelSalary_Detail");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Coefficient)
                    .HasColumnName("coefficient");

                entity.Property(e => e.Level)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("level")
                    .IsFixedLength();
            });

            modelBuilder.Entity<allowanceSalary>(entity =>
            {
                entity.ToTable("allowanceSalary_Detail");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Allowance)
                    .HasColumnName("allowance");
            });

            modelBuilder.Entity<Salary>(entity =>
            {
                entity.ToTable("salary");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Coefficient)
                    .HasColumnName("coefficient");

                entity.Property(e => e.Level)
                    .HasColumnName("level");

                entity.Property(e => e.AllowanceSalary)
                    .HasColumnName("allowance");

                entity.Property(e => e.NetSalary)
                    .HasColumnName("net_salary");

                entity.HasOne<levelSalary>(s => s.LevelSalary)
                     .WithMany(l => l.Salaries)
                     .HasForeignKey(s => s.Level)
                    .HasConstraintName("fk_e_levelsalary")
                     .IsRequired();

                entity.HasOne<allowanceSalary>(s => s.AllowanceSalary)
                     .WithMany(a => a.Salaries)
                     .HasForeignKey(s => s.AllowanceSalary)
                    .HasConstraintName("fk_e_allowancedepartment")
                     .IsRequired();

            });


            modelBuilder.Entity<Timekeeping>(entity =>
            {
                entity.ToTable("timekeeping");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Date)
                    .HasMaxLength(50)
                    .HasColumnName("date");

                entity.Property(e => e.EmployeeId).HasColumnName("employee_id");

                entity.Property(e => e.WorkingHour).HasColumnName("working_hour");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.Timekeepings)
                    .HasForeignKey(d => d.EmployeeId)
                    .HasConstraintName("fk_t_employee");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
