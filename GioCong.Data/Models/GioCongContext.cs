using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace GioCong.Data.Models
{
    public partial class GioCongContext : DbContext
    {
        public GioCongContext()
        {
        }

        public GioCongContext(DbContextOptions<GioCongContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet<AdvancedPayment> AdvancedPayments { get; set; }
        public virtual DbSet<Company> Companies { get; set; }
        public virtual DbSet<Competition> Competitions { get; set; }
        public virtual DbSet<Department> Departments { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<EmployeeDepartment> EmployeeDepartments { get; set; }
        public virtual DbSet<PayAdvanced> PayAdvanceds { get; set; }
        public virtual DbSet<PayPeriod> PayPeriods { get; set; }
        public virtual DbSet<PaySchedule> PaySchedules { get; set; }
        public virtual DbSet<Payslip> Payslips { get; set; }
        public virtual DbSet<PayslipHistory> PayslipHistories { get; set; }
        public virtual DbSet<PlanType> PlanTypes { get; set; }
        public virtual DbSet<SavingItem> SavingItems { get; set; }
        public virtual DbSet<SavingPlan> SavingPlans { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=LAPTOP-B5177K7U\\SE140882;Initial Catalog=GioCong;User ID=sa;Password=123;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Account>(entity =>
            {
                entity.ToTable("Account");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Name).HasMaxLength(100);

                entity.Property(e => e.Type)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.Emp)
                    .WithMany(p => p.Accounts)
                    .HasForeignKey(d => d.EmpId)
                    .HasConstraintName("FK_Account_Employee");
            });

            modelBuilder.Entity<AdvancedPayment>(entity =>
            {
                entity.ToTable("AdvancedPayment");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.HasOne(d => d.PayAdvanced)
                    .WithMany(p => p.AdvancedPayments)
                    .HasForeignKey(d => d.PayAdvancedId)
                    .HasConstraintName("FK_AdvancedPayment_PayAdvanced");
            });

            modelBuilder.Entity<Company>(entity =>
            {
                entity.ToTable("Company");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Address).HasMaxLength(100);

                entity.Property(e => e.Name).HasMaxLength(100);

                entity.Property(e => e.Phone)
                    .HasMaxLength(11)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Competition>(entity =>
            {
                entity.ToTable("Competition");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Message).HasMaxLength(255);

                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Title).HasMaxLength(50);
            });

            modelBuilder.Entity<Department>(entity =>
            {
                entity.ToTable("Department");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Address).HasMaxLength(100);

                entity.Property(e => e.Name).HasMaxLength(255);

                entity.Property(e => e.Phone)
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.Departments)
                    .HasForeignKey(d => d.CompanyId)
                    .HasConstraintName("FK_Department_Company");
            });

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.ToTable("Employee");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Address).HasMaxLength(100);

                entity.Property(e => e.BirthDate).HasColumnType("datetime");

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name).HasMaxLength(100);

                entity.Property(e => e.Password)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Phone)
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.Employees)
                    .HasForeignKey(d => d.CompanyId)
                    .HasConstraintName("FK_Employee_Company");
            });

            modelBuilder.Entity<EmployeeDepartment>(entity =>
            {
                entity.ToTable("EmployeeDepartment");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.FromDate).HasColumnType("datetime");

                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ToDate).HasColumnType("datetime");

                entity.HasOne(d => d.Dep)
                    .WithMany(p => p.EmployeeDepartments)
                    .HasForeignKey(d => d.DepId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EmployeeDepartment_Department");

                entity.HasOne(d => d.Emp)
                    .WithMany(p => p.EmployeeDepartments)
                    .HasForeignKey(d => d.EmpId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EmployeeDepartment_Employee");
            });

            modelBuilder.Entity<PayAdvanced>(entity =>
            {
                entity.ToTable("PayAdvanced");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Amount).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Payslip)
                    .WithMany(p => p.PayAdvanceds)
                    .HasForeignKey(d => d.PayslipId)
                    .HasConstraintName("FK_PayAdvanced_Payslip");
            });

            modelBuilder.Entity<PayPeriod>(entity =>
            {
                entity.ToTable("PayPeriod");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.Period)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.PayPeriods)
                    .HasForeignKey(d => d.CompanyId)
                    .HasConstraintName("FK_PayPeriod_Company");
            });

            modelBuilder.Entity<PaySchedule>(entity =>
            {
                entity.ToTable("PaySchedule");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.AnchorPayDate).HasColumnType("datetime");

                entity.Property(e => e.FirstDate).HasColumnType("datetime");

                entity.Property(e => e.Frequency)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastDate).HasColumnType("datetime");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.PaySchedules)
                    .HasForeignKey(d => d.CompanyId)
                    .HasConstraintName("FK_PaySchedule_Company");
            });

            modelBuilder.Entity<Payslip>(entity =>
            {
                entity.ToTable("Payslip");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.TotalSalary).HasColumnType("decimal(18, 0)");

                entity.HasOne(d => d.Emp)
                    .WithMany(p => p.Payslips)
                    .HasForeignKey(d => d.EmpId)
                    .HasConstraintName("FK_Payslip_Employee");

                entity.HasOne(d => d.SalaryPeriod)
                    .WithMany(p => p.Payslips)
                    .HasForeignKey(d => d.SalaryPeriodId)
                    .HasConstraintName("FK_Payslip_PayPeriod");
            });

            modelBuilder.Entity<PayslipHistory>(entity =>
            {
                entity.ToTable("PayslipHistory");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.MaxAdvanceAmount).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.SalaryAmount).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.HasOne(d => d.Payslip)
                    .WithMany(p => p.PayslipHistories)
                    .HasForeignKey(d => d.PayslipId)
                    .HasConstraintName("FK_PayslipHistory_Payslip");
            });

            modelBuilder.Entity<PlanType>(entity =>
            {
                entity.ToTable("PlanType");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.ContentJson)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<SavingItem>(entity =>
            {
                entity.ToTable("SavingItem");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Amount).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.SavingPlan)
                    .WithMany(p => p.SavingItems)
                    .HasForeignKey(d => d.SavingPlanId)
                    .HasConstraintName("FK_SavingItem_SavingPlan");
            });

            modelBuilder.Entity<SavingPlan>(entity =>
            {
                entity.ToTable("SavingPlan");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.Reason).HasMaxLength(50);

                entity.Property(e => e.SalaryPerMonth).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.CompetitionNavigation)
                    .WithMany(p => p.SavingPlans)
                    .HasForeignKey(d => d.Competition)
                    .HasConstraintName("FK_SavingPlan_Competition");

                entity.HasOne(d => d.CreateUserNavigation)
                    .WithMany(p => p.SavingPlans)
                    .HasForeignKey(d => d.CreateUser)
                    .HasConstraintName("FK_SavingPlan_Employee");

                entity.HasOne(d => d.PlanType)
                    .WithMany(p => p.SavingPlans)
                    .HasForeignKey(d => d.PlanTypeId)
                    .HasConstraintName("FK_SavingPlan_PlanType");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
